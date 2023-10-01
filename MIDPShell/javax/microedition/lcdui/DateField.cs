namespace javax.microedition.lcdui
{

    using java.lang;
    using java.util;


    public class DateField
      : Item
    {
        public static readonly int DATE = 1;
        public static readonly int TIME = 2;
        public static readonly int DATE_TIME = 3;

        public DateField(String paramString, int paramInt) { }

        public DateField(String paramString, int paramInt, TimeZone paramTimeZone) { }

        public int getInputMode()
        {
            return 0;
        }

        public Date getDate()
        {
            return null;
        }

        public void setDate(Date paramDate) { }

        public void setInputMode(int paramInt) { }
    }

}