using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.ViewModels
{
    public interface IEventSource
    {
        event Action<int> KeyPressed;
        event Action<int> KeyReleased;
        event Action<Point> PointerMoved;
        event Action<Point> PointerPressed;
        event Action<Point> PointerReleased;
    }
}
