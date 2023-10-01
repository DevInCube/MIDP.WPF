using java.lang;
namespace javax.microedition.lcdui
{

    public class Form : Screen
    {

        private System.Windows.Controls.GroupBox control;

        public override System.Windows.FrameworkElement WPFControl => control;

        public Form(String header) {
            System.Windows.Application.Current.Dispatcher.Invoke((System.Action)(() => {
                control = new System.Windows.Controls.GroupBox();
                control.Content = new System.Windows.Controls.ItemsControl();
                control.Header = header;
            }));
        }

        public Form(String paramString, Item[] paramArrayOfItem) { }

        public int append(String msg)
        {
            int index = 0;
            System.Windows.Application.Current.Dispatcher.Invoke((System.Action)(() =>
            {
                var lbl = new System.Windows.Controls.Label();
                lbl.Content = msg;
                (control.Content as System.Windows.Controls.ItemsControl).Items.Add(lbl);
                index = (control.Content as System.Windows.Controls.ItemsControl).Items.Count - 1;
            }));
            return index;
        }

        public int append(Image paramImage)
        {
            return 0;
        }

        public int append(Item paramItem)
        {
            return 0;
        }

        public int getHeight()
        {
            return 0;
        }

        public int getWidth()
        {
            return 0;
        }

        public int size()
        {
            return 0;
        }

        public Item get(int paramInt)
        {
            return null;
        }

        public void delete(int paramInt) { }

        public void deleteAll() { }

        public void insert(int paramInt, Item paramItem) { }

        public void set(int paramInt, Item paramItem) { }

        public void setItemStateListener(ItemStateListener paramItemStateListener) { }
    }

}