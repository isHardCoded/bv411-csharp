using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP {

    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();

        private Logger() { }

        public static Logger Instance { get { return instance; } }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger userLogger = Logger.Instance;
            userLogger.Log("Здесь мы логируем пользователей");

            Logger postsLogger = Logger.Instance;
            postsLogger.Log("А уже здесь мы логируем посты");

            Console.WriteLine(userLogger == postsLogger);


            Console.ReadKey();
        }
    }
}
