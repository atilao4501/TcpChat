using System;
using TcpChat;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Server, 2.Client");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Server server = new Server();
                Thread startServer = new Thread(server.OpenServer);
                startServer.Start();
                break;
            case 2:
                Client client = new Client();
                Thread startClient = new Thread(client.RunClient);
                startClient.Start();
                break;
        }
    }
}