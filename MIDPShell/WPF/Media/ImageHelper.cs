using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDP.WPF.Media
{
    public static class ImageHelper
    {
        [System.Runtime.InteropServices.DllImport("gdi32")]
        static extern int DeleteObject(System.IntPtr o);

        public static System.Windows.Media.Imaging.BitmapSource loadBitmap(System.Drawing.Bitmap source)
        {
            System.IntPtr ip = source.GetHbitmap();
            System.Windows.Media.Imaging.BitmapSource bs = null;
            try
            {
                bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip,
                   System.IntPtr.Zero, System.Windows.Int32Rect.Empty,
                   System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(ip);
            }

            return bs;
        }
    }
}
