using Act1;

class Program
{
    static void Main(string[] args)
    {
        // Crear un personaje
        Character hero = new Character("Sylvanas", 100, 99, 33);
        
        // Mostrar Datos del Héroe
        Console.WriteLine($"Nombre : {hero.Name}");
        Console.WriteLine($"Puntos de vida: {hero.CurrentHitPoints}/{hero.MaxHitPoints}");
        Console.WriteLine($"Daño: {hero.Attack()}");
        Console.WriteLine($"Defensa: {hero.Defense()}");
        
        // Crear un arma y una protección
        Sword sword = new Sword("Espada Valkiria", 75);
        Shield shield = new Shield("Escudo Valkiria", 20);

        // Equipar el arma y la protección al personaje
        hero.AddToInventory(sword);
        hero.AddToInventory(shield);
  
        // Recibir daño
        Console.WriteLine("\nEl personaje recibe 75 puntos de daño...");
        hero.ReceiveDamage(75);
        Console.WriteLine($"Puntos de vida actuales: {hero.CurrentHitPoints}/{hero.MaxHitPoints}");
        
        // Curar al personaje
        Console.WriteLine("\nEl personaje se cura 10 puntos de vida...");
        hero.Heal(10);
        Console.WriteLine($"Puntos de vida actuales: {hero.CurrentHitPoints}/{hero.MaxHitPoints}");
    }
}