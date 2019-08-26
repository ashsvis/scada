using System;
using System.Collections.Generic;

namespace core
{
    public class ModbusTcpChannel : TcpSocketChannel
    {
        private readonly byte[] buff = new byte[1024];

        public ModbusTcpChannel(string serverIp = "127.0.0.1", int port = 502)
        {
            ServerAddress = serverIp;
            ServerPort = port;
        }

        private byte[] EncodeData(params byte[] list)
        {
            var result = new byte[list.Length];
            for (var i = 0; i < list.Length; i++) result[i] = list[i];
            return result;
        }

        public override void Fetch(Channel channel, Entity entity)
        {
            try
            {
                var sendData = entity.SendData();
                var list = new List<byte>();
                list.AddRange(EncodeData(0, 0, 0, 0, 0));
                list.Add((byte)sendData.Length);
                list.AddRange(sendData);
                channel.Send(list.ToArray());
                var numBytes = channel.Receive(buff);
                if (numBytes > 5)
                {
                    var count = buff[5];
                    var receiveData = new byte[count];
                    Array.Copy(buff, 6, receiveData, 0, count);
                    entity.ReceiveData(receiveData, count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
