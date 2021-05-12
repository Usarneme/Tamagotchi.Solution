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
      Tamagotchi newPet = new Tamagotchi();
      //Act, Assert
      Assert.AreEqual(typeof(Tamagotchi), newPet.GetType());
    }
  }
}
