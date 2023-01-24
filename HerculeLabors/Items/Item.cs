using System;

namespace HerculesLabors.Items;

public delegate void Upgrade();
public abstract class Item
{
    public int Weight { get; protected set; }
    public string Name { get; protected set; }
    public abstract Upgrade UpgradeMe();
}
