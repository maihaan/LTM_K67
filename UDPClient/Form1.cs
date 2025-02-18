using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTinNhan_KeyDown(object sender, KeyEventArgs e)
        {
            // Gui tin nhan nếu người dùng nhấn Enter
            if(e.KeyCode == Keys.Enter)
                btGui_Click(sender, e);
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            // B1: Chuẩn bị thông tin
            String serverIP = "127.0.0.1";
            int serverPort = 8555;
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
            UdpClient udp = new UdpClient();

            // B2: Chuẩn bị dữ liệu
            byte[] duLieuGui = Encoding.UTF8.GetBytes(tbTinNhan.Text);

            // B3: Gửi tin nhắn
            udp.Send(duLieuGui, duLieuGui.Length, serverEndPoint);

            // B4: Nhận phản hồi
            //byte[] duLieuNhan = udp.Receive(ref serverEndPoint);

            // B5: Hiển thị thông tin
            tbLichSu.Text += "\r\n(" + DateTime.Now.ToString() + ") " + tbTinNhan.Text;
            //tbLichSu.Text += "\r\nServer: " + Encoding.UTF8.GetString(duLieuNhan);


            tbTinNhan.Text = "";
            tbTinNhan.Focus();
        }
    }
}
