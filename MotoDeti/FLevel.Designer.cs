
namespace MotoDeti
{
    partial class FLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLevel));
            this.pb_a = new System.Windows.Forms.PictureBox();
            this.pb_b = new System.Windows.Forms.PictureBox();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.lives_lbl = new System.Windows.Forms.Label();
            this.pb_a_answer = new System.Windows.Forms.PictureBox();
            this.pb_b_answer = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.next_btn = new CustomControls.RJControls.RJButton();
            this.lvl_description = new CustomControls.RJControls.RJButton();
            this.btn_b = new CustomControls.RJControls.RJButton();
            this.btn_a = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_a_answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b_answer)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_a
            // 
            this.pb_a.BackColor = System.Drawing.Color.Transparent;
            this.pb_a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_a.Location = new System.Drawing.Point(81, 244);
            this.pb_a.Name = "pb_a";
            this.pb_a.Size = new System.Drawing.Size(400, 388);
            this.pb_a.TabIndex = 0;
            this.pb_a.TabStop = false;
            // 
            // pb_b
            // 
            this.pb_b.BackColor = System.Drawing.Color.Transparent;
            this.pb_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_b.Location = new System.Drawing.Point(641, 244);
            this.pb_b.Name = "pb_b";
            this.pb_b.Size = new System.Drawing.Size(400, 388);
            this.pb_b.TabIndex = 1;
            this.pb_b.TabStop = false;
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.BackColor = System.Drawing.Color.White;
            this.timer_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timer_lbl.ForeColor = System.Drawing.Color.Black;
            this.timer_lbl.Location = new System.Drawing.Point(534, 519);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(51, 74);
            this.timer_lbl.TabIndex = 5;
            this.timer_lbl.Text = "60\r\nсек";
            this.timer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lives_lbl
            // 
            this.lives_lbl.AutoSize = true;
            this.lives_lbl.BackColor = System.Drawing.Color.White;
            this.lives_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lives_lbl.ForeColor = System.Drawing.Color.Black;
            this.lives_lbl.Location = new System.Drawing.Point(522, 258);
            this.lives_lbl.Name = "lives_lbl";
            this.lives_lbl.Size = new System.Drawing.Size(75, 38);
            this.lives_lbl.TabIndex = 6;
            this.lives_lbl.Text = "3 / 3";
            this.lives_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_a_answer
            // 
            this.pb_a_answer.BackgroundImage = global::MotoDeti.Properties.Resources.correct_answer;
            this.pb_a_answer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_a_answer.Location = new System.Drawing.Point(252, 647);
            this.pb_a_answer.Name = "pb_a_answer";
            this.pb_a_answer.Size = new System.Drawing.Size(53, 53);
            this.pb_a_answer.TabIndex = 7;
            this.pb_a_answer.TabStop = false;
            this.pb_a_answer.Visible = false;
            // 
            // pb_b_answer
            // 
            this.pb_b_answer.BackgroundImage = global::MotoDeti.Properties.Resources.correct_answer;
            this.pb_b_answer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_b_answer.Location = new System.Drawing.Point(819, 647);
            this.pb_b_answer.Name = "pb_b_answer";
            this.pb_b_answer.Size = new System.Drawing.Size(53, 53);
            this.pb_b_answer.TabIndex = 8;
            this.pb_b_answer.TabStop = false;
            this.pb_b_answer.Visible = false;
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.next_btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.next_btn.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next_btn.BorderRadius = 0;
            this.next_btn.BorderSize = 1;
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.ForeColor = System.Drawing.Color.White;
            this.next_btn.Location = new System.Drawing.Point(448, 647);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(230, 53);
            this.next_btn.TabIndex = 9;
            this.next_btn.Text = "Далее";
            this.next_btn.TextColor = System.Drawing.Color.White;
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // lvl_description
            // 
            this.lvl_description.BackColor = System.Drawing.Color.SandyBrown;
            this.lvl_description.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.lvl_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvl_description.BorderColor = System.Drawing.Color.Black;
            this.lvl_description.BorderRadius = 35;
            this.lvl_description.BorderSize = 0;
            this.lvl_description.Enabled = false;
            this.lvl_description.FlatAppearance.BorderSize = 0;
            this.lvl_description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lvl_description.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_description.ForeColor = System.Drawing.Color.Black;
            this.lvl_description.Location = new System.Drawing.Point(31, 22);
            this.lvl_description.MaximumSize = new System.Drawing.Size(1053, 172);
            this.lvl_description.MinimumSize = new System.Drawing.Size(1053, 172);
            this.lvl_description.Name = "lvl_description";
            this.lvl_description.Size = new System.Drawing.Size(1053, 172);
            this.lvl_description.TabIndex = 4;
            this.lvl_description.Text = "Задание";
            this.lvl_description.TextColor = System.Drawing.Color.Black;
            this.lvl_description.UseVisualStyleBackColor = false;
            // 
            // btn_b
            // 
            this.btn_b.BackColor = System.Drawing.Color.Transparent;
            this.btn_b.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_b.BackgroundImage = global::MotoDeti.Properties.Resources.кнопка_б;
            this.btn_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_b.BorderColor = System.Drawing.Color.Transparent;
            this.btn_b.BorderRadius = 0;
            this.btn_b.BorderSize = 0;
            this.btn_b.FlatAppearance.BorderSize = 0;
            this.btn_b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_b.ForeColor = System.Drawing.Color.Transparent;
            this.btn_b.Location = new System.Drawing.Point(726, 647);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(228, 53);
            this.btn_b.TabIndex = 3;
            this.btn_b.TextColor = System.Drawing.Color.Transparent;
            this.btn_b.UseVisualStyleBackColor = false;
            this.btn_b.Click += new System.EventHandler(this.btn_b_Click);
            this.btn_b.MouseEnter += new System.EventHandler(this.btn_b_MouseEnter);
            this.btn_b.MouseLeave += new System.EventHandler(this.btn_b_MouseLeave);
            // 
            // btn_a
            // 
            this.btn_a.BackColor = System.Drawing.Color.Transparent;
            this.btn_a.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_a.BackgroundImage = global::MotoDeti.Properties.Resources.кнопка_а;
            this.btn_a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_a.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_a.BorderRadius = 0;
            this.btn_a.BorderSize = 0;
            this.btn_a.FlatAppearance.BorderSize = 0;
            this.btn_a.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_a.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_a.ForeColor = System.Drawing.Color.White;
            this.btn_a.Location = new System.Drawing.Point(165, 647);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(228, 53);
            this.btn_a.TabIndex = 2;
            this.btn_a.TextColor = System.Drawing.Color.White;
            this.btn_a.UseVisualStyleBackColor = false;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            this.btn_a.MouseEnter += new System.EventHandler(this.btn_a_MouseEnter);
            this.btn_a.MouseLeave += new System.EventHandler(this.btn_a_MouseLeave);
            // 
            // FLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 763);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.pb_b_answer);
            this.Controls.Add(this.pb_a_answer);
            this.Controls.Add(this.lives_lbl);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.lvl_description);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.pb_b);
            this.Controls.Add(this.pb_a);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(1134, 802);
            this.MinimumSize = new System.Drawing.Size(1134, 802);
            this.Name = "FLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLevel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_a_answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b_answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_a;
        private System.Windows.Forms.PictureBox pb_b;
        private CustomControls.RJControls.RJButton btn_a;
        private CustomControls.RJControls.RJButton btn_b;
        private CustomControls.RJControls.RJButton lvl_description;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.Label lives_lbl;
        private System.Windows.Forms.PictureBox pb_a_answer;
        private System.Windows.Forms.PictureBox pb_b_answer;
        private CustomControls.RJControls.RJButton next_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}