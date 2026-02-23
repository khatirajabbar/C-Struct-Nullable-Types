using System.ComponentModel.Design;

namespace ConsoleApp5;

public class Weapon
{
    public int BulletCapacity { get; set; }
    public int CurrentBulletCount { get; set; }
    public double DischargeSpeed { get; set; }
    public string FireMode { get; set; }
    public Weapon(int capacity, int currentBullet, double speed, string mode)
    {
        BulletCapacity = capacity;
        CurrentBulletCount = currentBullet;
        DischargeSpeed = speed;
        FireMode = mode;
    }

    public void Shoot()
    {
        if (CurrentBulletCount > 0)
        {
            CurrentBulletCount--;
            Console.WriteLine($"Bang! 1 bullet is fired. Remaining bullets: {CurrentBulletCount}");
        }
        else 
        {
            Console.WriteLine("No bullets left! Please reload.");
        }
    }

    public void Fire()
    {
        if (CurrentBulletCount > 0)
        {
            double TimeSpent = (CurrentBulletCount * DischargeSpeed) / BulletCapacity;
            Console.WriteLine($"Firing... All {CurrentBulletCount} bullets are fired in {TimeSpent} seconds.");
            CurrentBulletCount = 0;
        }
        else
        {
            Console.WriteLine("No bullets left! Please reload.");
        }
    }
    public int GetRemainBulletCount()
    {
        return BulletCapacity - CurrentBulletCount;
    }

    public void Reload()
    {
        CurrentBulletCount = BulletCapacity;
        Console.WriteLine("Weapon is reloaded fully");
    }

    public void ChangeFireMode()
    {
        if (FireMode == "Single")
            FireMode = "Auto";
        else
            FireMode = "Single";
    
        Console.WriteLine($"Shooting method changed: {FireMode}");
    }
}