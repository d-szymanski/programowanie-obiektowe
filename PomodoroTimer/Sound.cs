using System.Media;

namespace PomodoroTimer
{
    class Sound
    {
        public static void playAsteriskSound()
        {
            SystemSounds.Asterisk.Play();
        }

        public static void playC()
        {
            SystemSounds.Hand.Play();
        }
    }
}
