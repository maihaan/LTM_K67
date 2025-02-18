using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            String tinNhan = tbTinNhan.Text;
            if(tinNhan.Equals(":D"))
            {
                Clipboard.SetImage(Image.FromFile("D:\\cart45.png"));
                rtbLichSu.Paste();
            }    
        }
    }
}
