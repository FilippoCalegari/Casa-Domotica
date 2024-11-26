﻿using Sistema_domotico__Server_.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml.Linq;

public class SynchronousSocketListener
{
    // Incoming data from the client.  
    public static string data = null;
    public static void StartListening()
    {
        int count = 0;

        // Establish the local endpoint for the socket.  
        // Dns.GetHostName returns the name of the   
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

                ClientManager clientThread = new ClientManager(handler, count);
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

    public static int Main(String[] args)
    {
        StartListening();
        return 0;
    }
}
public class ClientManager
{
    Socket clientSocket;
    byte[] bytes = new Byte[1024];
    String data = "";
    int count;

    public ClientManager(Socket clientSocket, int count)
    {
        this.clientSocket = clientSocket;
        this.count = count;
    }
    public void doClient()
    {
        string elementsPath = @"..\..\Resources\Elementi.txt";
        string credentialsPath = @"..\..\Resources\Credenziali.txt";
        List <Elementi> elements = new List <Elementi>();
        Elementi element;
        List <Credenziali> credentials = new List <Credenziali>();
        Credenziali credential;

        using (StreamReader elementsFile = new StreamReader(elementsPath))
        {
            int bytesRec = clientSocket.Receive(bytes);

            // Trascrivo gli elementi e i valori in una lista
            foreach (string linea in File.ReadLines(elementsPath))
            {
                string line = elementsFile.ReadLine();
                element = new Elementi(line.Split(';')[0], int.Parse(line.Split(';')[1]));
                elements.Add(element);
            }

            data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            string[] messaggio = data.Split(';');

            // Controllo che tipo di messaggio è arrivato dal client
            switch (messaggio[0])
            {
                case "Lights":
                    if (elements[0].Valore == 1) // Se accese (= 1)
                    {
                        Console.WriteLine($"Luci: ON");
                        elements[0].Valore = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Luci: OFF");
                        elements[0].Valore = 1;
                    }
                    break;

                case "TV":
                    if (elements[1].Valore == 1) // Se accesa (= 1)
                    {
                        Console.WriteLine($"TV: ON");
                        elements[1].Valore = 0;
                    }
                    else
                    {
                        Console.WriteLine($"TV: OFF");
                        elements[1].Valore = 1;
                    }
                    break;

                case "Water":
                    if (elements[2].Valore == 1) // Se accesa (= 1)
                    {
                        Console.WriteLine($"Irrigazione: ON");
                        elements[2].Valore = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Irrigazione: OFF");
                        elements[2].Valore = 1;
                    }
                    break;

                case "Door":
                    if (elements[3].Valore == 1) // Se aperta (= 1)
                    {
                        Console.WriteLine($"Porta: Aperta");
                        elements[3].Valore = 0;
                    }
                    else
                    {
                        Console.WriteLine($"Porta: Chiusa");
                        elements[3].Valore = 1;
                    }
                    break;

                case "Login":
                    using (StreamReader credentialsFile = new StreamReader(credentialsPath))
                    {
                        string line;

                        while ((line = credentialsFile.ReadLine()) != null)
                        {
                            string username = line.Split(';')[0];
                            string password = line.Split(';')[1];

                            if (username == messaggio[1])
                            {
                                Console.WriteLine(messaggio[1]);

                                if (password == messaggio[2])
                                {
                                    Console.WriteLine("Giusto.");
                                }
                                else
                                {
                                    Console.WriteLine("Password errata");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Registrati");
                            }
                        }
                    }
                    break;
            }
        }

        using(StreamWriter sw = new StreamWriter(elementsPath))
        {
            // Sovrascrivo i valori modificati nel file
            foreach (Elementi elemento in elements)
            {
                sw.WriteLine($"{elemento.Elemento};{elemento.Valore}");
            }
        }

        clientSocket.Shutdown(SocketShutdown.Both);
        clientSocket.Close();
        data = "";
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
    private string _password;
    public string Password
    {
        get => _password;
        set => _password = value;
    }
    public Credenziali (string nome, string password)
    {
        Nome = nome;
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
    public Elementi (string elemento, int valore)
    {
        Elemento = elemento;
        Valore = valore;
    }
}