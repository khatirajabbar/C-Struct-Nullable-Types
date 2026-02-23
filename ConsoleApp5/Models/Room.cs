namespace ConsoleApp5;

public class Room
{ 
    public int Id { get;}
    private static int ID;
    public string Name { get; set; }
    public double Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvailable { get; set; }

    public Room(string name, double price, int personCapacity)
    {
        ID = ++ID;
        Id = ID;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
        IsAvailable = true;
    }
    public override string ToString()
    {
        return ShowInfo();
    }
    public string ShowInfo()
    {
        return $"Room ID: {Id}, Name: {Name}, Price: {Price} USD, Person Capacity: {PersonCapacity}, Is Available: {IsAvailable}";
    }



}