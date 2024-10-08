using Xunit;

namespace Act1.Tests
{
    public class CharacterTests
    {
        [Fact]
        public void TestCharacterHealing()
        {
            // Arrange
            Character hero = new Character("Sylvanas", 100, 50, 20); 
            hero.ReceiveDamage(30); 

            // Act
            hero.Heal(20); 
            
            // Assert
            Assert.Equal(100, hero.CurrentHitPoints); 
        }

        [Fact]
        public void TestCharacterInvocationOfMinion()
        {
            // Arrange
            Character hero = new Character("Sylvanas", 100, 50, 30);
            Protection helmet = new Shield("Casco de Guerrero", 10); 

            // Act
            hero.AddToInventory(helmet);

            // Assert
            Assert.Single(hero.Minions); 
            Assert.Equal("Minion", hero.Minions[0].Name); 
            Assert.Equal(10, hero.Minions[0].Attack); 
            Assert.Equal(5, hero.Minions[0].Defense); 
        }

        [Fact]
        public void TestCharacterReceiveDamage()
        {
            Character hero = new Character("Sylvanas", 100, 50, 30); 

            hero.ReceiveDamage(60); 

            hero.ReceiveDamage(40); 

            Assert.Equal(60, hero.CurrentHitPoints); 
        }
    }
}