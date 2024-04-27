using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class EquipmentService
    {
        public List<Equipment> EquipmentList = new List<Equipment>();
        
        public Equipment AddNewEquipment()
        {
            Equipment equipment = new Equipment { Boots = null, Chestplate = null, Helmet = null, Pants = null, Wepon = null};

            EquipmentList.Add(equipment);
            return equipment;
        }

        public void AddEquipment(int itemIndex,List<Item> items,List<Player> players,bool? isEmpty,Item item1)
        {
            Item lastHelmet = null;
            Item lastChestplate = null;
            Item lastPants = null;
            Item lastBoots = null;
            Item lastWepon = null;
            Item item;
            if (isEmpty == true)
            {
                var itemType = item1.Type;
                item = new Item() { Id = 0, Name = "", Strenght = 0, Health = 0, CritChance = 0, Type = itemType, Rarity = Item.ItemRarity.none, IsEquiped = false };
                if (item.Type == Item.ItemType.helmet)
                {
                    if (EquipmentList[0].Helmet != null)
                    {
                        players[0].Strenght -= lastHelmet.Strenght;
                        players[0].HP -= lastHelmet.Health;
                        players[0].CritChance -= lastHelmet.CritChance;
                        lastHelmet.IsEquiped = false;
                    }
                    EquipmentList[0].Helmet = item;
                    lastHelmet = EquipmentList[0].Helmet;
                    players[0].Strenght += lastHelmet.Strenght;
                    players[0].HP += lastHelmet.Health;
                    players[0].CritChance += lastHelmet.CritChance;
                    item.IsEquiped = true;
                }
                else if (item.Type == Item.ItemType.chestplate)
                {
                    if (EquipmentList[0].Chestplate != null)
                    {
                        players[0].Strenght -= lastChestplate.Strenght;
                        players[0].HP -= lastChestplate.Health;
                        players[0].CritChance -= lastChestplate.CritChance;
                        lastChestplate.IsEquiped = false;
                    }
                    EquipmentList[0].Chestplate = item;
                    lastPants = EquipmentList[0].Chestplate;
                    players[0].Strenght += lastChestplate.Strenght;
                    players[0].HP += lastChestplate.Health;
                    players[0].CritChance += lastChestplate.CritChance;
                    item.IsEquiped = true;
                }
                else if (item.Type == Item.ItemType.pants)
                {
                    if (EquipmentList[0].Pants != null)
                    {
                        players[0].Strenght -= lastPants.Strenght;
                        players[0].HP -= lastPants.Health;
                        players[0].CritChance -= lastPants.CritChance;
                        lastPants.IsEquiped = false;
                    }
                    EquipmentList[0].Pants = item;
                    lastPants = EquipmentList[0].Pants;
                    players[0].Strenght += lastPants.Strenght;
                    players[0].HP += lastPants.Health;
                    players[0].CritChance += lastPants.CritChance;
                    item.IsEquiped = true;
                }
                else if (item.Type == Item.ItemType.boots)
                {
                    if (EquipmentList[0].Boots != null)
                    {
                        players[0].Strenght -= lastBoots.Strenght;
                        players[0].HP -= lastBoots.Health;
                        players[0].CritChance -= lastBoots.CritChance;
                        lastBoots.IsEquiped = false;
                    }
                    EquipmentList[0].Boots = item;
                    lastBoots = EquipmentList[0].Boots;
                    players[0].Strenght += lastBoots.Strenght;
                    players[0].HP += lastBoots.Health;
                    players[0].CritChance += lastBoots.CritChance;
                    item.IsEquiped = true;
                }
                else if (item.Type == Item.ItemType.wepon)
                {
                    if (EquipmentList[0].Wepon != null)
                    {
                        players[0].Strenght -= lastWepon.Strenght;
                        players[0].HP -= lastWepon.Health;
                        players[0].CritChance -= lastWepon.CritChance;
                        lastWepon.IsEquiped = false;
                    }
                    EquipmentList[0].Wepon = item;
                    lastWepon = EquipmentList[0].Wepon;
                    players[0].Strenght += lastWepon.Strenght;
                    players[0].HP += lastWepon.Health;
                    players[0].CritChance += lastWepon.CritChance;
                    item.IsEquiped = true;
                }
            }
            else
            {
                if (items[itemIndex].Type == Item.ItemType.helmet)
                {
                    if (EquipmentList[0].Helmet != null)
                    {
                        players[0].Strenght -= lastHelmet.Strenght;
                        players[0].HP -= lastHelmet.Health;
                        players[0].CritChance -= lastHelmet.CritChance;
                        lastHelmet.IsEquiped = false;
                    }
                    EquipmentList[0].Helmet = items[itemIndex];
                    lastHelmet = EquipmentList[0].Helmet;
                    players[0].Strenght += lastHelmet.Strenght;
                    players[0].HP += lastHelmet.Health;
                    players[0].CritChance += lastHelmet.CritChance;
                    items[itemIndex].IsEquiped = true;
                }
                else if (items[itemIndex].Type == Item.ItemType.chestplate)
                {
                    if (EquipmentList[0].Chestplate != null)
                    {
                        players[0].Strenght -= lastChestplate.Strenght;
                        players[0].HP -= lastChestplate.Health;
                        players[0].CritChance -= lastChestplate.CritChance;
                        lastChestplate.IsEquiped = false;
                    }
                    EquipmentList[0].Chestplate = items[itemIndex];
                    lastPants = EquipmentList[0].Chestplate;
                    players[0].Strenght += lastChestplate.Strenght;
                    players[0].HP += lastChestplate.Health;
                    players[0].CritChance += lastChestplate.CritChance;
                    items[itemIndex].IsEquiped = true;
                }
                else if (items[itemIndex].Type == Item.ItemType.pants)
                {
                    if (EquipmentList[0].Pants != null)
                    {
                        players[0].Strenght -= lastPants.Strenght;
                        players[0].HP -= lastPants.Health;
                        players[0].CritChance -= lastPants.CritChance;
                        lastPants.IsEquiped = false;
                    }
                    EquipmentList[0].Pants = items[itemIndex];
                    lastPants = EquipmentList[0].Pants;
                    players[0].Strenght += lastPants.Strenght;
                    players[0].HP += lastPants.Health;
                    players[0].CritChance += lastPants.CritChance;
                    items[itemIndex].IsEquiped = true;
                }
                else if (items[itemIndex].Type == Item.ItemType.boots)
                {
                    if (EquipmentList[0].Boots != null)
                    {
                        players[0].Strenght -= lastBoots.Strenght;
                        players[0].HP -= lastBoots.Health;
                        players[0].CritChance -= lastBoots.CritChance;
                        lastBoots.IsEquiped = false;
                    }
                    EquipmentList[0].Boots = items[itemIndex];
                    lastBoots = EquipmentList[0].Boots;
                    players[0].Strenght += lastBoots.Strenght;
                    players[0].HP += lastBoots.Health;
                    players[0].CritChance += lastBoots.CritChance;
                    items[itemIndex].IsEquiped = true;
                }
                else if (items[itemIndex].Type == Item.ItemType.wepon)
                {
                    if (EquipmentList[0].Wepon != null)
                    {
                        players[0].Strenght -= lastWepon.Strenght;
                        players[0].HP -= lastWepon.Health;
                        players[0].CritChance -= lastWepon.CritChance;
                        lastWepon.IsEquiped = false;
                    }
                    EquipmentList[0].Wepon = items[itemIndex];
                    lastWepon = EquipmentList[0].Wepon;
                    players[0].Strenght += lastWepon.Strenght;
                    players[0].HP += lastWepon.Health;
                    players[0].CritChance += lastWepon.CritChance;
                    items[itemIndex].IsEquiped = true;
                }
                else
                {
                    Console.WriteLine("You can`t equip this item");
                }
            }
        }
    }
}
