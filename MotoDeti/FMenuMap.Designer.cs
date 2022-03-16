
namespace MotoDeti
{
    partial class FMenuMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuMap));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_menu_map = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_top = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(62, 17);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 20;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_menu_map
            // 
            this.lbl_menu_map.AutoSize = true;
            this.lbl_menu_map.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_menu_map.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_menu_map.Location = new System.Drawing.Point(114, 17);
            this.lbl_menu_map.Name = "lbl_menu_map";
            this.lbl_menu_map.Size = new System.Drawing.Size(341, 36);
            this.lbl_menu_map.TabIndex = 19;
            this.lbl_menu_map.Text = "МЕНЮ ОДИНОЧНОЙ ИГРЫ";
            this.lbl_menu_map.Click += new System.EventHandler(this.lbl_set_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Khaki;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_exit.Location = new System.Drawing.Point(62, 75);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(393, 51);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_top
            // 
            this.btn_top.BackColor = System.Drawing.Color.Khaki;
            this.btn_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_top.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_top.Location = new System.Drawing.Point(62, 137);
            this.btn_top.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_top.Name = "btn_top";
            this.btn_top.Size = new System.Drawing.Size(393, 51);
            this.btn_top.TabIndex = 24;
            this.btn_top.Text = "Топ игроков";
            this.btn_top.UseVisualStyleBackColor = false;
            this.btn_top.Click += new System.EventHandler(this.btn_top_Click);
            // 
            // FMenuMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 223);
            this.Controls.Add(this.btn_top);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_menu_map);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(543, 262);
            this.MinimumSize = new System.Drawing.Size(543, 262);
            this.Name = "FMenuMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню одиночной игры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_menu_map;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_top;
    }
}