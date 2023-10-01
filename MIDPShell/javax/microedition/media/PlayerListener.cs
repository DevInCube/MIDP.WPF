using java.lang;
namespace javax.microedition.media
{

    public static class PlayerListenerEvent
    {
        public static readonly String CLOSED = "closed";
        public static readonly String DEVICE_AVAILABLE = "deviceAvailable";
        public static readonly String DEVICE_UNAVAILABLE = "deviceUnavailable";
        public static readonly String DURATION_UPDATED = "durationUpdated";
        public static readonly String END_OF_MEDIA = "endOfMedia";
        public static readonly String ERROR = "error";
        public static readonly String STARTED = "started";
        public static readonly String STOPPED = "stopped";
        public static readonly String VOLUME_CHANGED = "volumeChanged";
    }

    public interface PlayerListener
    {
        /*
        public static readonly String CLOSED = "closed";
        public static readonly String DEVICE_AVAILABLE = "deviceAvailable";
        public static readonly String DEVICE_UNAVAILABLE = "deviceUnavailable";
        public static readonly String DURATION_UPDATED = "durationUpdated";
        public static readonly String END_OF_MEDIA = "endOfMedia";
        public static readonly String ERROR = "error";
        public static readonly String STARTED = "started";
        public static readonly String STOPPED = "stopped";
        public static readonly String VOLUME_CHANGED = "volumeChanged";
        */
        void playerUpdate(Player paramPlayer, String paramString, Object paramObject);
    }
}