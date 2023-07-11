﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string Fullname = (FirstName + " " + LastName);
            Console.WriteLine("Name:[" + Fullname + "]");
        }
    }


}
