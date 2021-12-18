using System;

namespace Week_4_homework
{
    class Fizz_Buzz
    {
        private string _Fizz { get; }
        private string _Buzz { get; }
        public Fizz_Buzz()
        {
            _Fizz = "Fizz";
            _Buzz = "Buzz";
        }
        public string FizzBuzz(string value)
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
            string fibu = "";
            if (nr % 3 == 0)
                fibu += _Fizz;
            if (nr % 5 == 0)
                fibu += _Buzz;
            if (String.IsNullOrEmpty(fibu) || (nr == 0))
                fibu = value;

            return fibu;
        }
        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
