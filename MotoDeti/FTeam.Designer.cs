
namespace MotoDeti
{
    partial class FTeam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTeam));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_left = new System.Windows.Forms.Label();
            this.lbl_left_num = new System.Windows.Forms.Label();
            this.pB_time = new System.Windows.Forms.ProgressBar();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_team1 = new System.Windows.Forms.Label();
            this.lbl_team2 = new System.Windows.Forms.Label();
            this.lbl_team1_num = new System.Windows.Forms.Label();
            this.lbl_team2_num = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ip_address = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(143, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 26;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_left
            // 
            this.lbl_left.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_left.Location = new System.Drawing.Point(195, 9);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(303, 37);
            this.lbl_left.TabIndex = 25;
            this.lbl_left.Text = "ОСТАЛОСЬ ВОПРОСОВ";
            this.lbl_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_left_num
            // 
            this.lbl_left_num.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_left_num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_left_num.Location = new System.Drawing.Point(504, 10);
            this.lbl_left_num.Name = "lbl_left_num";
            this.lbl_left_num.Size = new System.Drawing.Size(35, 36);
            this.lbl_left_num.TabIndex = 27;
            this.lbl_left_num.Text = "0";
            this.lbl_left_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pB_time
            // 
            this.pB_time.Location = new System.Drawing.Point(12, 118);
            this.pB_time.Name = "pB_time";
            this.pB_time.Size = new System.Drawing.Size(641, 36);
            this.pB_time.TabIndex = 28;
            this.pB_time.Value = 50;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Beige;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_next.Location = new System.Drawing.Point(12, 161);
            this.btn_next.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(235, 51);
            this.btn_next.TabIndex = 29;
            this.btn_next.Text = "Следующий вопрос";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_stop.Location = new System.Drawing.Point(253, 161);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(199, 51);
            this.btn_stop.TabIndex = 30;
            this.btn_stop.Text = "Стоп";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_play.Location = new System.Drawing.Point(458, 161);
            this.btn_play.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(195, 51);
            this.btn_play.TabIndex = 31;
            this.btn_play.Text = "Возобновить";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lbl_team1
            // 
            this.lbl_team1.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_team1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_team1.Location = new System.Drawing.Point(12, 68);
            this.lbl_team1.Name = "lbl_team1";
            this.lbl_team1.Size = new System.Drawing.Size(208, 37);
            this.lbl_team1.TabIndex = 32;
            this.lbl_team1.Text = "КОМАНДА 1";
            this.lbl_team1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_team2
            // 
            this.lbl_team2.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_team2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_team2.Location = new System.Drawing.Point(390, 67);
            this.lbl_team2.Name = "lbl_team2";
            this.lbl_team2.Size = new System.Drawing.Size(208, 37);
            this.lbl_team2.TabIndex = 33;
            this.lbl_team2.Text = "КОМАНДА 2";
            this.lbl_team2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_team1_num
            // 
            this.lbl_team1_num.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_team1_num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_team1_num.Location = new System.Drawing.Point(226, 68);
            this.lbl_team1_num.Name = "lbl_team1_num";
            this.lbl_team1_num.Size = new System.Drawing.Size(48, 36);
            this.lbl_team1_num.TabIndex = 34;
            this.lbl_team1_num.Text = "0";
            this.lbl_team1_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_team2_num
            // 
            this.lbl_team2_num.BackColor = System.Drawing.Color.PaleGreen;
            this.lbl_team2_num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_team2_num.Location = new System.Drawing.Point(604, 68);
            this.lbl_team2_num.Name = "lbl_team2_num";
            this.lbl_team2_num.Size = new System.Drawing.Size(49, 36);
            this.lbl_team2_num.TabIndex = 35;
            this.lbl_team2_num.Text = "0";
            this.lbl_team2_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ip_address
            // 
            this.ip_address.BackColor = System.Drawing.Color.SandyBrown;
            this.ip_address.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.ip_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ip_address.BorderColor = System.Drawing.Color.Black;
            this.ip_address.BorderRadius = 35;
            this.ip_address.BorderSize = 0;
            this.ip_address.Enabled = false;
            this.ip_address.FlatAppearance.BorderSize = 0;
            this.ip_address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ip_address.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ip_address.ForeColor = System.Drawing.Color.Black;
            this.ip_address.Location = new System.Drawing.Point(12, 218);
            this.ip_address.MaximumSize = new System.Drawing.Size(1053, 172);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(641, 43);
            this.ip_address.TabIndex = 36;
            this.ip_address.TextColor = System.Drawing.Color.Black;
            this.ip_address.UseVisualStyleBackColor = false;
            // 
            // FTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 269);
            this.Controls.Add(this.ip_address);
            this.Controls.Add(this.lbl_team2_num);
            this.Controls.Add(this.lbl_team1_num);
            this.Controls.Add(this.lbl_team2);
            this.Controls.Add(this.lbl_team1);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.pB_time);
            this.Controls.Add(this.lbl_left_num);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_left);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(681, 308);
            this.MinimumSize = new System.Drawing.Size(681, 308);
            this.Name = "FTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Командная игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FTeam_FormClosed);
            this.Load += new System.EventHandler(this.FTeam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label lbl_left_num;
        private System.Windows.Forms.ProgressBar pB_time;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label lbl_team1;
        private System.Windows.Forms.Label lbl_team2;
        private System.Windows.Forms.Label lbl_team1_num;
        private System.Windows.Forms.Label lbl_team2_num;
        private System.Windows.Forms.Timer timer1;
        private CustomControls.RJControls.RJButton ip_address;
    }
}