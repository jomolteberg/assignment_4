namespace Assignment_4.Weapons;

public class Staff : Weapon
{
    public Staff()
    {
        Description = "A large staff";
        Damage = 75;
    }
    
    public override string AttackMessage() 
    {
        return "The hero swings his large staff";
    }
    
}