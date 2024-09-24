namespace Act1;

public abstract class Weapon : IApply
{
    public string Name { get; set; }
    public int Damage { get; set; }

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public abstract void Apply(Character character);
}
