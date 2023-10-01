using java.lang;
namespace javax.microedition.lcdui
{

    public abstract class Displayable
    {

        public abstract System.Windows.FrameworkElement WPFControl { get; } 

        protected virtual void sizeChanged(int paramInt1, int paramInt2) { }

        public bool isShown()
        {
            return true;//@todo
        }

        public virtual int getHeight()
        {
            return 0;
        }

        public virtual int getWidth()
        {
            return 0;
        }

        public String getTitle()
        {
            return null;
        }

        public Ticker getTicker()
        {
            return null;
        }

        public void addCommand(Command paramCommand) { }

        public void removeCommand(Command paramCommand) { }

        public void setCommandListener(CommandListener paramCommandListener) { }

        public void setTicker(Ticker paramTicker) { }

        public void setTitle(String paramString) { }
    }

}