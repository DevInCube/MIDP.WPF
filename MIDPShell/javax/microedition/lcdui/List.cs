using java.lang;
namespace javax.microedition.lcdui
{

    public class List : Screen, Choice
    {

        private System.Windows.Controls.ListView control = new System.Windows.Controls.ListView();

        public override System.Windows.FrameworkElement WPFControl => control;

        public static readonly Command SELECT_COMMAND = null;

        public List(String paramString, int paramInt) { }

        public List(String paramString, int paramInt, String[] paramArrayOfString, Image[] paramArrayOfImage) { }

        public bool isSelected(int paramInt)
        {
            return false;
        }

        public int append(String paramString, Image paramImage)
        {
            return 0;
        }

        public int getFitPolicy()
        {
            return 0;
        }

        public int getSelectedFlags(bool[] paramArrayOfBoolean)
        {
            return 0;
        }

        public int getSelectedIndex()
        {
            return 0;
        }

        public int size()
        {
            return 0;
        }

        public String getString(int paramInt)
        {
            return null;
        }

        public Font getFont(int paramInt)
        {
            return null;
        }

        public Image getImage(int paramInt)
        {
            return null;
        }

        public void delete(int paramInt) { }

        public void deleteAll() { }

        public void insert(int paramInt, String paramString, Image paramImage) { }

        public void removeCommand(Command paramCommand) { }

        public void set(int paramInt, String paramString, Image paramImage) { }

        public void setFitPolicy(int paramInt) { }

        public void setFont(int paramInt, Font paramFont) { }

        public void setSelectCommand(Command paramCommand) { }

        public void setSelectedFlags(bool[] paramArrayOfBoolean) { }

        public void setSelectedIndex(int paramInt, bool paramBoolean) { }
    }

}