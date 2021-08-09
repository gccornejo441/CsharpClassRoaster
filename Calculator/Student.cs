using System;
using System.Collections.Generic;
using System.Text;
using RosterData;

namespace ClassRoster
{
    public class Student : Roster
    {

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }

        public override void HelloToConsole()
        {
            Console.WriteLine("Hi, I'm a student, my name is " + FullName.ToUpper());
        }
    }
}
