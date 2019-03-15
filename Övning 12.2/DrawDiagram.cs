using System.Drawing;

namespace Övning_12._2
{
    class DrawDiagram
    {

        public DrawDiagram()
        {

        }

        public void Paint (int[] values, int maxValue, Graphics g)
        {
            int baseY = 50;
            g.DrawLine(Pens.Black, baseY, baseY, baseY, baseY + 2 + 2*maxValue);
            g.DrawLine(Pens.Black, baseY, baseY + 2 + 2*maxValue, baseY + 2* values.Length + 2, baseY + 2 + 2*maxValue);


            int xCoord = baseY + 1;
            int YBase = baseY + 2 + 2*maxValue;
            for (int i = 0; i < values.Length; i++)
            {
                g.DrawRectangle(Pens.Red, xCoord, YBase - 2*values[i], 1, 1);
                xCoord += 2;
            }
        }
    }
}
