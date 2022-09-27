using System;

public class Weapon
{
  public string name = "Sword";
  public int maxDamage = 6;
  public int minDamage = 2;
  public int weaponWeight;
  private Random generator = new();

  public int Attack()
  {
    return generator.Next(minDamage, maxDamage);
  }

}
