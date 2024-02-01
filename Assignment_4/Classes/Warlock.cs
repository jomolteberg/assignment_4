using Assignment_4.Weapons;

namespace Assignment_4.Classes;

public class Warlock : Wizard
{
    public Warlock(string name, string description, Weapon weapon)
        : base(name, description, weapon)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} invokes dark magic: " + EquippedWeapon.AttackMessage());
    }
}