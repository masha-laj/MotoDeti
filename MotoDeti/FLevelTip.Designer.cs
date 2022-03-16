
namespace MotoDeti
{
    partial class FLevelTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLevelTip));
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_tip = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Khaki;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(3, 350);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(659, 41);
            this.btn_close.TabIndex = 22;
            this.btn_close.Text = "ЗАКРЫТЬ";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_tip
            // 
            this.lbl_tip.BackColor = System.Drawing.Color.SandyBrown;
            this.lbl_tip.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.lbl_tip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lbl_tip.BorderColor = System.Drawing.Color.Black;
            this.lbl_tip.BorderRadius = 35;
            this.lbl_tip.BorderSize = 0;
            this.lbl_tip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tip.Enabled = false;
            this.lbl_tip.FlatAppearance.BorderSize = 0;
            this.lbl_tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_tip.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_tip.ForeColor = System.Drawing.Color.Black;
            this.lbl_tip.Location = new System.Drawing.Point(10, 10);
            this.lbl_tip.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_tip.Name = "lbl_tip";
            this.lbl_tip.Size = new System.Drawing.Size(645, 327);
            this.lbl_tip.TabIndex = 23;
            this.lbl_tip.Text = "Подсказка";
            this.lbl_tip.TextColor = System.Drawing.Color.Black;
            this.lbl_tip.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tip, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 394);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // FLevelTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 394);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(681, 433);
            this.MinimumSize = new System.Drawing.Size(681, 433);
            this.Name = "FLevelTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсказка";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private CustomControls.RJControls.RJButton lbl_tip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}