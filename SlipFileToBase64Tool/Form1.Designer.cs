namespace SlipFileToBase64Tool
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lsbSliptFile = new System.Windows.Forms.ListBox();
            this.btnSlipt = new System.Windows.Forms.Button();
            this.txtChunkSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtUrl
            // 
            this.txtUrl.Enabled = false;
            this.txtUrl.Location = new System.Drawing.Point(12, 11);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(526, 20);
            this.txtUrl.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(463, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 34);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(463, 83);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 244);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lsbSliptFile
            // 
            this.lsbSliptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbSliptFile.FormattingEnabled = true;
            this.lsbSliptFile.ItemHeight = 16;
            this.lsbSliptFile.Location = new System.Drawing.Point(15, 83);
            this.lsbSliptFile.Name = "lsbSliptFile";
            this.lsbSliptFile.Size = new System.Drawing.Size(424, 244);
            this.lsbSliptFile.TabIndex = 4;
            // 
            // btnSlipt
            // 
            this.btnSlipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlipt.Location = new System.Drawing.Point(364, 40);
            this.btnSlipt.Name = "btnSlipt";
            this.btnSlipt.Size = new System.Drawing.Size(75, 34);
            this.btnSlipt.TabIndex = 5;
            this.btnSlipt.Text = "Slipt";
            this.btnSlipt.UseVisualStyleBackColor = true;
            this.btnSlipt.Click += new System.EventHandler(this.btnSlipt_Click);
            // 
            // txtChunkSize
            // 
            this.txtChunkSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChunkSize.Location = new System.Drawing.Point(238, 46);
            this.txtChunkSize.Name = "txtChunkSize";
            this.txtChunkSize.Size = new System.Drawing.Size(95, 23);
            this.txtChunkSize.TabIndex = 6;
            this.txtChunkSize.Text = "4000000";
            this.txtChunkSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChunkSize_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chunk Size in byte:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChunkSize);
            this.Controls.Add(this.btnSlipt);
            this.Controls.Add(this.lsbSliptFile);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Slipt file to Base64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ListBox lsbSliptFile;
        private System.Windows.Forms.Button btnSlipt;
        private System.Windows.Forms.TextBox txtChunkSize;
        private System.Windows.Forms.Label label1;
    }
}

