namespace PomodoroTimer
{
    class PomodoroTime
    {
        private int seconds;
        static readonly int POMODORO_TIME = 60 * 25;

        public PomodoroTime(int _seconds)
        {
            seconds = _seconds;
        }

        public PomodoroTime() : this(POMODORO_TIME) { }

        public int getTime()
        {
            return seconds;
        }

        private int getSeconds()
        {
            return seconds % 60;
        }

        public string getSecondsString()
        {
            int num = getSeconds();
            string prefix = num < 10 ? "0" : "";
            return prefix + num.ToString();
        }

        private int getMinutes()
        {
            return ((seconds - getSeconds()) / 60) % 60;
        }

        public string getMinutesString()
        {
            int num = getMinutes();
            string prefix = num < 10 ? "0" : "";
            return prefix + num.ToString();
        }

        public void increment()
        {
            if (seconds < POMODORO_TIME)
            {
                seconds++;
            }
        }

        public void decrement()
        {
            if (seconds > 0)
            {
                seconds--;
            }
        }

        public void reset()
        {
            seconds = POMODORO_TIME;
        }
    }
}
