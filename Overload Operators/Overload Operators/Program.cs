﻿using System;

namespace Overload_Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Employee emp1 = new Employee() { FirstName = "Ted", LastName = "Smith"};
            Employee emp2 = new Employee() { FirstName = "Sed", LastName = "Tmith" };           
            bool same;
            
            emp1.Id = 1;
            emp2.Id = 2;
            same = emp1.Id == emp2.Id;

            if (same != true)
            {
                Console.WriteLine("All employees have different ID numbers. Employee 1 is " + emp1 + " and employee 2 is " + emp2);
            }
            else
            {
                Console.WriteLine("there are some employees with the same ID number ");
            }
        }
    }
}