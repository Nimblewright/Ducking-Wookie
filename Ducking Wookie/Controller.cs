using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ducking_Wookie
{
    static class Controller
    {
        public static void nextPhoto()
        {
            SendKeys.Send("{RIGHT}");
        }

        public static void previousPhoto()
        {
            SendKeys.Send("{LEFT}");
        }

        public static void rotateLeft()
        {
            SendKeys.Send("^{,}");
        }

        public static void rotateRight()
        {
            SendKeys.Send("^{.}");
        }

        public static void zoomIn()
        {
            SendKeys.Send("{+}");
        }

        public static void zoomOut()
        {
            SendKeys.Send("{-}");
        }

    }
}
