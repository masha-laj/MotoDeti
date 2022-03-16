
namespace MotoDeti
{
    partial class FGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGameOver));
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_revenge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_team
            // 
            this.lbl_team.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_team.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_team.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_team.Location = new System.Drawing.Point(191, 9);
            this.lbl_team.MaximumSize = new System.Drawing.Size(180, 37);
            this.lbl_team.MinimumSize = new System.Drawing.Size(180, 37);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(180, 37);
            this.lbl_team.TabIndex = 36;
            this.lbl_team.Text = "0";
            this.lbl_team.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_win
            // 
            this.lbl_win.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_win.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_win.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_win.Location = new System.Drawing.Point(9, 9);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(186, 37);
            this.lbl_win.TabIndex = 35;
            this.lbl_win.Text = "ПОБЕДИТЕЛЬ:";
            this.lbl_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(9, 51);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(172, 41);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_revenge
            // 
            this.btn_revenge.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_revenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_revenge.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_revenge.Location = new System.Drawing.Point(186, 51);
            this.btn_revenge.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_revenge.Name = "btn_revenge";
            this.btn_revenge.Size = new System.Drawing.Size(185, 41);
            this.btn_revenge.TabIndex = 38;
            this.btn_revenge.Text = "Реванш";
            this.btn_revenge.UseVisualStyleBackColor = false;
            this.btn_revenge.Click += new System.EventHandler(this.btn_revenge_Click);
            // 
            // FGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 98);
            this.Controls.Add(this.btn_revenge);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_win);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FGameOver_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_revenge;
    }
}