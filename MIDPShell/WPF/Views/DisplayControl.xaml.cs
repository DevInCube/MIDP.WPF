using MIDP.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MIDP.WPF.Views
{
    /// <summary>
    /// Interaction logic for DisplayControl.xaml
    /// </summary>
    public partial class DisplayControl : UserControl, INotifyPropertyChanged
    {

        public ObservableCollection<FrameworkElement> Items { get; set; }
        
        public DisplayControl()
        {
            InitializeComponent();
            Items = new ObservableCollection<FrameworkElement>();
            this.DataContext = this;
        }

        //public void 

        public void setControl(FrameworkElement c)
        {
            Application.Current.Dispatcher.Invoke((Action)(() => {
                this.Items.Clear();
                this.Items.Add(c);
            }));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private IEventListener eventListener;
        private IEventSource eventSource;

        public void SetEventSource(IEventSource eventSource)
        {
            this.eventSource = eventSource;
            if (eventSource != null)
            {
                eventSource.KeyPressed += eventSource_KeyPressed;
                eventSource.KeyReleased += eventSource_KeyReleased;
                eventSource.PointerMoved += eventSource_PointerMoved;
                eventSource.PointerPressed += eventSource_PointerPressed;
                eventSource.PointerReleased += eventSource_PointerReleased;
            }
        }

        void eventSource_PointerReleased(System.Drawing.Point obj)
        {
            if (eventListener != null)
                eventListener.pointerReleased(obj.X, obj.Y);
        }

        void eventSource_PointerPressed(System.Drawing.Point obj)
        {
            if (eventListener != null)
                eventListener.pointerPressed(obj.X, obj.Y);
        }

        void eventSource_PointerMoved(System.Drawing.Point obj)
        {
            if (eventListener != null)
                eventListener.pointerDragged(obj.X, obj.Y);
        }

        void eventSource_KeyReleased(int code)
        {
            if (eventListener != null)
                eventListener.keyReleased(code);
        }

        void eventSource_KeyPressed(int code)
        {
            if (eventListener != null)
                eventListener.keyPressed(code);
        }

        internal void SetEventListener(IEventListener eventListener)
        {
            this.eventListener = eventListener;
        }

    }
}
