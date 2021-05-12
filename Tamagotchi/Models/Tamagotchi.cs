using System.Collections.Generic;

namespace TamagotchiNamespace
{
  public class Tamagotchi
  {

    public int Hunger { get; set; }
    public int Sleepiness { get; set; }
    public int AttentionNeed { get; set; }
    public string Name { get; }

    private static List<Tamagotchi> _allTamagotchis = new List<Tamagotchi>();

    public Tamagotchi(int hunger, int sleepiness, int attentionNeed, string name)
    {
      Hunger = hunger;
      Sleepiness = sleepiness;
      AttentionNeed = attentionNeed;
      Name = name;
      _allTamagotchis.Add(this);
    }

    public static void PassTime()
    {
      foreach(Tamagotchi tamagotchi in _allTamagotchis)
      {
        tamagotchi.Hunger -= 10;
        tamagotchi.Sleepiness -= 10;
        tamagotchi.AttentionNeed -= 10;
      }
    }
  }
}
