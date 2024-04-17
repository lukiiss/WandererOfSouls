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
            Player player = new Player() { Id = lastId, Name = name ,Level = 1,MaxHP = 100,HP = 100,Strenght = 1,CritChance = 0};
            players.Add(player);
            return player;
        }
       
    }
}
