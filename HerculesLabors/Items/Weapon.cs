using System;

namespace HerculesLabors.Items ;
public class Weapon : Item
{
    public int Damage { get; private set; }

    public Weapon(string name, int damage, int weight)
    {
        throw new NotImplementedException();
    }

    private void UpgradeWeapons()
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