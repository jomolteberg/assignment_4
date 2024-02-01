using Assignment_4.Weapons;

namespace Assignment_4.Classes;

public class Spellblade : Wizard
{
    public Spellblade(string name, string description, Weapon weapon)
        : base(name, description, weapon)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} channels magic through their blade: " + EquippedWeapon.AttackMessage());
    }
}
