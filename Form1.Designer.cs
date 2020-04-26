namespace DownloadWebsiteAsPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxWebPage = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPDF = new System.Windows.Forms.RadioButton();
            this.radioPNG = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWebPage
            // 
            this.textBoxWebPage.Location = new System.Drawing.Point(120, 25);
            this.textBoxWebPage.Name = "textBoxWebPage";
            this.textBoxWebPage.Size = new System.Drawing.Size(717, 20);
            this.textBoxWebPage.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(762, 162);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Single Web Page:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPNG);
            this.groupBox1.Controls.Add(this.radioPDF);
            this.groupBox1.Location = new System.Drawing.Point(120, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 84);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export File Format Options";
            // 
            // radioPDF
            // 
            this.radioPDF.AutoSize = true;
            this.radioPDF.Checked = true;
            this.radioPDF.Location = new System.Drawing.Point(16, 32);
            this.radioPDF.Name = "radioPDF";
            this.radioPDF.Size = new System.Drawing.Size(49, 17);
            this.radioPDF.TabIndex = 0;
            this.radioPDF.TabStop = true;
            this.radioPDF.Text = ".PDF";
            this.radioPDF.UseVisualStyleBackColor = true;
            // 
            // radioPNG
            // 
            this.radioPNG.AutoSize = true;
            this.radioPNG.Location = new System.Drawing.Point(16, 55);
            this.radioPNG.Name = "radioPNG";
            this.radioPNG.Size = new System.Drawing.Size(51, 17);
            this.radioPNG.TabIndex = 1;
            this.radioPNG.Text = ".PNG";
            this.radioPNG.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 204);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.textBoxWebPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Download Website As PDF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWebPage;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPNG;
        private System.Windows.Forms.RadioButton radioPDF;
    }
}

