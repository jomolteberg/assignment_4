using Assignment_4.Weapons;

namespace Assignment_4.Classes;

public class Sorcerer : Wizard
{
        public Sorcerer(string name, string description, Weapon weapon)
            : base(name, description, weapon)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with fireball! " + EquippedWeapon.AttackMessage());
        }
}
