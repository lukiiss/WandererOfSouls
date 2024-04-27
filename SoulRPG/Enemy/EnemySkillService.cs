using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class EnemySkillService
    {
        public EnemySkill AddNewSkill(string name, int damage, int enemyId,List<Enemy> enemies,List<EnemySkill> enemySkills)
        {
            decimal enemySkillDamageMultiplayer = 1;
            int enemySkillDamage = (int)Math.Round(damage * enemySkillDamageMultiplayer);
            int lastId = 0;
            if(enemies.Count > 0) 
            { 
                lastId = enemies[enemies.Count - 1].Id;
            }
            foreach (Enemy enemy in enemies)
            {
                if (enemy.Id == enemyId)
                {
                    if (enemy.Strenght > 10)
                    {
                        enemySkillDamageMultiplayer = enemy.Strenght / 10;
                    }
                }
            }
            int currentId = lastId + 1;
            EnemySkill enemySkill = new EnemySkill { Id = currentId, Name = name, Damage = enemySkillDamage, DamageMultiplayer = enemySkillDamageMultiplayer, EntityId = enemyId };
            enemySkills.Add(enemySkill);
            return enemySkill;
        }
    }
}
