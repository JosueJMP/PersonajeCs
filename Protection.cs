﻿namespace Act1
{
    public abstract class Protection : IApply
    {
        public string Name { get; set; }
        public int Armor { get; set; }

        public Protection(string name, int armor)
        {
            Name = name;
            Armor = armor;
        }

        public abstract void Apply(Character character);
    }
}
