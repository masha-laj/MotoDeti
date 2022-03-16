
namespace MotoDeti
{
    partial class FContinue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FContinue));
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_players = new System.Windows.Forms.Label();
            this.dgv_players = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_filt = new System.Windows.Forms.ComboBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_game = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(196, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 16;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_players
            // 
            this.lbl_players.AutoSize = true;
            this.lbl_players.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_players.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_players.Location = new System.Drawing.Point(248, 9);
            this.lbl_players.Name = "lbl_players";
            this.lbl_players.Size = new System.Drawing.Size(214, 36);
            this.lbl_players.TabIndex = 15;
            this.lbl_players.Text = "ВЫБОР ИГРОКА";
            // 
            // dgv_players
            // 
            this.dgv_players.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_players.Location = new System.Drawing.Point(12, 102);
            this.dgv_players.Name = "dgv_players";
            this.dgv_players.RowHeadersWidth = 62;
            this.dgv_players.Size = new System.Drawing.Size(641, 238);
            this.dgv_players.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Khaki;
            this.btn_search.BackgroundImage = global::MotoDeti.Properties.Resources._3844432_magnifier_search_zoom_110300;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(358, 54);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(42, 42);
            this.btn_search.TabIndex = 18;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_filt
            // 
            this.cb_filt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_filt.FormattingEnabled = true;
            this.cb_filt.Items.AddRange(new object[] {
            "Все",
            "Школьники",
            "Выпускники"});
            this.cb_filt.Location = new System.Drawing.Point(406, 54);
            this.cb_filt.Name = "cb_filt";
            this.cb_filt.Size = new System.Drawing.Size(145, 41);
            this.cb_filt.TabIndex = 19;
            this.cb_filt.SelectedIndexChanged += new System.EventHandler(this.cb_filt_SelectedIndexChanged);
            // 
            // btn_sort
            // 
            this.btn_sort.BackColor = System.Drawing.Color.Khaki;
            this.btn_sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sort.Location = new System.Drawing.Point(557, 54);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(96, 41);
            this.btn_sort.TabIndex = 20;
            this.btn_sort.Text = "А - Я";
            this.btn_sort.UseVisualStyleBackColor = false;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_search.Location = new System.Drawing.Point(60, 55);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(292, 41);
            this.tb_search.TabIndex = 21;
            // 
            // btn_game
            // 
            this.btn_game.BackColor = System.Drawing.Color.Khaki;
            this.btn_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_game.Location = new System.Drawing.Point(12, 345);
            this.btn_game.Name = "btn_game";
            this.btn_game.Size = new System.Drawing.Size(641, 41);
            this.btn_game.TabIndex = 22;
            this.btn_game.Text = "ИГРАТЬ";
            this.btn_game.UseVisualStyleBackColor = false;
            this.btn_game.Click += new System.EventHandler(this.btn_game_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Khaki;
            this.btn_refresh.BackgroundImage = global::MotoDeti.Properties.Resources.twocirclingarrows1_120592;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Location = new System.Drawing.Point(12, 55);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(42, 42);
            this.btn_refresh.TabIndex = 34;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // FContinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 394);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_game);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.cb_filt);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_players);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_players);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(681, 433);
            this.MinimumSize = new System.Drawing.Size(681, 433);
            this.Name = "FContinue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор игрока";
            this.Load += new System.EventHandler(this.FContinue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_players;
        private System.Windows.Forms.DataGridView dgv_players;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_filt;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_game;
        private System.Windows.Forms.Button btn_refresh;
    }
}