using System;

namespace InterfaceExercise;

public class Car: IVehicle, ICompany
{
    public  Car ()
    {
    }

    public string Make { get; set; } = "Ford";
    public string Model { get; set; } = "Mustang";
    public int SeatCount { get; set; } = 4;
    public bool HasChangedGears { get; set; }
    public string CompanyName { get; set; } = "Ford";
    public string CompanyMotto { get; set; } = "Built Ford Tough"; 
    
    public void Drive()
    {
        Console.WriteLine($"{GetType().Name} now driving forward.");
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