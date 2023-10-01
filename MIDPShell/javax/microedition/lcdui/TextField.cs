using java.lang;
namespace javax.microedition.lcdui
{

    public class TextField : Item
    {
        public const int ANY = 0;
        public const int EMAILADDR = 1;
        public const int INITIAL_CAPS_WORD = 1048576;
        public const int UNEDITABLE = 131072;
        public const int NUMERIC = 2;
        public const int INITIAL_CAPS_SENTENCE = 2097152;
        public const int SENSITIVE = 262144;
        public const int PHONENUMBER = 3;
        public const int URL = 4;
        public const int DECIMAL = 5;
        public const int NON_PREDICTIVE = 524288;
        public const int CONSTRAINT_MASK = 65535;
        public const int PASSWORD = 65536;

        public TextField(String paramString1, String paramString2, int paramInt1, int paramInt2) { }

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