namespace InterfaceExercise;

public interface IVehicle
{
    public string CompanyName { get; set; } 
    public string Make { get; set; } 
    public string Model { get; set; }   
    public int SeatCount { get; set; } 
    
    public void Drive();
    public void Reverse();

    public void ChangedGears(bool b); 
}
//test
//test