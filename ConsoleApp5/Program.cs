using System.Data.SqlTypes;

namespace ConsoleApp5;

class Program
{
    static void Main(string[] args)
    {
        #region first task

        // IEmployeeService service = new EmployeeService();
        // try
        // {
        //     Employee[] newEmployees = service.GetEmployees(new DateTime(2034, 05, 02), new DateTime(2045, 09, 06));
        //     foreach (Employee emp in newEmployees)
        //     {
        //         Console.WriteLine(emp.ToString());
        //     }
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        // }

        #endregion

        #region second task

        /*try
        {
            Hotel hotel = new Hotel("Baku Palace");
            Room r1 = new Room("Deluxe 101", 150, 2);
            Room r2 = new Room("Suite 202", 300, 4);
            hotel.AddRoom(r1);
            hotel.AddRoom(r2);
            Console.WriteLine($"the room at index 0: {hotel[0].Name}");
            hotel.ReserveRoom(r1.Id);
            // hotel.ReserveRoom(null);
            hotel.ReserveRoom(14);
            hotel.ReserveRoom(r1.Id);

        }
        catch (NotFoundException ex)
        {
            Console.WriteLine($"Search Result: {ex.Message}");
        }
        catch (NotAvailableException ex)
        {
          Console.WriteLine($"Search Result: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexcepted ERROR: {ex.Message}");
        } */

        #endregion


        Weapon myWeapon = new Weapon(30, 20, 3, "Single");
        bool continueLoop = true;
        while (continueLoop)
        {
            Console.WriteLine("\nEnter command (command 0 for info):");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    Console.WriteLine(
                        $"Capacity:{myWeapon.BulletCapacity}, Current Bullets:{myWeapon.CurrentBulletCount}," +
                        $" Fire Mode:{myWeapon.FireMode}");
                    break;
                case "1":
                    myWeapon.Shoot();
                    break;
                case "2":
                    myWeapon.Fire();
                    break;
                case "3":
                    Console.WriteLine($"Remaining bullets to full capacity: {myWeapon.GetRemainBulletCount()}");
                    break;
                case "4":
                    myWeapon.Reload();
                    break;
                case "5":
                    myWeapon.ChangeFireMode();
                    break;
                case "6":
                    continueLoop = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
        }




    }
}

