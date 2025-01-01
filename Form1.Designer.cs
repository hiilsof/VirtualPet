
namespace VirtualPet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.petPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // petPictureBox
            // 
            this.petPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.petPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.petPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("petPictureBox.Image")));
            this.petPictureBox.Location = new System.Drawing.Point(12, 12);
            this.petPictureBox.Name = "petPictureBox";
            this.petPictureBox.Size = new System.Drawing.Size(100, 100);
            this.petPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.petPictureBox.TabIndex = 0;
            this.petPictureBox.TabStop = false;
            this.petPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.petPictureBox_MouseDown);
            this.petPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.petPictureBox_MouseMove);
            this.petPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.petPictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(127, 129);
            this.Controls.Add(this.petPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.petPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox petPictureBox;
    }
}

