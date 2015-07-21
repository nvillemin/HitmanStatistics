namespace HitmanStatistics {
    partial class FormAbout {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.LinkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.LinkLabelSource = new System.Windows.Forms.LinkLabel();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hitman Statistics is an open-source software created by Nathanaël Villemin.\r\n\r\nFo" +
    "r any questions or suggestions feel free to contact:\r\n\r\nSource code:";
            // 
            // LinkLabelEmail
            // 
            this.LinkLabelEmail.AutoSize = true;
            this.LinkLabelEmail.Location = new System.Drawing.Point(264, 35);
            this.LinkLabelEmail.Name = "LinkLabelEmail";
            this.LinkLabelEmail.Size = new System.Drawing.Size(108, 13);
            this.LinkLabelEmail.TabIndex = 1;
            this.LinkLabelEmail.TabStop = true;
            this.LinkLabelEmail.Text = "villemin.n@gmail.com";
            this.LinkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEmail_LinkClicked);
            // 
            // LinkLabelSource
            // 
            this.LinkLabelSource.AutoSize = true;
            this.LinkLabelSource.Location = new System.Drawing.Point(79, 61);
            this.LinkLabelSource.Name = "LinkLabelSource";
            this.LinkLabelSource.Size = new System.Drawing.Size(37, 13);
            this.LinkLabelSource.TabIndex = 2;
            this.LinkLabelSource.TabStop = true;
            this.LinkLabelSource.Text = "HERE";
            this.LinkLabelSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSource_LinkClicked);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(155, 86);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(300, 61);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(72, 13);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "Version: 2.2.3";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 117);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.LinkLabelSource);
            this.Controls.Add(this.LinkLabelEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Hitman Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkLabelEmail;
        private System.Windows.Forms.LinkLabel LinkLabelSource;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelVersion;
    }
}