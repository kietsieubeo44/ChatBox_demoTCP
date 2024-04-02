using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        private Socket clientSocket;
        private byte[] buffer = new byte[1024];

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 8888);
                MessageBox.Show("Đã Kết nối với server.");
                StartReceiving();
            }
            catch (Exception ex)
            {
                MessageBox.Show("không thể kết nối  server: " + ex.Message);
            }
        }

        private void StartReceiving()
        {
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
            if (txt_Nhan.InvokeRequired)
            {
                txt_Nhan.Invoke(new MethodInvoker(delegate { SetText(text); }));
            }
            else
            {
                txt_Nhan.Text = text;
            }
        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(txt_Gui.Text);
                clientSocket.Send(data);
                txt_Gui.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }
    }
}
