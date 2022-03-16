using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Drawing.Printing;
using System.Data.SQLite;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;

namespace MotoDeti
{
    public partial class FTop : Form
    {
        private GameDB db = GameDB.getInstance();
        private SQLiteDataAdapter adapter = null;
        private System.Data.DataTable table = null;
        private bool orderAsc = true;
        public FTop()
        {
            InitializeComponent();
            adapter = new SQLiteDataAdapter();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshTable()
        {
            var filter = cb_filt.SelectedItem as string;
            adapter.SelectCommand = db.GetTop(filter, orderAsc);

            table = new System.Data.DataTable();
            adapter.Fill(table);
            dgv_top.DataSource = table;
            dgv_top.Columns[0].Visible = false;
            dgv_top.Columns[1].HeaderText = "Никнейм";
            dgv_top.Columns[2].HeaderText = "Возраст";
            dgv_top.Columns[3].HeaderText = "Город";
            dgv_top.Columns[4].HeaderText = "Школа";
            dgv_top.Columns[5].HeaderText = "Класс";
            dgv_top.Columns[6].HeaderText = "Буква";
            dgv_top.Columns[7].HeaderText = "Количество ошибок";
            dgv_top.Columns[8].HeaderText = "Время игры";
        }

        private void FTop_Load(object sender, EventArgs e)
        {
            refreshTable();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            ws.Name = "Exported from gridview";

            ws.Rows.HorizontalAlignment = HorizontalAlignment.Center;
            for (int i = 1; i < dgv_top.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dgv_top.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgv_top.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_top.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dgv_top.Rows[i].Cells[j].Value;
                }
            }

            ws.Cells.EntireColumn.AutoFit();
            app.Visible = true;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170); 
                pd.PrintPage += printDocument_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при печати", ex.ToString());
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            foreach (DataRow row in dgv_top.Rows)
            {
                string text = row.ToString();
                graphic.DrawString(text, new System.Drawing.Font("Segoe Print", 14, FontStyle.Bold), Brushes.Black, 20, 225);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rows = dgv_top.SelectedRows;
            if (rows.Count != 1) return;
            var index = rows[0].Index;
            var id = rows[0].Cells[0].Value;


            db.DeletePlayer(Convert.ToInt32(id));
            
            dgv_top.Rows.RemoveAt(index);
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            orderAsc = !orderAsc;

            refreshTable();
        }

        private void cb_filt_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void btn_search_top_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_top.RowCount; i++)
            {
                dgv_top.Rows[i].Selected = false;
                for (int j = 0; j < dgv_top.ColumnCount; j++)
                    if (dgv_top.Rows[i].Cells[j].Value != null)
                        if (dgv_top.Rows[i].Cells[j].Value.ToString().Contains(tb_search_top.Text))
                        {
                            dgv_top.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void btn_share_ClickAsync(object sender, EventArgs e)
        {
            int height = dgv_top.Height;
            dgv_top.Height = dgv_top.RowCount * dgv_top.RowTemplate.Height;

            //Create a Bitmap and draw the DataGridView on it.
            Bitmap bitmap = new Bitmap(dgv_top.Width, dgv_top.Height);
            dgv_top.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dgv_top.Width, dgv_top.Height));

            //Resize DataGridView back to original height.
            dgv_top.Height = height;

            //Save the Bitmap to folder.
            //bitmap.Save(@"C:\projects\DataGridView.png");

            Share(bitmap);
        }

        private async Task Share(Bitmap bm)
        {
            var stream = new MemoryStream();
            bm.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            var b64 = Convert.ToBase64String(stream.ToArray());
            //HttpContent fileStreamContent = new StreamContent(stream);
            HttpContent fileStreamContent = new StringContent(b64);
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(fileStreamContent, "image");
                var response = await client.PostAsync("https://api.imgbb.com/1/upload?expiration=600&key=9211b647926a6eeef462d38335fcd55e", formData);
                if (!response.IsSuccessStatusCode)
                {
                    return;
                }
                var json = await response.Content.ReadAsStringAsync();
                
                var imgbb = JsonConvert.DeserializeObject<IMGBBResponse>(json);
                var url = imgbb.data.url_viewer;
                var imgUrl = imgbb.data.url;

                var builder = new UriBuilder("https://vk.com/share.php");
                builder.Query = $"url={url}&image={imgUrl}";

                System.Diagnostics.Process.Start(builder.ToString());
            }
        }
    }

    public class IMGBBImage
    {
        public string filename;
        public string name;
        public string mime;
        public string extension;
        public string url;
    }

    public class IMGBBData
    {
        public string id;
        public string title;
        public string url_viewer;
        public string url;
        public string display_url;
        public int size;
        public int time;
        public int expiration;
        public IMGBBImage image;
    }

    public class IMGBBResponse
    {
        public IMGBBData data;
        public IMGBBImage thumb;
        public IMGBBImage medium;
        public string delete_url;
        public bool success;
        public int status;
    }
}
