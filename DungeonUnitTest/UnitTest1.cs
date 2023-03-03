using DungeonLibrary;
namespace DungeonUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMaxDamageRabidRat()
        {
            Monster r1 = new Monster("Rabid Rat", block: 7, hitChance: 90,maxLife: 20, "Description", maxDamage: 7, minDamage: 2);
            int expectedMaxDamage = 0;
            int actualMaxDamage = 0;
            expectedMaxDamage = 7;
            actualMaxDamage = r1.MaxDamage;
            Assert.Equal(expectedMaxDamage, actualMaxDamage);

        }

        [Fact]
        public void TestMaxDamageViciousVacuum()
        {
            Monster v1 = new Monster("Vicious Vacuum", block: 8, hitChance: 85, maxLife: 22,"Description", maxDamage: 8, minDamage: 1);
            int expectedMaxDamage = 0;
            int actualMaxDamage = 0;
            expectedMaxDamage = 5;
            actualMaxDamage = v1.MaxDamage;
            Assert.Equal(expectedMaxDamage,actualMaxDamage);
        }

        [Fact]
        public void TestMaxDamageLaserPointer()
        {
            Monster l1 = new Monster("Laserating Laser Pointer", block: 15, hitChance: 70, maxLife: 25,"Description" ,maxDamage: 8, minDamage: 1);
            int expectedMaxDamage = 0;
            int actualMaxDamage = 0;
            expectedMaxDamage = 8;
            actualMaxDamage = l1.MaxDamage;
            Assert.Equal (expectedMaxDamage, actualMaxDamage);


        }

        [Fact]
        public void TestMaxDamageGracie()
        {
            Monster g1 = new Monster("Growling Gracie", block: 15, hitChance: 75, maxLife: 30, "Description:",maxDamage: 7, minDamage: 4);
            int expectedMaxDamage = 0;
            int actualMaxDamage = 0;
            expectedMaxDamage = 9;
            actualMaxDamage = g1.MaxDamage;
            Assert.Equal(expectedMaxDamage, actualMaxDamage);
        }

        [Fact]
        public void TestMaxDamageToddler()
        {
            Monster t1 = new Monster("Terrorizing Toddler", block: 25, hitChance: 80, maxLife: 24, "Description",maxDamage: 8, minDamage: 4);
            int expectedMaxDamage = 0;
            int actualDamage = 0;
            expectedMaxDamage= 8;
            actualDamage = t1.MaxDamage;
            Assert.Equal(expectedMaxDamage, actualDamage);
        }
    }
}