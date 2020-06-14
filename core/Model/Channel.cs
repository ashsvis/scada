using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace core
{
    public abstract class Channel : IDisposable
    {
        private readonly BackgroundWorker worker;
        private readonly Queue<Entity> queue;

        public Channel()
        {
            queue = new Queue<Entity>();

            worker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true,
                WorkerReportsProgress = true
            };
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        public void Open()
        {
            worker.RunWorkerAsync();
        }

        public void Close()
        {
            worker.CancelAsync();
        }

        public void AddToQueue(Entity entity)
        {
            if (!queue.Contains(entity))
                queue.Enqueue(entity);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;
            var lastsecond = DateTime.Now.Second;
            var lastminute = -1;
            var lasthour = -1;
            try
            {
                Connect();
                try
                {
                    while (!worker.CancellationPending && Connected)
                    {
                        Thread.Sleep(1); // разгрузка процессоров
                        if (queue.Count > 0)
                        {
                            var entity = queue.Dequeue();
                            if (entity.Active)
                            {
                                var now = DateTime.Now;
                                if (now >= entity.CurrentTime)
                                {
                                    Fetch(this, entity);
                                    entity.CurrentTime = now.Add(entity.FetchTime);
                                }
                                queue.Enqueue(entity);
                            }
                        }
                        var dt = DateTime.Now;
                        if (lastsecond == dt.Second) continue;
                        lastsecond = dt.Second;
                        // прошла секунда

                        if (lastminute == dt.Minute) continue;
                        lastminute = dt.Minute;
                        // прошла минута

                        if (lasthour != dt.Hour && dt.Minute == 0)
                        {
                            lasthour = dt.Hour;
                            // здесь закрываем предыдущий час
                        }
                    }

                }
                finally
                {
                    Disconnect();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ~Channel()
        {
            Dispose();
        }

        public abstract void Connect();

        public abstract bool Connected { get; }

        public abstract void Disconnect();

        public virtual void Dispose()
        {
            worker.Dispose();
        }

        public virtual void Fetch(Channel channel, Entity entity) {} // stub

        public abstract int Send(byte[] buffer);
        public abstract int Receive(byte[] buffer);

    }
}
