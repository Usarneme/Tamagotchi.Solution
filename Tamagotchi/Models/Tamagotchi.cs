using System.Collections.Generic;

namespace TamagotchiNamespace
{
  public class Tamagotchi
  {

    public int HungerLevel { get; set; }
    public int SleepinessLevel { get; set; }
    public int AttentionLevel { get; set; }
    public string Name { get; }
    public int ID { get; }
    private static int _idCounter = 1;
    public static List<Tamagotchi> allTamagotchis = new List<Tamagotchi>();

    public Tamagotchi(int hunger, int sleepiness, int attention, string name)
    {
      HungerLevel = hunger;
      SleepinessLevel = sleepiness;
      AttentionLevel = attention;
      Name = name;
      ID = _idCounter;
      _idCounter += 1;
      allTamagotchis.Add(this);
    }

    public static void Feed(int id)
    {
      foreach(Tamagotchi thisPet in allTamagotchis)
      {
        if (thisPet.ID == id)
        {
          thisPet.HungerLevel += 60;
        }
      }
      PassTime();
    }

    public static void Rest(int id)
    {
      foreach(Tamagotchi thisPet in allTamagotchis)
      {
        if (thisPet.ID == id)
        {
          thisPet.SleepinessLevel += 60;
        }
      }
      PassTime();
    }

    public static void GiveAttention(int id)
    {
      foreach(Tamagotchi thisPet in allTamagotchis)
      {
        if (thisPet.ID == id)
        {
          thisPet.AttentionLevel += 60;
        }
      }
      PassTime();
    }

    public static void PassTime()
    {
      foreach(Tamagotchi tamagotchi in allTamagotchis)
      {
        tamagotchi.HungerLevel -= 10;
        tamagotchi.SleepinessLevel -= 10;
        tamagotchi.AttentionLevel -= 10;
      }
      allTamagotchis.RemoveAll(tamagotchi => tamagotchi.HungerLevel <= 0 || tamagotchi.SleepinessLevel <= 0 || tamagotchi.AttentionLevel <= 0);
    }
  }
}
