using java.lang;
using MIDP.WPF.Media;
using MIDP.WPF.ViewModels;
using System.ComponentModel;

namespace javax.microedition.lcdui
{

    public abstract class Canvas : Displayable, IEventListener
    {
        public const int UP = 1;
        public const int GAME_B = 10;
        public const int GAME_C = 11;
        public const int GAME_D = 12;
        public const int LEFT = 2;
        public const int KEY_POUND = 35;
        public const int KEY_STAR = 42;
        public const int KEY_NUM0 = 48;
        public const int KEY_NUM1 = 49;
        public const int RIGHT = 5;
        public const int KEY_NUM2 = 50;
        public const int KEY_NUM3 = 51;
        public const int KEY_NUM4 = 52;
        public const int KEY_NUM5 = 53;
        public const int KEY_NUM6 = 54;
        public const int KEY_NUM7 = 55;
        public const int KEY_NUM8 = 56;
        public const int KEY_NUM9 = 57;
        public const int DOWN = 6;
        public const int FIRE = 8;
        public const int GAME_A = 9;

        private Graphics graphics;
        private IDrawingContext dc;

        public override System.Windows.FrameworkElement WPFControl => dc.WPFControl;

        public Canvas()
        {
            dc = new BitmapDrawingContext();
            graphics = dc.CreateGraphics();
        }

        public abstract void paint(Graphics paramGraphics);

        protected void hideNotify() { }

        public virtual void keyPressed(int keyCode) { }

        public virtual void keyReleased(int keyCode) { }

        protected void keyRepeated(int paramInt) { }

        public virtual void pointerDragged(int x, int y) { }

        public virtual void pointerPressed(int x, int y) { }

        public virtual void pointerReleased(int x, int y) { }

        protected void showNotify() { }

        protected override void sizeChanged(int w, int h) { }

        public bool hasPointerEvents()
        {
            return false;
        }

        public bool hasPointerMotionEvents()
        {
            return false;
        }

        public bool hasRepeatEvents()
        {
            return false;
        }

        public bool isDoubleBuffered()
        {
            return false;
        }

        public  void repaint() 
        {
            if (isShown())
            {
                this.paint(graphics);
            }
        }

        public  void repaint(int x, int y, int w, int h) { }        

        public void serviceRepaints()
        {
            if (isShown())
            {
                dc.ServiceRepaints();
            }
        }

        public int getGameAction(int keyCode)
        {
            return 0;
        }

        public override int getHeight()
        {
            return dc.Height;
        }

        public int getKeyCode(int paramInt)
        {
            return 0;
        }

        public override int getWidth()
        {
            return dc.Width;
        }

        public String getKeyName(int paramInt)
        {
            return null;
        }

        public void setFullScreenMode(bool paramBoolean) {
            //@todo            
        }


    }

}