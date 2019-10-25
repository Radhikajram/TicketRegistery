using System;
using System.Collections.Generic;
using System.Text;

namespace TicketRegistery
{
    public static class Util
    {
        internal static string AskForString(string prompt)
        {
            bool correct = true;
            string answer;

            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (!string.IsNullOrEmpty(answer))
                {
                    correct = false;
                }

            } while (correct);
            return answer;
        }

        internal static int AskForInt(string number)
        {
            bool isOk;
            int answer;

            do
            {
                string input = AskForString(number);
                isOk = int.TryParse(input, out answer);

                if (!isOk)
                {
                    Console.WriteLine("Wrong format input number");
                }

            } while (!isOk);

            return answer;
        }
    }
}
