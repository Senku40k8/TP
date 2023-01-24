using System;
using System.Collections.Generic;
using HerculesLabors.Items;

namespace HerculesLabors ;
public class Hercules
{
    
    public int Health { get; set; }
    public List<Item> Bag { get;}
    public int Strength { get; set;}
    
    public bool TrueHero { get; set;}

    public Hercules()
    {
        throw new NotImplementedException();
    }

    public bool IsAlive()
    {
        throw new NotImplementedException();
    }

    public void ClearInventory()
    {
        throw new NotImplementedException();
    }
    public void PrintBag()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }

    public void PrintStat()
    {
        throw new NotImplementedException();
    }

    public void RemoveItem(Item item)
    {
        throw new NotImplementedException();
    }

    public void UpgradeAll()
    {
        throw new NotImplementedException();
    }

    public List<Item> GetWeapons()
    {
        throw new NotImplementedException();
    }

    public List<Item> GetPotions()
    {
        throw new NotImplementedException();
    }

    public int GetAttackDamage()
    {
        throw new NotImplementedException();
    }

    public int GetBagWeight()
    {
        throw new NotImplementedException();
    }

    public void AddLoot(List<Item> toAdd)
    {
        throw new NotImplementedException();
    }

    public Item FindBookByName(String str)
    {
        throw new NotImplementedException();
    }

    public bool TalkToGod(string god)
    {
        throw new NotImplementedException();
    }

    public void Battle(Monsters.Monster monster)
    {
        throw new NotImplementedException();
    }

    public void SortBag(Comparison<Item> func)
    {
        throw new NotImplementedException();
    }
}