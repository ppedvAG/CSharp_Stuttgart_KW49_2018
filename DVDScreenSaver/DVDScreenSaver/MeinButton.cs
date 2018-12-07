using System;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;

namespace DVDScreenSaver
{
    delegate void TripleClickEventHandler(object sender, int clickCount);

    class MeinButton : Button
    {
        public event TripleClickEventHandler TripleClick;
        
        int clicks = 0;
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            
            clicks++;
            if (clicks % 3 == 0)
                OnTripleClick(clicks);
        }

        protected virtual void OnTripleClick(int clickCount)
        {
            TripleClick(this, clicks);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {

            //base.OnPaint(pevent);

            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);

            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pevent.Graphics.FillEllipse(new SolidBrush(BackColor), ClientRectangle);

            var sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            pevent.Graphics.DrawString("DVD", SystemFonts.DefaultFont, Brushes.Black, ClientRectangle, sf);

        }
    }

    class MeinButton2 : MeinButton
    {
        protected override void OnTripleClick(int clickCount)
        {
            base.OnTripleClick(clickCount);
        }
    }
}