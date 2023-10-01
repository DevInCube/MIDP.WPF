using java.lang;
namespace javax.microedition.lcdui
{

    public class ImageItem
      : Item
    {
        public static readonly int LAYOUT_DEFAULT = 0;
        public static readonly int LAYOUT_LEFT = 1;
        public static readonly int LAYOUT_RIGHT = 2;
        public static readonly int LAYOUT_NEWLINE_BEFORE = 256;
        public static readonly int LAYOUT_CENTER = 3;
        public static readonly int LAYOUT_NEWLINE_AFTER = 512;

        public ImageItem(String paramString1, Image paramImage, int paramInt, String paramString2) { }

        public ImageItem(String paramString1, Image paramImage, int paramInt1, String paramString2, int paramInt2) { }

        public int getAppearanceMode()
        {
            return 0;
        }

        public int getLayout()
        {
            return 0;
        }

        public String getAltText()
        {
            return null;
        }

        public Image getImage()
        {
            return null;
        }

        public void setAltText(String paramString) { }

        public void setImage(Image paramImage) { }

        public void setLayout(int paramInt) { }
    }
}