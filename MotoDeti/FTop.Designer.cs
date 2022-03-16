
namespace MotoDeti
{
    partial class FTop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTop));
            this.tb_search_top = new System.Windows.Forms.TextBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.cb_filt = new System.Windows.Forms.ComboBox();
            this.btn_search_top = new System.Windows.Forms.Button();
            this.dgv_top = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_top = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_share = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_search_top
            // 
            this.tb_search_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search_top.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_search_top.Location = new System.Drawing.Point(51, 3);
            this.tb_search_top.Name = "tb_search_top";
            this.tb_search_top.Size = new System.Drawing.Size(377, 41);
            this.tb_search_top.TabIndex = 28;
            // 
            // btn_sort
            // 
            this.btn_sort.BackColor = System.Drawing.Color.Khaki;
            this.btn_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sort.Location = new System.Drawing.Point(712, 3);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(96, 41);
            this.btn_sort.TabIndex = 27;
            this.btn_sort.Text = "А - Я";
            this.btn_sort.UseVisualStyleBackColor = false;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // cb_filt
            // 
            this.cb_filt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_filt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_filt.FormattingEnabled = true;
            this.cb_filt.Items.AddRange(new object[] {
            "Все",
            "Школьники",
            "Выпускники"});
            this.cb_filt.Location = new System.Drawing.Point(482, 3);
            this.cb_filt.Name = "cb_filt";
            this.cb_filt.Size = new System.Drawing.Size(224, 41);
            this.cb_filt.TabIndex = 26;
            this.cb_filt.SelectedIndexChanged += new System.EventHandler(this.cb_filt_SelectedIndexChanged);
            // 
            // btn_search_top
            // 
            this.btn_search_top.BackColor = System.Drawing.Color.Khaki;
            this.btn_search_top.BackgroundImage = global::MotoDeti.Properties.Resources._3844432_magnifier_search_zoom_110300;
            this.btn_search_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_top.Location = new System.Drawing.Point(434, 3);
            this.btn_search_top.Name = "btn_search_top";
            this.btn_search_top.Size = new System.Drawing.Size(42, 41);
            this.btn_search_top.TabIndex = 25;
            this.btn_search_top.UseVisualStyleBackColor = false;
            this.btn_search_top.Click += new System.EventHandler(this.btn_search_top_Click);
            // 
            // dgv_top
            // 
            this.dgv_top.AllowUserToAddRows = false;
            this.dgv_top.AllowUserToDeleteRows = false;
            this.dgv_top.AllowUserToResizeRows = false;
            this.dgv_top.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_top.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_top.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_top.Location = new System.Drawing.Point(3, 108);
            this.dgv_top.MultiSelect = false;
            this.dgv_top.Name = "dgv_top";
            this.dgv_top.RowHeadersVisible = false;
            this.dgv_top.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_top.Size = new System.Drawing.Size(812, 227);
            this.dgv_top.TabIndex = 24;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(7, 8);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(25, 21);
            this.btn_back.TabIndex = 23;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_top
            // 
            this.lbl_top.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_top.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_top.Location = new System.Drawing.Point(42, 0);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(195, 37);
            this.lbl_top.TabIndex = 22;
            this.lbl_top.Text = "ТОП ИГРОКОВ";
            this.lbl_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Khaki;
            this.btn_print.BackgroundImage = global::MotoDeti.Properties.Resources._2849806_copy_interface_multimedia_print_printer_107972;
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Location = new System.Drawing.Point(678, 8);
            this.btn_print.Margin = new System.Windows.Forms.Padding(8);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(55, 49);
            this.btn_print.TabIndex = 30;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel.Location = new System.Drawing.Point(8, 8);
            this.btn_excel.Margin = new System.Windows.Forms.Padding(8);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(96, 49);
            this.btn_excel.TabIndex = 31;
            this.btn_excel.Text = "EXCEL";
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(120, 8);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(8);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(542, 49);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "УДАЛИТЬ";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Khaki;
            this.btn_refresh.BackgroundImage = global::MotoDeti.Properties.Resources.twocirclingarrows1_120592;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Location = new System.Drawing.Point(3, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(42, 40);
            this.btn_refresh.TabIndex = 33;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_share
            // 
            this.btn_share.BackColor = System.Drawing.Color.Khaki;
            this.btn_share.BackgroundImage = global::MotoDeti.Properties.Resources._share_90177;
            this.btn_share.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_share.Location = new System.Drawing.Point(749, 8);
            this.btn_share.Margin = new System.Windows.Forms.Padding(8);
            this.btn_share.Name = "btn_share";
            this.btn_share.Size = new System.Drawing.Size(55, 49);
            this.btn_share.TabIndex = 34;
            this.btn_share.UseVisualStyleBackColor = false;
            this.btn_share.Click += new System.EventHandler(this.btn_share_ClickAsync);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_top, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 409);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btn_refresh, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_search_top, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_filt, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_search_top, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_sort, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 52);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(812, 50);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(812, 43);
            this.tableLayoutPanel5.TabIndex = 38;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_top, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_back, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(277, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 37);
            this.tableLayoutPanel4.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_share, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_print, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_delete, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_excel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 341);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(812, 65);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // FTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(834, 448);
            this.MinimumSize = new System.Drawing.Size(834, 448);
            this.Name = "FTop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Топ игроков";
            this.Load += new System.EventHandler(this.FTop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_top)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search_top;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.ComboBox cb_filt;
        private System.Windows.Forms.Button btn_search_top;
        private System.Windows.Forms.DataGridView dgv_top;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_share;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}