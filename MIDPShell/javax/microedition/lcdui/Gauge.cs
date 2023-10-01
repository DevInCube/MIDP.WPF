using java.lang;
namespace javax.microedition.lcdui
{

    public class Gauge
      : Item
    {
        public static readonly int INDEFINITE = -1;
        public static readonly int CONTINUOUS_IDLE = 0;
        public static readonly int INCREMENTAL_IDLE = 1;
        public static readonly int CONTINUOUS_RUNNING = 2;
        public static readonly int INCREMENTAL_UPDATING = 3;

        public Gauge(String paramString, bool paramBoolean, int paramInt1, int paramInt2) { }

        public bool isInteractive()
        {
            return false;
        }

        public int getMaxValue()
        {
            return 0;
        }

        public int getValue()
        {
            return 0;
        }

        public void setMaxValue(int paramInt) { }

        public void setValue(int paramInt) { }
    }


}