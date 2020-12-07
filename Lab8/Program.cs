using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle("Porsche", "red", 260, 2019);
            Vehicle car2 = new Vehicle("Mitsubishi", "blue", 250, 2018);
            Vehicle car3 = new Vehicle("Mustang", "red", 300, 2020);
            Vehicle car4 = new Vehicle("Porsche", "red", 260, 2020);
            Vehicle car5 = new Vehicle("Chevrolet", "yellow", 250, 2017);


            Garage garage1 = new Garage();
            garage1.AddCar(car1);
            garage1.AddCar(car2);
            garage1.AddCar(car3);
            garage1.AddCar(car4);
            garage1.AddCar(car5);

            garage1.ChooseCar(car5);
            garage1.ChooseCarByName("Porsche");
            garage1.ChooseCarByColor("red");
            garage1.ChooseCarBySpeed(250);
            garage1.ChooseCarByYear(2019);

            garage1.GetListOfCars();
            garage1.DeleteCar(car4);
            garage1.GetListOfCars();

            Console.ReadKey();
        }
    }
}
