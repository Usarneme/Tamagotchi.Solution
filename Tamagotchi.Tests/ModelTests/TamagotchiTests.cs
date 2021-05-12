using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TamagotchiNamespace;

namespace TamagotchiNamespace.Test
{
  [TestClass]
  public class TamagotchiTests : IDisposable
  {
    public void Dispose()
    {
      Tamagotchi.ClearAll();
    }

    [TestMethod]
    public static void CreateInstance_IsTamagotchi_True()
    {
      // Arrange
      Tamagotchi newPet = new Tamagotchi(20);
      //Act, Assert
      Assert.AreEqual(typeof(Tamagotchi), newPet.GetType());
    }
    [TestMethod]
    public static void Tamagotchi_HasAHungerProperty_Property()
    {
      int hungerLevel = 20;
      Tamagotchi newPet = new Tamagotchi(hungerLevel);
      int actualHungerLevel = newPet.Hunger;
      Assert.AreEqual(hungerLevel, actualHungerLevel);
    }


  }
}
