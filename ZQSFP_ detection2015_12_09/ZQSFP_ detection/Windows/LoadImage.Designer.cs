namespace ZQSFP_detection
{
    partial class LoadImage
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
            this.Load_Image = new System.Windows.Forms.Button();
            this.Load_Camera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load_Image
            // 
            this.Load_Image.Location = new System.Drawing.Point(12, 12);
            this.Load_Image.Name = "Load_Image";
            this.Load_Image.Size = new System.Drawing.Size(201, 148);
            this.Load_Image.TabIndex = 0;
            this.Load_Image.Text = "載入圖片";
            this.Load_Image.UseVisualStyleBackColor = true;
            this.Load_Image.Click += new System.EventHandler(this.Load_Image_Click);
            // 
            // Load_Camera
            // 
            this.Load_Camera.Location = new System.Drawing.Point(219, 12);
            this.Load_Camera.Name = "Load_Camera";
            this.Load_Camera.Size = new System.Drawing.Size(201, 148);
            this.Load_Camera.TabIndex = 1;
            this.Load_Camera.Text = "載入相機";
            this.Load_Camera.UseVisualStyleBackColor = true;
            this.Load_Camera.Click += new System.EventHandler(this.Load_Camera_Click);
            // 
            // LoadImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 172);
            this.Controls.Add(this.Load_Camera);
            this.Controls.Add(this.Load_Image);
            this.Name = "LoadImage";
            this.Text = "LoadImage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_Image;
        private System.Windows.Forms.Button Load_Camera;
    }
}