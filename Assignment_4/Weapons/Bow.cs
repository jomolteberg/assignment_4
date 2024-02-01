namespace Assignment_4.Weapons;

public class Bow : Weapon
{
    public Bow()
    {
        Description = "A sturdy, well-crafted bow with a taut string, designed for accuracy and long-range attacks.";
        Damage = 150; 
    }

    public override string AttackMessage()
    {
        return "The bowstring twangs as an arrow is loosed, soaring towards the enemy with deadly precision.";
    }
}