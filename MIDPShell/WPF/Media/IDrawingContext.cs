using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.Media
{
    interface IDrawingContext
    {

        System.Windows.FrameworkElement WPFControl { get; }
        int Width { get; }
        int Height { get; }
        javax.microedition.lcdui.Graphics CreateGraphics();

        void ServiceRepaints();
        void Repaint();
    }
}
