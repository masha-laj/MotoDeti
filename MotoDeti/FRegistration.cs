using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoDeti
{
    public partial class FRegistration : Form
    {
        GameDB db = GameDB.getInstance();
        FMap mapForm = new FMap();

        public FRegistration()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_game_Click(object sender, EventArgs e)
        {
            var nick = tb_nickname.Text.Trim();

            int age = 0;
            if (!int.TryParse(tb_age.Text.Trim(), out age)) {
                MessageBox.Show("Введите возраст цифрами!");
                return;
            }
            var town = tb_town.Text.Trim();
            var endschool = chb_endschool.Checked;
            var school = endschool ? null : tb_school.Text.Trim();
            var number = endschool ? null : cb_number.SelectedItem;
            var letter = endschool ? null : cb_letter.SelectedItem;

            var schoolcond = !endschool && (string.IsNullOrWhiteSpace(school) || number == null || letter == null);

            if (string.IsNullOrWhiteSpace(nick)
                || string.IsNullOrWhiteSpace(town)
                || string.IsNullOrWhiteSpace(town)
                || schoolcond)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var playerId = db.AddPlayer(new PlayerRegData
            {
                nickname = nick,
                age = age,
                town = town,
                school = school,
                number = number,
                letter = letter
            });

            var gameInfo = db.GetGameInfo(playerId);

            mapForm.GameInfo = gameInfo;
            mapForm.ShowDialog(this);

            tb_nickname.Clear();
            tb_age.Clear();
            tb_town.Clear();
            chb_endschool.Checked = false;
            cb_number.SelectedIndex = -1;
            cb_letter.SelectedIndex = -1;
            this.Close();
        }

        public void FRegistration_Load(object sender, EventArgs e)
        {

        }

        private void chb_endschool_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_endschool.Checked)
            {
                lbl_school.Enabled = false;
                tb_school.Enabled = false;
                lbl_class.Enabled = false;
                lbl_number.Enabled = false;
                cb_number.Enabled = false;
                lbl_letter.Enabled = false;
                cb_letter.Enabled = false;

                tb_school.Clear();
                cb_number.SelectedIndex = -1;
                cb_letter.SelectedIndex = -1;

            }
            else
            {
                lbl_school.Enabled = true;
                tb_school.Enabled = true;
                lbl_class.Enabled = true;
                lbl_number.Enabled = true;
                cb_number.Enabled = true;
                lbl_letter.Enabled = true;
                cb_letter.Enabled = true;
            }
        }
    }
}
