﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab9
{
    interface IDraw
    {
        void Draw();
    }

    class Painter
    {
        public static void Draw(IDraw Obj)
        {
            Obj.Draw();
        }
    }

    abstract class Shape : IDraw
    {
        public ConsoleColor color;
        public int numberOfApexes { get; protected set; }
        public string name { get; protected set; }
        public int size;
        public double area;
        public double length;

        public abstract void Area();
        public abstract void Length();
        public abstract void Draw();

    }

    class Square : Shape
    {
        Random random = new Random();

        public Square(string name)
        {

            this.name = name;
            size = random.Next(1, 100);
            color = (ConsoleColor)random.Next(16);
            numberOfApexes = 4;
        }

        public Square(string name, int size)
        {
            this.name = name;
            this.size = size;
            color = (ConsoleColor)new Random().Next(16);
            numberOfApexes = 4;
        }

        public Square(string name, int size, ConsoleColor color)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            numberOfApexes = 4;
        }

        public override void Area()
        {
            area = size * size;
        }
        public override void Length()
        {
            length = numberOfApexes * size;
        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
            if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Name: {0}\tSize: {1}\tArea: {2}\tLength: {3}\tAmount of apexes: {4}", name, size, area, length, numberOfApexes);

            Console.ResetColor();
        }

    }
    class Circle : Shape
    {
        Random random = new Random();

        public Circle(string name)
        {

            this.name = name;
            size = random.Next(1, 100);
            color = (ConsoleColor)random.Next(16);
            numberOfApexes = 0;
        }

        public Circle(string name, int size)
        {
            this.name = name;
            this.size = size;
            color = (ConsoleColor)new Random().Next(16);
            numberOfApexes = 0;
        }

        public Circle(string name, int size, ConsoleColor color)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            numberOfApexes = 0;
        }

        public override void Area()
        {
            area = size * size * Math.PI;
        }
        public override void Length()
        {
            length = 2 * size * Math.PI;
        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
            if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Name: {0}\tSize: {1}\tArea: {2}\tLength: {3}\tAmount of apexes: {4}", name, size, area, length, numberOfApexes);

            Console.ResetColor();
        }
    }

    class Triangle : Shape
    {
        Random random = new Random();

        double size2;

        public Triangle(string name)
        {

            this.name = name;
            size = random.Next(1, 100);
            size2 = Math.Sqrt(2 * size * size);
            color = (ConsoleColor)random.Next(16);
            numberOfApexes = 3;
        }

        public Triangle(string name, int size, int size2)
        {
            this.name = name;
            this.size = size;
            this.size2 = size2;
            color = (ConsoleColor)new Random().Next(16);
            numberOfApexes = 3;
        }

        public Triangle(string name, int size, int size2, ConsoleColor color)
        {
            this.name = name;
            this.size = size;
            this.size2 = size2;
            this.color = color;
            numberOfApexes = 3;
        }

        public override void Area()
        {
            double temp = size * size - (size2 * size2) / 4;

            area = (size2 * temp) / 2;
        }
        public override void Length()
        {
            length = 2 * size + size2;
        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
            if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Name: {0}\tSize1: {1}\tSize2: {2}\tArea: {3}\tLength: {4}\tAmount of apexes: {5}", name, size, size2, area, length, numberOfApexes);

            Console.ResetColor();
        }
    }

    class Picture
    {
        public List<Shape> shapes;

        public int lengthOfList
        {
            get
            {
                return shapes.Count();
            }
        }

        public Picture()
        {
            shapes = new List<Shape>();
        }

        public Picture(int lengthOfList)
        {
            shapes = new List<Shape>(lengthOfList);
        }

        public void AddShape(Shape Obj)
        {
            shapes.Add(Obj);
        }
        public void DeleteShape(string name)
        {
            shapes.RemoveAll(i => i.name == name);
        }

        public void DeleteShape(int apexes)
        {
            shapes.RemoveAll(i => i.numberOfApexes == apexes);
        }
        public void DeleteShape(double area)
        {
            shapes.RemoveAll(i => i.area == area);
        }
        public void Draw()
        {
            foreach (Shape i in shapes)
                i.Draw();
        }

        public Shape this[int index]
        {
            get
            {
                return shapes[index];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square("square");
            Thread.Sleep(200);

            Circle cr = new Circle("circle");
            Thread.Sleep(200);

            Triangle tr = new Triangle("triangle");
            Thread.Sleep(200);


            sq.Area();
            sq.Length();
            cr.Area();
            cr.Length();
            tr.Area();
            tr.Length();


            Picture picture = new Picture(3);
            picture.AddShape(sq);
            picture.AddShape(cr);
            picture.AddShape(tr);

            Console.WriteLine("Length of list : {0}", picture.lengthOfList);

            Console.WriteLine("Painter.Draw(sq)");
            Painter.Draw(sq);

            Console.WriteLine("picture:");
            picture.Draw();

            Console.WriteLine("-squre has been deleted-");
            picture.DeleteShape("square");

            Console.WriteLine("picture[0].name : {0}", picture[0].name);

            Console.ReadLine();
        }
    }
}
