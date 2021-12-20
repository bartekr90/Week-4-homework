using System;

namespace Week_4_homework
{
    class Person
    {
        private DateTime _ageOfPerson;
        private string _nameOfPerson;
        private string _placeOfbirth;

        /// <summary>
        /// Creates new user.
        /// </summary>
        public Person()
        {
            PersonSetup();
        }

        private void PersonSetup()
        {
            Console.WriteLine("Podaj swoje imię (ograniczenia: max 20 znaków, tylko liery i znak '-'): ");
            string name;
            do
            {
                name = DataCheck.LetterValidation(20);
                if (String.IsNullOrEmpty(name))
                    PrintColorMessage(ConsoleColor.Red, "Nie podano imienia!");
            } while (String.IsNullOrEmpty(name));

            Console.WriteLine(name);

            Console.WriteLine("Podaj miejsce urodzenia (ograniczenia: max 20 znaków, tylko liery i znak '-'): ");
            string place;
            do
            {
                place = DataCheck.LetterValidation(20);
                if (String.IsNullOrEmpty(place))
                    PrintColorMessage(ConsoleColor.Red, "Nie podano miejsca!");
            } while (String.IsNullOrEmpty(place));

            Console.WriteLine(place);

            Console.WriteLine("Podaj miesiąc swoich urodzin (wartości z przedziału 1-12): ");
            int month = DateValidation(Console.ReadLine(), 1, 12);

            var currentYear = DateTime.Now.Year;
            Console.WriteLine("Podaj rok swoich urodzin (dopuszczalny wiek od 4 do 120 lat): ");
            int year = DateValidation(Console.ReadLine(), (currentYear - 120), (currentYear - 4));

            Console.WriteLine($"Podaj dzień miesiąca swoich urodzin (wartości od 1 do {DateTime.DaysInMonth(year, month)}: ");
            int day = DateValidation(Console.ReadLine(), 1, DateTime.DaysInMonth(year, month));

            _nameOfPerson = name;
            _placeOfbirth = place;
            _ageOfPerson = new DateTime(year, month, day);
        }

        public void PersonIntro()
        {
            var age = DateTime.Now.Year - _ageOfPerson.Year;
            if (DateTime.Now.DayOfYear < _ageOfPerson.DayOfYear)
                age--;

            Console.Write("Cześć ");
            PrintColorMessage(ConsoleColor.Blue, _nameOfPerson);
            Console.Write(", urodziłeś się w ");
            PrintColorMessage(ConsoleColor.DarkGreen, _placeOfbirth);
            Console.Write(", Twoja data urodzin: ");
            PrintColorMessage(ConsoleColor.DarkRed, $"{_ageOfPerson.Date}");
            Console.Write(", a Twój wiek to: ");
            PrintColorMessage(ConsoleColor.DarkYellow, $"{age}");
            Console.WriteLine();
        }

        private static int DateValidation(string value, int min, int max)
        {
            while (true)
            {
                if (!int.TryParse(value, out int nr))
                {
                    Console.WriteLine("błędna data urodzenia, podana wartość prawdopodobnie nie jest liczbą");
                    value = Console.ReadLine();
                    continue;
                }
                if ((nr < min) || (nr > max))
                {
                    Console.WriteLine("Wiek nie spełnia wymagań, wartości są spoza zakresu");
                    value = Console.ReadLine();
                    continue;
                }
                return nr;
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
