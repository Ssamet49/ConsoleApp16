using System;


enum FuelType
{
    Petrol,
    Diesel,
    Electric
}


class Vehicle
{
    public string Brand;
    public string Model;
    public int Year;
    public FuelType Fuel;


    public static int Count = 0;


    public Vehicle(string brand, string model, int year, FuelType fuel)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Fuel = fuel;
        Count++;
    }


    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine started.");
    }


    public string Info()
    {
        return Brand + " " + Model + " (" + Year + ", " + Fuel + ")";
    }
}

class Car : Vehicle
{
    public Car(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel) { }

    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }
}

class Truck : Vehicle
{
    public Truck(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel) { }

    public override void StartEngine()
    {
        Console.WriteLine("Truck engine started.");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, int year, FuelType fuel) : base(brand, model, year, fuel) { }

    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started.");
    }
}

class Program
{
    static void Main()
    {

        Vehicle[] fleet = {
            new Car("Togg", "T10X", 2024, FuelType.Electric),
            new Truck("Volvo", "FH16", 2022, FuelType.Diesel),
            new Motorcycle("Honda", "CBR", 2023, FuelType.Petrol)
        };

        foreach (Vehicle v in fleet)
        {
            Console.WriteLine(v.Info());
            v.StartEngine();
        }


        Console.WriteLine("Total vehicles: " + Vehicle.Count);
    }
}