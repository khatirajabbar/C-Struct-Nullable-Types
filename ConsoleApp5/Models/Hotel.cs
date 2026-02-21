namespace ConsoleApp5;

public class Hotel
{
    public string Name { get; set; }
    private static Room[] Rooms = new Room[0];

    public void AddRoom(Room room)
    {
        Array.Resize(ref Rooms, Rooms.Length + 1);
        Rooms[^1] = room;
    }

    /*public Hotel this[int index]
    {
        get
        {
            return Rooms[index];
        }
    }*/
    
    
}