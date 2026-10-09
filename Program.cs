using System;
using System.Collections.Generic;

/*public class Book
{
   public string Title;
   public string Author;
   public string ISBN;

   private bool isAvailable = true; 

   public void BorrowBook()
   {
       isAvailable = false;
       Console.WriteLine(Title + " götürüldü.");
   }

   public void ReturnBook()
   {
       isAvailable = true;
       Console.WriteLine(Title + " qaytarıldı.");
   }
}

public class Program
{
   public static void Main()
   {

       List<Book> library = new List<Book>
       {
           new Book { Title = "Kitab 1" },
           new Book { Title = "Kitab 2" },
           new Book { Title = "Kitab 3" },
           new Book { Title = "Kitab 4" },
           new Book { Title = "Kitab 5" }
       };


       library[0].BorrowBook();
       library[1].BorrowBook();
   }
}
*/



/*
TASK2
public interface IShape
{
   double CalculateArea();
   double CalculatePerimeter();
}

public class Circle : IShape
{
   public double Radius = 5;
   public double CalculateArea() { return 3.14 * Radius * Radius; }
   public double CalculatePerimeter() { return 2 * 3.14 * Radius; }
}

public class Rectangle : IShape
{
   public double Width = 4, Height = 5;
   public double CalculateArea() { return Width * Height; }
   public double CalculatePerimeter() { return 2 * (Width + Height); }
}

public class Triangle : IShape
{
   public double Side = 3;
   public double CalculateArea() { return Side * Side; } 
   public double CalculatePerimeter() { return Side * 3; }
}

public class ShapeHelper
{
  
   public double CalculateArea(double radius) { return 3.14 * radius * radius; }
   public double CalculateArea(double width, double height) { return width * height; }
}

public class Program
{
   public static void Main()
   {
       List<IShape> shapes = new List<IShape> { new Circle(), new Rectangle(), new Triangle() };

       foreach (var shape in shapes)
       {
           Console.WriteLine("Sahə: " + shape.CalculateArea());
       }
   }
}
*/
/*TASK3
    public class Vehicle
{
    public string Brand;
    public int Speed;

    public virtual void MakeSound() 
    {
        Console.WriteLine("Səs çıxarır");
    }
}

public class Car : Vehicle
{
    public override void MakeSound() { Console.WriteLine("Avtomobil: Vrrrum!"); }
}

public class Motorcycle : Vehicle
{
    public override void MakeSound() { Console.WriteLine("Motosikl: Vut-vut!"); }
}

public class Bicycle : Vehicle
{
    public override void MakeSound() { Console.WriteLine("Velosiped: Zırr-zırr!"); }
}

public class Program
{
    public static void Main()
    {
        
        List<Vehicle> vehicles = new List<Vehicle> { new Car(), new Motorcycle(), new Bicycle() };

        foreach (var v in vehicles)
        {
            v.MakeSound(); 
        }
*/
/*TASK4
    public abstract class Employee
{
    private double baseSalary;

    public double GetSalary() { return baseSalary; }
    public void SetSalary(double value) { baseSalary = value; }

    public abstract double CalculateBonus(); 

public class Manager : Employee
{
    public override double CalculateBonus()
    {
        return GetSalary() * 0.20; 
    }
}

public class Intern : Employee
{
    public override double CalculateBonus()
    {
        return 100; 
    }
}

public class Program
{
    public static void Main()
    {
        Manager m = new Manager(); m.SetSalary(2000);
        Intern i1 = new Intern(); i1.SetSalary(500);
        Intern i2 = new Intern(); i2.SetSalary(400);

        List<Employee> employees = new List<Employee> { m, i1, i2 };

        foreach (var emp in employees)
        {
            Console.WriteLine("Cəmi maaş: " + (emp.GetSalary() + emp.CalculateBonus()));
        }
    }
}
*/ 