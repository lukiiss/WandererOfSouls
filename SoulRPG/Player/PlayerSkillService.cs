using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class PlayerSkillService
    {
        public PlayerSkill AddNewSkill(string name,int damage,int playerId,List<Player> players,List<PlayerSkill> playerSkills)
        {
            decimal playerSkillDamageMultiplayer = 1;
            int playerSkillDamage = (int)Math.Round(damage * playerSkillDamageMultiplayer);
            int lastId = 0;
            if(playerSkills.Count > 0)
            {
                lastId = players[players.Count - 1].Id;
            }
            foreach (Player player in players) 
            {
                if(player.Id == playerId) 
                {
                    if (player.Strenght > 10)
                    {
                        playerSkillDamageMultiplayer = player.Strenght / 10;
                    }
                }
            }
            int currentId = lastId + 1;
            PlayerSkill playerSkill = new PlayerSkill {Id = currentId, Name = name, Damage = playerSkillDamage,DamageMultiplayer = playerSkillDamageMultiplayer , EntityId = playerId };
            playerSkills.Add(playerSkill);
            return playerSkill;
        }

    }
}
