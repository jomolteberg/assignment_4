namespace Assignment_4.Weapons;

public class Weapon
{
    protected string Description { get; set; }
    protected string AttackMessageString { get; set; } = "Default attack!";
    protected int Damage { get; set; }
    
    
    public string GetDescription()
    {
        return Description;
    }

    public int GetDamage()
    {
        return Damage;
    }

    public virtual string AttackMessage()
    {
        return AttackMessageString;
    }
}