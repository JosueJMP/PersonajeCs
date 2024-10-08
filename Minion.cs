namespace Act1;

public class Minion
{
    public string Name { get; }
    public int Attack { get; }
    public int Defense { get; }
    public int MaxHitPoints { get; }
    public int CurrentHitPoints { get; private set; }

    public Minion(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
        MaxHitPoints = 50;
        CurrentHitPoints = MaxHitPoints; 
    }

    public void ReceiveDamage(int damage)
    {
        int damageToTake = damage - Defense;
        if (damageToTake > 0)
        {
            CurrentHitPoints -= damageToTake;
            if (CurrentHitPoints < 0)
            {
                CurrentHitPoints = 0;
            }
        }
    }

    public void Heal(int amount)
    {
        CurrentHitPoints += amount;
        if (CurrentHitPoints > MaxHitPoints)
        {
            CurrentHitPoints = MaxHitPoints;
        }
    }
}
