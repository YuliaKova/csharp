using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Garage
    {
        List<Vehicle> cars = new List<Vehicle>();

        public void AddCar(Vehicle Obj)
        {
            cars.Add(Obj);
        }
        public void DeleteCar(Vehicle Obj)
        {
            cars.Remove(Obj);
        }
        public void GetListOfCars()
        {
            foreach (Vehicle i in cars)
            {
                i.GetVehicle();
            }
            Console.WriteLine();
        }
        public void ChooseCar(Vehicle Obj)
        {
            Console.WriteLine("Specific car chosen by Sheik:");
            foreach (Vehicle i in cars)
            {
                if (i == Obj)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }
        public void ChooseCarByName(string name)
        {
            Console.WriteLine("Chosen by Sheik by name:");
            foreach (Vehicle i in cars)
            {
                if (i.GetName() == name)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }
        public void ChooseCarByColor(string color)
        {
            Console.WriteLine("Chosen by Sheik by color:");
            foreach (Vehicle i in cars)
            {
                if (i.GetColor() == color)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }
        public void ChooseCarBySpeed(int speed)
        {
            Console.WriteLine("Chosen by Sheik by speed:");
            foreach (Vehicle i in cars)
            {
                if (i.GetSpeed() == speed)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }
        public void ChooseCarByYear(int yearOfManufacture)
        {
            Console.WriteLine("Chosen by Sheik by year of manufacture:");
            foreach (Vehicle i in cars)
            {
                if (i.GetYearOfManufacture() == yearOfManufacture)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }
    }
}
