using System;

namespace Car
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyCar car;
            System.Console.WriteLine("Creating Car object and assigning" + "Its memory location to myCar");
            car = new MyCar();
            
            //assign values
            car.make = "Toyota";
            car.model = "MR2";
            car.color = "Black";
            car.yearBuilt = 1995;
            
            //display values
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + car.make);
            System.Console.WriteLine("myCar.model = " + car.model);
            System.Console.WriteLine("myCar.color = " + car.color);
            System.Console.WriteLine("myCar.yearBuilt = " + car.yearBuilt);
            
            
            //call the method
            car.Start();
            car.Stop();
            
            //create another car
            System.Console.WriteLine("Creating another Car object and" + " assigning its memory location to redPorsChe");
            MyCar redPorsChe = new MyCar();
            redPorsChe.make = "Porsche";
            redPorsChe.model = "Boxster";
            redPorsChe.color = "Red";
            redPorsChe.yearBuilt = 2000;
            
            System.Console.WriteLine("redPorsChe is a " + redPorsChe.model);
            
            System.Console.WriteLine("Assigning redPorsChe to myCar");
            car = redPorsChe;
            System.Console.WriteLine("myCar details :");
            System.Console.WriteLine("myCar.make = " + car.make);
            System.Console.WriteLine("myCar.model = " + car.model);
            System.Console.WriteLine("myCar.color = " + car.color);
            System.Console.WriteLine("myCar.yearBuilt = " + car.yearBuilt);
            car = null;
            Console.ReadLine();
        }
    }
}