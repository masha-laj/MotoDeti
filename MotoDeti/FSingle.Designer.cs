
namespace MotoDeti
{
    partial class FSingle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSingle));
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_top = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Khaki;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_new.Location = new System.Drawing.Point(33, 55);
            this.btn_new.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(178, 51);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "Новая игра";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Khaki;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_continue.Location = new System.Drawing.Point(33, 117);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(178, 51);
            this.btn_continue.TabIndex = 3;
            this.btn_continue.Text = "Продолжить";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(45, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 16;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_menu.Location = new System.Drawing.Point(97, 9);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(90, 36);
            this.lbl_menu.TabIndex = 15;
            this.lbl_menu.Text = "МЕНЮ";
            // 
            // btn_top
            // 
            this.btn_top.BackColor = System.Drawing.Color.Khaki;
            this.btn_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_top.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_top.Location = new System.Drawing.Point(33, 179);
            this.btn_top.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_top.Name = "btn_top";
            this.btn_top.Size = new System.Drawing.Size(178, 51);
            this.btn_top.TabIndex = 17;
            this.btn_top.Text = "Топ игроков";
            this.btn_top.UseVisualStyleBackColor = false;
            this.btn_top.Click += new System.EventHandler(this.btn_top_Click);
            // 
            // FSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(248, 244);
            this.Controls.Add(this.btn_top);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_new);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(264, 283);
            this.MinimumSize = new System.Drawing.Size(264, 283);
            this.Name = "FSingle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Одиночная игра";
            this.Load += new System.EventHandler(this.FSingle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_top;
    }
}