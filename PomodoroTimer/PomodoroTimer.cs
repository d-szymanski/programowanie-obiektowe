using System;
using System.Timers;

namespace PomodoroTimer
{
    class PomodoroTimer : SecondsCounter
    {
        private Timer timer;
        public bool isBreakTime { get; private set; } = false;
        static readonly int POMODORO_TIME = 25 * 60;
        static readonly int BREAK_TIME = 5 * 60;

        public PomodoroTimer() : base(POMODORO_TIME)
        {
            initTimer();
        }

        private void initTimer()
        {
            timer = new Timer();
            timer.Interval = 10; // default 1000.
            timer.AutoReset = true;
            timer.Elapsed += onTimedEvent;
        }

        private void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (count == 0)
            {
                toggleMode();
                Sound.playAsteriskSound();
            }
            decrement();
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
            Sound.playC();
            stopTimer();
            if (isBreakTime)
            {
                toggleMode();
            }
            else
            {
                resetPomodoroTime();
            }
        }

        private void resetPomodoroTime()
        {
            resetCounter();
        }

        private void toggleMode()
        {
            isBreakTime = !isBreakTime;
            setCount(getNewMaxCount(isBreakTime));
        }

        private int getNewMaxCount(bool isBreakMode)
        {
            return isBreakMode ? BREAK_TIME : POMODORO_TIME;
        }

        public string getPomodoroTimer()
        {
            return string.Format("{0}:{1}", getMinutesString(), getSecondsString());
        }
    }
}
