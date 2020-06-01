using AnimatedWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.G124.Yaroshchuk.M4.E3.WinAnim
{
    public partial class AniMainForm : Form
    {
        public AniMainForm()
        {
            InitializeComponent();
        }

        private void btnAwBlend_Click(object sender, EventArgs e)
        {
            //Hide Window
            this.Hide();

            //Start animation. Second param in () - time of animations in ml. seconds.
            WinApiClass.AnimateWindow(this, 3000, WinApiClass.AnimateWindowFlags.AW_ACTIVATE | WinApiClass.AnimateWindowFlags.AW_BLEND);
            
            // Show button after animation.
            this.btnAwBlend.Invalidate();
            this.btnHorAwSlide.Invalidate();
            this.btnCenterAwSlide.Invalidate();
        }

        private void btnHorAwSlide_Click(object sender, EventArgs e)
        {
            this.Hide();

            WinApiClass.AnimateWindow(this, 3000, WinApiClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinApiClass.AnimateWindowFlags.AW_SLIDE);

            this.btnAwBlend.Invalidate();
            this.btnHorAwSlide.Invalidate();
            this.btnCenterAwSlide.Invalidate();
        }

        private void btnCenterAwSlide_Click(object sender, EventArgs e)
        {
            this.Hide();

            WinApiClass.AnimateWindow(this, 3000, WinApiClass.AnimateWindowFlags.AW_CENTER | WinApiClass.AnimateWindowFlags.AW_SLIDE);

            this.btnAwBlend.Invalidate();
            this.btnHorAwSlide.Invalidate();
            this.btnCenterAwSlide.Invalidate();
        }
    }
}
