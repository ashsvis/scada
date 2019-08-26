namespace core
{
    public class ModbusInput : ModbusValue
    {
        public ushort Value { get; set; }

        public ModbusInput()
        {
            Node = 1;
            Address = 0;
            Function = 4;
            Datacount = 1;
        }

        public override void ReceiveData(byte[] data, int count)
        {
            Value = ReceiveShortData(data, count);
        }
    }
}
