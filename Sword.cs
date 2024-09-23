namespace Act1;

public class Sword : Weapon
{
    public Sword(string name, int damage) : base(name, damage) { }

    public override void Apply(Character character)
    {
        Console.WriteLine($"{Name} equipada. Daño incrementado: {Damage}");
    }
}
