using java.lang;
namespace javax.microedition.lcdui
{

    public abstract class Item
    {
        public static readonly int LAYOUT_DEFAULT = 0;
        public static readonly int PLAIN = 0;
        public static readonly int HYPERLINK = 1;
        public static readonly int LAYOUT_LEFT = 1;
        public static readonly int LAYOUT_SHRINK = 1024;
        public static readonly int LAYOUT_TOP = 16;
        public static readonly int LAYOUT_2 = 16384;
        public static readonly int BUTTON = 2;
        public static readonly int LAYOUT_RIGHT = 2;
        public static readonly int LAYOUT_EXPAND = 2048;
        public static readonly int LAYOUT_NEWLINE_BEFORE = 256;
        public static readonly int LAYOUT_CENTER = 3;
        public static readonly int LAYOUT_BOTTOM = 32;
        public static readonly int LAYOUT_VSHRINK = 4096;
        public static readonly int LAYOUT_VCENTER = 48;
        public static readonly int LAYOUT_NEWLINE_AFTER = 512;
        public static readonly int LAYOUT_VEXPAND = 8192;

        public int getLayout()
        {
            return 0;
        }

        public int getMinimumHeight()
        {
            return 0;
        }

        public int getMinimumWidth()
        {
            return 0;
        }

        public int getPreferredHeight()
        {
            return 0;
        }

        public int getPreferredWidth()
        {
            return 0;
        }

        public String getLabel()
        {
            return null;
        }

        public void addCommand(Command paramCommand) { }

        public void notifyStateChanged() { }

        public void removeCommand(Command paramCommand) { }

        public void setDefaultCommand(Command paramCommand) { }

        public void setItemCommandListener(ItemCommandListener paramItemCommandListener) { }

        public void setLabel(String paramString) { }

        public void setLayout(int paramInt) { }

        public void setPreferredSize(int paramInt1, int paramInt2) { }
    }


}