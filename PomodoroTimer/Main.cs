using System;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class Main : Form
    {

        private FormLocation formLocation = new FormLocation();
        private Timer formRefreshTimer;
        private PomodoroTimer pomodoroTimer = new PomodoroTimer();
        private ColorTransition colorTransition = new ColorTransition(true);
        private LogWriter logWriter = new LogWriter("PomodoroTimer started");
        public Main()
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
            if (pomodoroTimer.isBreakTime)
            {
                if (pomodoroTimer.getIsRunning())
                {

                    BackColor = colorTransition.getGreenColor();
                }
                else
                {
                    BackColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                if (pomodoroTimer.getIsRunning())
                {
                    BackColor = colorTransition.getRedColor();
                }
                else
                {
                    BackColor = System.Drawing.Color.DarkRed;

                }
            }
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
                logWriter.LogWrite("Started");
            }
            else
            {
                pomodoroTimer.stop();
                logWriter.LogWrite("Stoped");
            }
        }

        private void resetPomodoroTimer()
        {
            if (pomodoroTimer.getIsRunning())
            {
                pomodoroTimer.stop();
                logWriter.LogWrite("Stoped");
            }
            pomodoroTimer.reset();
            logWriter.LogWrite("Restarted");
        }
    }
}
