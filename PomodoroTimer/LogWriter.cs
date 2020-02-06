using System;
using System.IO;
using System.Reflection;

namespace PomodoroTimer
{
    class LogWriter
    {
        private string path = string.Empty;
        public LogWriter(string logMessage)
        {
            LogWrite(logMessage);
        }
        public void LogWrite(string logMessage)
        {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(path + "\\" + "pomodoro-log.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
