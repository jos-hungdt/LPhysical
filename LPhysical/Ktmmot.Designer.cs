namespace LPhysical
{
    partial class Ktmmot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ktmmot));
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.wbResult = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cmbSession
            // 
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(1, 13);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(133, 21);
            this.cmbSession.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRead.BackgroundImage")));
            this.btnRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRead.Location = new System.Drawing.Point(27, 41);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 34);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Học";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // wbResult
            // 
            this.wbResult.Location = new System.Drawing.Point(141, 0);
            this.wbResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResult.Name = "wbResult";
            this.wbResult.Size = new System.Drawing.Size(530, 530);
            this.wbResult.TabIndex = 3;
            // 
            // Ktmmot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 529);
            this.Controls.Add(this.wbResult);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.cmbSession);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ktmmot";
            this.Text = "LPhysical";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.WebBrowser wbResult;
    }
}