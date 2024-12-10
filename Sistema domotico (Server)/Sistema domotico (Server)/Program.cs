using Sistema_domotico__Server_.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

public class SynchronousSocketListener
{
    // Incoming data from the client.  
    public static string data = null;

    // Percorso file elementi
    public static string elementsPath = @"..\..\Resources\Elementi.txt";

    // Liste elementi e socket
    public static List<Elementi> ListaElementiServer = new List<Elementi>();
    public static List<Socket> AllSockets = new List<Socket>();
    public static void StartListening()
    {
        int count = 0;

        // Establish the local endpoint for the socket.  
        // host running the application.  
        IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

        // Create a TCP/IP socket.  
        Socket listener = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);

        // Bind the socket to the local endpoint and   
        // listen for incoming connections.
        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);

            // Start listening for connections.  
            while (true)
            {
                // Program is suspended while waiting for an incoming connection.  
                Socket handler = listener.Accept();
                count++;

                AllSockets.Add(handler);

                ClientManager clientThread = new ClientManager(handler, count, ref ListaElementiServer, ref AllSockets);
                Thread t = new Thread(new ThreadStart(clientThread.doClient));
                t.Start();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\nPress ENTER to continue...");
        Console.Read();

    }

    public static void LoadElements()
    {
        using (StreamReader elementsFile = new StreamReader(elementsPath))
        {
            // Trascrivo gli elementi e i valori in una lista
            foreach (string linea in File.ReadLines(elementsPath))
            {
                string line = elementsFile.ReadLine();
                ListaElementiServer.Add(new Elementi(line.Split(';')[0], int.Parse(line.Split(';')[1])));
            }
        }
    }
    public static int Main(String[] args)
    {
        LoadElements();
        StartListening();
        return 0;
    }
}
public class ClientManager
{
    Socket clientSocket;
    List<Elementi> Elementii;
    List<Socket> Sockets;
    byte[] bytes = new Byte[1024];
    String data = "";
    int count;

