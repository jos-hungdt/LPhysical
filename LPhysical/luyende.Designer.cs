namespace LPhysical
{
    partial class luyende
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(luyende));
            this.cbClas = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.wbRes = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cbClas
            // 
            this.cbClas.FormattingEnabled = true;
            this.cbClas.Location = new System.Drawing.Point(12, 496);
            this.cbClas.Name = "cbClas";
            this.cbClas.Size = new System.Drawing.Size(144, 21);
            this.cbClas.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(162, 490);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(71, 31);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // wbRes
            // 
            this.wbRes.Location = new System.Drawing.Point(2, 3);
            this.wbRes.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbRes.Name = "wbRes";
            this.wbRes.Size = new System.Drawing.Size(672, 481);
            this.wbRes.TabIndex = 3;
            // 
            // luyende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 529);
            this.Controls.Add(this.wbRes);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbClas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "luyende";
            this.Text = "Đề tự luyện > Không sợ bài tập khó - Chỉ sợ lòng không chịu khó";
            this.Load += new System.EventHandler(this.luyende_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClas;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.WebBrowser wbRes;
    }
}