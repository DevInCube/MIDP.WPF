using java.lang;
namespace javax.microedition.lcdui
{

    public interface Choice
    {
        /*
        public static sealed int TEXT_WRAP_DEFAULT = 0;
        public static sealed int EXCLUSIVE = 1;
        public static sealed int TEXT_WRAP_ON = 1;
        public static sealed int MULTIPLE = 2;
        public static sealed int TEXT_WRAP_OFF = 2;
        public static sealed int IMPLICIT = 3;
        public static sealed int POPUP = 4;
        */
         bool isSelected(int paramInt);

          int append(String paramString, Image paramImage);

         int getFitPolicy();

         int getSelectedFlags(bool[] paramArrayOfBoolean);

         int getSelectedIndex();

         int size();

         String getString(int paramInt);

         Font getFont(int paramInt);

         Image getImage(int paramInt);

         void delete(int paramInt);

         void deleteAll();

         void insert(int paramInt, String paramString, Image paramImage);

         void set(int paramInt, String paramString, Image paramImage);

         void setFitPolicy(int paramInt);

         void setFont(int paramInt, Font paramFont);

         void setSelectedFlags(bool[] paramArrayOfBoolean);

         void setSelectedIndex(int paramInt, bool paramBoolean);
    }
}