using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MeowEmu
{
    public partial class Form1 : Form
    {
        private static int port = 12345;
        private static UdpClient client = new UdpClient();
        private MeowFaceData buffer = new MeowFaceData();
        private static readonly float radianConst = 0.0174533f;
        public Form1()
        {
            Application.AddMessageFilter(new MouseMessageFilter());
            MouseMessageFilter.MouseMove += new MouseEventHandler(OnMouseMove);
            InitializeComponent();
            client = new UdpClient();
            SendTimer.Start();
            Jaw.YValue = -1; // close the jaw
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FillBuffer();
            var bytes = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(buffer));
            client.Send(bytes, bytes.Length, "127.0.0.1", port);
        }


        private void FillBuffer()
        {
            buffer.EyeLeft.x = LeftEye.YValue / radianConst;
            buffer.EyeLeft.y = LeftEye.XValue / radianConst;
            buffer.BlendShapes[(int)MeowShapeType.eyeBlinkLeft].v = 1 - LeftOpenness.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.eyeSquintLeft].v = LeftSquinted.Checked ? 1 : 0;
            buffer.BlendShapes[(int)MeowShapeType.eyeWideLeft].v = LeftWidened.Checked ? 1 : 0;
            buffer.BlendShapes[(int)MeowShapeType.browOuterUpLeft].v = BrowOuterUpLeft.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.browDownLeft].v = 1f - BrowDownLeft.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.browInnerUpLeft].v = BrowInnerUpLeft.Value / 10f;


            buffer.EyeRight.x = RightEye.YValue / radianConst;
            buffer.EyeRight.y = RightEye.XValue / radianConst;
            buffer.BlendShapes[(int)MeowShapeType.eyeBlinkRight].v = 1 - RightOpenness.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.eyeSquintRight].v = RightSquinted.Checked ? 1 : 0;
            buffer.BlendShapes[(int)MeowShapeType.eyeWideRight].v = RightWidened.Checked ? 1 : 0;
            buffer.BlendShapes[(int)MeowShapeType.browOuterUpRight].v = BrowOuterUpRight.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.browDownRight].v = 1f - BrowDownRight.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.browInnerUpRight].v = BrowInnerUpRight.Value / 10f;

            buffer.BlendShapes[(int)MeowShapeType.jawOpen].v = (Jaw.YValue + 1) / 2;
            buffer.BlendShapes[(int)MeowShapeType.jawLeft].v = Math.Max(0, -Jaw.XValue);
            buffer.BlendShapes[(int)MeowShapeType.jawRight].v = Math.Max(0, Jaw.XValue);

            buffer.BlendShapes[(int)MeowShapeType.noseSneerLeft].v = NoseSneerLeft.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.noseSneerRight].v = NoseSneerRight.Value / 10f;


            buffer.BlendShapes[(int)MeowShapeType.mouthSmileLeft].v = Math.Max(0, SmileFrownLeft.Value / 10f);
            buffer.BlendShapes[(int)MeowShapeType.mouthFrownLeft].v = Math.Max(0, -SmileFrownLeft.Value / 10f);
            buffer.BlendShapes[(int)MeowShapeType.mouthSmileRight].v = Math.Max(0, SmileFrownRight.Value / 10f);
            buffer.BlendShapes[(int)MeowShapeType.mouthFrownRight].v = Math.Max(0, -SmileFrownRight.Value / 10f);
            // cheek puff isn't used by the module in the first place
            // buffer.BlendShapes[(int)MeowShapeType.cheekPuff].v = CheekPuff.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.mouthRollUpper].v = 1 - MouthRollUpper.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.mouthRollLower].v = MouthRollLower.Value / 10f;

            buffer.BlendShapes[(int)MeowShapeType.mouthLeft].v = Math.Max(0, -MouthLeftRight.Value / 10f);
            buffer.BlendShapes[(int)MeowShapeType.mouthRight].v = Math.Max(0, MouthLeftRight.Value / 10f);
            buffer.BlendShapes[(int)MeowShapeType.mouthUpperUpLeft].v = Math.Max(0, -MouthLRUpper.YValue) * Math.Max(0, -MouthLRUpper.XValue);
            buffer.BlendShapes[(int)MeowShapeType.mouthUpperUpRight].v = Math.Max(0, -MouthLRUpper.YValue) * Math.Max(0, MouthLRUpper.XValue);
            buffer.BlendShapes[(int)MeowShapeType.mouthLowerDownLeft].v = Math.Max(0, MouthLRUpper.YValue) * Math.Max(0, -MouthLRUpper.XValue);
            buffer.BlendShapes[(int)MeowShapeType.mouthLowerDownRight].v = Math.Max(0, MouthLRUpper.YValue) * Math.Max(0, MouthLRUpper.XValue);
            buffer.BlendShapes[(int)MeowShapeType.mouthShrugUpper].v = Math.Max(0, MouthLRUpper.YValue);


            buffer.BlendShapes[(int)MeowShapeType.mouthPucker].v = MouthPucker.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.mouthFunnel].v = MouthFunnel.Value / 10f;
            buffer.BlendShapes[(int)MeowShapeType.tongueOut].v = TongueOut.Value / 10f;

        }

        void OnMouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
            p.Y -= Top;
            p.X -= Left;
            p.Y -= 31; // aaaa hardcoded win10 title bar height
            Control c = FindControlAtPoint(this, p);
            if (c == null) return;
            CurrentElementBox.Text = c.Name;
        }
        public static Control FindControlAtPoint(Control container, Point pos)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                if (c.Visible && c.Bounds.Contains(pos))
                {
                    child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
                    if (child == null) return c;
                    else return child;
                }
            }
            return null;
        }

    }
    class MouseMessageFilter : IMessageFilter
    {
        public static event MouseEventHandler MouseMove = delegate { };
        const int WM_MOUSEMOVE = 0x0200;

        public bool PreFilterMessage(ref Message m)
        {

            if (m.Msg == WM_MOUSEMOVE)
            {
                Point mousePosition = Control.MousePosition;
                MouseMove(null, new MouseEventArgs(
                    MouseButtons.None, 0, mousePosition.X, mousePosition.Y, 0));
            }
            return false;
        }
    }
}
