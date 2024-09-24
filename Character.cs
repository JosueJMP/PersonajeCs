namespace Act1;

using System;
using System.Collections.Generic;

public class Character
{
    public string Name { get; set; }
    public int MaxHitPoints { get; set; }
    public int CurrentHitPoints { get; private set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }
    private List<IApply> Inventory { get; set; }

    public Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        CurrentHitPoints = maxHitPoints; 
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        Inventory = new List<IApply>();
    }

    public int Attack()
    {
        int totalDamage = BaseDamage;
        foreach (var item in Inventory)
        {
            if (item is Weapon weapon)
            {
                totalDamage += weapon.Damage;
            }
        }
        return totalDamage;
    }

    public int Defense()
    {
        int totalDefense = BaseArmor;
        foreach (var item in Inventory)
        {
            if (item is Protection protection)
            {
                totalDefense += protection.Armor;
            }
        }
        return totalDefense;
    }

    public void Heal(int amount)
    {
        CurrentHitPoints += amount;
        if (CurrentHitPoints > MaxHitPoints)
        {
            CurrentHitPoints = MaxHitPoints;
        }
    }

    public void ReceiveDamage(int damage)
    {
        int damageToTake = damage - Defense();
        if (damageToTake > 0)
        {
            CurrentHitPoints -= damageToTake;
            if (CurrentHitPoints < 0)
            {
                CurrentHitPoints = 0;
            }
        }
    }

    public void AddToInventory(IApply item)
    {
        item.Apply(this);
        Inventory.Add(item);
    }

    public override string ToString()
    {
        
        return base.ToString();
        
    }
}
