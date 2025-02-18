
namespace UDPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbLichSu = new System.Windows.Forms.TextBox();
            this.tbTinNhan = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLichSu
            // 
            this.tbLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLichSu.Location = new System.Drawing.Point(12, 12);
            this.tbLichSu.Multiline = true;
            this.tbLichSu.Name = "tbLichSu";
            this.tbLichSu.ReadOnly = true;
            this.tbLichSu.Size = new System.Drawing.Size(325, 368);
            this.tbLichSu.TabIndex = 100;
            // 
            // tbTinNhan
            // 
            this.tbTinNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTinNhan.Location = new System.Drawing.Point(12, 386);
            this.tbTinNhan.Multiline = true;
            this.tbTinNhan.Name = "tbTinNhan";
            this.tbTinNhan.Size = new System.Drawing.Size(253, 52);
            this.tbTinNhan.TabIndex = 0;
            this.tbTinNhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTinNhan_KeyDown);
            // 
            // btGui
            // 
            this.btGui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btGui.Image = global::UDPClient.Properties.Resources.next30;
            this.btGui.Location = new System.Drawing.Point(271, 386);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(66, 52);
            this.btGui.TabIndex = 1;
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.tbTinNhan);
            this.Controls.Add(this.tbLichSu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(365, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLichSu;
        private System.Windows.Forms.TextBox tbTinNhan;
        private System.Windows.Forms.Button btGui;
    }
}

