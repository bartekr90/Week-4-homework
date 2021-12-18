using System;

namespace Week_4_homework
{
    static class Make
    {
        public static bool IsItEven(string value)
        {
            int nr;
            while (true)
            {
                if (!int.TryParse(value, out nr))
                {
                    PrintColorMessage(ConsoleColor.Red, "Podaj liczbe całkowitą!");
                    Console.WriteLine();
                    value = Console.ReadLine();
                    continue;
                }
            return (nr % 2 == 0);
            }
        }

        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
