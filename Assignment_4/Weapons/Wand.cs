namespace Assignment_4.Weapons;

public class Wand : Weapon
{
    public Wand()
    {
        Description =
            "A slender, ornate wand, shimmering with arcane energy, ideal for casting spells from a distance.";
        Damage = 50;
    }
    
    public override string AttackMessage() 
    {
        return "The wand emits a burst of magical energy, weaving a spell of destruction upon its target.";
    }
    
}