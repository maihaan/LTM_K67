using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;

namespace SocketFileServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // B1: Chuẩn bị thông tin
            String serverIP = "127.0.0.1";
            int serverPort = 8500;
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sk.Bind(serverEndPoint);

            // B2: Lắng nghe, tiếp nhận và xử lý dữ liệu
            sk.Listen(100);
            while(true)
            {
                // Nếu có kết nối đến thì tiếp nhận và xử lý dữ liệu
                Socket t = sk.Accept();
                byte[] boDem = new byte[1024];
                List<byte> duLieuNhan = new List<byte>();
                int demNhan = 1;
                while (demNhan > 0)
                {
                    demNhan = t.Receive(boDem);
                    // Chuyển dữ liệu nhận được vào duLieuNhan
                    if (demNhan > 0)
                        for (int i = 0; i < demNhan; i++)
                            duLieuNhan.Add(boDem[i]);
                    else
                        break;
                }

                if (duLieuNhan.Count > 0)
                {
                    // Xử lý dữ liệu: duLieuNhan = Độ dài tên tệp + Tên tệp + Nội dung tệp
                    int doDaiTen = duLieuNhan[0];
                    byte[] byteTenTep = new byte[doDaiTen];
                    for (int i = 0; i < doDaiTen; i++)
                        byteTenTep[i] = duLieuNhan[i + 1];
                    String tenTep = Encoding.UTF8.GetString(byteTenTep);
                    byte[] noiDungTep = new byte[duLieuNhan.Count - 257];
                    for (int i = 0; i < noiDungTep.Length; i++)
                        noiDungTep[i] = duLieuNhan[i + 257];

                    // Lưu trữ tệp tin nhận được
                    File.WriteAllBytes("D:\\ServerFiles\\" + tenTep, noiDungTep);

                    // Gửi phản hồi cho máy khách
                    String phanHoi = "Đã nhận " + duLieuNhan.Count.ToString() + " bytes";
                    t.Send(Encoding.UTF8.GetBytes(phanHoi));

                    // Hiển thị thông tin để theo dõi
                    Console.WriteLine("(" + DateTime.Now.ToString() + ") Da nhan tep: "
                        + tenTep + " (" + noiDungTep.Length + " bytes)");
                }
                // Giải phóng socket nhận dữ liệu
                t.Dispose();

            }    
        }
    }
}
