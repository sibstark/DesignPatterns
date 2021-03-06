﻿using Prototype.Classes;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle figure = new Circle(30, 50, 60);
            // deep cloning
            Circle clonedFigure = figure.DeepCopy() as Circle;
            figure.Point.X = 100;
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }
}
