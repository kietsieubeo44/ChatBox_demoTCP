﻿namespace Server
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
            this.btn_Gui = new System.Windows.Forms.Button();
            this.txt_Gui = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_HienThiChatServer
            // 
            this.txt_HienThiChatServer.Location = new System.Drawing.Point(34, 12);
            this.txt_HienThiChatServer.Multiline = true;
            this.txt_HienThiChatServer.Name = "txt_HienThiChatServer";
            this.txt_HienThiChatServer.Size = new System.Drawing.Size(474, 305);
            this.txt_HienThiChatServer.TabIndex = 0;
    
            // 
            // btn_KhoiDong
            // 
            this.btn_KhoiDong.Location = new System.Drawing.Point(203, 345);
            this.btn_KhoiDong.Name = "btn_KhoiDong";
            this.btn_KhoiDong.Size = new System.Drawing.Size(145, 45);
            this.btn_KhoiDong.TabIndex = 1;
            this.btn_KhoiDong.Text = "khởi động";
            this.btn_KhoiDong.UseVisualStyleBackColor = true;
            this.btn_KhoiDong.Click += new System.EventHandler(this.btn_KhoiDong_Click);
            // 
            // btn_Gui
            // 
            this.btn_Gui.Location = new System.Drawing.Point(361, 407);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(146, 60);
            this.btn_Gui.TabIndex = 2;
            this.btn_Gui.Text = "Gửi";
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // txt_Gui
            // 
            this.txt_Gui.Location = new System.Drawing.Point(34, 407);
            this.txt_Gui.Multiline = true;
            this.txt_Gui.Name = "txt_Gui";
            this.txt_Gui.Size = new System.Drawing.Size(314, 60);
            this.txt_Gui.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 503);
            this.Controls.Add(this.txt_Gui);
            this.Controls.Add(this.btn_Gui);
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
        private System.Windows.Forms.Button btn_Gui;
        private System.Windows.Forms.TextBox txt_Gui;
    }
}

