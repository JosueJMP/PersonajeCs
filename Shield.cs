namespace Act1;

public class Shield : Protection
{
    public Shield(string name, int armor) : base(name, armor) { }

    public override void Apply(Character character)
    {
        Console.WriteLine($"{Name} equipado. Armadura incrementada: {Armor}");
    }
}
