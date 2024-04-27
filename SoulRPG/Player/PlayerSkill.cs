using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class PlayerSkill : ISkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public decimal DamageMultiplayer { get; set; }
        public int EntityId { get; set; }
        public void UseSkill(int skillId,int enemyId,List<Enemy> enemies,List<Player> players,List<PlayerSkill> playerSkills)
        {
            EnemyService enemyService = new EnemyService();
            PlayerSkillService playerSkillService = new PlayerSkillService();
            int enemyIndex = -1;
            int skillIndex = -1;
            int damage;
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemyId == enemies[i].Id)
                {
                    enemyIndex = i;
                }
            }   
            for(int i = 0; i < playerSkills.Count; i++) 
            { 
                if(skillId == playerSkills[i].Id) 
                {   
                    skillIndex = i;
                }
            }
            if (skillIndex != -1 && enemyIndex != -1)
            {
                damage = playerSkills[skillIndex].Damage;
                enemies[enemyIndex].HP = enemies[enemyIndex].HP - damage;
                Console.WriteLine("you use an attack named " + playerSkills[skillIndex].Name + " and dealt " + playerSkills[skillIndex].Damage + " dmg.");
                Thread.Sleep(2000);
            }
        }

    }

    
}
