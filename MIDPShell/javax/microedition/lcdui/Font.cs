using java.lang;

namespace javax.microedition.lcdui
{

    public class Font
    {
        public const int FACE_SYSTEM = 0;
        public const int FONT_STATIC_TEXT = 0;
        public const int SIZE_MEDIUM = 0;
        public const int STYLE_PLAIN = 0;
        public const int FONT_INPUT_TEXT = 1;
        public const int STYLE_BOLD = 1;
        public const int SIZE_LARGE = 16;
        public const int STYLE_ITALIC = 2;
        public const int FACE_MONOSPACE = 32;
        public const int STYLE_UNDERLINED = 4;
        public const int FACE_PROPORTIONAL = 64;
        public const int SIZE_SMALL = 8;

        private int face;
        private int style;
        private int size;

        private System.Drawing.Font wpfFont;
        internal System.Drawing.Font WPFFont => wpfFont;

        public Font(int face, int style, int size)
        {
            // TODO: Complete member initialization
            this.face = face;
            this.style = style;
            this.size = size;
            //throw IllegalArgumentException 
            var defFont = System.Drawing.SystemFonts.DefaultFont;
            float fontSize = 12;
            if ((this.getSize() & Font.SIZE_SMALL) != 0) fontSize = 10;
            if ((this.getSize() & Font.SIZE_LARGE) != 0) fontSize = 14;
            int fStyle = this.getStyle();
            System.Drawing.FontStyle ffstyle = System.Drawing.FontStyle.Regular;
            if ((fStyle & Font.STYLE_BOLD) != 0) ffstyle |= System.Drawing.FontStyle.Bold;
            if ((fStyle & Font.STYLE_ITALIC) != 0) ffstyle |= System.Drawing.FontStyle.Italic;
            if ((fStyle & Font.STYLE_UNDERLINED) != 0) ffstyle |= System.Drawing.FontStyle.Underline;
            string fontName = System.Drawing.FontFamily.GenericSansSerif.Name;
            this.wpfFont = new System.Drawing.Font(fontName, fontSize, ffstyle); 
        }

        public bool isBold()
        {
            return (style & Font.STYLE_BOLD) != 0;
        }

        public bool isItalic()
        {
            return (style & Font.STYLE_ITALIC) != 0;
        }

        public bool isPlain()
        {
            return (style & Font.STYLE_PLAIN) != 0;
        }

        public bool isUnderlined()
        {
            return (style & Font.STYLE_UNDERLINED) != 0;
        }

        public int charWidth(char paramChar)
        {
            return 0;
        }

        public int charsWidth(char[] chars, int paramInt1, int paramInt2)
        {
            return 0;
        }

        public int getBaselinePosition()
        {
            var gr = System.Drawing.Graphics.FromImage(new System.Drawing.Bitmap(500, 20));
            System.Drawing.FontFamily ff = wpfFont.FontFamily;            
            float lineSpace = ff.GetLineSpacing(wpfFont.Style);
            float ascent = ff.GetCellAscent(wpfFont.Style);
            float baseline = wpfFont.GetHeight(gr) * ascent / lineSpace;
            return (int)baseline;
        }

        public int getFace()
        {
            return this.face;
        }

        public int getHeight()
        {
            return this.wpfFont.Height;
        }

        public int getSize()
        {
            return this.size;
        }

        public int getStyle()
        {
            return this.style;
        }

        public int stringWidth(String str)
        {
            var gr = System.Drawing.Graphics.FromImage(new System.Drawing.Bitmap(500, 20));
            return (int)gr.MeasureString(str.ToString(), wpfFont).Width;
        }

        public int substringWidth(String paramString, int paramInt1, int paramInt2)
        {
            return 0;
        }

        public static Font getDefaultFont()
        {
            return null;
        }

        public static Font getFont(int fontSpecifier)
        {
            return null;
        }

        public static Font getFont(int face, int style, int size)
        {
            return new Font(face, style, size);
        }
    }
}