
namespace Socket_Client
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
            this.tbLichSu = new System.Windows.Forms.TextBox();
            this.tbTinNhan = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.cbNguoiNhan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNguoiGui = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbLichSu
            // 
            this.tbLichSu.Location = new System.Drawing.Point(13, 98);
            this.tbLichSu.Multiline = true;
            this.tbLichSu.Name = "tbLichSu";
            this.tbLichSu.ReadOnly = true;
            this.tbLichSu.Size = new System.Drawing.Size(327, 225);
            this.tbLichSu.TabIndex = 0;
            // 
            // tbTinNhan
            // 
            this.tbTinNhan.Location = new System.Drawing.Point(13, 330);
            this.tbTinNhan.Multiline = true;
            this.tbTinNhan.Name = "tbTinNhan";
            this.tbTinNhan.Size = new System.Drawing.Size(266, 50);
            this.tbTinNhan.TabIndex = 1;
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(286, 330);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(54, 50);
            this.btGui.TabIndex = 2;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // cbNguoiNhan
            // 
            this.cbNguoiNhan.FormattingEnabled = true;
            this.cbNguoiNhan.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbNguoiNhan.Location = new System.Drawing.Point(12, 71);
            this.cbNguoiNhan.Name = "cbNguoiNhan";
            this.cbNguoiNhan.Size = new System.Drawing.Size(327, 21);
            this.cbNguoiNhan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Người nhận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Người gửi";
            // 
            // cbNguoiGui
            // 
            this.cbNguoiGui.FormattingEnabled = true;
            this.cbNguoiGui.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbNguoiGui.Location = new System.Drawing.Point(12, 28);
            this.cbNguoiGui.Name = "cbNguoiGui";
            this.cbNguoiGui.Size = new System.Drawing.Size(327, 21);
            this.cbNguoiGui.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNguoiGui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNguoiNhan);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.tbTinNhan);
            this.Controls.Add(this.tbLichSu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLichSu;
        private System.Windows.Forms.TextBox tbTinNhan;
        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.ComboBox cbNguoiNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNguoiGui;
    }
}

