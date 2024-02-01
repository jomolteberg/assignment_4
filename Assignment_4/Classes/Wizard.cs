using Assignment_4.Weapons;

namespace Assignment_4.Classes;

public class Wizard
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected Weapon EquippedWeapon { get; set; }

    public Wizard(string name, string description, Weapon equippedweapon)
    {
        Name = name;
        Description = description;
        EquippedWeapon = equippedweapon;
    }
    
    public string GetName()
    {
        return Name;
    }
    public string GetDescription()
    {
        return Description;
    }
    public virtual void Attack()
    {
        Console.WriteLine(EquippedWeapon.AttackMessage());
    }
    
    
}
