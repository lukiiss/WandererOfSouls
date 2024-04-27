using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WandererOfSouls
{
    public class MenuActionService
    {

        public void RedTextColor(string number , string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(number);
            Console.ResetColor();
            Console.Write(". " + text + "\n");
        }
        public void choices(string first,string? second,string? third,string? fourth)
        {
            var actionService = new MenuActionService();

            Console.WriteLine("What do you do?");
            actionService.RedTextColor("1", first);
            if (second != null)
            {
                actionService.RedTextColor("2", second);
            }
            if (third != null)
            {
                actionService.RedTextColor("3", third);
            }
            if(fourth != null)
            {
                actionService.RedTextColor("4", fourth);
            }
            Console.WriteLine("Choose an option.");
        }

        public void StartGameView()
        {
            PlayerService playerService = new PlayerService();
            MenuActionService actionService = new MenuActionService();
            EnemyService enemyService = new EnemyService();
            PlayerSkillService playerSkillService = new PlayerSkillService();
            EnemySkillService enemySkillService = new EnemySkillService();
            PlayerSkill playerSkill = new PlayerSkill();
            EnemySkill enemySkill = new EnemySkill();
            ItemService itemService = new ItemService();
            EquipmentService equipment = new EquipmentService();
            List<Enemy> enemies = new List<Enemy>();
            List<EnemySkill> enemySkills = new List<EnemySkill>();
            List<PlayerSkill> playerSkills = new List<PlayerSkill>();
            List<Player> players = new List<Player>();
            List<Item> items = new List<Item>();
            List<Equipment> equipmentList = new List<Equipment>();
            Equipment equipment1 = equipment.AddNewEquipment();
            equipmentList.Add(equipment1);

            Console.WriteLine("Inesrt your name:");
            string name = Console.ReadLine();
            players.Add( playerService.AddNewPlayer(name));
            playerSkillService.AddNewSkill("Light punch", 15, 1,players,playerSkills);
            playerSkillService.AddNewSkill("Heavy punch", 30, 1,players,playerSkills);
            Console.WriteLine("======================");
            Console.WriteLine("| WANDERER OF SOULS  |");
            Console.WriteLine("======================");
            string choice;
            while (true) 
            {
                Console.WriteLine("You awaken in a small hut on the outskirts of a mysterious forest. The air is thick with mist, and the only sound is the distant cry of a lone wolf.");
                actionService.choices("Explore the hut.", "Exit the hut.",null,null);
                choice = Console.ReadLine();
                if(choice == "1" || choice == "2")
                {
                    break;
                }
            }
            switch(choice)
            {
                case "1":
                    while (true)
                    {
                        Console.WriteLine("You take a look around the hut.Inside, you find a weathered journal, a map with cryptic markings, and a satchel containing provisions.");
                        actionService.choices("Read the journal.", "Study the map.", "Leave the hut", null);
                        choice = Console.ReadLine();
                        if(choice == "1" || choice == "2" || choice == "3")
                        {
                            break;
                        }
                    }
                    switch(choice)
                    {
                        case "1":
                            while (true)
                            {
                                Console.WriteLine("You open the journal and read the faded entries, detailing the previous inhabitant's experiences in the forest. You learn about mysterious phenomena in the area and a legend of a powerful artifact hidden in the woods.");
                                Console.WriteLine("You learn about mysterious phenomena in the area and a legend of a powerful artifact hidden in the woods.");
                                actionService.choices("Study map", "Leave the hut", null, null);
                                choice = Console.ReadLine();
                                if(choice == "1")
                                {
                                    Console.WriteLine("The map contains various symbols and notes, suggesting the existence of hidden paths and");
                                    Console.WriteLine("places worth exploring in the area.");

                                    break;
                                }
                                else if(choice == "2")
                                {
                                    break;
                                }
                            }
                            break;
                        case "2":
                            while (true)
                            {
                                Console.WriteLine("The map contains various symbols and notes, suggesting the existence of hidden paths and");
                                Console.WriteLine("places worth exploring in the area.");
                                actionService.choices("Read the journal", "Leave the hut", null, null);
                                choice = Console.ReadLine();
                                if(choice == "1")
                                {
                                    Console.WriteLine("You open the journal and read the faded entries, detailing the previous inhabitant's experiences in the forest. You learn about mysterious phenomena in the area and a legend of a powerful artifact hidden in the woods.");
                                    Console.WriteLine("You learn about mysterious phenomena in the area and a legend of a powerful artifact hidden in the woods.");
                                    break;
                                }
                                else if(choice == "2")
                                {
                                    break;
                                }
                            }
                            break;
                    }
                    break;     
            }
            while (true)
            {
                Console.WriteLine("You step out of the hut, ready for further exploration, but suddenly, you hear suspicious sounds coming from behind the nearby bushes. Without warning, a group of bandits emerges from the bushes, ready to fight!");
                actionService.choices("Fight the bandids.", "Try to persuade them for a peaceful resolution.", "Run away.", null);
                choice = Console.ReadLine();
                if(choice == "1" || choice == "2" || choice == "3") 
                {
                    break;
                }
            }
            switch(choice)
            {
                case "2":
                    while (true)
                    {
                        Console.WriteLine("You attempt to reason with the bandits, hoping to avoid unnecessary conflict. However, they scoff at your attempts at diplomacy and only respond with menacing laughter. It seems they are determined to fight.");
                        actionService.choices("Fight the bandits", "Run away", null, null);
                        choice = Console.ReadLine();
                        if(choice == "1" || choice == "2")
                        {
                            break;
                        }
                    }
                    if(choice == "2")
                    {
                        while (true)
                        {
                            Console.WriteLine("You try to flee from the bandits, hoping to outrun them and avoid confrontation. Unfortunately, your attempt to escape is futile as they quickly catch up to you, blocking your path and leaving you with no choice but to fight.");
                            actionService.choices("Fight the bandits", null, null, null);
                            choice = Console.ReadLine();
                            if(choice == "1")
                            {
                                break;
                            }
                        }
                    }
                    break;
                case "3":
                    while (true)
                    {
                        Console.WriteLine("You try to flee from the bandits, hoping to outrun them and avoid confrontation. Unfortunately, your attempt to escape is futile as they quickly catch up to you, blocking your path and leaving you with no choice but to fight.");
                        actionService.choices("Fight the bandits", "Try to persuade them for a peaceful resolution.", null, null);
                        choice = Console.ReadLine();
                        if (choice == "1" || choice == "2")
                        {
                            break;
                        }
                    }
                    if (choice == "2")
                    {
                        while (true)
                        {
                            Console.WriteLine("You attempt to reason with the bandits, hoping to avoid unnecessary conflict. However, they scoff at your attempts at diplomacy and only respond with menacing laughter. It seems they are determined to fight.");
                            actionService.choices("Fight the bandits", null, null, null);
                            choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                break;
                            }
                        }
                    }
                    break;
            }
            enemies.Add( enemyService.AddNewEnemy("Bandit",1,50,1,0));
            enemySkills.Add(enemySkillService.AddNewSkill("Sneak Attack", 15, enemies[0].Id, enemies, enemySkills));
            enemySkills.Add(enemySkillService.AddNewSkill("Ramming", 10, enemies[0].Id, enemies, enemySkills));
            Console.WriteLine("The bandits quickly close in, ready for a fight. There's no escaping now - it's time to stand your ground!");
            
            Console.WriteLine("The battle begins! The bandits are armed and aggressive, but you have no choice but to fight back and defend yourself against them.");
            while (true)
            {
                Console.WriteLine(players[0].Name + "  Level:" + players[0].Level + "  HP:" + players[0].HP);
                Console.WriteLine(enemies[0].Name + "  Level:" + enemies[0].Level + "  HP:" + enemies[0].HP);
                while (true)
                {
                    actionService.choices("Attack", "Use an item", "Run", null);
                    choice = Console.ReadLine();
                    string choice1 = choice;
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("What do you do?");
                            for (int i = 0; i < playerSkills.Count; i++)
                            {
                                Console.WriteLine(i + 1 + ". " + playerSkills[i].Name);
                            }
                            Console.WriteLine("Choose an option.");
                            choice = Console.ReadLine();
                            int intChoice;
                            int.TryParse(choice, out intChoice);
                            if (intChoice <= playerSkills.Count && intChoice > 0)
                            {
                                switch (intChoice)
                                {
                                    case 1:
                                        playerSkill.UseSkill(playerSkills[0].Id, enemies[0].Id, enemies, players, playerSkills);
                                        break;
                                    case 2:
                                        playerSkill.UseSkill(playerSkills[1].Id, enemies[0].Id, enemies, players, playerSkills);
                                        break;
                                    case 3:
                                        playerSkill.UseSkill(playerSkills[2].Id, enemies[0].Id, enemies, players, playerSkills);
                                        break;
                                    case 4:
                                        playerSkill.UseSkill(playerSkills[3].Id, enemies[0].Id, enemies, players, playerSkills);
                                        break;
                                }

                            }
                            break;
                        case "2":
                            Console.WriteLine("You dont have any Items.");
                            break;
                        case "3":
                            Console.WriteLine("You can't escape because the bandits have surrounded you.");
                            break;
                    }
                    if(choice1 == "1" || choice1 == "3")
                    {
                        break;
                    }
                }
                enemySkill.UseSkill(enemies[0].Id, enemies, players,enemySkills);
                if (enemies[0].HP <= 0)
                {

                    Console.WriteLine("you won the battle, and gain");
                    Console.WriteLine("300XP");
                    playerService.ExpForLvl(300);
                    itemService.AddNewItem("Rusted sword", 2, 0, 5, 5,1);
                    itemService.AddNewItem("Rusted chestplate",1,25,0,2,1);
                    Item droppedItem1 = itemService.EnemyDrop(100, 0, null, null, null, null, null, null);
                    Item droppedItem2 = itemService.EnemyDrop(100, 1, null, null, null, null, null, null);
                    itemService.TextItemColor(null,0 );
                    itemService.TextItemColor(null,1 );
                    players[0].HP = players[0].MaxHP;
                    enemies[0].HP = enemies[0].MaxHP;
                    while (true)
                    {
                        actionService.choices("Open Inventory (You can open inventory by writing /inventory on choose actions)", "Leave", null, null);
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            itemService.InventoryView("/inventory",equipmentList,players);
                        }
                        else if (choice == "2")
                        {
                            break;
                        }
                    }
                    break;
                }
            }
            Console.WriteLine("After you won fight you decide to go to forest.");
            Console.WriteLine("Chcapter 1 ended");
        }
    }
}