    public ClientManager(Socket clientSocket, int count, ref List<Elementi> elementii, ref List<Socket> sockets)
    {
        Elementii = elementii;
        Sockets = sockets;
        this.clientSocket = clientSocket;
        this.count = count;
    }
    public void doClient()
    {
        // Percorsi file
        string credentialsPath = @"..\..\Resources\Credenziali.txt";

        // Credenziali
        List<Credenziali> credentials = new List<Credenziali>();
        Credenziali credential;
        string nome;
        string username;
        string password;

        string exit;
        string messageToServer;

        do
        {
            int bytesRec = clientSocket.Receive(bytes);

            data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            string[] messaggio = data.Split(';');
            exit = messaggio[0];

            // Controllo che tipo di messaggio è arrivato dal client
            switch (messaggio[0])
            {
                case "Lights":

                    if (messaggio[1] == "Bedroom")
                    {
                        if (Elementii[0].Valore == 1) // Se accese (= 1)
                        {
                            Console.WriteLine($"Bedroom: OFF");
                            Elementii[0].Valore = 0;

                            messageToServer = "Bedroom;OFF";
                        }
                        else
                        {
                            Console.WriteLine($"Bedroom: ON");
                            Elementii[0].Valore = 1;

                            messageToServer = "Bedroom;ON";
                        }

                        SendToMultipleClients(Sockets, messageToServer);
                    }
                    else if (messaggio[1] == "Livingroom")
                    {
                        if (Elementii[1].Valore == 1) // Se accese (= 1)
                        {
                            Console.WriteLine($"Livingroom: OFF");
                            Elementii[1].Valore = 0;

                            messageToServer = "Livingroom;OFF";
                        }
                        else
                        {
                            Console.WriteLine($"Livingroom: ON");
                            Elementii[1].Valore = 1;

                            messageToServer = "Livingroom;ON";
                        }

                        SendToMultipleClients(Sockets, messageToServer);
                    }
                    else if (messaggio[1] == "Kitchen")
                    {
                        if (Elementii[2].Valore == 1) // Se accese (= 1)
                        {
                            Console.WriteLine($"Kitchen: OFF");
                            Elementii[2].Valore = 0;

                            messageToServer = "Kitchen;OFF";
                        }
                        else
                        {
                            Console.WriteLine($"Kitchen: ON");
                            Elementii[2].Valore = 1;

                            messageToServer = "Kitchen;ON";
                        }

                        SendToMultipleClients(Sockets, messageToServer);
                    }
                    else if (messaggio[1] == "Bathroom")
                    {
                        if (Elementii[3].Valore == 1) // Se accese (= 1)
                        {
                            Console.WriteLine($"Bathroom: OFF");
                            Elementii[3].Valore = 0;

                            messageToServer = "Bathroom;OFF";
                        }
                        else
                        {
                            Console.WriteLine($"Bathroom: ON");
                            Elementii[3].Valore = 1;

                            messageToServer = "Bathroom;ON";
                        }

                        SendToMultipleClients(Sockets, messageToServer);
                    }

                    break;

                case "TV":
                    if (Elementii[4].Valore == 1) // Se accesa (= 1)
                    {
                        Console.WriteLine($"TV: OFF");
                        Elementii[4].Valore = 0;

                        messageToServer = "TV;OFF";
                    }
                    else
                    {
                        Console.WriteLine($"TV: ON");
                        Elementii[4].Valore = 1;

                        messageToServer = "TV;ON";
                    }

                    SendToMultipleClients(Sockets, messageToServer);

                    break;

                case "Water":
                    if (Elementii[5].Valore == 1) // Se accesa (= 1)
                    {
                        Console.WriteLine($"Irrigazione: OFF");
                        Elementii[5].Valore = 0;

                        messageToServer = "Irrigazione;OFF";
                    }
                    else
                    {
                        Console.WriteLine($"Irrigazione: ON");
                        Elementii[5].Valore = 1;

                        messageToServer = "Irrigazione;ON";
                    }

                    SendToMultipleClients(Sockets, messageToServer);

                    break;

                case "Door":

                    if (messaggio[1] == "Entrance")
                    {
                        if (Elementii[6].Valore == 1) // Se accese (= 1)
                        {
                            Console.WriteLine($"Entrance: Closed");
                            Elementii[6].Valore = 0;

                            messageToServer = "Entrance;Chiuso";
                        }
                        else
                        {
                            Console.WriteLine($"Entrance: Open");
                            Elementii[6].Valore = 1;

                            messageToServer = "Entrance;Aperto";
                        }

                        SendToMultipleClients(Sockets, messageToServer);
                    }
                    else if (messaggio[1] == "Garage")
                    {
                        if (Elementii[7].Valore == 1) // Se accese (= 1)
                        {
                            Console.WriteLine($"Garage: Closed");
                            Elementii[7].Valore = 0;

                            messageToServer = "Garage;Chiuso";
                        }
                        else
                        {
                            Console.WriteLine($"Garage: Open");
                            Elementii[7].Valore = 1;

                            messageToServer = "Garage;Aperto";
                        }

                        SendToMultipleClients(Sockets, messageToServer);
                    }

                    break;

                case "Login":
                    using (StreamReader credentialsFile = new StreamReader(credentialsPath))
                    {
                        FileInfo fileInfo = new FileInfo(credentialsPath);
                        string line;
                        bool found = true;

                        while ((line = credentialsFile.ReadLine()) != null)
                        {
                            username = line.Split(';')[1];
                            password = line.Split(';')[2];

                            if (username == messaggio[2])
                            {
                                found = true;
                                messageToServer = $"Login;WrongPassword;null";

                                if (password == messaggio[3])
                                {

                                    nome = line.Split(';')[0];

                                    messageToServer = $"Login;RightPassword;{nome}";
                                }

                                SendToClient(clientSocket, messageToServer);

                                break;
                            }
                            else
                            {
                                found = false;
                            }
                        }

                        if (!found || fileInfo.Length == 0)
                        {
                            SendToClient(clientSocket, $"Login;SignUp;null");
                        }
                    }
                    break;

                case "SignUp":

                    nome = messaggio[1];
                    username = messaggio[2];
                    password = messaggio[3];

                    credential = new Credenziali(nome, username, password);
                    credentials.Add(credential);

                    using (StreamWriter sw = File.AppendText(credentialsPath))
                    {
                        foreach (Credenziali credenziale in credentials)
                        {
                            sw.WriteLine($"{credential.Nome};{credential.Username};{credential.Password}");
                        }
                    }

                    SendToClient(clientSocket, $"SignedUp;{nome}");

                    break;
            }
        } while (exit != "Exit");

        clientSocket.Shutdown(SocketShutdown.Both);
        clientSocket.Close();
        data = "";
    }
    public void SendToClient(Socket socket, string message)
    {
        SendMessage(socket, message);
    }
    public void SendToMultipleClients(List<Socket> sockets, string message)
    {
        foreach (var socket in sockets)
        {
            SendMessage(socket, message);
        }
    }
    public void SendMessage(Socket socket, string message)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(message);
        socket.Send(bytes);
    }
}
public class Credenziali
{
    private string _nome;
    public string Nome
    {
        get => _nome;
        set => _nome = value;
    }
    private string _username;
    public string Username
    {
        get => _username;
        set => _username = value;
    }
    private string _password;
    public string Password
    {
        get => _password;
        set => _password = value;
    }
    public Credenziali(string nome, string username, string password)
    {
        Nome = nome;
        Username = username;
        Password = password;
    }
}
public class Elementi
{
    private string _elemento;
    public string Elemento
    {
        get => _elemento;
        set => _elemento = value;
    }

    private int _valore;
    public int Valore
    {
        get => _valore;
        set => _valore = value;
    }
    public Elementi(string elemento, int valore)
    {
        Elemento = elemento;
        Valore = valore;
    }
}