namespace ST_LoadImage
{
    partial class Choose
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
            this.ImgaeFromFile = new System.Windows.Forms.Button();
            this.ImageFromCamera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImgaeFromFile
            // 
            this.ImgaeFromFile.Location = new System.Drawing.Point(12, 12);
            this.ImgaeFromFile.Name = "ImgaeFromFile";
            this.ImgaeFromFile.Size = new System.Drawing.Size(210, 111);
            this.ImgaeFromFile.TabIndex = 0;
            this.ImgaeFromFile.Text = "File";
            this.ImgaeFromFile.UseVisualStyleBackColor = true;
            this.ImgaeFromFile.Click += new System.EventHandler(this.ImgaeFromFile_Click);
            // 
            // ImageFromCamera
            // 
            this.ImageFromCamera.Location = new System.Drawing.Point(231, 12);
            this.ImageFromCamera.Name = "ImageFromCamera";
            this.ImageFromCamera.Size = new System.Drawing.Size(210, 111);
            this.ImageFromCamera.TabIndex = 1;
            this.ImageFromCamera.Text = "Camera";
            this.ImageFromCamera.UseVisualStyleBackColor = true;
            this.ImageFromCamera.Click += new System.EventHandler(this.ImageFromCamera_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 135);
            this.Controls.Add(this.ImageFromCamera);
            this.Controls.Add(this.ImgaeFromFile);
            this.Name = "Choose";
            this.Text = "choose";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImgaeFromFile;
        private System.Windows.Forms.Button ImageFromCamera;
    }
}