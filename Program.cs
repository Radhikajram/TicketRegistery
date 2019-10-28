using System;
using System.Linq;

namespace TicketRegistery
{
    class Program
    {
       

        public static int TicketPrice;
       
        public static bool ExitFlag = true;

      
        static void Main(string[] args)
        {
           
            
            do
            {
                // Display Main menu Options
                int Option = Util.AskForInt("Option from Main Menu(1-Book Tickets,2-Repeat Ten times,3-The Third word :,4 Quit)");
              
                // Switch on cases. 
                switch (Option)
                {
                    // Book Tickets.Ticket price is derived upon input age.
                    case 1:
                        {
                            BookTicket();
                            break;
                        }
                     // Loop through the Input string and display for 10 times.
                      case 2:
                        {
                            PrintInputStringTenTimes();
                            break;
                        }
                    // Display only the last word of a sentence.
                    case 3:
                        {
                            printThirdStringOfSentence();
                            break;
                        }
                 
                    // Quit.
                    case 4:
                        {
                            ExitFlag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Option ");
                            break;

                        }
                }
            } while (ExitFlag);
        }
            static void BookTicket()
            {
                 bool ContinueFlag = true;
            Ticketdetails ticketdetails = new Ticketdetails();
            // Get Name and Age from Console.
            do
              {
                   
                      string name = Util.AskForString("Name: ");
                      int age = Util.AskForInt("Age: ");
                      Person person = new Person(name, age);
                     TicketPrice = person.getTicketPrice;

                // Add person to the List
                ticketdetails.addPerson(name, age, TicketPrice);
                // Want to add more person to the list
                string Continue = Util.AskForString("You wish to Add more person details(y/n): ");
                if (Continue == "n")
                {

                    Person[] people = ticketdetails.getPersonList();
                    int TotalTicketPrice = 0;
                    foreach (var ppl in people)
                    {

                        TotalTicketPrice += ppl.ticketPrice;

                        Console.WriteLine(ppl);
                    }
                    Console.WriteLine($"Total Ticket Price is {TotalTicketPrice}");
                    ContinueFlag = false;
                }
            } while (ContinueFlag);
        }

           static void PrintInputStringTenTimes()
            {
                 string Input = Util.AskForString("Enter your string here:");

            for (var i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.{Input} ");

            }
            Console.WriteLine();
          }

        static void printThirdStringOfSentence()
        {
            string InputString = Util.AskForString(" Type your sentence here: ");
            string[] words = InputString.Split(' ');
            Console.WriteLine($"The input string is {InputString}");

            if (words.Length >= 2)
            {
                Console.WriteLine($"The Third word of the string is {words[2]}");
            }
            else
            {
                Console.WriteLine("The sentence has just two words ");
            }
        }

      
    }
}
