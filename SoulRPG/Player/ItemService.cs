using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WandererOfSouls
{
    public class ItemService
    {
        private List<Item> items = new List<Item>();
        public void InventoryView(string choice,List<Equipment> equipmentList,List<Player> players)
        {
            MenuActionService actionService = new MenuActionService();
            EquipmentService equipmentService = new EquipmentService();
            string choice1;

            if(choice.ToLower() == "/inventory")
            {
                while (true)
                {
                    int i;
                    Console.WriteLine("Inventory:");
                    for (i = 1; i <= items.Count; i++)
                    {
                        TextItemColor(i, i - 1);
                    }
                    Console.WriteLine("Equipment:");

                    int helmetIndex = FindIndex(equipmentList[0].Helmet);
                    Console.Write("Helmet - ");
                    TextItemColor(null, helmetIndex);

                    int chestplateIndex = FindIndex(equipmentList[0].Chestplate);
                    Console.Write("Chestplate - ");
                    TextItemColor(null, chestplateIndex);

                    int pantsIndex = FindIndex(equipmentList[0].Pants);
                    Console.Write("Pants - ");
                    TextItemColor(null, pantsIndex);

                    int bootsIndex = FindIndex(equipmentList[0].Boots);
                    Console.Write("Boots - ");
                    TextItemColor(null, bootsIndex);

                    int weponIndex = FindIndex(equipmentList[0].Wepon);
                    Console.Write("Wepon - ");
                    TextItemColor(null, weponIndex);
                    actionService.choices("Leave", null, null, null);
                    int choiceInt;
                    while (true)
                    {
                        Console.WriteLine("Choice item you want to view");
                        int.TryParse(Console.ReadLine(), out choiceInt);
                        if (choiceInt > 0 && choiceInt <= items.Count || choiceInt == i + 1)
                        {
                            break;
                        }
                    }
                    if (choiceInt == i + 1)
                    {
                        break;
                    }
                    if (choiceInt > 0 && choiceInt <= items.Count)
                    {
                        AllInfo(choiceInt - 1);
                        if (items[choiceInt - 1].IsEquiped == true)
                        {
                            while (true)
                            {
                                actionService.choices("Unequip", "Leave", null, null);
                                choice1 = Console.ReadLine();
                                if (choice1 == "1")
                                {
                                    bool isEmpty = true;
                                    equipmentService.AddEquipment(choiceInt - 1, items, players, isEmpty, items[choiceInt - 1]);
                                    Console.WriteLine("Item unequiped successfully");
                                    break;
                                }
                                else if (choice1 == "2")
                                {
                                    break;
                                }
                            }
                        }
                        else if (items[choiceInt - 1].Type != Item.ItemType.none)
                        {
                            while (true)
                            {
                                actionService.choices("Equip", "Leave", null, null);
                                choice1 = Console.ReadLine();
                                if (choice1 == "1")
                                {
                                    equipmentService.AddEquipment(choiceInt - 1, items, players, null, null);
                                    Console.WriteLine("You successffuly equiped item");
                                    break;
                                }
                                else if (choice1 == "2")
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                actionService.choices("Leave", null, null, null);
                                choice1 = Console.ReadLine();
                                if (choice1 == "1")
                                {
                                    break;
                                }

                            }
                        }

                    }
                }
            }
        }
        public void AllInfo(int index)
        {
            Console.WriteLine($"Id - {items[index].Id} | Name - {items[index].Name} | Strenght - {items[index].Strenght} | Bonus Health - {items[index].Health} | Crit Chance - {items[index].CritChance} | Type - {items[index].Type}");
        }
        public int FindIndex(Item item)
        {
            int index = -1;
            for(int i = 0;i < items.Count;i++)
            {
                if (item != null)
                {
                    if (items[i].Id == item.Id)
                    {
                        index = i;
                        break;
                    }
                }
            }
            return index;

        }

        public Item AddNewItem(string name, int strenght, int health, decimal critChance, int typeId, int rarityId)
        {
            var type = Item.ItemType.none;
            var rarity = Item.ItemRarity.none;
            int lastId = 0;
            if (items.Count > 0)
            {
                lastId = items[items.Count - 1].Id;
            }
            int currentId = lastId + 1;

            switch (typeId)
            {
                case 1:
                    switch (rarityId)
                    {
                        case 1:
                            rarity = Item.ItemRarity.common;
                            type = Item.ItemType.helmet;
                            break;
                        case 2:
                            rarity = Item.ItemRarity.uncommon;
                            type = Item.ItemType.helmet;
                            break;
                        case 3:
                            rarity = Item.ItemRarity.rare;
                            type = Item.ItemType.helmet;
                            break;
                        case 4:
                            rarity = Item.ItemRarity.epic;
                            type = Item.ItemType.helmet;
                            break;
                        case 5:
                            rarity = Item.ItemRarity.legendary;
                            type = Item.ItemType.helmet;
                            break;
                        default:
                            type = Item.ItemType.helmet;
                            break;
                    }
                    break;
                case 2:
                    switch (rarityId)
                    {
                        case 1:
                            rarity = Item.ItemRarity.common;
                            type = Item.ItemType.chestplate;
                            break;
                        case 2:
                            rarity = Item.ItemRarity.uncommon;
;                            type = Item.ItemType.chestplate;
                            break;
                        case 3:
                            rarity = Item.ItemRarity.rare;
                            type = Item.ItemType.chestplate;
                            break;
                        case 4:
                            rarity = Item.ItemRarity.epic;
                            type = Item.ItemType.chestplate;
                            break;
                        case 5:
                            rarity = Item.ItemRarity.legendary;
                            type = Item.ItemType.chestplate;
                            break;
                        default:
                            type = Item.ItemType.chestplate;
                            break;
                    }
                    break;
                case 3:
                    switch (rarityId)
                    {
                        case 1:
                            rarity = Item.ItemRarity.common;
                            type = Item.ItemType.pants;
                            break;
                        case 2:
                            rarity = Item.ItemRarity.uncommon;
                            type = Item.ItemType.pants;
                            break;
                        case 3:
                            rarity = Item.ItemRarity.rare;
                            type = Item.ItemType.pants;
                            break;
                        case 4:
                            rarity = Item.ItemRarity.epic;
                            type = Item.ItemType.pants;
                            break;
                        case 5:
                            rarity = Item.ItemRarity.legendary;
                            type = Item.ItemType.pants;
                            break;
                        default:
                            type = Item.ItemType.pants;
                            break;
                    }
                    break;
                case 4:
                    switch (rarityId)
                    {
                        case 1:
                            rarity = Item.ItemRarity.common;
                            type = Item.ItemType.boots;
                            break;
                        case 2:
                            rarity = Item.ItemRarity.uncommon;
                            type = Item.ItemType.boots;
                            break;
                        case 3:
                            rarity = Item.ItemRarity.rare;
                            type = Item.ItemType.boots;
                            break;
                        case 4:
                            rarity = Item.ItemRarity.epic;
                            type = Item.ItemType.boots;
                            break;
                        case 5:
                            rarity = Item.ItemRarity.legendary;
                            type = Item.ItemType.boots;
                            break;
                        default:
                            type = Item.ItemType.boots;
                            break;
                    }
                    break;
                case 5:
                    switch (rarityId)
                    {
                        case 1:
                            rarity = Item.ItemRarity.common;
                            type = Item.ItemType.wepon;
                            break;
                        case 2:
                            rarity = Item.ItemRarity.uncommon;
                            type = Item.ItemType.wepon;
                            break;
                        case 3:
                            rarity = Item.ItemRarity.rare;
                            type = Item.ItemType.wepon;
                            break;
                        case 4:
                            rarity = Item.ItemRarity.epic;
                            type = Item.ItemType.wepon;
                            break;
                        case 5:
                            rarity = Item.ItemRarity.legendary;
                            type = Item.ItemType.wepon;
                            break;
                        default:
                            type = Item.ItemType.wepon;
                            break;
                    }
                    break;
                case 6:
                    switch (rarityId)
                    {
                        case 1:
                            rarity = Item.ItemRarity.common;
                            type = Item.ItemType.useableItem;
                            break;
                        case 2:
                            rarity = Item.ItemRarity.uncommon;
                            type = Item.ItemType.useableItem;
                            break;
                        case 3:
                            rarity = Item.ItemRarity.rare;
                            type = Item.ItemType.useableItem;
                            break;
                        case 4:
                            rarity = Item.ItemRarity.epic;
                            type = Item.ItemType.useableItem;
                            break;
                        case 5:
                            rarity = Item.ItemRarity.legendary;
                            type = Item.ItemType.useableItem;
                            break;
                        default:
                            type = Item.ItemType.useableItem;
                            break;
                    }
                    break;
                default:
                    switch (rarityId)
                    {
                        case 1:
                            rarity = Item.ItemRarity.common;
                            break;
                        case 2:;
                            rarity = Item.ItemRarity.uncommon;
                            break;
                        case 3:
                            rarity = Item.ItemRarity.rare;
                            break;
                        case 4:
                            rarity = Item.ItemRarity.epic;
                            break;
                        case 5:
                            rarity = Item.ItemRarity.legendary;
                            break;
                    }
                    break;
            }

            Item item = new Item { Id = currentId, Name = name, Strenght = strenght, Health = health, CritChance = critChance, Type = type, Rarity = rarity, IsEquiped = false };
            items.Add(item);
            return item;
        }
        
        public void TextItemColor(int? number, int itemIndex)
        {
            if (itemIndex == -1)
            {
                Console.WriteLine("Empty \n");
            }
            else
            {
                string name = items[itemIndex].Name;
                if (items[itemIndex].Rarity == Item.ItemRarity.common)
                {
                    if (number != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(number);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(". " + name + "\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(name + "\n");
                        Console.ResetColor();
                    }
                }
                else if (items[itemIndex].Rarity == Item.ItemRarity.uncommon)
                {
                    if (number != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(number);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(". " + name + "\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(name + "\n");
                        Console.ResetColor();
                    }
                }
                else if (items[itemIndex].Rarity == Item.ItemRarity.epic)
                {
                    if (number != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(number);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(". " + name + "\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(name + "\n");
                        Console.ResetColor();
                    }
                }
                else if (items[itemIndex].Rarity == Item.ItemRarity.legendary)
                {
                    if (number != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(number);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(". " + name + "\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(name + "\n");
                        Console.ResetColor();
                    }
                }
                else
                {
                    if (number != null)
                    {
                        Console.WriteLine(number + ". " + name + "\n");
                    }
                    else
                    {
                        Console.Write(name + "\n");
                    }
                }
            }
        }
                public Item EnemyDrop(double? dropChance1,int item1,double? dropChance2,Item? item2, double? dropChance3, Item? item3, double? dropChance4, Item? item4)
        {
            Random random = new Random();
            double drop = (random.NextDouble() * (100 - 0.01)) + 0.01;
            Item droppedItem = new Item { };
            if (drop <= dropChance1 && drop > 0)
            {
                droppedItem = items[item1];
            }
            else if (drop <= dropChance2 && drop > dropChance1)
            {
                droppedItem = item2;
            }
            else if (drop <= dropChance3 && drop > dropChance1 + dropChance2)
            {
                droppedItem = item3;
            }
            else if (drop <= dropChance4 && drop > dropChance1 + dropChance2 + dropChance3)
            {
                droppedItem = item4;
            }
            
            return droppedItem;
        }
    }
}
