using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;


class MyTcpListener
{
    static void Main(string[] args)
    {
        TcpListener server = null;
        try
        {
            IPAddress locAddr = IPAddress.Parse("127.0.0.1");
            Int32 port = 8888;

            server = new TcpListener(locAddr, port);

            server.Start();

            byte[] bytes = new byte[256];
            string data = null;

            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");
                data = null;

                NetworkStream stream = client.GetStream();
                int len = 0;

                while (true)
                {
                    len = stream.Read(bytes, 0, bytes.Length);
                    if (len == 0) break;
                    data = Encoding.ASCII.GetString(bytes, 0, len);
                    Console.WriteLine("Recieved: {0}", data);

                    data = data.ToUpper();
                    byte[] msg = Encoding.ASCII.GetBytes(data);
                    stream.Write(msg, 0, msg.Length);
                    Console.WriteLine("Sent: {0}", data);
                }
                client.Close();
            }
        }
        catch (SocketException ex)
        {
            Console.WriteLine("SocketException: {0}", ex);
        }
        finally
        {
            server.Stop();
        }

        Console.WriteLine("\nHit enter to continue...");
        Console.Read();
    }
}
