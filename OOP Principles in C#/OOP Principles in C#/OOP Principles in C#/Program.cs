using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


using System;

static class MathUtilities
{
    public static double Square(double x)
    {
        return x * x;
    }

    public static double SquareRoot(double x)
    {
        return Math.Sqrt(x);
    }

    public static double Max(double a, double b)
    {
        return (a > b) ? a : b;
    }
}

class Converter
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double KilometersToMiles(double km)
    {
        return km * 0.621371;
    }
}


public class VisitorCounter
{
    static int visitors = 0;

    public VisitorCounter()
    {
        visitors++;
    }

    public static string Visitors()
    {
        return visitors.ToString();
    }
}

public class Company{

    static string companyName;
    List<string> Employees = [];
    public Company(string Name) {
        companyName = Name;
    }
    public void newEmployee(string employeeName)
    {
        Employees.Add(employeeName);
    }

    public void companyInfo()
    {
        Console.WriteLine(companyName + " " + string.Join(", ", Employees));
    }
    }

class overloadTest
{
    public void Add(int x)
    {
        Console.WriteLine("x = " + x);
    }

    public void Add(int x, int y)
    {
        Console.WriteLine("x/y" + x/y);
    }
}

class Animal
{
    public virtual void Speaking()
    {
        Console.WriteLine("bark");
    }

    public virtual void MakeSound() {

    }
}
class Cat : Animal
{
    public override void Speaking()
    {
        Console.WriteLine("Meow");
    }

    public override void MakeSound()
    {
        Console.WriteLine("MEOW");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("BARK");
    }
}

class Person
{
    private int age;
    public int Age { get { return age; }
        set {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("age must be more than 0");
            }
        ;
        }
    }
}

abstract class Shape
{
    public abstract void GetArea(int x, int y);
}

class Rectangle : Shape
{
    public override void GetArea(int x, int y)
    {
        Console.WriteLine(x * y);
    }
}

static class Calculator
{
    public static void Add(int x, int y)
    {
        Console.WriteLine(x + y);
    }

    public static void Add(int x, int y, int z)
    {
        Console.WriteLine(x + y + z);
    }

    public static void Add(double x, double y)
    {
        Console.WriteLine(x + y);
    }
}

abstract class Appliance
{
    public string Brand { get; set; }
    public abstract void TurnOn();
    public abstract void TurnOff();
}

class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine($"{Brand} Starting wash cycle...");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} Stopping wash cycle.");
    }
}

class AirConditioner : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine($"{Brand} Cooling mode activated.");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Brand} Shutting down cooling.");
    }
}


class BankAccount
{
    private int Balance;

    public int Deposit
    {
        get; set
        {
            Balance += value;
        }
    }

    public int Withdraw
    {
        get; set
        {
            if (Balance - value > 0)
            {
                Balance -= value;
            }
        }
    }

    public void viewBalance()
    {
        Console.WriteLine(Balance);
    }
} 

abstract class Employee
{
    public abstract void CalculateSalary(int amount);
}

class FullTimeEmployee : Employee
{
    public override void CalculateSalary(int amount)
    {
        Console.WriteLine(amount * 1.1);
    }
}

class PartTimeEmployee : Employee
{
    public override void CalculateSalary(int amount)
    {
        Console.WriteLine(amount * 0.8);
    }
}

namespace OOP_Principles_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            VisitorCounter visitor1 = new VisitorCounter();
            VisitorCounter visitor2 = new VisitorCounter();

            //Console.WriteLine(VisitorCounter.Visitors());

            Company Orange = new Company("Orange");
            Orange.newEmployee("Ahmad");
            Orange.newEmployee("Sara");
            //Orange.companyInfo();

            Animal cat = new Cat();
            //cat.Speaking();

            Person p = new Person();
            p.Age = 25;
            //Console.WriteLine(p.Age);

            Calculator.Add(1.1, 3.1);
            Calculator.Add(1, 2, 1);
            Calculator.Add(1, 5);

            Shape shape = new Rectangle();
            shape.GetArea(4, 5);

            BankAccount account = new BankAccount();

            account.Deposit = (500);
            account.Withdraw = (200);
            account.viewBalance();

            //

            Employee Mohammad = new FullTimeEmployee();
            Employee Ahmad = new PartTimeEmployee();
            Mohammad.CalculateSalary(1000);
            Ahmad.CalculateSalary(1000);


        }
    }
}
