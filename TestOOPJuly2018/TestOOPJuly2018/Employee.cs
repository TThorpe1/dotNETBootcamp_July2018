using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestOOPJuly2018
{
    class Employee
    {
        #region Fields
        // Fields to represent the data (private), camelCase 
        private string firstName;
        private string lastName;
        private float salary;
        private string ssn;
        #endregion

        #region Properties
        // Properties to protect the fields + validation (Regex)
        // PascalCase 
        public string FirstName
        {
            set { firstName = value;  }
            get { return firstName; }
        }

        public string LastName
        {
            set { lastName = value;  }
            get { return lastName; }

        }

        public string SSN
        {
            set {
                if (!Regex.IsMatch(value, @"^\d{3}-\d{2}-\d{4}$\"))
                {
                    throw new Exception("SSN is not valid!");
                }
                else
                {
                    ssn = value;
                }
               
            }
            get { return ssn; }
        }

        public float Salary
        {
            set { salary = value; }
            get { return salary; }

        }
        #endregion

        // Constructors 
        // it is a method that is used to initialize the object's data
        // This method will have the same name as the class
        // can be only called when you create the object 
        // every class has a default constructor: C# will write it for you 

        public Employee()// default constructor (no-argument constructor)
        {
            FirstName = "not assigned";
            LastName = "not assigned";
            Salary = 40000;
            SSN = "000-00-0000"; 
        }

        // overloaded constructor 
        public Employee(string fn, string ln, float sal, string s)
        {
           // firstName = fn; 

            FirstName = fn;
            LastName = ln;
            Salary = sal;
            SSN = s;

            // fn = FirstName; // Logical error!!!! 
        }


        // Methods
        


    }
}
