using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace Bank_App
{
    class ElipsButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            base.OnPaint(pevent);
        }

    }
}
