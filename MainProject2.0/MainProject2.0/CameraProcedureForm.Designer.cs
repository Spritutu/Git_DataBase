namespace MainProject2._0
{
    partial class CameraProcedureForm
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
            this.Camerawindow2 = new System.Windows.Forms.TabControl();
            this.Camera_1 = new System.Windows.Forms.TabPage();
            this.Camera_2 = new System.Windows.Forms.TabPage();
            this.Camera_3 = new System.Windows.Forms.TabPage();
            this.Camera_4 = new System.Windows.Forms.TabPage();
            this.cameraProcedure1 = new CameraProcedure.CameraProcedure();
            this.cameraProcedure2 = new CameraProcedure.CameraProcedure();
            this.Camerawindow2.SuspendLayout();
            this.Camera_1.SuspendLayout();
            this.Camera_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Camerawindow2
            // 
            this.Camerawindow2.Controls.Add(this.Camera_1);
            this.Camerawindow2.Controls.Add(this.Camera_2);
            this.Camerawindow2.Controls.Add(this.Camera_3);
            this.Camerawindow2.Controls.Add(this.Camera_4);
            this.Camerawindow2.Location = new System.Drawing.Point(12, 12);
            this.Camerawindow2.Name = "Camerawindow2";
            this.Camerawindow2.SelectedIndex = 0;
            this.Camerawindow2.Size = new System.Drawing.Size(1575, 760);
            this.Camerawindow2.TabIndex = 17;
            // 
            // Camera_1
            // 
            this.Camera_1.Controls.Add(this.cameraProcedure1);
            this.Camera_1.Location = new System.Drawing.Point(4, 22);
            this.Camera_1.Name = "Camera_1";
            this.Camera_1.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_1.Size = new System.Drawing.Size(1567, 734);
            this.Camera_1.TabIndex = 1;
            this.Camera_1.Text = "Camera No.1";
            this.Camera_1.UseVisualStyleBackColor = true;
            // 
            // Camera_2
            // 
            this.Camera_2.Controls.Add(this.cameraProcedure2);
            this.Camera_2.Location = new System.Drawing.Point(4, 22);
            this.Camera_2.Name = "Camera_2";
            this.Camera_2.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_2.Size = new System.Drawing.Size(1567, 734);
            this.Camera_2.TabIndex = 2;
            this.Camera_2.Text = "Camera No.2";
            this.Camera_2.UseVisualStyleBackColor = true;
            // 
            // Camera_3
            // 
            this.Camera_3.Location = new System.Drawing.Point(4, 22);
            this.Camera_3.Name = "Camera_3";
            this.Camera_3.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_3.Size = new System.Drawing.Size(1567, 734);
            this.Camera_3.TabIndex = 3;
            this.Camera_3.Text = "Camera No.3";
            this.Camera_3.UseVisualStyleBackColor = true;
            // 
            // Camera_4
            // 
            this.Camera_4.Location = new System.Drawing.Point(4, 22);
            this.Camera_4.Name = "Camera_4";
            this.Camera_4.Padding = new System.Windows.Forms.Padding(3);
            this.Camera_4.Size = new System.Drawing.Size(1567, 734);
            this.Camera_4.TabIndex = 4;
            this.Camera_4.Text = "Camera No.4";
            this.Camera_4.UseVisualStyleBackColor = true;
            // 
            // cameraProcedure1
            // 
            this.cameraProcedure1.Location = new System.Drawing.Point(6, 5);
            this.cameraProcedure1.Name = "cameraProcedure1";
            this.cameraProcedure1.Size = new System.Drawing.Size(1502, 733);
            this.cameraProcedure1.TabIndex = 0;
            // 
            // cameraProcedure2
            // 
            this.cameraProcedure2.Location = new System.Drawing.Point(3, 6);
            this.cameraProcedure2.Name = "cameraProcedure2";
            this.cameraProcedure2.Size = new System.Drawing.Size(1502, 722);
            this.cameraProcedure2.TabIndex = 1;
            // 
            // CameraProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 846);
            this.Controls.Add(this.Camerawindow2);
            this.Name = "CameraProcedureForm";
            this.Text = "CameraProcedureForm";
            this.Camerawindow2.ResumeLayout(false);
            this.Camera_1.ResumeLayout(false);
            this.Camera_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Camerawindow2;
        private System.Windows.Forms.TabPage Camera_1;
        private System.Windows.Forms.TabPage Camera_2;
        private System.Windows.Forms.TabPage Camera_3;
        private System.Windows.Forms.TabPage Camera_4;
        private CameraProcedure.CameraProcedure cameraProcedure1;
        private CameraProcedure.CameraProcedure cameraProcedure2;
    }
}