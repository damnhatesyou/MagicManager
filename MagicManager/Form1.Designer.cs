namespace MagicManager
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
            this.nameTextbox = new System.Windows.Forms.Label();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.AutoSize = true;
            this.nameTextbox.Location = new System.Drawing.Point(1227, 10);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(70, 32);
            this.nameTextbox.TabIndex = 3;
            this.nameTextbox.Text = "blah";
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.Location = new System.Drawing.Point(1133, 224);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(100, 50);
            this.cardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardPictureBox.TabIndex = 4;
            this.cardPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2513, 1275);
            this.Controls.Add(this.cardPictureBox);
            this.Controls.Add(this.nameTextbox);
            this.Name = "Form1";
            this.Text = "Magic Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameTextbox;
        private System.Windows.Forms.PictureBox cardPictureBox;
    }
}

