namespace SnippingTool_Winforms
{
    partial class MainForm
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
            this.snaphotButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // snaphotButton
            // 
            this.snaphotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.snaphotButton.Location = new System.Drawing.Point(28, 22);
            this.snaphotButton.Name = "snaphotButton";
            this.snaphotButton.Size = new System.Drawing.Size(197, 66);
            this.snaphotButton.TabIndex = 0;
            this.snaphotButton.Text = "Take a snapshot";
            this.snaphotButton.UseVisualStyleBackColor = true;
            this.snaphotButton.Click += new System.EventHandler(this.SnaphotButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(427, 180);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.snaphotButton);
            this.Name = "MainForm";
            this.Text = "SnippingTool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button snaphotButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

