namespace WindowsCasino
{
    partial class CFlashController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFlashController));
            this.resultTxt = new System.Windows.Forms.Label();
            this.outTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTxt
            // 
            this.resultTxt.AutoSize = true;
            this.resultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxt.Location = new System.Drawing.Point(939, 15);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultTxt.Size = new System.Drawing.Size(19, 13);
            this.resultTxt.TabIndex = 1;
            this.resultTxt.Text = "...";
            // 
            // outTxt
            // 
            this.outTxt.Location = new System.Drawing.Point(12, 12);
            this.outTxt.Name = "outTxt";
            this.outTxt.Size = new System.Drawing.Size(193, 20);
            this.outTxt.TabIndex = 2;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(212, 10);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(108, 23);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send to flash";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recived from flash:";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(339, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(475, 100);
            this.player.TabIndex = 0;
            this.player.FlashCall += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEventHandler(this.player_FlashCall);
            // 
            // CFlashController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.outTxt);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.player);
            this.MinimizeBox = false;
            this.Name = "CFlashController";
            this.Text = "CFlashController";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash player;
        private System.Windows.Forms.Label resultTxt;
        private System.Windows.Forms.TextBox outTxt;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
    }
}

