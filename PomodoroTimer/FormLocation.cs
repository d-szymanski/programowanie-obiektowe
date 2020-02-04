using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PomodoroTimer
{
    class FormLocation
    {
        private Point mouseLocation;

        public void setMouseLocation(int x, int y)
        {
            mouseLocation.X = x;
            mouseLocation.Y = y;
        }

        public Point getNewFormLocationFromMousePosition(Point mousePosition)
        {
            mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
            return mousePosition;
        }
    }
}
