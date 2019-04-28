namespace WinCasino
{
    partial class Games
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
            this.Machine1Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Machine1Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Machine1Icon
            // 
            this.Machine1Icon.Image = global::WinCasino.Properties.Resources._8139VOJ5uJL;
            this.Machine1Icon.Location = new System.Drawing.Point(140, 104);
            this.Machine1Icon.Name = "Machine1Icon";
            this.Machine1Icon.Size = new System.Drawing.Size(100, 93);
            this.Machine1Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Machine1Icon.TabIndex = 0;
            this.Machine1Icon.TabStop = false;
            this.Machine1Icon.Click += new System.EventHandler(this.Machine1Icon_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(573, 298);
            this.Controls.Add(this.Machine1Icon);
            this.Name = "Games";
            this.Text = "Games";
            ((System.ComponentModel.ISupportInitialize)(this.Machine1Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Machine1Icon;


    }
}