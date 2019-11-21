using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SoftwareDesignExam
{
    abstract class ThreadProxy
    {
        protected Thread thread;
        protected bool running;

        public Thread Thread { get => thread; }
        public bool IsAlive { get => thread.IsAlive; }
        public bool Running { get => running; }

        public ThreadProxy()
        {
            thread = new Thread(new ThreadStart(ThreadLoop));
            running = false;
        }

        protected abstract void Task();
        protected void ThreadLoop()
        {
            while (running)
            {
                Task();
            }
        }
        public void Start()
        {
            running = true;
            thread.Start();
            while (!thread.IsAlive) ;
        }

        public void Stop()
        {
            running = false;
            thread.Join();
        }

    

    }
}
