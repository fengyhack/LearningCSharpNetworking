using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TalkatClient
{
    class ClientConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("正在运行...");
            TcpClient client = null;
            const int COUNT = 5;
            for (int i = 0; i < COUNT; i++)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect("localhost", 8500);   // 与服务器连接
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                // 打印连接到的服务端信息
                Console.WriteLine("连接成功: {0} --> {1}", client.Client.LocalEndPoint, client.Client.RemoteEndPoint);

                string msg = string.Format("[ID_{0}]\"Hello World, this is a simple demo.\"",i+1);
                NetworkStream streamToServer = client.GetStream();
                byte[] buffer = Encoding.Unicode.GetBytes(msg);   // 获得缓存
                streamToServer.Write(buffer, 0, buffer.Length);   // 发往服务器
                Console.WriteLine(msg);
            }

            // 按 Q退出
            Console.WriteLine("\n输入\"Q\"键退出");
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Q);
        }
    }
}
