namespace Assignment_4.Weapons;

public class Mace : Weapon
{
    public Mace()
    {
        Description = "A robust mace with a spiked head, designed to smash through armor and bone with ease.";
        Damage = 70; 
    }

    public override string AttackMessage()
    {
        return "The mace crashes down with brute force, causing a thunderous impact upon striking.";
    }
}
