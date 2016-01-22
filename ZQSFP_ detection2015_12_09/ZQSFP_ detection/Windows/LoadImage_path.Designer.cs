namespace ZQSFP_detection
{
    partial class LoadImage_path
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
            this.ChooseImage = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.PicturePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ChooseImage
            // 
            this.ChooseImage.Location = new System.Drawing.Point(441, 12);
            this.ChooseImage.Name = "ChooseImage";
            this.ChooseImage.Size = new System.Drawing.Size(75, 23);
            this.ChooseImage.TabIndex = 0;
            this.ChooseImage.Text = "選擇圖片";
            this.ChooseImage.UseVisualStyleBackColor = true;
            this.ChooseImage.Click += new System.EventHandler(this.ChooseImage_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(441, 41);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PicturePath
            // 
            this.PicturePath.Location = new System.Drawing.Point(12, 26);
            this.PicturePath.Name = "PicturePath";
            this.PicturePath.Size = new System.Drawing.Size(423, 22);
            this.PicturePath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadImage_path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 76);
            this.Controls.Add(this.PicturePath);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.ChooseImage);
            this.Name = "LoadImage_path";
            this.Text = "LoadImage_path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseImage;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox PicturePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}