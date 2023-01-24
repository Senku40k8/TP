using System;
using System.Collections.Generic;
using HerculesLabors.Items;

namespace HerculesLabors.Monsters
{
    public class Monster
    {
        public int Health { get; set;}
        public int Damage { get; protected set; }
        public string Name { get; protected set; }
        
        public List<Item> Loot { get; protected set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
            
    }
}