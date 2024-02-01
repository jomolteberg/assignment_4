namespace Assignment_4.Weapons;

public class Dagger : Weapon
{
    public Dagger()
    {
        Description =
            "A sleek and sharp dagger, lightweight and easy to conceal, ideal for quick, close-range attacks.";
        Damage = 100;
    }
    
    public override string AttackMessage() 
    {
        return "The dagger darts forward in a lightning-fast stab, aiming for a vital spot with lethal precision.";
    }
}