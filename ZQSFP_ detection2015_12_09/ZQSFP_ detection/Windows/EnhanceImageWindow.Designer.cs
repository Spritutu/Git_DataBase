namespace ZQSFP_detection
{
    partial class EnhanceImageWindow
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
            this.CoherenceEnhancingDiff_button = new System.Windows.Forms.Button();
            this.Emphasize_button = new System.Windows.Forms.Button();
            this.EquHistoImage_button = new System.Windows.Forms.Button();
            this.Illuminate_button = new System.Windows.Forms.Button();
            this.ScaleImageMax_button = new System.Windows.Forms.Button();
            this.ShockFilter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoherenceEnhancingDiff_button
            // 
            this.CoherenceEnhancingDiff_button.Location = new System.Drawing.Point(12, 12);
            this.CoherenceEnhancingDiff_button.Name = "CoherenceEnhancingDiff_button";
            this.CoherenceEnhancingDiff_button.Size = new System.Drawing.Size(179, 23);
            this.CoherenceEnhancingDiff_button.TabIndex = 0;
            this.CoherenceEnhancingDiff_button.Text = "CoherenceEnhancingDiff";
            this.CoherenceEnhancingDiff_button.UseVisualStyleBackColor = true;
            this.CoherenceEnhancingDiff_button.Click += new System.EventHandler(this.CoherenceEnhancingDiff_button_Click);
            // 
            // Emphasize_button
            // 
            this.Emphasize_button.Location = new System.Drawing.Point(12, 41);
            this.Emphasize_button.Name = "Emphasize_button";
            this.Emphasize_button.Size = new System.Drawing.Size(179, 23);
            this.Emphasize_button.TabIndex = 1;
            this.Emphasize_button.Text = "Emphasize";
            this.Emphasize_button.UseVisualStyleBackColor = true;
            this.Emphasize_button.Click += new System.EventHandler(this.Emphasize_button_Click);
            // 
            // EquHistoImage_button
            // 
            this.EquHistoImage_button.Location = new System.Drawing.Point(12, 70);
            this.EquHistoImage_button.Name = "EquHistoImage_button";
            this.EquHistoImage_button.Size = new System.Drawing.Size(179, 23);
            this.EquHistoImage_button.TabIndex = 2;
            this.EquHistoImage_button.Text = "EquHistoImage";
            this.EquHistoImage_button.UseVisualStyleBackColor = true;
            this.EquHistoImage_button.Click += new System.EventHandler(this.EquHistoImage_button_Click);
            // 
            // Illuminate_button
            // 
            this.Illuminate_button.Location = new System.Drawing.Point(12, 99);
            this.Illuminate_button.Name = "Illuminate_button";
            this.Illuminate_button.Size = new System.Drawing.Size(179, 23);
            this.Illuminate_button.TabIndex = 3;
            this.Illuminate_button.Text = "Illuminate";
            this.Illuminate_button.UseVisualStyleBackColor = true;
            this.Illuminate_button.Click += new System.EventHandler(this.Illuminate_button_Click);
            // 
            // ScaleImageMax_button
            // 
            this.ScaleImageMax_button.Location = new System.Drawing.Point(12, 128);
            this.ScaleImageMax_button.Name = "ScaleImageMax_button";
            this.ScaleImageMax_button.Size = new System.Drawing.Size(179, 23);
            this.ScaleImageMax_button.TabIndex = 4;
            this.ScaleImageMax_button.Text = "ScaleImageMax";
            this.ScaleImageMax_button.UseVisualStyleBackColor = true;
            this.ScaleImageMax_button.Click += new System.EventHandler(this.ScaleImageMax_button_Click);
            // 
            // ShockFilter_button
            // 
            this.ShockFilter_button.Location = new System.Drawing.Point(12, 157);
            this.ShockFilter_button.Name = "ShockFilter_button";
            this.ShockFilter_button.Size = new System.Drawing.Size(179, 23);
            this.ShockFilter_button.TabIndex = 5;
            this.ShockFilter_button.Text = "ShockFilter";
            this.ShockFilter_button.UseVisualStyleBackColor = true;
            this.ShockFilter_button.Click += new System.EventHandler(this.ShockFilter_button_Click);
            // 
            // EnhanceImageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 195);
            this.Controls.Add(this.ShockFilter_button);
            this.Controls.Add(this.ScaleImageMax_button);
            this.Controls.Add(this.Illuminate_button);
            this.Controls.Add(this.EquHistoImage_button);
            this.Controls.Add(this.Emphasize_button);
            this.Controls.Add(this.CoherenceEnhancingDiff_button);
            this.Name = "EnhanceImageWindow";
            this.Text = "EnhanceImageWinow";
            this.Load += new System.EventHandler(this.EnhanceImageWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CoherenceEnhancingDiff_button;
        private System.Windows.Forms.Button Emphasize_button;
        private System.Windows.Forms.Button EquHistoImage_button;
        private System.Windows.Forms.Button Illuminate_button;
        private System.Windows.Forms.Button ScaleImageMax_button;
        private System.Windows.Forms.Button ShockFilter_button;
    }
}