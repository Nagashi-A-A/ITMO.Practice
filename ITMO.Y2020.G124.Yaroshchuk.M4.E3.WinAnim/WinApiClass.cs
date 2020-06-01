using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace AnimatedWindow
{
    public class WinApiClass
    {
        #region Window animation
        ///<summary>
        ///Type of window animation. Enumeration is returning int data type after input.
        ///There are personal int variable for every element
        ///</summary>
        [Flags]
        public enum AnimateWindowFlags:int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTER = 16,
            AW_HIDE = 65536,
            AW_ACTIVATE = 131072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288
        };
        ///<summary>
        ///Window animation
        ///</summary>
        ///<param name="hwnd">Window.</param>
        ///<param name="dwTime">Time.</param>
        ///<param name="dwFlags">Animation Type. If there is an Enumeration
        ///in the uncontrollable code, then it must be converted to the int data type.
        ///</param>
        ///<returns></returns>
        [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        ///<summary>
        ///Window animation
        ///</summary>
        ///<param name="ctrl">Window.</param>
        ///<param name="dwTime">Time.</param>
        ///<param name="Flags">Flags.</param>
        ///<returns></returns>
        public static bool AnimateWindow(Control ctrl, int dwTime, AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion
    }
}