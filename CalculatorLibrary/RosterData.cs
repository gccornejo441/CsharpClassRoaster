using System;
using System.Collections.Generic;

namespace RosterData
{
    public class Roster
    {
        public void printAll(string[] rosterInfo)
        {
         
            Console.WriteLine(":::::::::: Students in roster ::::::::::"); 
            foreach(var student in rosterInfo)
            {

                string[] name = student.Split(',');
                Console.Write($"{name[0]}\tFirstname: {name[1]}    \tLastname: {name[2]} \tAge: {name[4]}\t daysInCouse: {{ {name[5]},{name[6]},{name[7]} }}\t");
                Console.WriteLine($"Degree Program: {name[8]}\t");

            }           
        }

        public void emailValidation(string[] rosterInfo)
        {
            Console.WriteLine(" ");
            Console.WriteLine(":::::::::: Email validation ::::::::::");
            for(int i = 0; i < rosterInfo.Length; i++)
            {
                string[] studentEmail = rosterInfo[i].Split(',');

                foreach(var student in studentEmail)
                {
                    string[] newStudentList = new string[] { student };


                    Console.WriteLine("dot: {0}", newStudentList[1]);

                }                    
             }
        }

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

                            Console.Write($"Enter a valid student ID: ");
                            string insert = Console.ReadLine();

                            studentsToAdd = insert;
                            break;
                    }
                }
                break;
            }
            return newStudent[0];
        }

       // public string printAll(string studentID, string firstName, string lastname, int age, int daysInCourse[], DegreeProgram degreeProgram);
    }
}
