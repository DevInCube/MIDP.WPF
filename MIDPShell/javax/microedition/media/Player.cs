using java.lang;
namespace javax.microedition.media
{

    public enum PlayerState : int
    {
        CLOSED = 0,
        UNREALIZED = 100,
        REALIZED = 200,
        PREFETCHED = 300,
        STARTED = 400,
    }

    public interface Player : Controllable
    {
        /*
        public static readonly long TIME_UNKNOWN = -1L;
        public static readonly int CLOSED = 0;
        public static readonly int UNREALIZED = 100;
        public static readonly int REALIZED = 200;
        public static readonly int PREFETCHED = 300;
        public static readonly int STARTED = 400;
        */
        int getState();
        String getContentType();
        long getDuration();
        long getMediaTime();
        long setMediaTime(long mediaTime);       
        void addPlayerListener(PlayerListener listener);
        void removePlayerListener(PlayerListener listener);
        void close();
        void deallocate();
        void prefetch();        
        void realize();
        void setLoopCount(int count);
        void start();        
        void stop();
        
    }
}