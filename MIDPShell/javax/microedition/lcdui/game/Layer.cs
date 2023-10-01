namespace javax.microedition.lcdui.game
{


    public abstract class Layer
    {
        public abstract void paint(Graphics paramGraphics);

        public  bool isVisible()
        {
            return false;
        }

        public  int getHeight()
        {
            return 0;
        }

        public  int getWidth()
        {
            return 0;
        }

        public  int getX()
        {
            return 0;
        }

        public  int getY()
        {
            return 0;
        }

        public void move(int paramInt1, int paramInt2) { }

        public void setPosition(int paramInt1, int paramInt2) { }

        public void setVisible(bool paramBoolean) { }
    }

}