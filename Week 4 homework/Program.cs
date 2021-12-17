using System;

namespace Week_4_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }
        private static string InputLimitation()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            bool loop = true;
            while (loop)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); // won't show up in console
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            loop = false;
                            Console.WriteLine();
                            break;
                        }
                    default:
                        {
                            if (sb.Length < 25)
                            {
                                sb.Append(keyInfo.KeyChar);
                                Console.Write(keyInfo.KeyChar);
                            }
                            break;
                        }
                }
            }
            return sb.ToString();
        }

    }
}
