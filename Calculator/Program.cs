using System;
using CalculatorLibrary;

namespace CalculatorProgram
{
    class Program
    {

        static void add(string[] studentInfo)
        {
            string studentsToAdd;

            for (int i = 0; i < studentInfo.Length; i++)
            {
                studentsToAdd = studentInfo[i];

                switch(studentsToAdd)
                {
                    case "A1":
                        Console.WriteLine(studentsToAdd);
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("This is a class roaster app created in C#");
            Console.WriteLine("-----------------------------------------");

            // Studen Data
            string[] studentData = new string[] {
                "A1,John,Smith,John1989@gm ail.com,20,30,35,40,SECURITY",
                "A2,Suzan,Erickson,Erickson_1990@gmailcom,19,50,30,40,NETWORK",
                "A3,Jack,Napoli,The_lawyer99yahoo.com,19,20,40,33,SOFTWARE",
                "A4,Erin,Black,Erin.black@comcast.net,22,50,58,40,SECURITY",
                "A5,Gabriel,Cornejo,gcornej@wgu.edu,26,20,20,20,SOFTWARE"
            };

            string[] studentID = new string[5];


            var insert = Console.ReadLine();

            studentID[0] = insert;

            add(studentID);
        }
    }
}
