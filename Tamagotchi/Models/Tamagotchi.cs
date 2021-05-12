namespace TamagotchiNamespace
{
  public class Tamagotchi
  {

    public int Hunger { get; set; }
    public int Sleepiness { get; set; }
    public int AttentionNeed { get; set; }

    public Tamagotchi(int hunger, int sleepiness, int attentionNeed)
    {
      Hunger = hunger;
      Sleepiness = sleepiness;
      AttentionNeed = attentionNeed;
    }
    public static void ClearAll()
    {
      // todo
    }
  }
}
