namespace PomodoroTimer
{
    class SecondsCounter
    {
        protected int count { get; private set; }
        private int initialCount;

        public SecondsCounter(int _seconds)
        {
            setCount(_seconds);
        }

        protected void setCount(int _count)
        {
            count = _count;
            initialCount = _count;
        }

        private int getSeconds()
        {
            return count % 60;
        }

        public string getSecondsString()
        {
            int num = getSeconds();
            string prefix = num < 10 ? "0" : "";
            return prefix + num.ToString();
        }

        private int getMinutes()
        {
            return ((count - getSeconds()) / 60) % 60;
        }

        public string getMinutesString()
        {
            int num = getMinutes();
            string prefix = num < 10 ? "0" : "";
            return prefix + num.ToString();
        }

        public void decrement()
        {
            if (count > 0)
            {
                count--;
            }
        }

        public void resetCounter()
        {
            count = initialCount;
        }
    }
}
