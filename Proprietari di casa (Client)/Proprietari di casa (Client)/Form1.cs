using System;
using System.Data.SqlTypes;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
            ServerListener();
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
        public static void SendMessage(string oggetto)
        {
            byte[] msg = Encoding.ASCII.GetBytes(oggetto);
            sender.Send(msg);
        }
        public void ServerListener()
        {
            Thread listeningThread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        // Ricevi il messaggio dal server
                        int bytesRec = sender.Receive(bytes);
                        string data = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        // Mostra il messaggio o aggiornalo nell'interfaccia
                        this.Invoke((MethodInvoker)delegate
                        {
                            ManageMessage(data); // Puoi anche aggiornare un'etichetta o altro controllo
                        });
                    }
                    catch (SocketException ex)
                    {
                        MessageBox.Show($"Errore di connessione: {ex.Message}");
                        break;
                    }
                }
            });

            listeningThread.IsBackground = true; // Assicura che il thread si chiuda quando il form si chiude
            listeningThread.Start();
        }
        private void ManageMessage(string data)
        {
            string[] message = data.Split(';');
            string nome;

            switch (message[0])
            {
                case "Login":

                    nome = message[2];

                    if (message[1] == "RightPassword")
                    {
                        pan_loginInterface.Hide();
                        panel_App.Show();
                        this.BackgroundImage = Properties.Resources.App_iPhone_Background;
                        lb_subTitle.Text = $"Ciao {nome}\n Bentornato a casa";
                    }
                    else if (message[1] == "WrongPassword")
                    {
                        lb_loginErrors.Text = "Password errata.";
                    }
                    else if (message[1] == "SignUp")
                    {
                        lb_loginErrors.Text = "Utente non trovato: prova a registrarti.";
                    }

                    break;

                case "SignedUp":

                    nome = message[1];

                    pan_signUp.Hide();
                    this.BackgroundImage = Properties.Resources.App_iPhone_Background;
                    panel_App.Show();

                    lb_subTitle.Text = $"Ciao {nome}\n Bentornato a casa";

                    break;

                case "Bedroom":

                    btn_bedroomLights.Text = $"Camera: {message[1]}";

                    break;

                case "Livingroom":

                    btn_livingroomLights.Text = $"Salotto: {message[1]}";

                    break;

                case "Kitchen":

                    btn_kitchenLights.Text = $"Cucina: {message[1]}";

                    break;

                case "Bathroom":

                    btn_bathroomLights.Text = $"Bagno: {message[1]}";

                    break;

                case "TV":

                    btn_TV.Text = $"TV: {message[1]}";

                    break;

                case "Irrigazione":

                    btn_watering.Text = $"Irrigazione: {message[1]}";

                    break;

                case "Entrance":

                    btn_entranceDoor.Text = $"Portone: {message[1]}";

                    break;

                case "Garage":

                    btn_garageDoor.Text = $"Garage: {message[1]}";

                    break;
            }
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
            SendMessage(TV);
            //btn_TV.Text = $"TV: {controllo}";
        }

        private void btn_watering_Click(object sender, EventArgs e)
        {
            string watering = "Water";
            SendMessage(watering);

            //btn_watering.Text = $"Irrigazione: {controllo}";
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
            SendMessage(signUp);

            /*string message = registrazione.Split(';')[0];
            */
        }

        private void btn_loginToApp_Click(object sender, EventArgs e)
        {
            string login = $"Login;Nome;{tb_loginUsername.Text};{tb_loginPassword.Text}";
            SendMessage(login);
        }

        private void btn_signUpToApp_Click(object sender, EventArgs e)
        {
            pan_loginInterface.Hide();
            pan_signUp.Show();
        }

        private void btn_bedroomLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Bedroom";
            SendMessage(lights);

            //btn_bedroomLights.Text = $"Camera: {controllo}";
        }

        private void btn_kitchenLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Kitchen";
            SendMessage(lights);

            //btn_kitchenLights.Text = $"Cucina: {controllo}";
        }

        private void btn_livingroomLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Livingroom";
            SendMessage(lights);

            //btn_livingroomLights.Text = $"Salotto: {controllo}";
        }

        private void btn_bathroomLights_Click(object sender, EventArgs e)
        {
            string lights = "Lights;Bathroom";
            SendMessage(lights);

            //btn_bathroomLights.Text = $"Bagno: {controllo}";
        }

        private void btn_entranceDoor_Click(object sender, EventArgs e)
        {
            string door = "Door;Entrance";
            SendMessage(door);

            //btn_entranceDoor.Text = $"Portone: {controllo}";
        }

        private void btn_garageDoor_Click(object sender, EventArgs e)
        {
            string door = "Door;Garage";
            SendMessage(door);

            //btn_garageDoor.Text = $"Garage: {controllo}";
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
