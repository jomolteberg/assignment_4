namespace Assignment_4.Weapons;

public class Sword : Weapon
{
    public Sword()
    {
        Description = "A finely crafted longsword with a gleaming blade, perfect for swift and precise strikes.";
        Damage = 150;
    }
    
    public override string AttackMessage() 
    {
        return "With a swift slash, the sword cuts through the air, delivering a powerful blow.";
    }
    
}