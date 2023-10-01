using java.io;
using java.lang;

namespace javax.microedition.media
{

    public class Manager
    {

        public static readonly String TONE_DEVICE_LOCATOR = "device://tone";

        public static String[] getSupportedContentTypes(String paramString)
        {
            return null;
        }

        public static String[] getSupportedProtocols(String paramString)
        {
            return null;
        }

        public static Player createPlayer(InputStream stream, String contentType)
        {
            return new MIDP.WPF.Media.AudioPlayer(stream, contentType);
        }

        public static Player createPlayer(String paramString)
        {
            return null;
        }

        public static void playTone(int paramInt1, int paramInt2, int paramInt3)

        { }
    }
}