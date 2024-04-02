namespace client
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
            this.btn_Gui = new System.Windows.Forms.Button();
            this.btn_KetNoi = new System.Windows.Forms.Button();
            this.txt_Nhan = new System.Windows.Forms.TextBox();
            this.txt_Gui = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Gui
            // 
            this.btn_Gui.Location = new System.Drawing.Point(305, 432);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(134, 52);
            this.btn_Gui.TabIndex = 0;
            this.btn_Gui.Text = "Gửi";
            this.btn_Gui.UseVisualStyleBackColor = true;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // btn_KetNoi
            // 
            this.btn_KetNoi.Location = new System.Drawing.Point(174, 344);
            this.btn_KetNoi.Name = "btn_KetNoi";
            this.btn_KetNoi.Size = new System.Drawing.Size(108, 52);
            this.btn_KetNoi.TabIndex = 1;
            this.btn_KetNoi.Text = "Kết Nối";
            this.btn_KetNoi.UseVisualStyleBackColor = true;
            this.btn_KetNoi.Click += new System.EventHandler(this.btn_KetNoi_Click);
            // 
            // txt_Nhan
            // 
            this.txt_Nhan.Location = new System.Drawing.Point(22, 15);
            this.txt_Nhan.Multiline = true;
            this.txt_Nhan.Name = "txt_Nhan";
            this.txt_Nhan.Size = new System.Drawing.Size(417, 323);
            this.txt_Nhan.TabIndex = 2;
            // 
            // txt_Gui
            // 
            this.txt_Gui.Location = new System.Drawing.Point(22, 402);
            this.txt_Gui.Multiline = true;
            this.txt_Gui.Name = "txt_Gui";
            this.txt_Gui.Size = new System.Drawing.Size(274, 81);
            this.txt_Gui.TabIndex = 3;
            this.txt_Gui.TextChanged += new System.EventHandler(this.txt_Gui_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 504);
            this.Controls.Add(this.txt_Gui);
            this.Controls.Add(this.txt_Nhan);
            this.Controls.Add(this.btn_KetNoi);
            this.Controls.Add(this.btn_Gui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Gui;
        private System.Windows.Forms.Button btn_KetNoi;
        private System.Windows.Forms.TextBox txt_Nhan;
        private System.Windows.Forms.TextBox txt_Gui;
    }
}

