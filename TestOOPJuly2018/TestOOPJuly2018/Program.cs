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
            Teacher t1 = new Teacher("David", "Wolverton", 700000, "122-12-1212", 2000);

           // t1.PrintInfo();

            Employee e1 = new Employee("Adam", "David", 50000, "332-33-3323");

            Manager m1 = new Manager("Charlene", "Donelson", 50000, "434-44-4434", 10);




            List<Employee> gcList = new List<Employee>() { t1,e1,m1};

            foreach (Employee emp in gcList)
            {
                emp.PrintInfo();
            }


            //// List of Employees 

            //List<Employee> employees = new List<Employee>();

            //Employee s1 = new Employee("Damien", "Rocchi", 1500000, "455-55-6655");
            //employees.Add(s1);

            //// if you have no constructor
            //Employee s2 = new Employee();
            //s2.FirstName = "Damien";
            //s2.LastName = "Rocchi";
            //s2.Salary = 1500000;
            //s2.SSN = "455-55-6655";



            //// used to add new employees to the list 
            //while (true)
            //{
            //    Console.WriteLine("Please provide the First Name:");
            //    string FirstName = Console.ReadLine();

            //    Console.WriteLine("Please provide the Last Name:");
            //    string LastName = Console.ReadLine();

            //    Console.WriteLine("Please provide the SSN:");
            //    string SSN = Console.ReadLine();

            //    Console.WriteLine("Please provide the Salary:");
            //    float Salary = float.Parse(Console.ReadLine());

            //    Employee temp = new Employee(FirstName,LastName,Salary,SSN);

            //    employees.Add(temp);// add the temp object to the employees list 

            //    Console.WriteLine("Do you want to add more employees?");
            //    string choice = Console.ReadLine();
            //    if (choice == "N")
            //        break;  
            //}

            //foreach (Employee e in employees)
            //{

            //    Console.WriteLine($"{e.FirstName} {e.LastName}");
            //    Console.WriteLine("===================");
            //}

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
