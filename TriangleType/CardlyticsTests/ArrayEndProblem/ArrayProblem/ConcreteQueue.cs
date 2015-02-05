using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayProblem
{
    public class ConcreteQueue<T> : Queue
    {
        public ConcurrentQueue<T> queue = new ConcurrentQueue<T>();
        public int maxSize { get; set; }

        public void Enqueue(T entry)
        {
            queue.Enqueue(entry);
            lock (this)
            {
                T overflow;
                while (queue.Count > maxSize && queue.TryDequeue(out overflow))
                {

                }
            }
        }
    }
}
