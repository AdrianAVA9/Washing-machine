namespace WashingMachine.IU
{
    partial class ShowException
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
            this.exceptionName = new System.Windows.Forms.Label();
            this.exceptionDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exceptionName
            // 
            this.exceptionName.AutoSize = true;
            this.exceptionName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exceptionName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exceptionName.Location = new System.Drawing.Point(26, 18);
            this.exceptionName.Name = "exceptionName";
            this.exceptionName.Size = new System.Drawing.Size(114, 16);
            this.exceptionName.TabIndex = 0;
            this.exceptionName.Text = "Exception Name";
            // 
            // exceptionDescription
            // 
            this.exceptionDescription.AutoSize = true;
            this.exceptionDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exceptionDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exceptionDescription.Location = new System.Drawing.Point(26, 40);
            this.exceptionDescription.Name = "exceptionDescription";
            this.exceptionDescription.Size = new System.Drawing.Size(137, 17);
            this.exceptionDescription.TabIndex = 1;
            this.exceptionDescription.Text = "Exception description";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnClose.Location = new System.Drawing.Point(537, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowException
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 80);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.exceptionDescription);
            this.Controls.Add(this.exceptionName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowException";
            this.Load += new System.EventHandler(this.ShowException_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exceptionName;
        private System.Windows.Forms.Label exceptionDescription;
        private System.Windows.Forms.Button btnClose;
    }
}