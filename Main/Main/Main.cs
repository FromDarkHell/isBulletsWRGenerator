using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using SpeedrunComSharp;
namespace Main
{
    public partial class Main : Form
    {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Unspecified);
        public static string GetIPAddress()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
        public Main() {
            InitializeComponent();
        }
        public void Butt_Click(object sender, System.EventArgs e) {             // Lewd
            string localip = GetIPAddress();
            MessageBox.Show("Test");
            s.Connect(localip, 16834);
            byte[] msg = Encoding.UTF8.GetBytes("getsplitindex\\r\\n");
            byte[] buffer = new byte[1024];
            int iRx = s.Receive(buffer);
            char[] chars = new char[iRx];
            Decoder d = Encoding.UTF8.GetDecoder();
        }
    }
}
