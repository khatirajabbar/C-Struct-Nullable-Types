namespace ConsoleApp5;

public class Hotel
{
    public string Name { get; set; }
    private Room[] _rooms = new Room[0];
    public Hotel(string name)
    {
        Name = name;
    }
    public Room this[int index]
    {   get {return _rooms[index]; }
        set { _rooms[index] = value; }
    }

    public void AddRoom(Room room)
    {
        Array.Resize(ref _rooms, _rooms.Length + 1);
        _rooms[^1] = room;
    }
    public void ReserveRoom(int? roomId)
    {
        if (roomId is null) throw new NotFoundException($"Room ID cannot be null.");
        Room foundRoom = null;
        foreach (var room in _rooms)
        {
            if (room.Id == roomId)
            {
                foundRoom = room;
                break;
            }
        }
        if (foundRoom is null) throw new NotFoundException($"Room ID is not found.");
        if (!foundRoom.IsAvailable) throw new NotAvailableException($"Room is not available.");
        foundRoom.IsAvailable = false;
        Console.WriteLine($"Room {foundRoom.Name} is successfully reserved.");
        }
        
}
    
    
