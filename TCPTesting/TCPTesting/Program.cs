using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace TCPTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var uri = new Uri(args[0]); // for cmd input
            //var uri = new Uri("http://accdevipcoa0045.csgidev.com/miscommon/test.html");
            //var result = SendingHttpRequestUsingSocket.GetResource(uri);
            //Console.WriteLine(result);

            //mytcp.tcpserver();

            TcpListener server = null;
            try
            {
                // Set the TcpListener on port 13000.
                Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();
                    
                    int i;


                    // Loop to receive all the data sent by the client.

                    if (stream.DataAvailable)
                    {
                        Console.WriteLine("data is availbe on network stream");

                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            i = stream.Read(bytes, 0, bytes.Length);
                            Console.WriteLine(i);
                            Console.WriteLine("has data");
                            // Translate data bytes to a ASCII string.
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            Console.WriteLine("Received: {0}", data);

                            // Process the data sent by the client.
                            data = data.ToUpper();

                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                            // Send back a response.
                            stream.Write(msg, 0, msg.Length);
                            Console.WriteLine("Sent: {0}", data);
                        } 
                    }

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
        

    }
}
