namespace java.lang
{
    public class Thread
    {

        private readonly System.Threading.Thread _thread;

        public Thread() { }
        public Thread(Runnable target)
        {
            this._thread = new System.Threading.Thread(target.run);
        }
        public Thread(Runnable target, String name) { }
        public Thread(String name) { }
        /*public Thread(ThreadGroup group, Runnable target) { }
        public Thread(ThreadGroup group, Runnable target, String name) { }
        public Thread(ThreadGroup group, Runnable target, String name, long stackSize) { }
        public Thread(ThreadGroup group, String name) { }*/

        public void start()
        {
            if (_thread == null) throw new RuntimeException("Thread not created");
            _thread.Start();
        }

        public static void sleep(int delay)
        {
            System.Threading.Thread.Sleep(delay);
        }
    }
}
