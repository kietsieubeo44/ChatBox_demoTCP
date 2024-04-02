namespace Server
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
            this.txt_HienThiChatServer = new System.Windows.Forms.TextBox();
            this.btn_KhoiDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_HienThiChatServer
            // 
            this.txt_HienThiChatServer.Location = new System.Drawing.Point(34, 12);
            this.txt_HienThiChatServer.Multiline = true;
            this.txt_HienThiChatServer.Name = "txt_HienThiChatServer";
            this.txt_HienThiChatServer.Size = new System.Drawing.Size(481, 397);
            this.txt_HienThiChatServer.TabIndex = 0;
            // 
            // btn_KhoiDong
            // 
            this.btn_KhoiDong.Location = new System.Drawing.Point(191, 427);
            this.btn_KhoiDong.Name = "btn_KhoiDong";
            this.btn_KhoiDong.Size = new System.Drawing.Size(145, 45);
            this.btn_KhoiDong.TabIndex = 1;
            this.btn_KhoiDong.Text = "khởi động";
            this.btn_KhoiDong.UseVisualStyleBackColor = true;
            this.btn_KhoiDong.Click += new System.EventHandler(this.btn_KhoiDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 503);
            this.Controls.Add(this.btn_KhoiDong);
            this.Controls.Add(this.txt_HienThiChatServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HienThiChatServer;
        private System.Windows.Forms.Button btn_KhoiDong;
    }
}

