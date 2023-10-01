using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.ViewModels
{
    public interface IEventListener
    {

        void keyPressed(int keyCode);
        void keyReleased(int keyCode);
        void pointerDragged(int x, int y);        
        void pointerPressed(int x, int y);        
        void pointerReleased(int x, int y);
    }
}
