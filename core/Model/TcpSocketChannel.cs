using System.Net;
using System.Net.Sockets;

namespace core
{
    public class TcpSocketChannel : Channel
    {
        private Socket socket;

        public string ServerAddress { get; set; }
        public int ServerPort { get; set; }

        public TcpSocketChannel()
        {
            SendTimeout = 5000;
            ReceiveTimeout = 5000;
        }

        ~TcpSocketChannel()
        {
            Dispose();
        }

        public override void Dispose()
        {
            if (socket != null) socket.Dispose();
            base.Dispose();
        }

        public override void Connect()
        {
            if (socket != null) socket.Dispose();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var remoteEp = new IPEndPoint(IPAddress.Parse(ServerAddress), ServerPort);
            socket.SendTimeout = SendTimeout;
            socket.ReceiveTimeout = ReceiveTimeout;
            socket.Connect(remoteEp);
        }

        public override void Disconnect()
        {
            socket.Disconnect(true);
        }

        public override int Receive(byte[] buffer)
        {
            return socket.Receive(buffer);
        }

        public override int Send(byte[] buffer)
        {
            return socket.Send(buffer);
        }

        public override bool Connected
        {
            get { return socket.Connected; }
        }

        public int SendTimeout { get; set; }
        public int ReceiveTimeout { get; set; }
    }
}
