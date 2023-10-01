namespace javax.microedition.lcdui.game
{


    public class Sprite : Layer
    {
        public const int TRANS_NONE = 0;
        public const int TRANS_MIRROR_ROT180 = 1;
        public const int TRANS_MIRROR = 2;
        public const int TRANS_ROT180 = 3;
        public const int TRANS_MIRROR_ROT270 = 4;
        public const int TRANS_ROT90 = 5;
        public const int TRANS_ROT270 = 6;
        public const int TRANS_MIRROR_ROT90 = 7;

        public Sprite(Image paramImage) { }

        public Sprite(Image paramImage, int paramInt1, int paramInt2) { }

        public Sprite(Sprite paramSprite) { }

        public  bool collidesWith(Image paramImage, int paramInt1, int paramInt2, bool paramBoolean)
        {
            return false;
        }

        public  bool collidesWith(Sprite paramSprite, bool paramBoolean)
        {
            return false;
        }

        public  bool collidesWith(TiledLayer paramTiledLayer, bool paramBoolean)
        {
            return false;
        }

        public  int getFrame()
        {
            return 0;
        }

        public override void paint(Graphics paramGraphics) { }

        public int getFrameSequenceLength()
        {
            return 0;
        }

        public int getRawFrameCount()
        {
            return 0;
        }

        public int getRefPixelX()
        {
            return 0;
        }

        public int getRefPixelY()
        {
            return 0;
        }

        public void defineCollisionRectangle(int paramInt1, int paramInt2, int paramInt3, int paramInt4) { }

        public void defineReferencePixel(int paramInt1, int paramInt2) { }

        public void nextFrame() { }

        public void prevFrame() { }

        public void setFrame(int paramInt) { }

        public void setFrameSequence(int[] paramArrayOfInt) { }

        public void setImage(Image paramImage, int paramInt1, int paramInt2) { }

        public void setRefPixelPosition(int paramInt1, int paramInt2) { }

        public void setTransform(int paramInt) { }
    }

}