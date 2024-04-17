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
        public void UseSkill(int skillId,int id)
        {
            EnemyService enemyService = new EnemyService();
            PlayerSkillService playerSkillService = new PlayerSkillService();
            var enemies = enemyService.AllEnemies();
            var players = new List<Player>();

            int enemyIndex = -1;
            int skillIndex = -1;
            int damage;
            for (int i = 0; i < enemies.Count; i++)
            {
                if (id == enemies[i].Id)
                {
                    enemyIndex = i;
                }
            }   
            for(int i = 0; i < players[0].Skills.Count; i++) 
            { 
                if(skillId == players[0].Id) 
                {   
                    skillIndex = i;
                }
            }
            if (skillIndex != -1 && enemyIndex != -1)
            {
                damage = players[0].Skills[skillIndex].Damage;
                enemies[enemyIndex].HP = -damage;
            }
        }

    }

    
}
