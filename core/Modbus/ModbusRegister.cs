namespace core
{
    public class ModbusRegister : ModbusValue
    {
        public ushort Value { get; set; }

        public ModbusRegister()
        {
            Node = 1;
            Address = 0;
            Function = 3;
            Datacount = 1;
        }

        public override void ReceiveData(byte[] data, int count)
        {
            Value = ReceiveShortData(data, count);
        }
    }
}
