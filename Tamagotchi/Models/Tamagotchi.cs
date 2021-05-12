namespace TamagotchiNamespace
{
  public class Tamagotchi
  {

    public int Hunger { get; set; }
    public int Sleepiness { get; set; }
    public int AttentionNeed { get; set; }
    public string Name { get; }

    public Tamagotchi(int hunger, int sleepiness, int attentionNeed, string name)
    {
      Hunger = hunger;
      Sleepiness = sleepiness;
      AttentionNeed = attentionNeed;
      Name = name;
    }
    public static void ClearAll()
    {
      // todo
    }
  }
}
