using System;

namespace core
{
    public abstract class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Descriptor { get; set; }
        public bool Active { get; set; }
        public TimeSpan FetchTime { get; set; } = new TimeSpan(0, 0, 1);
        public DateTime CurrentTime { get; set; } = DateTime.Now;

        public abstract byte[] SendData();
        public abstract void ReceiveData(byte[] data, int count);

        protected byte[] EncodeData(params byte[] list)
        {
            var result = new byte[list.Length];
            for (var i = 0; i < list.Length; i++) result[i] = list[i];
            return result;
        }
    }
}
