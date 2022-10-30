using System.Net;
using System.Net.Sockets;
using System.Text;

public class Server
{
    internal static void RunServer()
    {
        // Establish the local endpoint for the socket. Dns.GetHostName returns the name of the host running the application.
        IPHostEntry ipHost = Dns.GetHostEntry( Dns.GetHostName() );

        // Set it to use 192.168.1.XXX address (Local To Router) by using Array @ [1] and not [0]
        IPAddress ipAddr = ipHost.AddressList[1];
        IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 5575);
    
        // Creation TCP/IP Socket using Socket Class Constructor
        Socket SocketListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            // Using Bind() method we associate a network address to the Server Socket All
            // client that will connect to this Server Socket must know this network Address
            SocketListener.Bind(localEndPoint);
    
            // Using Listen() method we create the Client list that will want to connect to Server
            SocketListener.Listen(10);
    
            while(true)
            {
                Console.WriteLine("Waiting connection ... ");
    
                // Suspend while waiting for incoming connection Using Accept()
                // method the server will accept connection of client
                Socket clientSocket = SocketListener.Accept();
    
                // Data buffer
                byte[] bytes = new Byte[1024];
                string? data = null;
    
                while(true)
                {
                    int numByte = clientSocket.Receive(bytes);
                    
                    data += Encoding.ASCII.GetString(bytes, 0, numByte);
                                                
                    if (data.IndexOf("<EOF>") > -1)
                        break;
                }
    
                Console.WriteLine("Text received -> {0} ", data);
                byte[] message = Encoding.ASCII.GetBytes("Test Server");
    
                // Send a message to Client using Send() method
                clientSocket.Send(message);
    
                // Close client Socket using the Close() method. After closing,
                // we can use the closed Socket for a new Client Connection
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
