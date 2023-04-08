using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsFillDrawExtMethod
{
    static class ExtensionMethods
    {
        public static void FillPlusSign(this Graphics graphics, Brush brush, RectangleF rect, float thickness)
        {
            float smallestDim = (rect.Width < rect.Height) ? rect.Width : rect.Height;

            // Draw vertical rectangle
            //float x = rect.X + rect.Width / 2 - thickness / 2;
            float x = rect.X + smallestDim / 2 - thickness / 2;
            //graphics.FillRectangle(brush, x, rect.Y, thickness, rect.Height);
            graphics.FillRectangle(brush, x, rect.Y, thickness, smallestDim);

            // Draw horizontal rectangle
            //float y = rect.Y + rect.Height / 2 - thickness / 2;
            float y = rect.Y + smallestDim / 2 - thickness / 2;
            //graphics.FillRectangle(brush, rect.X, y, rect.Width, thickness);
            graphics.FillRectangle(brush, rect.X, y, smallestDim, thickness);
        }
    }
}
