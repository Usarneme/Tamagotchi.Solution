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
    public void CreateInstance_IsTamagotchi_True()
    {
      // Arrange
      Tamagotchi newPet = new Tamagotchi(20, 20, 20);
      //Act, Assert
      Assert.AreEqual(typeof(Tamagotchi), newPet.GetType());
    }

    [TestMethod]
    public void Tamagotchi_HasAHungerProperty_Property()
    {
      int hungerLevel = 30;
      Tamagotchi newPet = new Tamagotchi(hungerLevel, 20 , 20);
      int actualHungerLevel = newPet.Hunger;
      Assert.AreEqual(hungerLevel, actualHungerLevel);
    }


    [TestMethod]
    public void Tamagotchi_HasASleepinessProperty_Property()
    {
      int sleepinessLevel = 30;
      Tamagotchi newPet = new Tamagotchi(20, sleepinessLevel, 20);
      int actualSleepinessLevel = newPet.Sleepiness;
      Assert.AreEqual(sleepinessLevel, actualSleepinessLevel);
    }


    [TestMethod]
    public void Tamagotchi_HasAnAttentionNeedProperty_Property()
    {
      int attentionNeedLevel = 30;
      Tamagotchi newPet = new Tamagotchi(20, 20, attentionNeedLevel);
      int actualAttentionNeedLevel = newPet.AttentionNeed;
      Assert.AreEqual(attentionNeedLevel, actualAttentionNeedLevel);
    }

    [TestMethod]
    public void Tamagotchi_ChangeSleepinessLevel_SleepinessPropertyReduced()
    {
      Tamagotchi newPet = new Tamagotchi(20, 20, 20);
      newPet.Sleepiness = 10;
      Assert.AreEqual(newPet.Sleepiness, 10);
    }

  }
}
