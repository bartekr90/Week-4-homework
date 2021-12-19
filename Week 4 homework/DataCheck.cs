using System;

namespace Week_4_homework
{
    static class DataCheck
    {
        /// <summary>
        /// Filters characters based on ASCII decimal values, can return empty string.
        /// </summary>
        /// <param name="length">Limit length of string</param>
        /// <param name="hide">Optional hiding of characters </param>
        /// <param name="info">Console info after presing ENTER</param>
        /// <returns></returns>
        public static string LetterValidation(int length = 25, bool hide = false, string info = "Accepted: ")
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            bool loop = true;
            char keySign;
            byte castSign;

            while (loop)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(hide);
                keySign = keyInfo.KeyChar;
                castSign = (byte)keySign;

                if (castSign == 27)
                    goto Clear;

                if (castSign == 8)
                    goto Remove;

                if (castSign == 13)
                    goto ReturnString;

                if (castSign == 45 || (castSign > 64 && castSign < 91) || (castSign > 96 && castSign < 123) || (castSign > 127 && castSign < 168))
                    goto Append;

                else
                    goto NotAppend;

                ReturnString:
                loop = false;
                PrintColorMessage(ConsoleColor.Green, ($"{info}"));                
                break;

            Append:
                if (sb.Length < length)
                {
                    sb.Append(keySign);
                }
                continue;

            NotAppend:
                continue;

            Remove:

                if (sb.Length > 0)
                    sb.Remove(sb.Length - 1, 1);
                continue;

            Clear:
                sb.Clear();
                Console.WriteLine();
                continue;
            }

            return sb.ToString();
        }
        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
