using System;

namespace Week_4_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FizzBuzz fiz1 = new FizzBuzz();
                while (true)
                {
                    Console.WriteLine($"{DateTime.Now}");
                    GetAppInfo();
                    Console.WriteLine("Wybierz opcję z menu poprzez wciśnięcie odpowiedniej cyfry: ");
                    Console.WriteLine("\t[1] - Sprawdzanie czy lizba jest parzysta");
                    Console.WriteLine("\t[2] - Graz FizzBizz");
                    Console.WriteLine("\t[3] - Dodanie swoich danych");
                    Console.WriteLine("\t[4] - Zakończ");
                    string menu = Console.ReadLine();
                    switch (menu)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę całkowitą");
                            Console.WriteLine(Make.IsItEven(Console.ReadLine()));
                            Console.Read();
                            Console.Clear();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Podaj liczbę całkowitą");
                            Console.WriteLine(fiz1.GetOutPut(Console.ReadLine()));
                            Console.Read();
                            Console.Clear();
                            break;
                        case "3":
                            Person person = new Person();
                            Console.Clear();
                            person.PersonIntro();
                            Console.Read();
                            Console.Clear();
                            break;
                        case "4":
                            PrintColorMessage(ConsoleColor.Red, "KONIEC PROGRAMU");
                            return;
                        default:
                            break;
                    }
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Wystąpił błąd danych: " + ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }

        static void GetAppInfo()
        {
            string appName = "Sprawdzanie liczb FizzBuzz";
            int appVersion = 2;
            string appAutor = "Bartosz Rachwał";
            PrintColorMessage(ConsoleColor.Magenta, $"[{appName}] Werjsa 0.0.{appVersion}, Autor: {appAutor}");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }



    }


}
