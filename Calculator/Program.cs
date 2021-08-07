using System;
using RosterData;
using System.Collections.Generic;

namespace CalculatorProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is a class roaster app created in C#");
            Console.WriteLine("-----------------------------------------");

            Roster roster = new Roster();

            // Student Data
            string[] studentData = new string[] {
                "A1,John,Smith,John1989@gm ail.com,20,30,35,40,SECURITY",
                "A2,Suzan,Erickson,Erickson_1990@gmailcom,19,50,30,40,NETWORK",
                "A3,Jack,Napoli,The_lawyer99yahoo.com,19,20,40,33,SOFTWARE",
                "A4,Erin,Black,Erin.black@comcast.net,22,50,58,40,SECURITY",
                "A5,Gabriel,Cornejo,gcornej@wgu.edu,26,20,20,20,SOFTWARE"
            };

            string[] studentID = new string[5];

            Console.WriteLine("Enter a student ID: ");
            var insert = Console.ReadLine();

            studentID[0] = insert;

            string newStudent = roster.add(studentID, studentData);
            Console.Write($"You have added: {newStudent}");
            Console.WriteLine(" ");
        }
    }
}
