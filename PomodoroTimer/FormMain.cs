using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class FormMain : Form
    {
        FormLocation formLocation = new FormLocation();

        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formLocation.setMouseLocation(-e.X, -e.Y);
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = formLocation.getNewFormLocationFromMousePosition(MousePosition);
            }
        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
