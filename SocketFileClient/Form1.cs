using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SocketFileClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }    
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            // B1: Kiểm tra dữ liệu đầu vào
            if (tbDuongDan.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tệp tin cần gửi");
                btTim.Focus();
                return;
            }
            if(!File.Exists(tbDuongDan.Text))
            {
                MessageBox.Show("Không tìm thấy tệp tin");
                btTim.Focus();
                return;
            }

            // B2: Đọc tệp tin vào mảng byte
            try
            {
                byte[] noiDungTep = File.ReadAllBytes(tbDuongDan.Text);

                // B3: Kết nối máy chủ
                String serverIP = "127.0.0.1";
                int serverPort = 8500;
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
                Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sk.Connect(serverEndPoint);
                if(!sk.Connected)
                {
                    MessageBox.Show("Không thể kết nối đến máy chủ. Hãy kiểm tra đường truyền mạng và thử lại");
                    return;
                }

                // B4: Gửi tệp tin: duLieuGui = Do dai ten tep + Ten tep + Noi dung tep
                byte[] duLieuGui = new byte[noiDungTep.Length + 257];
                String tenTep = Path.GetFileName(tbDuongDan.Text);
                duLieuGui[0] = (byte)tenTep.Length;
                byte[] byteTenTep = Encoding.UTF8.GetBytes(tenTep);
                for(int i = 0; i < byteTenTep.Length; i++)
                {
                    duLieuGui[i + 1] = byteTenTep[i];
                }    
                for(int i = 0; i < noiDungTep.Length; i++)
                {
                    duLieuGui[i + 257] = noiDungTep[i];
                }
                sk.Send(duLieuGui);

                // B5: Nhận phản hồi từ máy chủ
                byte[] duLieuNhan = new byte[1024];
                int dem = sk.Receive(duLieuNhan);

                // B6: Hiển thị thông tin gửi nhận
                tbLichSu.Text += "\r\n(" + DateTime.Now.ToString() + ")--> Gửi tệp: " + tenTep;
                tbLichSu.Text += "\r\n<-- Server: " + Encoding.UTF8.GetString(duLieuNhan);

                // B6: Ngắt kết nối
                sk.Disconnect(false);
            }
            catch
            {
                MessageBox.Show("Không thể đọc nội dung tệp tin do tệp tin đang được sử dụng bởi chương trình khác. Hãy kiểm tra và thử lại");
                return;
            }
            
        }
    }
}
