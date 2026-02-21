namespace ConsoleApp5;

public class Employee
{
    public string name {get; set;}
    public string surname{get; set;}
    public DateTime birthdate {get; set;}
    public double salary {get; set;}

    override public string ToString()
    { 
        return $"Name: {name} {surname}, Birthdate: {birthdate.ToShortDateString()}, Salary: {salary} USD";
    }
    
    
    
}