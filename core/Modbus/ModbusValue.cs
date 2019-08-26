using System;

namespace core
{
    public abstract class ModbusValue : Entity
    {
        public byte Node { get; set; } = 1;
        public ushort Address { get; set; } = 0;

        protected byte Function { get; set; }
        protected ushort Datacount { get; set; }
        public byte ErrorCode { get; set; }

        public override byte[] SendData()
        {
            var sendBytes = EncodeData((byte)Node, (byte)Function,
                (byte)(Address >> 8), (byte)(Address & 0xff),
                (byte)(Datacount >> 8), (byte)(Datacount & 0xff));
            return sendBytes;
        }

        public override void ReceiveData(byte[] data, int count)
        {
            if (count == 3 && data[0] == Node && data[1] == (Function | 0x80))
            {
                ErrorCode = data[2];
            }
        }

        protected ushort ReceiveShortData(byte[] data, int count)
        {
            if (count == 5 && data[0] == Node && data[1] == Function && data[2] == 2)
            {
                var reg = EncodeData(data[4], data[3]);
                ErrorCode = 0;
                return BitConverter.ToUInt16(reg, 0);
            }
            return 0;
        }
    }
}
