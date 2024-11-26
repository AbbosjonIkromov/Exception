using System;
namespace Exception1
{
    public class Logger
    {

        public static void LogError(string code, string message)
        {
            Console.Write($"[{DateTime.Now.ToString("hh:mm:ss")} ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ERR ] ");
            Console.ResetColor();
            Console.Write($"{code}: {message}\n");
        }
    }
}