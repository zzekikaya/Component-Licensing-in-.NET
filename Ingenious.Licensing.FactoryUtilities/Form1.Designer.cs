namespace Ingenious.Licensing.FactoryUtilities
{
    partial class Form1
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
            this.bttn_GenKey = new System.Windows.Forms.Button();
            this.tbx_LicKey = new System.Windows.Forms.TextBox();
            this.lbl_LicKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_GenKey
            // 
            this.bttn_GenKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_GenKey.Location = new System.Drawing.Point(403, 72);
            this.bttn_GenKey.Name = "bttn_GenKey";
            this.bttn_GenKey.Size = new System.Drawing.Size(129, 23);
            this.bttn_GenKey.TabIndex = 0;
            this.bttn_GenKey.Text = "Generate Key";
            this.bttn_GenKey.UseVisualStyleBackColor = true;
            this.bttn_GenKey.Click += new System.EventHandler(this.bttn_GenKey_Click);
            // 
            // tbx_LicKey
            // 
            this.tbx_LicKey.Location = new System.Drawing.Point(12, 30);
            this.tbx_LicKey.Name = "tbx_LicKey";
            this.tbx_LicKey.Size = new System.Drawing.Size(520, 20);
            this.tbx_LicKey.TabIndex = 1;
            // 
            // lbl_LicKey
            // 
            this.lbl_LicKey.AutoSize = true;
            this.lbl_LicKey.Location = new System.Drawing.Point(12, 14);
            this.lbl_LicKey.Name = "lbl_LicKey";
            this.lbl_LicKey.Size = new System.Drawing.Size(68, 13);
            this.lbl_LicKey.TabIndex = 2;
            this.lbl_LicKey.Text = "License Key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 107);
            this.Controls.Add(this.lbl_LicKey);
            this.Controls.Add(this.tbx_LicKey);
            this.Controls.Add(this.bttn_GenKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Factory Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_GenKey;
        private System.Windows.Forms.TextBox tbx_LicKey;
        private System.Windows.Forms.Label lbl_LicKey;
    }
}

