using java.lang;
namespace javax.microedition.lcdui
{

    public class Command
    {
        public static readonly int SCREEN = 1;
        public static readonly int BACK = 2;
        public static readonly int CANCEL = 3;
        public static readonly int OK = 4;
        public static readonly int HELP = 5;
        public static readonly int STOP = 6;
        public static readonly int EXIT = 7;
        public static readonly int ITEM = 8;

        public Command(String paramString, int paramInt1, int paramInt2) { }

        public Command(String paramString1, String paramString2, int paramInt1, int paramInt2) { }

        public int getCommandType()
        {
            return 0;
        }

        public int getPriority()
        {
            return 0;
        }

        public String getLabel()
        {
            return null;
        }

        public String getLongLabel()
        {
            return null;
        }
    }


}