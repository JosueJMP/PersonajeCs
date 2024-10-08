using System;
using System.Collections.Generic;

namespace Act1
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; private set; }
        public int BaseDamage { get; set; }
        public int BaseArmor { get; set; }
        private List<IApply> Inventory { get; set; }
        public List<Minion> Minions { get; private set; } 

        public Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
        {
            Name = name;
            MaxHitPoints = maxHitPoints;
            CurrentHitPoints = maxHitPoints; 
            BaseDamage = baseDamage;
            BaseArmor = baseArmor;
            Inventory = new List<IApply>();
            Minions = new List<Minion>(); 
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
            
            if (item is Protection protection && protection.Name.Contains("Casco"))
            {
                InvokeMinion();
            }
        }

        private void InvokeMinion()
        {
       
            Minion minion = new Minion("Gustavo El minion Peleon", 10, 5);
            Minions.Add(minion);
            Console.WriteLine($"{minion.Name} ha sido invocado con {minion.Attack} de ataque y {minion.Defense} de defensa.");
        }
    }
}
