using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class PlayerSkillService
    {
        private List<Player> players = new List<Player>();
        private List<PlayerSkill> playerSkills = new List<PlayerSkill>();
        public PlayerSkill AddNewSkill(int id,string name,int damage,int playerId)
        {
            PlayerSkillService playerSkillService = new PlayerSkillService();
            decimal playerSkillDamageMultiplayer = 1;
            int playerSkillDamage = (int)Math.Round(damage * playerSkillDamageMultiplayer);
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
            PlayerSkill playerSkill = new PlayerSkill {Id = id, Name = name, Damage = playerSkillDamage,DamageMultiplayer = playerSkillDamageMultiplayer , EntityId = playerId };
            playerSkillService.playerSkills.Add(playerSkill);
            return playerSkill;
        }
        public void AddNewSkillToPlayer(int skillId, int playerId)
        {
            foreach (Player player in players)
            {
                if (player.Id == playerId)
                {
                    foreach (PlayerSkill playerSkill in playerSkills)
                    {
                        if (playerSkill.Id == skillId)
                        {
                            if (playerSkills.Count < 4)
                            {
                                player.Skills.Add(playerSkill);
                                playerSkills.Add(playerSkill);
                            }
                            else
                            {
                                Console.WriteLine("You have max skill count and must delete one of them to get this skill");
                                for (int i = 0; i < playerSkills.Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ". " + playerSkills[i].Name);
                                }
                                string stringChoice = Console.ReadLine();
                                int choice;
                                int.TryParse(stringChoice, out choice);
                                switch (choice)
                                {
                                    case 1:
                                        playerSkills[0] = playerSkill;
                                        break;
                                    case 2:
                                        playerSkills[1] = playerSkill;
                                        break;
                                    case 3:
                                        playerSkills[2] = playerSkill;
                                        break;
                                    case 4:
                                        playerSkills[3] = playerSkill;
                                        break;
                                }
                            }
                        }
                        break;
                    }
                }
            }
        }
        public List<PlayerSkill> AllPlayerSkills()
        {
            return playerSkills;
        }

    }
}
