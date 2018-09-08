using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter Start Date");
                var userResponse = Console.ReadLine();
                var date1 = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(
                    Convert.ToBoolean(
                        Regex.Escape($"(0[1 - 9] |[12][0 - 9] | 3[01])[- /.](0[1 - 9] | 1[012])[- /.](19 | 20)$)"))
                        ? "You entered a valid Date!"
                        : "Nice try! next time please do it right!");
                Console.ReadLine();
                Console.WriteLine("Enter End Date");
                Console.WriteLine(
                    Convert.ToBoolean(
                        Regex.Escape($"(0[1 - 9] |[12][0 - 9] | 3[01])[- /.](0[1 - 9] | 1[012])[- /.](19 | 20)$)"))
                        ? "You entered a valid Date!"
                        : "Nice try! next time please do it right!");
               

               var date2 = Convert.ToDateTime(Console.ReadLine());

                var dateDiff = Convert.ToInt32(date1 < date2 ? (date2 - date1).TotalDays : (date1 - date2).TotalDays);


                var hourDiff = dateDiff * 24;
                var minDiff = hourDiff * 60;
                Console.WriteLine(
                    $"The difference between the dates is {dateDiff} Days, or {hourDiff} Hours, or {minDiff} Minutes.");
                Console.ReadKey();
                Console.WriteLine("Would you like to try again? Type Y or N.");


                switch (userResponse)
                {
                    case "Y":
                    case "y":
                        break;
                    case "N":
                    case "n":
                        break;
                }
            }
        }
    }
}
        