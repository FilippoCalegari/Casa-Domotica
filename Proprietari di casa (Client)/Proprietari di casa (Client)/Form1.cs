using System;
using System.Net;
using System.Net.NetworkInformation;
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
            StartClient();
            pan_loginInterface.Show();
            this.BackgroundImage = Properties.Resources.Registration_iPhone_Background;
        }

        // Establish the remote endpoint for the socket.  
        // This example uses port 11000 on the local computer.  
        static IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        static IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

        // Create a TCP/IP  socket.  
        static Socket sender = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);

        // Data buffer for incoming data.  
        static byte[] bytes = new byte[1024];

        public static void StartClient()
        {

            // Connect to a remote device.  
            try
            {
                // Connect the socket to the remote endpoint. Catch any errors.  
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());
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
        public static string SendMessage(string oggetto)
        {
            byte[] msg = Encoding.ASCII.GetBytes(oggetto);
            sender.Send(msg);

            int bytesRec = sender.Receive(bytes);
            string data = Encoding.ASCII.GetString(bytes, 0, bytesRec);

            return data;
        }
        private void lb_appTitle_Click(object sender, EventArgs e)
        {

        }
        private void btn_lights_Click(object sender, EventArgs e)
        {
            btn_bathroomLights.Show();
            btn_bedroomLights.Show();
            btn_kitchenLights.Show();
            btn_livingroomLights.Show();
            btn_backToMain.Show();
        }

        private void btn_TV_Click(object sender, EventArgs e)
        {
            string TV = "TV";
            string controllo = SendMessage(TV);
            btn_TV.Text = $"TV: {controllo}";
        }

        private void btn_watering_Click(object sender, EventArgs e)
        {
            string watering = "Water";
            string controllo = SendMessage(watering);

            MessageBox.Show(controllo);
        }

        private void btn_entrances_Click(object sender, EventArgs e)
        {
            btn_entranceDoor.Show();
            btn_garageDoor.Show();
            btn_backToMain.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            pan_signUp.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string exit = $"Exit";
            SendMessage(exit);
        }

        private void pan_credInterface_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string signUp = $"SignUp;{tb_registerName.Text};{tb_registerUsername.Text};{tb_registerPassword.Text}";
            string registrazione = SendMessage(signUp);

            string message = registrazione.Split(';')[0];
            string nome = registrazione.Split(';')[1];

            if (message == "SignedUp")
            {
                pan_signUp.Hide();
                this.BackgroundImage = Properties.Resources.App_iPhone_Background;
                panel_App.Show();
                lb_subTitle.Text = $"Ciao {nome}\n Bentornato a casa";
            }
        }

        private void btn_loginToApp_Click(object sender, EventArgs e)
        {
            string login = $"Login;Nome;{tb_loginUsername.Text};{tb_loginPassword.Text}";
            string accesso = SendMessage(login);

            string message = accesso.Split(';')[0];
            string nome = accesso.Split(';')[1];

            if (message == "RightPassword")
            {
                pan_loginInterface.Hide();
                panel_App.Show();
                this.BackgroundImage = Properties.Resources.App_iPhone_Background;
                lb_subTitle.Text = $"Ciao {nome}\n Bentornato a casa";
            }
            else if (message == "WrongPassword")
            {
                lb_loginErrors.Text = "Password errata.";
            }
            else if (message == "SignUp")
            {
                lb_loginErrors.Text = "Utente non trovato: prova a registrarti.";
            }
        }

        private void btn_signUpToApp_Click(object sender, EventArgs e)
        {
            pan_loginInterface.Hide();
            pan_signUp.Show();
        }

        private void btn_bedroomLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Bedroom";
            string controllo = SendMessage(lights);

            MessageBox.Show(controllo);
        }

        private void btn_kitchenLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Kitchen";
            string controllo = SendMessage(lights);

            MessageBox.Show(controllo);
        }

        private void btn_livingroomLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Livingroom";
            string controllo = SendMessage(lights);

            MessageBox.Show(controllo);
        }

        private void btn_bathroomLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Bathroom";
            string controllo = SendMessage(lights);

            btn_bathroomLights.Text = $"Bagno: {controllo}";
        }

        private void btn_entranceDoor_Click(object sender, EventArgs e)
        {
            string door = "Door;Entrance";
            string controllo = SendMessage(door);

            MessageBox.Show(controllo);
        }

        private void btn_garageDoor_Click(object sender, EventArgs e)
        {
            string door = "Door;Garage";
            string controllo = SendMessage(door);

            MessageBox.Show(controllo);
        }

        private void btn_backToMain_Click(object sender, EventArgs e)
        {
            btn_bathroomLights.Hide();
            btn_bedroomLights.Hide();
            btn_kitchenLights.Hide();
            btn_livingroomLights.Hide();
            btn_entranceDoor.Hide();
            btn_garageDoor.Hide();
            btn_backToMain.Hide();
        }
    }
}