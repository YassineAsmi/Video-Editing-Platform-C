using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VideoEditingPlatform
{
    public class GradientColor :Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }
        public Color LeftColor { get; set; }
        public Color RightColor { get; set; }
        public float Angle { get; set; }
        public Color CenterColor { get; private set; }
        public Color[] SurroundColos { get; private set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var colorArray = new Color[] { TopColor, BottomColor,LeftColor,RightColor };
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(this.ClientRectangle);
            Graphics graphics = e.Graphics;
            using (PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath)
            {
                CenterColor = Color.FromArgb((int)colorArray.Average(a => a.R), (int)colorArray.Average(a => a.G), (int)colorArray.Average(a => a.B)),
                    SurroundColors = colorArray
            })
            {
                graphics.FillPath(pathGradientBrush, graphicsPath);
            }
        }
    


    }
}
