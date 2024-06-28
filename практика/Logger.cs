using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика
{
    internal class Logger
    {
        public static void Log(string message)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logFilePath = Path.Combine(desktopPath, "Message.log");

            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                string logEntry = $"[{DateTime.Now}] {message}";
                writer.WriteLine(logEntry);
            }
        }
    }
}
