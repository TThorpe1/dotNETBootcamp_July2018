using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of Employees 

            List<Employee> employees = new List<Employee>();

            // used to add new employees to the list 
            while (true)
            {
                Employee temp = new Employee();
                Console.WriteLine("Please provide the First Name:");
                temp.FirstName = Console.ReadLine();

                Console.WriteLine("Please provide the Last Name:");
                temp.LastName = Console.ReadLine();

                Console.WriteLine("Please provide the SSN:");
                temp.SSN = Console.ReadLine();

                Console.WriteLine("Please provide the Salary:");
                temp.Salary = float.Parse(Console.ReadLine());

                employees.Add(temp);// add the temp object to the employees list 

                Console.WriteLine("Do you want to add more employees?");
                string choice = Console.ReadLine();
                if (choice == "N")
                    break;  
            }

            foreach (Employee e in employees)
            {

                Console.WriteLine($"{e.FirstName} {e.LastName}");
                Console.WriteLine("===================");
            }

            //for (int i = 0; i < employees.Count; i++)
            //{
            //    Console.WriteLine($"{employees[i].FirstName} {employees[i].LastName}");
            //    Console.WriteLine("===================");
            //}


            //Employee john = new Employee();// object 

            //john.FirstName = "John";// set

            //Console.WriteLine(john.FirstName);//get 

            //john.Salary = 50000;// set 

            //john.Salary = john.Salary + 1000; // get then a set 

            //Console.WriteLine(john.SSN);// blank 


            






        }
    }
}
