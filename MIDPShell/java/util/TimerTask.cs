using java.lang;
namespace java.util
{

    public abstract class TimerTask : Runnable
    {
        public abstract void run();

        public bool cancel()
        {
            return false;
        }

        public long scheduledExecutionTime()
        {
            return 0L;
        }
    }

}