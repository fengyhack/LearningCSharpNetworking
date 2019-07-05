using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TalkatServer
{
    class ServerConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("正在启动... ");
            IPAddress ip = new IPAddress(new byte[] { 127, 0, 0, 1 });
            //获得 IPAddress对象的另外几种常用方法：
            //IPAddress ip = IPAddress.Parse( "127.0.0.1");
            //IPAddress ip = Dns.GetHostEntry( "localhost").AddressList[0];

            TcpListener listener = new TcpListener(ip, 8500);
            listener.Start();   // 开始侦听
            Console.WriteLine("开始侦听...");

            while (true)
            {
                // 获取一个连接，同步方法
                TcpClient remoteClient = listener.AcceptTcpClient();
                // 打印连接到的客户端信息
                Console.WriteLine("客户端已连接:{0} <-- {1}",
                    remoteClient.Client.LocalEndPoint, remoteClient.Client.RemoteEndPoint);

                const int BufferSize = 4096;
                // 获得流，并写入buffer中
                NetworkStream streamToClient = remoteClient.GetStream();
                byte[] buffer = new byte[BufferSize];
                int bytesRead = streamToClient.Read(buffer, 0, BufferSize);
                Console.WriteLine("Reading data, {0} bytes ...", bytesRead);
                // 获得请求的字符串
                string msg = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received: {0}", msg);
            }

            Console.WriteLine("\n输入\"Q\"键退出");
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Q);
        }
    }
}
