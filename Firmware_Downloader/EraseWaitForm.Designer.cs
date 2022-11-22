
namespace Firmware_Downloader
{
    partial class EraseWaitForm
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
            this.lbl_wait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_wait
            // 
            this.lbl_wait.AutoSize = true;
            this.lbl_wait.Location = new System.Drawing.Point(87, 35);
            this.lbl_wait.Name = "lbl_wait";
            this.lbl_wait.Size = new System.Drawing.Size(33, 12);
            this.lbl_wait.TabIndex = 0;
            this.lbl_wait.Text = "none";
            // 
            // EraseWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 88);
            this.Controls.Add(this.lbl_wait);
            this.Name = "EraseWaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EraseWaitForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EraseWaitForm_FormClosing);
            this.Load += new System.EventHandler(this.EraseWaitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_wait;
    }
}