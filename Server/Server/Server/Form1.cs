using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private Socket serverSocket;
        private Socket clientSocket;
        private byte[] buffer = new byte[1024];
        private StringBuilder stringBuilder = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StartServer()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 8888));
            serverSocket.Listen(5);
            serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);

            MessageBox.Show("Server đã khởi động. Lắng nghe kết nối ...");
        }

        private void AcceptCallback(IAsyncResult ia)
        {
            clientSocket = serverSocket.EndAccept(ia);
            buffer = new byte[1024];
            clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ia)
        {
            int bytesRead = clientSocket.EndReceive(ia);
            string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            // Display received data
            SetText(receivedData);

            // Continue listening for more data
            buffer = new byte[1024];
            clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), null);
        }

        private void SetText(string text)
        {
            if (txt_HienThiChatServer.InvokeRequired)
            {
                txt_HienThiChatServer.Invoke(new MethodInvoker(delegate { SetText(text); }));
            }
            else
            {
                stringBuilder.Append(text);
                stringBuilder.Append(Environment.NewLine);
                txt_HienThiChatServer.Text = stringBuilder.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverSocket.Close();
        }

        private void btn_KhoiDong_Click(object sender, EventArgs e)
        {
            try
            {
                StartServer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting server: " + ex.Message);
            }
        }

    }
}
