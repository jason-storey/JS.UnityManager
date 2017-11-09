using System;
using System.Windows.Forms;

namespace JS.UnityManager
{
    public partial class PassPanel : Panel
    {
        public PassPanel()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int WM_MOUSEHOVER = 0x02A1;
            const int HTTRANSPARENT = (-1);

            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEHOVER)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
