using System.Drawing;
using System.Windows.Forms;

namespace DVDScreenSaver
{
    class MeinButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);

            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);

            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pevent.Graphics.FillEllipse(new SolidBrush(BackColor), ClientRectangle);

            var sf = new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center };
            pevent.Graphics.DrawString("DVD", SystemFonts.DefaultFont, Brushes.Black, ClientRectangle,sf);

        }
    }
}