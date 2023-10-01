using java.io;
using java.lang;

namespace javax.microedition.lcdui
{

    public class Image
    {

        private System.Drawing.Image image;
        internal System.Drawing.Image WPFImage => image;

        public Image(System.Drawing.Image image1)
        {
            this.image = image1;
        }

        public bool isMutable()
        {
            return true;
        }

        public int getHeight()
        {
            return image.Height;
        }

        public int getWidth()
        {
            return image.Width;
        }

        public Graphics getGraphics()
        {
            System.Drawing.Graphics newGraphics = System.Drawing.Graphics.FromImage(image);
            return new Graphics(newGraphics);
        }

        public static Image createImage(byte[] imageData, int imageOffset, int imageLength)
        {
            //@todo width height
            using (var ms = new System.IO.MemoryStream(imageData))
            {
                var bitmap = new System.Drawing.Bitmap(ms);
                return new Image(bitmap);
            }
        }

        public static Image createImage(int w, int h)
        {
            return new Image(new System.Drawing.Bitmap(w, h));
        }

        public static Image createImage(InputStream stream)
        {
            return new Image(System.Drawing.Image.FromStream(stream.Stream));
        }

        public static Image createImage(String name)
        {
            if (name == null) throw new NullPointerException("name");
            return null;
        }

        public static Image createImage(Image paramImage)
        {
            return new Image(paramImage.image);
        }

        public static Image createImage(Image image, int x, int y, int width, int height, int transform)
        {
            return null;
        }

        public static Image createRGBImage(int[] rgb, int width, int height, bool processAlpha)
        {
            return null;
        }

        public void getRGB(int[] rgbData, int offset, int scanlength, int x, int y, int width, int height) { }
    }

}