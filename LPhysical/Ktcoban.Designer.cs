namespace LPhysical
{
    partial class Ktcoban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ktcoban));
            this.cmbSession = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.webBrowserht = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cmbSession
            // 
            this.cmbSession.FormattingEnabled = true;
            this.cmbSession.Location = new System.Drawing.Point(2, 24);
            this.cmbSession.Name = "cmbSession";
            this.cmbSession.Size = new System.Drawing.Size(140, 21);
            this.cmbSession.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXem.BackgroundImage")));
            this.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXem.Location = new System.Drawing.Point(37, 51);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(78, 35);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Học";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // webBrowserht
            // 
            this.webBrowserht.Location = new System.Drawing.Point(148, 2);
            this.webBrowserht.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserht.Name = "webBrowserht";
            this.webBrowserht.Size = new System.Drawing.Size(524, 525);
            this.webBrowserht.TabIndex = 3;
            // 
            // Ktcoban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 529);
            this.Controls.Add(this.webBrowserht);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cmbSession);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ktcoban";
            this.Text = "LPhysical";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSession;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.WebBrowser webBrowserht;
    }
}