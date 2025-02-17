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

namespace Socket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            // Bước 1: Khởi tạo thông tin
            String serverIP = "127.0.0.1";
            int serverPort = 8555;
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bước 2: Chuyển đổi dữ liệu trước khi gửi
            String nguoiGui = cbNguoiGui.Text;
            String nguoiNhan = cbNguoiNhan.Text;
            String tinNhan = tbTinNhan.Text;
            String noiDungGui = nguoiGui + "#" + nguoiNhan + "#" + tinNhan;
            byte[] duLieu = Encoding.UTF8.GetBytes(noiDungGui);

            // Bước 3: Kết nối đến máy chủ
            sk.Connect(ep);
            if(!sk.Connected)
            {
                MessageBox.Show("Không thể kết nối đến máy chủ. Kiểm tra kết nối mạng");
                return;
            }

            // Bước 4: Gửi dữ liệu
            int demGui = sk.Send(duLieu);

            // Bước 5: Tiếp nhận phản hồi từ máy chủ
            byte[] duLieuNhan = new byte[1024];
            int dem = sk.Receive(duLieuNhan);
            String tinNhanDuoc = Encoding.UTF8.GetString(duLieuNhan, 0, dem);
            
            tbLichSu.Text += DateTime.Now.ToString() + "\r\nBạn: " + tbTinNhan.Text;
            tbLichSu.Text += "\r\nMáy chủ: " + tinNhanDuoc;
            tbTinNhan.Text = "";
            tbTinNhan.Focus();

            // Bước 6: Ngắt kết nối
            sk.Disconnect(false);
        }
    }
}
