using System;
using System.Timers;

namespace PomodoroTimer
{
    class PomodoroTimer
    {
        private PomodoroTime pomodoroTime;
        private Timer timer;


        public PomodoroTimer(int _seconds)
        {
            pomodoroTime = new PomodoroTime(_seconds);
            initTimer();
        }

        public PomodoroTimer()
        {
            pomodoroTime = new PomodoroTime();
            initTimer();
        }

        private void initTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += onTimedEvent;
        }

        private void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            pomodoroTime.decrement();
        }

        public bool getIsRunning()
        {
            return timer.Enabled;
        }

        public void start() { startTimer(); }
        private void startTimer()
        {
            timer.Enabled = true;
        }

        public void stop() { stopTimer(); }
        private void stopTimer()
        {
            timer.Enabled = false;
        }

        public void reset()
        {
            stopTimer();
            resetPomodoroTime();
        }
        private void resetPomodoroTime()
        {
            pomodoroTime.reset();
        }

        public string getPomodoroTimer()
        {
            return string.Format("{0}:{1}", pomodoroTime.getMinutesString(), pomodoroTime.getSecondsString());
        }
    }
}
