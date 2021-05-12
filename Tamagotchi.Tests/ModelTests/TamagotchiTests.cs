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
      Tamagotchi newPet = new Tamagotchi(20, 20, 20, "Name");
      //Act, Assert
      Assert.AreEqual(typeof(Tamagotchi), newPet.GetType());
    }

    [TestMethod]
    public void Tamagotchi_HasAHungerProperty_Property()
    {
      int hungerLevel = 30;
      Tamagotchi newPet = new Tamagotchi(hungerLevel, 20 , 20, "Name");
      int actualHungerLevel = newPet.Hunger;
      Assert.AreEqual(hungerLevel, actualHungerLevel);
    }


    [TestMethod]
    public void Tamagotchi_HasASleepinessProperty_Property()
    {
      int sleepinessLevel = 30;
      Tamagotchi newPet = new Tamagotchi(20, sleepinessLevel, 20, "Name");
      int actualSleepinessLevel = newPet.Sleepiness;
      Assert.AreEqual(sleepinessLevel, actualSleepinessLevel);
    }


    [TestMethod]
    public void Tamagotchi_HasAnAttentionNeedProperty_Property()
    {
      int attentionNeedLevel = 30;
      Tamagotchi newPet = new Tamagotchi(20, 20, attentionNeedLevel, "Name");
      int actualAttentionNeedLevel = newPet.AttentionNeed;
      Assert.AreEqual(attentionNeedLevel, actualAttentionNeedLevel);
    }

    [TestMethod]
    public void Tamagotchi_ChangeSleepinessLevel_SleepinessPropertyReduced()
    {
      Tamagotchi newPet = new Tamagotchi(20, 20, 20, "Name");
      newPet.Sleepiness = 10;
      Assert.AreEqual(newPet.Sleepiness, 10);
    }
    [TestMethod]
    public void Tamagotchi_NameIt_HasAName()
    {
      string name = "Rusty";
      Tamagotchi newPet = new Tamagotchi(20, 20, 20, name);
      Assert.AreEqual(newPet.Name, name);
    }

    [TestMethod]
    public void Tamagotchis_PassTime_FirstInstanceSleepinessReduced()
    {
      Tamagotchi pet1 = new Tamagotchi(50,50,50,"one");
      Tamagotchi pet2 = new Tamagotchi(40,40,40,"two");
      Tamagotchi.PassTime();
      Assert.AreEqual(pet1.Sleepiness, 40);
    }

    [TestMethod]
    public void Tamagotchis_PassTime_SecondInstanceHungerReduced()
    {
      Tamagotchi pet1 = new Tamagotchi(50,50,50,"one");
      Tamagotchi pet2 = new Tamagotchi(40,40,40,"two");
      Tamagotchi.PassTime();
      Assert.AreEqual(pet2.Hunger, 30);
    }
  }
}
