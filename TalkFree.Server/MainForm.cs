using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace SharpSocket.TalkFree.Server
{
    public partial class MainForm : Form
    {
        private string strSrvIP = "";
        private int  nSrvPort = 0;
        private List<string> listStrClient = new List<string>();
        private string strEventLog = "";

        public MainForm()
        {
            InitializeComponent();
            strSrvIP = GetServerNetIP();
            nSrvPort = GetRandAvailablePort();
            textBox_HostIP.Text = strSrvIP;
            textBox_HostPort.Text = nSrvPort.ToString();

            string[] ss = GetLocalHostIP();
            foreach(string s in ss)
            {
                listBox_LocalHostIP.Items.Add(s);
            }

            PrintCurrentTime();
            richTextBoxEventLog.Text += "Host Configuration Initialized. (INT)\n";
            ScrollToTheLastLine();
        }

        public static string[] GetLocalHostIP()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] ipAddrs = Dns.GetHostAddresses(hostName);
            int count=ipAddrs.Length;
            string[] ss=new string[count];
            for(int i=0;i<count;++i)
            {
                ss[i]=ipAddrs[i].ToString();
            }

            return ss;
        }

        public static string GetServerNetIP()
        {
            Uri uri = new Uri("http://www.ikaka.com/ip/index.asp");
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = 0;
            req.CookieContainer = new CookieContainer();
            req.GetRequestStream().Write(new byte[0], 0, 0);
            System.Net.HttpWebResponse res = (HttpWebResponse)(req.GetResponse());
            StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding("GB2312"));
            string srcText = sr.ReadToEnd();
            sr.Close();
            req.Abort();
            res.Close();
            Match m = Regex.Match(srcText, @"[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}");
            return m.ToString();
        }

        public static int GetRandAvailablePort()
        {
            const int MIN_PORT_N = 1250;
            const int MAX_PORT_N = 8000;
            int MID = (MIN_PORT_N + 9 * MAX_PORT_N) / 10;
            Random rand = new Random();
            int start_port = rand.Next(MIN_PORT_N, MID);
            for (int i = start_port; i <= MAX_PORT_N; i++)
            {
                if (PortIsAvailable(i)) return i;
            }

            return -1;
        }

        public static List<int> PortIsUsed()
        {
            //获取本地计算机的网络连接和通信统计数据的信息
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();

            //返回本地计算机上的所有Tcp监听程序
            IPEndPoint[] ipsTCP = ipGlobalProperties.GetActiveTcpListeners();

            //返回本地计算机上的所有UDP监听程序
            IPEndPoint[] ipsUDP = ipGlobalProperties.GetActiveUdpListeners();

            //返回本地计算机上的Internet协议版本4(IPV4 传输控制协议(TCP)连接的信息。
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            List<int> allPorts = new List<int>();
            foreach (IPEndPoint ep in ipsTCP) allPorts.Add(ep.Port);
            foreach (IPEndPoint ep in ipsUDP) allPorts.Add(ep.Port);
            foreach (TcpConnectionInformation conn in tcpConnInfoArray) allPorts.Add(conn.LocalEndPoint.Port);

            return allPorts;
        }

        public static bool PortIsAvailable(int port)
        {
            bool isAvailable = true;

            List<int> portUsed = PortIsUsed();

            foreach (int p in portUsed)
            {
                if (p == port)
                {
                    isAvailable = false; 
                    break;
                }
            }

            return isAvailable;
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            PrintCurrentTime();
            richTextBoxEventLog.Text += string.Format("Start Server //{0}:{1}\n", strSrvIP, nSrvPort);
            ScrollToTheLastLine();
        }

        private void btnRndHostPort_Click(object sender, EventArgs e)
        {
            nSrvPort = GetRandAvailablePort();
            textBox_HostPort.Text = nSrvPort.ToString();
            PrintCurrentTime();
            richTextBoxEventLog.Text += "Server PortNumber Updated --> " + nSrvPort.ToString() + "\n";
            ScrollToTheLastLine();
        }

        private void ScrollToTheLastLine()
        {
            richTextBoxEventLog.SelectionStart = richTextBoxEventLog.Text.Length;
            richTextBoxEventLog.ScrollToCaret();
        }

        private void PrintCurrentTime()
        {
            richTextBoxEventLog.Text += "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff") + "] ";
        }

        private void listBox_LocalHostIP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            strSrvIP = listBox_LocalHostIP.SelectedItem as string;
            textBox_HostIP.Text = strSrvIP;
            PrintCurrentTime();
            richTextBoxEventLog.Text += "Server IP Updated --> " + strSrvIP + " (LAN)\n";
            ScrollToTheLastLine();
        }

        private void btnNetIP_Click(object sender, EventArgs e)
        {
            strSrvIP = GetServerNetIP();
            textBox_HostIP.Text = strSrvIP;
            PrintCurrentTime();
            richTextBoxEventLog.Text += "Server IP Updated --> " + strSrvIP + " (INT)\n";
            ScrollToTheLastLine();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            PrintCurrentTime();
            richTextBoxEventLog.Text += "Server Stopped\n";
            ScrollToTheLastLine();
        }
    }
}
