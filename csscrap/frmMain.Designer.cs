namespace csscrap
{
    partial class frmMain
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
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtSheet = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblSheet = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(53, 45);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(189, 20);
            this.txtLink.TabIndex = 0;
            // 
            // txtSheet
            // 
            this.txtSheet.Location = new System.Drawing.Point(53, 71);
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(189, 20);
            this.txtSheet.TabIndex = 1;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(53, 97);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(189, 20);
            this.txtFile.TabIndex = 2;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(13, 45);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(27, 13);
            this.lblLink.TabIndex = 4;
            this.lblLink.Text = "Link";
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Location = new System.Drawing.Point(13, 71);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(33, 13);
            this.lblSheet.TabIndex = 5;
            this.lblSheet.Text = "Folha";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 97);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(43, 13);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "Arquivo";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(109, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Gerar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(99, 189);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(100, 23);
            this.pgBar.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtSheet);
            this.Controls.Add(this.txtLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Excel 4 Winner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtSheet;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ProgressBar pgBar;
    }
}