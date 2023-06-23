using System.ComponentModel;

namespace Lec04LibN
{
    public interface ILogger
    {
        void start(
            string title
            );
        void log(
            string message
            );
        void stop();
    }
    public partial class Logger : ILogger
    {
        private readonly string LogFileName
                                    = string.Format(@"{0}\LOG{1}.txt", 
                                      Directory.GetCurrentDirectory(),
                                      DateTime.Now.ToString("yyyyMMdd-HH-mm-ss"));
        private int NumberLine = 0;

        private static Logger Instance;
        private string Title = "";
        private StreamWriter writter;
        private Logger() 
        {
            writter = new StreamWriter(LogFileName);
        }

        public void log(
            string message = ""
            )
        {
            writter.WriteLine(Formatter("INFO") + message);
            NumberLine++;
            writter.Flush();
        }
        public static ILogger create()
        {
            if (Instance == null)
            {
                Instance = new Logger();
                Instance.writter.WriteLine(Instance.Formatter("INIT"));
            }
            return Instance;
        }
        public void start(
            string title 
            )
        {
            Title += title + ":";
            writter.WriteLine(Formatter("STRT"));
            writter.Flush();
        }
        public void stop()
        {
            Title = Title.Remove(Title.Length - 2);
            writter.WriteLine(Formatter("STOP"));
            writter.Flush();
        }
        private string Formatter(string type)
        {
            string result = $"{NumberLine.ToString("000000")}-{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}-";
            result += $"{type} {Title} ";
            return result;
        }
    }
}