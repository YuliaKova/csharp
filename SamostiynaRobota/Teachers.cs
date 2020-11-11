using System;
using System.Collections.Generic;

namespace SamostiynaRobota
{
    class Teachers
    {
        string name;
        int age;
        double experience;
        string discipline;
        bool englishKnowledge;

        static List<Teachers> listOfTeachers = new List<Teachers>();
        public Teachers(string name, int age, double experience, string discipline, bool englishKnowledge)
        {
            this.name = name;
            this.age = age;
            this.experience = experience;
            this.discipline = discipline;
            this.englishKnowledge = englishKnowledge;
        }
        static public void AddTeacher(Teachers Obj)
        {
            listOfTeachers.Add(Obj);
        }
        public void GetTeachersInfo()
        {
            Console.WriteLine("\nName: " + name + "\nAge: " + age + "\nExperience: " + experience + "\nDiscipline: " + discipline + "\nEnglish Knowledge: " + englishKnowledge);
        }
        static public void ChooseTeacher(int age, double experience, string discipline, bool englishKnowledge)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age && i.experience == experience && i.discipline == discipline && i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(int age, double experience, string discipline)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age && i.experience == experience && i.discipline == discipline)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(int age, double experience, bool englishKnowledge)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age && i.experience == experience && i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(int age, string discipline, bool englishKnowledge)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age && i.discipline == discipline && i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(double experience, string discipline, bool englishKnowledge)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.experience == experience && i.discipline == discipline && i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(int age, double experience)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age && i.experience == experience)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(int age, string discipline)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age && i.discipline == discipline)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(int age, bool englishKnowledge)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age && i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(double experience, string discipline)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.experience == experience && i.discipline == discipline)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(double experience, bool englishKnowledge)
        {            
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.experience == experience && i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(string discipline, bool englishKnowledge)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.discipline == discipline && i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(int age)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.age == age)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(double experience)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.experience == experience)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(string discipline)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.discipline == discipline)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseTeacher(bool englishKnowledge)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Teachers i in listOfTeachers)
            {
                if (i.englishKnowledge == englishKnowledge)
                {
                    i.GetTeachersInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
    }
}