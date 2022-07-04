namespace Presentation
{
    partial class frmHome
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
            this.pbAreion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAreion
            // 
            this.pbAreion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAreion.Image = global::Presentation.Properties.Resources.Areion;
            this.pbAreion.Location = new System.Drawing.Point(-6, 2);
            this.pbAreion.Name = "pbAreion";
            this.pbAreion.Size = new System.Drawing.Size(330, 255);
            this.pbAreion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAreion.TabIndex = 0;
            this.pbAreion.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 389);
            this.Controls.Add(this.pbAreion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbAreion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAreion;

    }
}