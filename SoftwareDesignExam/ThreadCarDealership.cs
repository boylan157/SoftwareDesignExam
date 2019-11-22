
using System.Threading;

namespace SoftwareDesignExam
{
    //makes a abstract class Thread
    abstract class ThreadCarDealership
    {
        protected Thread thread;
        protected bool running;

        //makes ThreadCarDealership start a threadloop
        protected ThreadCarDealership()
        {
            thread = new Thread(new ThreadStart(ThreadLoop));
            running = false;
        }

        //makes a protected Task
        protected abstract void Task();

        //makes a protected threadloop while task is running
        protected void ThreadLoop()
        {
            while (running)
            {
                Task();
            }
        }

        //makes a start thread
        public void Start()
        {
            running = true;
            thread.Start();
            while (!thread.IsAlive) ;
        }

        //makes a stop thread
        public void Stop()
        {
            running = false;
            thread.Join();
        }

    

    }
}
