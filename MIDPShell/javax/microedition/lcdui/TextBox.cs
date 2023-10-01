using java.lang;
namespace javax.microedition.lcdui
{

    public class TextBox : Screen
    {

        private System.Windows.Controls.TextBox textBox = new System.Windows.Controls.TextBox();

        public override System.Windows.FrameworkElement WPFControl => textBox;

        public TextBox(String paramString1, String paramString2, int paramInt1, int paramInt2) { }

        public int getCaretPosition()
        {
            return 0;
        }

        public int getChars(char[] paramArrayOfChar)
        {
            return 0;
        }

        public int getConstraints()
        {
            return 0;
        }

        public int getMaxSize()
        {
            return 0;
        }

        public int setMaxSize(int paramInt)
        {
            return 0;
        }

        public int size()
        {
            return 0;
        }

        public String getString()
        {
            return null;
        }

        public void delete(int paramInt1, int paramInt2) { }

        public void insert(char[] paramArrayOfChar, int paramInt1, int paramInt2, int paramInt3) { }

        public void insert(String paramString, int paramInt) { }

        public void setChars(char[] paramArrayOfChar, int paramInt1, int paramInt2) { }

        public void setConstraints(int paramInt) { }

        public void setInitialInputMode(String paramString) { }

        public void setString(String paramString) { }
    }


}