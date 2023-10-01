using javax.microedition.midlet;

namespace javax.microedition.lcdui
{

    using java.lang;
    using MIDP.WPF.ViewModels;

    public class Display
    {
        public static readonly int COLOR_BACKGROUND = 0;
        public static readonly int COLOR_FOREGROUND = 1;
        public static readonly int LIST_ELEMENT = 1;
        public static readonly int CHOICE_GROUP_ELEMENT = 2;
        public static readonly int COLOR_HIGHLIGHTED_BACKGROUND = 2;
        public static readonly int ALERT = 3;
        public static readonly int COLOR_HIGHLIGHTED_FOREGROUND = 3;
        public static readonly int COLOR_BORDER = 4;
        public static readonly int COLOR_HIGHLIGHTED_BORDER = 5;

        private static Display stDisplay = new Display();
        private MIDP.WPF.Views.DisplayControl displayControl = new MIDP.WPF.Views.DisplayControl();
        public System.Windows.Controls.Control Control => displayControl;

        public bool flashBacklight(int paramInt)
        {
            return false;
        }

        public bool isColor()
        {
            return false;
        }

        public bool vibrate(int paramInt)
        {
            return false;
        }

        public int getBestImageHeight(int paramInt)
        {
            return 0;
        }

        public int getBestImageWidth(int paramInt)
        {
            return 0;
        }

        public int getBorderStyle(bool paramBoolean)
        {
            return 0;
        }

        public int getColor(int paramInt)
        {
            return 0;
        }

        public int numAlphaLevels()
        {
            return 0;
        }

        public int numColors()
        {
            return 0;
        }

        public Displayable getCurrent()
        {
            return null;
        }

        public static Display getDisplay(MIDlet paramMIDlet)
        {
            return stDisplay;
        }

        public void callSerially(Runnable paramRunnable) { }

        public void setCurrent(Alert paramAlert, Displayable paramDisplayable) { }

        public void setCurrent(Displayable disp) 
        {
            this.displayControl.setControl(disp.WPFControl);
            if (disp is Canvas)
            {
                this.displayControl.SetEventListener(disp as IEventListener);
            }
        }

        public void setCurrentItem(Item paramItem) { }
    }


}