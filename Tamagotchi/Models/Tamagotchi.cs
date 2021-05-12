using System.Collections.Generic;

namespace TamagotchiNamespace
{
  public class Tamagotchi
  {

    public int Hunger { get; set; }
    public int Sleepiness { get; set; }
    public int AttentionNeed { get; set; }
    public string Name { get; }
    public int ID { get; }
    private static int _idCounter = 1;
    public static List<Tamagotchi> allTamagotchis = new List<Tamagotchi>();

    public Tamagotchi(int hunger, int sleepiness, int attentionNeed, string name)
    {
      Hunger = hunger;
      Sleepiness = sleepiness;
      AttentionNeed = attentionNeed;
      Name = name;
      ID = _idCounter;
      _idCounter += 1;
      allTamagotchis.Add(this);
    }

    public void Feed(Tamagotchi thisPet)
    {
      thisPet.Hunger += 60;
      PassTime();
    }

    public void Rest(Tamagotchi thisPet)
    {
      thisPet.Sleepiness += 60;
      PassTime();
    }

    public void GiveAttention(Tamagotchi thisPet)
    {
      thisPet.AttentionNeed += 60;
      PassTime();
    }

    public static void PassTime()
    {
      foreach(Tamagotchi tamagotchi in allTamagotchis)
      {
        tamagotchi.Hunger -= 10;
        tamagotchi.Sleepiness -= 10;
        tamagotchi.AttentionNeed -= 10;
      }
    }
  }
}
