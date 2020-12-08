﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2
{
    //TASK 2
    class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Student(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        //TASK 4
        public static bool Adult(Student Obj)
        {
            return Obj.Age >= 18;
        }
        public static bool AisFirstLetterOfFirstName(Student Obj)
        {
            return Obj.FirstName[0] == 'A';
        }
        public static bool MoreThan3LettersInLastName(Student Obj)
        {
            return Obj.LastName.Length > 3;
        }

        public void StudentInfo()
        {
            Console.WriteLine(
                $"\tName: {FirstName}" +
                $"\n\tSurname: {LastName}" +
                $"\n\tAge: {Age}\n");
        }
    }
}
