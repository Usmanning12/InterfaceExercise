using System;

namespace InterfaceExercise;

public class Truck: IVehicle, ICompany
{
    public Truck()
    {
        
    }
    public string Make { get; set; } = "Ford";
    public string Model { get; set; } = "Mustang";
    public int SeatCount { get; set; } = 4;
    public bool HasFourWheelDrive { get; set; }
    public bool HasChangedGears { get; set; }
    public string CompanyName { get; set; } = "Ford";
    public string CompanyMotto { get; set; } = "Built Ford Tough"; 

    
    public void Drive()
    {
        if (HasFourWheelDrive == true)
        {
            Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward...");

        }
        else
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }
    }

    public void Reverse()
    {
        Console.WriteLine($"{GetType().Name} now reversing . . .");
        HasChangedGears = false; 
    }

    public void Park()
    {

        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now park...");
            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine("Can't park until we change gears");
        }
        
    }

    public void ChangedGears(bool isChanged)
    {
        HasChangedGears = isChanged;
    }

    
}