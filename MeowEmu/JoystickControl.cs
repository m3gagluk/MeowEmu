using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeowEmu
{
    public class JoystickControl : Control
    {
        private Graphics G = null;

        public float XValue = 0f;

        public float YValue = 0f;

        private static readonly SolidBrush BlackBrush = new SolidBrush(Color.Black);

        private static readonly int DotRadius = 4;

        public JoystickControl()
        {
            DoubleBuffered = true;
        }

        /// <summary>
        /// OnPaint event of the object.
        /// </summary>
        /// <param name=""e""></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            G = e.Graphics;
            G.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            DrawNode();
        }

        /// <summary>
        /// On resize event of the object.
        /// </summary>
        /// <param name=""e""></param>
        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            base.OnResize(e);
        }

        /// <summary>
        /// Draws a node control.
        /// </summary>
        protected void DrawNode()
        {
            G.DrawRectangle(Pens.DarkGray, 0, 0, Width-1, Height-1);
            G.FillEllipse(BlackBrush, (int)((XValue + 1f)/2 * Width - DotRadius), (int)((YValue + 1f)/2 * Height - DotRadius), DotRadius*2, DotRadius*2);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.None) return;
            XValue = ((float)e.X / Width)*2 - 1f;
            YValue = ((float)e.Y / Height)*2 - 1f;
            XValue = Math.Max(Math.Min(XValue, 1), -1);
            YValue = Math.Max(Math.Min(YValue, 1), -1);
            Invalidate();
        }
    }
}
