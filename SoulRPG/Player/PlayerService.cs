using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WandererOfSouls
{
    public class PlayerService
    {
        private List<Player> players = new List<Player>();
        private List<PlayerSkill> _playerSkills = new List<PlayerSkill>();
        public Player AddNewPlayer(string name)
        {
            int playersCount = players.Count;
            int lastId = 0;
            if (playersCount > 0)
            {
                lastId = players[playersCount - 1].Id;
            }
            int currentId = lastId + 1;
            Player player = new Player() { Id = currentId, Name = name ,Level = 1,Exp = 0,MaxHP = 100,HP = 100,Strenght = 1,CritChance = 0};
            players.Add(player);
            return player;
        }
        public void PointsOnLvlUp()
        {
            MenuActionService actionService = new MenuActionService();
            Console.WriteLine("You can spend your points on one of your stats which stat you want to incerese");
            actionService.choices($"HP {players[0].HP}",$"Strenght {players[0].Strenght}",$"Crit chance {players[0].CritChance}",null);
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    players[0].HP += 20;
                    Console.WriteLine("Now you have 20 HP more.");
                    break;
                case "2":
                    players[0].Strenght += 5;
                    Console.WriteLine("Now you chave 5 Strenght more.");
                    break;
                case "3":
                    players[0].CritChance += 2;
                    Console.WriteLine("Nowe you have 2% Crit Chance more.");
                    break;
            }

        }
        public void ExpForLvl(int exp)
        {
            int level = 1;
            int levelExp = 0;
            exp += levelExp;
            if(exp > 200 && level == 1)
            {
                level = 2;
                levelExp = exp - 200;
                players[0].Level = level;
                Console.WriteLine("Level up!!!");
                Console.WriteLine($"Level {level}  {exp - 200}/400xp");

            }
            if(exp > 400 && level==2)
            {
                level = 3;
                levelExp = exp - 400;
                players[0].Level = level;
                Console.WriteLine("Level up!!!");
                Console.WriteLine($"Level {level}  {exp - 400}/600xp");
            }
            if(exp > 600 && level==3)
            {
                level = 4;
                levelExp = exp - 600;
                players[0].Level = level;
                Console.WriteLine("Level up!!!");
                Console.WriteLine($"Level {level}  {exp - 600}/800xp");
            }
        }
    }
}
