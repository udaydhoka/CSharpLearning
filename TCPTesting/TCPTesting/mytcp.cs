using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCPTesting
{
    class mytcp
    {
        internal static void  tcpserver()            
        {
            TcpListener listener = null;
            try
            {
                short port = 13000;
                IPAddress ip = IPAddress.Parse("127.0.0.1");

                IPEndPoint iPEndPoint = new IPEndPoint(ip, port);

                listener = new TcpListener(iPEndPoint);
                listener.ExclusiveAddressUse = true;

                listener.Start();

                while (true)
                {
                    Console.Write("Waiting for a connection... ");

                    Socket conn = listener.AcceptSocket();

                    Console.WriteLine("Connected!");



                    if (conn.Connected && conn.Available != 0)
                    {
                        Console.WriteLine(conn.Available);

                        using (NetworkStream stream = new NetworkStream(conn, FileAccess.ReadWrite))
                        {

                            string data = string.Empty;
                            int bytes = 0;
                            Byte[] bdata = new Byte[256];
                            bytes = stream.Read(bdata, offset: 0, size: data.Length);

                            data = System.Text.Encoding.ASCII.GetString(bdata);

                            Console.WriteLine("Received data length {0} is bytes", bytes);
                            Console.WriteLine("Received data is {0}", data); ;

                            byte[] msg = System.Text.Encoding.ASCII.GetBytes("processed");

                            stream.Write(msg, 0, msg.Length);


                        }
                    }
                    conn.Close();
                }

            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                listener.Stop();
            }
        }

    }
}
