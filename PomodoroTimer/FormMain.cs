using System;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class FormMain : Form
    {
        private FormLocation formLocation = new FormLocation();
        private Timer formRefreshTimer;
        private PomodoroTimer pomodoroTimer = new PomodoroTimer();


        public FormMain()
        {
            InitializeComponent();
            initFormRefreshTimer();
        }

        private void initFormRefreshTimer()
        {
            formRefreshTimer = new Timer();
            formRefreshTimer.Interval = 25;
            formRefreshTimer.Tick += new EventHandler(refreshForm);
            formRefreshTimer.Enabled = true;
        }

        private void refreshForm(Object myObject, EventArgs myEventArgs)
        {
            LabelTimer.Text = pomodoroTimer.getPomodoroTimer();
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

        private void Timer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                togglePomodoroTimer();
            }
            else if (e.Button == MouseButtons.Right)
            {
                resetPomodoroTimer();
            }
        }

        private void togglePomodoroTimer()
        {
            if (!pomodoroTimer.getIsRunning())
            {
                pomodoroTimer.start();
            }
            else
            {
                pomodoroTimer.stop();
            }
        }
        private void resetPomodoroTimer()
        {
            if (pomodoroTimer.getIsRunning())
            {
                pomodoroTimer.stop();
            }
            pomodoroTimer.reset();
        }
    }
}
