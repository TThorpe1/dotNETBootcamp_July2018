using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace TestFileIOJuly2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // write to a file 
            StreamWriter wr = new StreamWriter("../../data.txt",true);

            wr.WriteLine("Sarah,Brown,45000,443-44-4434");

            wr.Close();

           

           // PrintFile();
        }

        public static void PrintFile()
        {
            // reading the data.txt

            StreamReader reader = new StreamReader("../../data.txt");

            //string fileData = reader.ReadToEnd();// read all the content 

            List<string> stringList = new List<string>();

            string fileData = "";
            string nextLine = reader.ReadLine(); // reads one line at a time 
            while (nextLine != null)// we did not reach to the end of the file
            {
                fileData += nextLine + "\n"; //append : fileData = fileData + nextLine+"\n";
                stringList.Add(nextLine);// adding the line to the list 
                nextLine = reader.ReadLine();
            }

            Console.WriteLine(fileData);

            foreach (string employee in stringList)
            {
                // parsing the employee list into an array of strings 
                string[] info = employee.Split(',');

                // Employee temp = new Employee(info[0], info[1],...);
            }





            reader.Close();// close the stream reader and the file


        }
    }
}
