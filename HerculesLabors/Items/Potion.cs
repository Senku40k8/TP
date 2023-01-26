using System;

namespace HerculesLabors.Items;

public delegate void Booster(Hercules hercules);
public class Potion : Item
{
    private Booster Boost { get;  set; }
    public int BoostEfficiency { get; private set; }

    public Potion(string name, int weight, int boostEfficiency = 1)
    {
        throw new NotImplementedException();
    }

    private static void BoostHealthLow(Hercules hercules)
    {
        throw new NotImplementedException();
    }

    private static void BoostHealthMedium(Hercules hercules)
    {
        throw new NotImplementedException();
    }

    private static void BoostHealthHigh(Hercules hercules)
    {
        throw new NotImplementedException();
    }

    public void Use(Hercules hercules)
    {
        throw new NotImplementedException();
    }

    private static Booster FindBoost(int boostEfficiency)
    {
        throw new NotImplementedException();
    }

    private void UpgradePotions()
    {
        throw new NotImplementedException();
    }

    public override Upgrade UpgradeMe()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
        
}
