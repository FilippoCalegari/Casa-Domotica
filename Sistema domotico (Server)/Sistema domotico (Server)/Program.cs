using Sistema_domotico__Server_.Properties;
using System;
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

        Console.WriteLine("Timeout : {0}", listener.ReceiveTimeout);

        // Bind the socket to the local endpoint and   
        // listen for incoming connections.
        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);

            // Start listening for connections.  
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
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
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Elementi.txt");
        StreamReader sr = new StreamReader(filePath);
        StreamWriter sw = new StreamWriter(filePath);
        int bytesRec = clientSocket.Receive(bytes);

        string line = sr.ReadLine();
        string[] status = line.Split(';');

        data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
        
        switch (data)
        {
            case "Lights":
                if (status[1] == "1")
                {
                    Console.WriteLine($"Luci: ON");
                    status[1] = "0";
                }
                else
                {
                    Console.WriteLine($"Luci: OFF");
                    status[1] = "1";
                }
            break;

        }
            
        
        
        clientSocket.Shutdown(SocketShutdown.Both);
        clientSocket.Close();
        data = "";
    }
}