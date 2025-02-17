using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Socket_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bước 1: Khởi tạo thông tin
            String serverIP = "127.0.0.1";
            int serverPort = 8555;
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Bước 2: Lắng nghe và xử lý kết nối đến
            sk.Bind(ep);
            sk.Listen(100);
            while(true)
            {
                //if(sk.Available > 0)
                {
                    // Tiếp nhận dữ liệu
                    Socket skTepm = sk.Accept();
                    byte[] duLieuNhan = new byte[1024];
                    int dem = skTepm.Receive(duLieuNhan);
                    if(dem > 0)
                    {
                        // Xử lý dữ liệu nhận
                        String tinNhanNhan = Encoding.UTF8.GetString(duLieuNhan, 0, dem);
                        String nguoiGui = tinNhanNhan.Split('#')[0];
                        String nguoiNhan = tinNhanNhan.Split('#')[1];
                        String tinNhan = tinNhanNhan.Split('#')[2];
                        Console.WriteLine(DateTime.Now.ToString() + ": " + tinNhanNhan);

                        // Lưu trữ dữ liệu trong CSDL
                        String query = "Insert Into tbTinNhanSocket(NguoiGui, NguoiNhan, TinNhan, ThoiGianGui, TrangThai) values(N'"
                            + nguoiGui + "',N'" + nguoiNhan + "',N'" + tinNhan + "',N'" + DateTime.Now.ToString() + "',N'Đã gửi')";
                        DBSupport db = new DBSupport();
                        int count = db.Ghi(query);
                    }

                    // Phản hồi lại máy khách
                    String tinNhanGui = "Đã nhận " + dem + " bytes";
                    byte[] duLieuGui = Encoding.UTF8.GetBytes(tinNhanGui);
                    skTepm.Send(duLieuGui);

                    // Giải phóng bộ nhớ
                    skTepm.Dispose();
                }    
            }    
        }
    }
}
