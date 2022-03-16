
namespace MotoDeti
{
    partial class FPdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_rules = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_pdd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_rules);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 487);
            this.panel1.TabIndex = 31;
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
            this.lbl_rules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_rules.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Khaki;
            this.btn_back.BackgroundImage = global::MotoDeti.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(299, 9);
            this.btn_back.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(42, 36);
            this.btn_back.TabIndex = 30;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // lbl_pdd
            // 
            this.lbl_pdd.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_pdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_pdd.Location = new System.Drawing.Point(351, 9);
            this.lbl_pdd.Name = "lbl_pdd";
            this.lbl_pdd.Size = new System.Drawing.Size(195, 37);
            this.lbl_pdd.TabIndex = 29;
            this.lbl_pdd.Text = "СПРАВОЧНИК ПДД";
            this.lbl_pdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FPdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MotoDeti.Properties.Resources.Bezymyanny_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_pdd);
            this.Font = new System.Drawing.Font("Segoe Print", 15.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FPdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lbl_rules;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_pdd;
    }
}