
namespace MotoDeti
{
    partial class FSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSet));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_set = new System.Windows.Forms.Label();
            this.trb_sound = new System.Windows.Forms.TrackBar();
            this.gb_team = new System.Windows.Forms.GroupBox();
            this.cb_answertime_team = new System.Windows.Forms.ComboBox();
            this.lbl_answertime_team = new System.Windows.Forms.Label();
            this.cb_gametime = new System.Windows.Forms.ComboBox();
            this.lbl_gametime = new System.Windows.Forms.Label();
            this.cb_btn_answer2 = new System.Windows.Forms.ComboBox();
            this.lbl_team2 = new System.Windows.Forms.Label();
            this.lbl_btn_answer2 = new System.Windows.Forms.Label();
            this.cb_btn_answer1 = new System.Windows.Forms.ComboBox();
            this.lbl_team1 = new System.Windows.Forms.Label();
            this.lbl_btn_answer1 = new System.Windows.Forms.Label();
            this.gb_single = new System.Windows.Forms.GroupBox();
            this.chb_help = new System.Windows.Forms.CheckBox();
            this.cb_answertime_single = new System.Windows.Forms.ComboBox();
            this.lbl_answertime_single = new System.Windows.Forms.Label();
            this.cb_attempts = new System.Windows.Forms.ComboBox();
            this.lbl_attempts = new System.Windows.Forms.Label();
            this.chb_team = new System.Windows.Forms.CheckBox();
            this.btn_sound_on = new System.Windows.Forms.Button();
            this.btn_sound_off = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trb_sound)).BeginInit();
            this.gb_team.SuspendLayout();
            this.gb_single.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(146, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 18;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_set
            // 
            this.lbl_set.AutoSize = true;
            this.lbl_set.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_set.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_set.Location = new System.Drawing.Point(198, 9);
            this.lbl_set.Name = "lbl_set";
            this.lbl_set.Size = new System.Drawing.Size(171, 36);
            this.lbl_set.TabIndex = 17;
            this.lbl_set.Text = "НАСТРОЙКИ";
            this.lbl_set.Click += new System.EventHandler(this.lbl_set_Click);
            // 
            // trb_sound
            // 
            this.trb_sound.BackColor = System.Drawing.Color.MintCream;
            this.trb_sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trb_sound.Location = new System.Drawing.Point(66, 103);
            this.trb_sound.Maximum = 100;
            this.trb_sound.Name = "trb_sound";
            this.trb_sound.Size = new System.Drawing.Size(146, 45);
            this.trb_sound.SmallChange = 0;
            this.trb_sound.TabIndex = 19;
            this.trb_sound.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb_sound.Scroll += new System.EventHandler(this.trb_sound_Scroll);
            // 
            // gb_team
            // 
            this.gb_team.BackColor = System.Drawing.Color.MintCream;
            this.gb_team.Controls.Add(this.cb_answertime_team);
            this.gb_team.Controls.Add(this.lbl_answertime_team);
            this.gb_team.Controls.Add(this.cb_gametime);
            this.gb_team.Controls.Add(this.lbl_gametime);
            this.gb_team.Controls.Add(this.cb_btn_answer2);
            this.gb_team.Controls.Add(this.lbl_team2);
            this.gb_team.Controls.Add(this.lbl_btn_answer2);
            this.gb_team.Controls.Add(this.cb_btn_answer1);
            this.gb_team.Controls.Add(this.lbl_team1);
            this.gb_team.Controls.Add(this.lbl_btn_answer1);
            this.gb_team.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_team.Location = new System.Drawing.Point(268, 57);
            this.gb_team.Name = "gb_team";
            this.gb_team.Size = new System.Drawing.Size(246, 254);
            this.gb_team.TabIndex = 20;
            this.gb_team.TabStop = false;
            this.gb_team.Text = "КОМАНДНЫЙ РЕЖИМ";
            // 
            // cb_answertime_team
            // 
            this.cb_answertime_team.FormattingEnabled = true;
            this.cb_answertime_team.Items.AddRange(new object[] {
            "3",
            "5",
            "10"});
            this.cb_answertime_team.Location = new System.Drawing.Point(163, 75);
            this.cb_answertime_team.Name = "cb_answertime_team";
            this.cb_answertime_team.Size = new System.Drawing.Size(77, 36);
            this.cb_answertime_team.TabIndex = 9;
            // 
            // lbl_answertime_team
            // 
            this.lbl_answertime_team.AutoSize = true;
            this.lbl_answertime_team.Location = new System.Drawing.Point(6, 78);
            this.lbl_answertime_team.Name = "lbl_answertime_team";
            this.lbl_answertime_team.Size = new System.Drawing.Size(157, 28);
            this.lbl_answertime_team.TabIndex = 8;
            this.lbl_answertime_team.Text = "Время на ответ:";
            // 
            // cb_gametime
            // 
            this.cb_gametime.FormattingEnabled = true;
            this.cb_gametime.Items.AddRange(new object[] {
            "30",
            "60",
            "120",
            "180",
            "240",
            "300"});
            this.cb_gametime.Location = new System.Drawing.Point(163, 29);
            this.cb_gametime.Name = "cb_gametime";
            this.cb_gametime.Size = new System.Drawing.Size(77, 36);
            this.cb_gametime.TabIndex = 7;
            this.cb_gametime.SelectedIndexChanged += new System.EventHandler(this.cb_gametime_SelectedIndexChanged);
            // 
            // lbl_gametime
            // 
            this.lbl_gametime.AutoSize = true;
            this.lbl_gametime.Location = new System.Drawing.Point(6, 32);
            this.lbl_gametime.Name = "lbl_gametime";
            this.lbl_gametime.Size = new System.Drawing.Size(156, 28);
            this.lbl_gametime.TabIndex = 6;
            this.lbl_gametime.Text = "Время всей игры:";
            // 
            // cb_btn_answer2
            // 
            this.cb_btn_answer2.FormattingEnabled = true;
            this.cb_btn_answer2.Items.AddRange(new object[] {
            "u",
            "i",
            "o",
            "p"});
            this.cb_btn_answer2.Location = new System.Drawing.Point(163, 205);
            this.cb_btn_answer2.Name = "cb_btn_answer2";
            this.cb_btn_answer2.Size = new System.Drawing.Size(77, 36);
            this.cb_btn_answer2.TabIndex = 5;
            // 
            // lbl_team2
            // 
            this.lbl_team2.AutoSize = true;
            this.lbl_team2.BackColor = System.Drawing.Color.Salmon;
            this.lbl_team2.Location = new System.Drawing.Point(6, 177);
            this.lbl_team2.Name = "lbl_team2";
            this.lbl_team2.Size = new System.Drawing.Size(108, 28);
            this.lbl_team2.TabIndex = 4;
            this.lbl_team2.Text = "Команда 2:";
            // 
            // lbl_btn_answer2
            // 
            this.lbl_btn_answer2.AutoSize = true;
            this.lbl_btn_answer2.Location = new System.Drawing.Point(6, 208);
            this.lbl_btn_answer2.Name = "lbl_btn_answer2";
            this.lbl_btn_answer2.Size = new System.Drawing.Size(151, 28);
            this.lbl_btn_answer2.TabIndex = 3;
            this.lbl_btn_answer2.Text = "Кнопка ответа:";
            // 
            // cb_btn_answer1
            // 
            this.cb_btn_answer1.FormattingEnabled = true;
            this.cb_btn_answer1.Items.AddRange(new object[] {
            "q",
            "w",
            "e",
            "r"});
            this.cb_btn_answer1.Location = new System.Drawing.Point(163, 141);
            this.cb_btn_answer1.Name = "cb_btn_answer1";
            this.cb_btn_answer1.Size = new System.Drawing.Size(77, 36);
            this.cb_btn_answer1.TabIndex = 2;
            // 
            // lbl_team1
            // 
            this.lbl_team1.AutoSize = true;
            this.lbl_team1.BackColor = System.Drawing.Color.Salmon;
            this.lbl_team1.Location = new System.Drawing.Point(6, 113);
            this.lbl_team1.Name = "lbl_team1";
            this.lbl_team1.Size = new System.Drawing.Size(108, 28);
            this.lbl_team1.TabIndex = 1;
            this.lbl_team1.Text = "Команда 1:";
            // 
            // lbl_btn_answer1
            // 
            this.lbl_btn_answer1.AutoSize = true;
            this.lbl_btn_answer1.Location = new System.Drawing.Point(6, 144);
            this.lbl_btn_answer1.Name = "lbl_btn_answer1";
            this.lbl_btn_answer1.Size = new System.Drawing.Size(151, 28);
            this.lbl_btn_answer1.TabIndex = 0;
            this.lbl_btn_answer1.Text = "Кнопка ответа:";
            // 
            // gb_single
            // 
            this.gb_single.BackColor = System.Drawing.Color.MintCream;
            this.gb_single.Controls.Add(this.chb_help);
            this.gb_single.Controls.Add(this.cb_answertime_single);
            this.gb_single.Controls.Add(this.lbl_answertime_single);
            this.gb_single.Controls.Add(this.cb_attempts);
            this.gb_single.Controls.Add(this.lbl_attempts);
            this.gb_single.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_single.Location = new System.Drawing.Point(12, 154);
            this.gb_single.Name = "gb_single";
            this.gb_single.Size = new System.Drawing.Size(250, 157);
            this.gb_single.TabIndex = 21;
            this.gb_single.TabStop = false;
            this.gb_single.Text = "ОДИНОЧНЫЙ РЕЖИМ";
            // 
            // chb_help
            // 
            this.chb_help.AutoSize = true;
            this.chb_help.Location = new System.Drawing.Point(11, 112);
            this.chb_help.MaximumSize = new System.Drawing.Size(113, 32);
            this.chb_help.MinimumSize = new System.Drawing.Size(113, 32);
            this.chb_help.Name = "chb_help";
            this.chb_help.Size = new System.Drawing.Size(113, 32);
            this.chb_help.TabIndex = 23;
            this.chb_help.Text = "Подсказки";
            this.chb_help.UseVisualStyleBackColor = true;
            this.chb_help.CheckedChanged += new System.EventHandler(this.chb_help_CheckedChanged);
            // 
            // cb_answertime_single
            // 
            this.cb_answertime_single.FormattingEnabled = true;
            this.cb_answertime_single.Items.AddRange(new object[] {
            "3",
            "5",
            "10"});
            this.cb_answertime_single.Location = new System.Drawing.Point(163, 74);
            this.cb_answertime_single.Name = "cb_answertime_single";
            this.cb_answertime_single.Size = new System.Drawing.Size(77, 36);
            this.cb_answertime_single.TabIndex = 13;
            this.cb_answertime_single.SelectedIndexChanged += new System.EventHandler(this.cb_answertime_single_SelectedIndexChanged);
            // 
            // lbl_answertime_single
            // 
            this.lbl_answertime_single.AutoSize = true;
            this.lbl_answertime_single.Location = new System.Drawing.Point(6, 77);
            this.lbl_answertime_single.Name = "lbl_answertime_single";
            this.lbl_answertime_single.Size = new System.Drawing.Size(157, 28);
            this.lbl_answertime_single.TabIndex = 12;
            this.lbl_answertime_single.Text = "Время на ответ:";
            // 
            // cb_attempts
            // 
            this.cb_attempts.FormattingEnabled = true;
            this.cb_attempts.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.cb_attempts.Location = new System.Drawing.Point(163, 29);
            this.cb_attempts.Name = "cb_attempts";
            this.cb_attempts.Size = new System.Drawing.Size(77, 36);
            this.cb_attempts.TabIndex = 11;
            this.cb_attempts.SelectedIndexChanged += new System.EventHandler(this.cb_attempts_SelectedIndexChanged);
            // 
            // lbl_attempts
            // 
            this.lbl_attempts.AutoSize = true;
            this.lbl_attempts.Location = new System.Drawing.Point(6, 32);
            this.lbl_attempts.Name = "lbl_attempts";
            this.lbl_attempts.Size = new System.Drawing.Size(96, 28);
            this.lbl_attempts.TabIndex = 10;
            this.lbl_attempts.Text = "Попытки:";
            // 
            // chb_team
            // 
            this.chb_team.AutoSize = true;
            this.chb_team.BackColor = System.Drawing.Color.MintCream;
            this.chb_team.Location = new System.Drawing.Point(12, 57);
            this.chb_team.Name = "chb_team";
            this.chb_team.Size = new System.Drawing.Size(250, 40);
            this.chb_team.TabIndex = 22;
            this.chb_team.Text = "Командный режим ";
            this.chb_team.UseVisualStyleBackColor = false;
            this.chb_team.CheckedChanged += new System.EventHandler(this.chb_team_CheckedChanged);
            // 
            // btn_sound_on
            // 
            this.btn_sound_on.BackColor = System.Drawing.Color.Khaki;
            this.btn_sound_on.BackgroundImage = global::MotoDeti.Properties.Resources._3643734_high_sound_speaker_voice_volume_113403;
            this.btn_sound_on.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sound_on.Location = new System.Drawing.Point(216, 103);
            this.btn_sound_on.Name = "btn_sound_on";
            this.btn_sound_on.Size = new System.Drawing.Size(46, 45);
            this.btn_sound_on.TabIndex = 23;
            this.btn_sound_on.UseVisualStyleBackColor = false;
            this.btn_sound_on.Click += new System.EventHandler(this.btn_sound_on_Click);
            // 
            // btn_sound_off
            // 
            this.btn_sound_off.BackColor = System.Drawing.Color.Khaki;
            this.btn_sound_off.BackgroundImage = global::MotoDeti.Properties.Resources._3643732_mute_sound_speaker_voice_volume_1134391;
            this.btn_sound_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sound_off.Location = new System.Drawing.Point(12, 103);
            this.btn_sound_off.Name = "btn_sound_off";
            this.btn_sound_off.Size = new System.Drawing.Size(46, 45);
            this.btn_sound_off.TabIndex = 24;
            this.btn_sound_off.UseVisualStyleBackColor = false;
            this.btn_sound_off.Click += new System.EventHandler(this.btn_sound_off_Click);
            // 
            // FSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 325);
            this.Controls.Add(this.btn_sound_off);
            this.Controls.Add(this.btn_sound_on);
            this.Controls.Add(this.chb_team);
            this.Controls.Add(this.gb_single);
            this.Controls.Add(this.gb_team);
            this.Controls.Add(this.trb_sound);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_set);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(543, 364);
            this.MinimumSize = new System.Drawing.Size(543, 364);
            this.Name = "FSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb_sound)).EndInit();
            this.gb_team.ResumeLayout(false);
            this.gb_team.PerformLayout();
            this.gb_single.ResumeLayout(false);
            this.gb_single.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_set;
        private System.Windows.Forms.TrackBar trb_sound;
        private System.Windows.Forms.GroupBox gb_team;
        private System.Windows.Forms.GroupBox gb_single;
        private System.Windows.Forms.CheckBox chb_team;
        private System.Windows.Forms.Button btn_sound_on;
        private System.Windows.Forms.Button btn_sound_off;
        private System.Windows.Forms.ComboBox cb_answertime_team;
        private System.Windows.Forms.Label lbl_answertime_team;
        private System.Windows.Forms.ComboBox cb_gametime;
        private System.Windows.Forms.Label lbl_gametime;
        private System.Windows.Forms.ComboBox cb_btn_answer2;
        private System.Windows.Forms.Label lbl_team2;
        private System.Windows.Forms.Label lbl_btn_answer2;
        private System.Windows.Forms.ComboBox cb_btn_answer1;
        private System.Windows.Forms.Label lbl_team1;
        private System.Windows.Forms.Label lbl_btn_answer1;
        private System.Windows.Forms.ComboBox cb_answertime_single;
        private System.Windows.Forms.Label lbl_answertime_single;
        private System.Windows.Forms.ComboBox cb_attempts;
        private System.Windows.Forms.Label lbl_attempts;
        private System.Windows.Forms.CheckBox chb_help;
    }
}