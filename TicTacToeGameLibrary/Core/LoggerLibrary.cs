using System.IO;
using System.Reflection;

namespace TicTacToeGameLibrary.Core
{
    public static class LoggerLibrary
    {
        public static void LoggerWrite(string message)
        {
            try
            {
                string executableFilePath = Assembly.GetExecutingAssembly().Location;
                string workPath = Path.GetDirectoryName(executableFilePath);
                string settingsLoggerFilePath = Path.Combine(workPath, "Logger");

                if (!File.Exists(settingsLoggerFilePath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(settingsLoggerFilePath);                     
                }

                using StreamWriter sw = File.AppendText(Path.Combine(settingsLoggerFilePath, "Logs.txt"));
                sw.WriteLine($"{DateTime.Now} => {message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
