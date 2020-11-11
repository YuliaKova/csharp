using System;

namespace SamostiynaRobota
{
    class Program
    {
        static void Main(string[] args) //Варіант 10
        {
            Teachers Petryuk = new Teachers("Maria Petrivna", 50, 27.0, "Math", false);
            Teachers Semanyuk = new Teachers("Petro Semenovich", 45, 24.0, "English", true);
            Teachers Ivanyuk = new Teachers("Semen Ivanovich", 40, 15.0, "Math", true);
            Teachers Vasylyuk = new Teachers("Ivan Vasylyovich", 35, 15.1, "Phisics", false);
            Teachers Igoryuk = new Teachers("Vasylisa Igorivna", 40, 15.0, "Programming", true);

            Teachers.AddTeacher(Petryuk);
            Teachers.AddTeacher(Semanyuk);
            Teachers.AddTeacher(Ivanyuk);
            Teachers.AddTeacher(Vasylyuk);
            Teachers.AddTeacher(Igoryuk);

            Teachers.ChooseTeacher(50, 27.0, "Math", false);
            Teachers.ChooseTeacher(45, 24.0, "English");
            Teachers.ChooseTeacher(40, 15.0, true);
            Teachers.ChooseTeacher(50, "Math", true);
            Teachers.ChooseTeacher(15.1, "Math", true);
            Teachers.ChooseTeacher(40, 15.0);
            Teachers.ChooseTeacher(35, "English");
            Teachers.ChooseTeacher(40, true);
            Teachers.ChooseTeacher(24.0, "Phisics");
            Teachers.ChooseTeacher(15.1, false);
            Teachers.ChooseTeacher("Programming", true);
            Teachers.ChooseTeacher(45);
            Teachers.ChooseTeacher(15.0);
            Teachers.ChooseTeacher("English");
            Teachers.ChooseTeacher(true);


            Console.ReadKey();
        }
    }
}