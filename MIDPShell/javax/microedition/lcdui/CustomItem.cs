using java.lang;
namespace javax.microedition.lcdui
{

    public abstract class CustomItem
      : Item
    {
        protected static readonly int NONE = 0;
        protected static readonly int TRAVERSE_HORIZONTAL = 1;
        protected static readonly int POINTER_DRAG = 128;
        protected static readonly int KEY_REPEAT = 16;
        protected static readonly int TRAVERSE_VERTICAL = 2;
        protected static readonly int POINTER_PRESS = 32;
        protected static readonly int KEY_PRESS = 4;
        protected static readonly int POINTER_RELEASE = 64;
        protected static readonly int KEY_RELEASE = 8;

        protected CustomItem(String paramString) { }

        protected abstract int getMinContentHeight();

        protected abstract int getMinContentWidth();

        protected abstract int getPrefContentHeight(int paramInt);

        protected abstract int getPrefContentWidth(int paramInt);

        protected abstract void paint(Graphics paramGraphics, int paramInt1, int paramInt2);

        protected bool traverse(int paramInt1, int paramInt2, int paramInt3, int[] paramArrayOfInt)
        {
            return false;
        }

        protected  int getInteractionModes()
        {
            return 0;
        }

        protected  void invalidate() { }

        protected  void repaint() { }

        protected  void repaint(int paramInt1, int paramInt2, int paramInt3, int paramInt4) { }

        protected void hideNotify() { }

        protected void keyPressed(int paramInt) { }

        protected void keyReleased(int paramInt) { }

        protected void keyRepeated(int paramInt) { }

        protected void pointerDragged(int paramInt1, int paramInt2) { }

        protected void pointerPressed(int paramInt1, int paramInt2) { }

        protected void pointerReleased(int paramInt1, int paramInt2) { }

        protected void showNotify() { }

        protected void sizeChanged(int paramInt1, int paramInt2) { }

        protected void traverseOut() { }

        public int getGameAction(int paramInt)
        {
            return 0;
        }
    }
}