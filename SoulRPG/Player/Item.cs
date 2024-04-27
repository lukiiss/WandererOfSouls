using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Strenght { get; set; }
        public int Health { get; set; }
        public decimal CritChance { get; set; }
        public enum ItemType
        {
            helmet,
            chestplate,
            pants,
            boots,
            wepon,
            useableItem,
            none
        }
        public ItemType Type { get; set; }
        public enum ItemRarity
        {
            common,
            uncommon,
            rare,
            epic,
            legendary,
            none
        }
        public ItemRarity Rarity { get; set; }
        public bool IsEquiped { get; set; }

        public Item()
        {

        }
        public Item(int id,string name,int strenght,int health,decimal critChance,ItemType type,ItemRarity rarity)
        {
            Id = id;
            Name = name;
            Strenght = strenght;
            Health = health;
            CritChance = critChance;
            this.Type = type;
            this.Rarity = rarity;
            IsEquiped = false;
        }
    }
}
