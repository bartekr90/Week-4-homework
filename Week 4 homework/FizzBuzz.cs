using System;

namespace Week_4_homework
{
    class FizzBuzz
    {
        public string GetOutPut(string value)
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
                break;
            }

            if (nr % 15 == 0)
                return "FizzBuzz";
            if (nr % 3 == 0)
                return "Fizz";
            if (nr % 5 == 0)
                return "Buzz";
            return value;
        }
        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
