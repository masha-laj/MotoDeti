
namespace MotoDeti
{
    partial class FMemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMemo));
            this.lbl_memo = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_rules = new System.Windows.Forms.Button();
            this.btn_pdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_memo
            // 
            this.lbl_memo.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_memo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_memo.Location = new System.Drawing.Point(358, 9);
            this.lbl_memo.Name = "lbl_memo";
            this.lbl_memo.Size = new System.Drawing.Size(195, 37);
            this.lbl_memo.TabIndex = 23;
            this.lbl_memo.Text = "ПАМЯТКА";
            this.lbl_memo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(306, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 24;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_rules
            // 
            this.lbl_rules.BackColor = System.Drawing.Color.OldLace;
            this.lbl_rules.Enabled = false;
            this.lbl_rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_rules.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_rules.Location = new System.Drawing.Point(0, 0);
            this.lbl_rules.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.lbl_rules.Name = "lbl_rules";
            this.lbl_rules.Size = new System.Drawing.Size(810, 1082);
            this.lbl_rules.TabIndex = 25;
            this.lbl_rules.Text = resources.GetString("lbl_rules.Text");
            this.lbl_rules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_rules.UseVisualStyleBackColor = false;
            // 
            // btn_pdd
            // 
            this.btn_pdd.BackColor = System.Drawing.Color.Khaki;
            this.btn_pdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdd.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.btn_pdd.Location = new System.Drawing.Point(12, 549);
            this.btn_pdd.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.btn_pdd.Name = "btn_pdd";
            this.btn_pdd.Size = new System.Drawing.Size(827, 49);
            this.btn_pdd.TabIndex = 26;
            this.btn_pdd.Text = "ПДД";
            this.btn_pdd.UseVisualStyleBackColor = false;
            this.btn_pdd.Click += new System.EventHandler(this.btn_pdd_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_rules);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 487);
            this.panel1.TabIndex = 28;
            // 
            // FMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_pdd);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_memo);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximumSize = new System.Drawing.Size(864, 645);
            this.MinimumSize = new System.Drawing.Size(864, 645);
            this.Name = "FMemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Памятка";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_memo;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button lbl_rules;
        private System.Windows.Forms.Button btn_pdd;
        private System.Windows.Forms.Panel panel1;
    }
}