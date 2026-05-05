using System;
using System.Collections.Generic;
using System.Text;

namespace Veteriner_Otomasyonu
{
    public class LogManager
    {
        private string logFilePath = Path.Combine(Application.StartupPath, "Logs"); // Log dosyasının yolu 
        public LogManager()
        {
            if (!Directory.Exists(logFilePath))
            {
                Directory.CreateDirectory(logFilePath);
            }
        }

        public void LogYaz(string who, string what, string process)
        {
            try
            {
                string fileName = $"Log_{DateTime.Now:yyyy_MM_dd}.txt";
                string logPath = Path.Combine(logFilePath, fileName);

                string logEntry = $"{DateTime.Now:G} - {who} - {what} - {process}";

                using (StreamWriter sw = File.AppendText(logPath))
                {
                    sw.WriteLine(logEntry);
                }
            }
            catch (Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine("Log yazılamadı: " + ex.Message);
            }
        }
    }
}
