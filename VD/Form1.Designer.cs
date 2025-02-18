
namespace VD
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
            this.rtbLichSu = new System.Windows.Forms.RichTextBox();
            this.tbTinNhan = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbLichSu
            // 
            this.rtbLichSu.Location = new System.Drawing.Point(13, 13);
            this.rtbLichSu.Name = "rtbLichSu";
            this.rtbLichSu.Size = new System.Drawing.Size(371, 309);
            this.rtbLichSu.TabIndex = 0;
            this.rtbLichSu.Text = "";
            // 
            // tbTinNhan
            // 
            this.tbTinNhan.Location = new System.Drawing.Point(13, 329);
            this.tbTinNhan.Multiline = true;
            this.tbTinNhan.Name = "tbTinNhan";
            this.tbTinNhan.Size = new System.Drawing.Size(298, 60);
            this.tbTinNhan.TabIndex = 1;
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(318, 329);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(66, 60);
            this.btGui.TabIndex = 2;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 403);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.tbTinNhan);
            this.Controls.Add(this.rtbLichSu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLichSu;
        private System.Windows.Forms.TextBox tbTinNhan;
        private System.Windows.Forms.Button btGui;
    }
}

