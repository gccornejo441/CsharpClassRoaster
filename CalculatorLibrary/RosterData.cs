using System;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;


namespace RosterData
{
    public class Roster
    {
        public string add(string[] studentInfo, string[] rosterInfo)
        {
            string studentsToAdd;

            // Add list
            string[] newStudent = new string[1];

            for (int i = 0; i < studentInfo.Length; i++)
            {
                studentsToAdd = studentInfo[i];
                bool noStudent = false;
                while (!noStudent)
                {
                    switch (studentsToAdd.ToUpper())
                    {
                        case "A1":
                            Console.WriteLine($"You have selected the student id: {studentsToAdd.ToUpper()}");
                            Console.WriteLine(" ");

                            newStudent[0] = rosterInfo[0];
                            noStudent = true;
                            break;
                        case "A2":
                            Console.WriteLine($"You have selected the student id: {studentsToAdd.ToUpper()}");
                            Console.WriteLine(" ");

                            newStudent[0] = rosterInfo[1];
                            noStudent = true;
                            break;
                        case "A3":
                            Console.WriteLine($"You have selected the student id: {studentsToAdd.ToUpper()}");
                            Console.WriteLine(" ");

                            newStudent[0] = rosterInfo[2];
                            noStudent = true;
                            break;
                        case "A4":
                            Console.WriteLine($"You have selected the student id: {studentsToAdd.ToUpper()}");
                            Console.WriteLine(" ");

                            newStudent[0] = rosterInfo[3];
                            noStudent = true;
                            break;
                        case "A5":
                            Console.WriteLine($"You have selected the student id: {studentsToAdd.ToUpper()}");
                            Console.WriteLine(" ");

                            newStudent[0] = rosterInfo[4];
                            noStudent = true;
                            break;
                        default:
                            noStudent = false;

                            var insert = "";
                            Console.Write($"Enter a valid student ID: {insert = Console.ReadLine()}");

                            studentsToAdd = insert;
                            break;
                    }
                }
                break;
            }
            return newStudent[0];
        }
    }
}
