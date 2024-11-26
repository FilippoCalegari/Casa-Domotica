using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Proprietari_di_casa__Client_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static void StartClient(string oggetto)
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                string data = "";
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                // Create a TCP/IP  socket.  
                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                Random stringa_casuale = new Random();
                string stringa_da_inviare = "";

                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes($"{oggetto}");

                    // Send the data through the socket.  
                    int bytesSent = sender.Send(msg);

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void lb_appTitle_Click(object sender, EventArgs e)
        {

        }
        private void btn_lights_Click(object sender, EventArgs e)
        {
            string lights = "Lights";
            StartClient(lights);
        }

        private void btn_TV_Click(object sender, EventArgs e)
        {
            string TV = "TV";
            StartClient(TV);
        }

        private void btn_watering_Click(object sender, EventArgs e)
        {
            string watering = "Water";
            StartClient(watering);
        }

        private void btn_entrances_Click(object sender, EventArgs e)
        {
            string door = "Door";
            StartClient(door);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = $"Login;{tb_insertName.Text};{tb_insertPassword.Text}";
            StartClient(login);
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            string signUp = $"SignUp;{tb_insertName.Text};{tb_insertPassword.Text}";
            StartClient(signUp);
        }
    }
}