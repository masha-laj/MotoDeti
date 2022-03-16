
namespace MotoDeti
{
    partial class FMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenu));
            this.btn_memo = new System.Windows.Forms.Button();
            this.btn_single_game = new System.Windows.Forms.Button();
            this.btn_team_game = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_mainmenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_memo
            // 
            this.btn_memo.BackColor = System.Drawing.Color.Khaki;
            this.btn_memo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_memo.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_memo.Location = new System.Drawing.Point(57, 53);
            this.btn_memo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_memo.Name = "btn_memo";
            this.btn_memo.Size = new System.Drawing.Size(217, 49);
            this.btn_memo.TabIndex = 0;
            this.btn_memo.Text = "Памятка";
            this.btn_memo.UseVisualStyleBackColor = false;
            this.btn_memo.Click += new System.EventHandler(this.btn_memo_Click);
            // 
            // btn_single_game
            // 
            this.btn_single_game.BackColor = System.Drawing.Color.Khaki;
            this.btn_single_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single_game.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_single_game.Location = new System.Drawing.Point(57, 106);
            this.btn_single_game.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_single_game.Name = "btn_single_game";
            this.btn_single_game.Size = new System.Drawing.Size(217, 49);
            this.btn_single_game.TabIndex = 1;
            this.btn_single_game.Text = "Одиночная игра";
            this.btn_single_game.UseVisualStyleBackColor = false;
            this.btn_single_game.Click += new System.EventHandler(this.btn_single_game_Click);
            // 
            // btn_team_game
            // 
            this.btn_team_game.BackColor = System.Drawing.Color.Khaki;
            this.btn_team_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_team_game.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_team_game.Location = new System.Drawing.Point(57, 161);
            this.btn_team_game.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_team_game.Name = "btn_team_game";
            this.btn_team_game.Size = new System.Drawing.Size(217, 49);
            this.btn_team_game.TabIndex = 2;
            this.btn_team_game.Text = "Командная игра";
            this.btn_team_game.UseVisualStyleBackColor = false;
            this.btn_team_game.Click += new System.EventHandler(this.btn_team_game_Click);
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.Khaki;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_set.Location = new System.Drawing.Point(57, 216);
            this.btn_set.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(217, 49);
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = "Настройки";
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Salmon;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_exit.Location = new System.Drawing.Point(57, 271);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(217, 49);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "ВЫХОД";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_mainmenu
            // 
            this.lbl_mainmenu.AutoSize = true;
            this.lbl_mainmenu.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_mainmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_mainmenu.Location = new System.Drawing.Point(57, 9);
            this.lbl_mainmenu.Name = "lbl_mainmenu";
            this.lbl_mainmenu.Size = new System.Drawing.Size(217, 36);
            this.lbl_mainmenu.TabIndex = 5;
            this.lbl_mainmenu.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 336);
            this.Controls.Add(this.lbl_mainmenu);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_team_game);
            this.Controls.Add(this.btn_single_game);
            this.Controls.Add(this.btn_memo);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(355, 375);
            this.MinimumSize = new System.Drawing.Size(355, 375);
            this.Name = "FMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.FMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_memo;
        private System.Windows.Forms.Button btn_single_game;
        private System.Windows.Forms.Button btn_team_game;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_mainmenu;
    }
}

