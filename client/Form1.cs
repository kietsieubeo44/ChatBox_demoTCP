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
                clientSocket.Connect(IPAddress.Parse("172.21.144.1"), 8888);
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
            if (bytesRead > 0)
            {
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                // Display received data
                SetText(receivedData);
            }

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
                if (text.StartsWith("server:"))
                {
                    txt_Nhan.AppendText(text.Substring(8) + Environment.NewLine);
                }
                else
                {
                    txt_Nhan.AppendText(text + Environment.NewLine);
                }
            }
        }


        private void btn_Gui_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes("s: " + txt_Gui.Text);
                clientSocket.Send(data);
                txt_Gui.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
            }
        }


        private void txt_Gui_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
