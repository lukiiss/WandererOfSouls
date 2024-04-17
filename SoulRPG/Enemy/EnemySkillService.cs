using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class EnemySkillService
    {
        public EnemySkill AddNewSkill(int id, string name, int damage, int enemyId)
        {
            List<Enemy> enemies = new List<Enemy>();
            List<EnemySkill> enemiesSkills = new List<EnemySkill>();

            decimal enemySkillDamageMultiplayer = 1;
            int enemySkillDamage = (int)Math.Round(damage * enemySkillDamageMultiplayer);
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
            EnemySkill enemySkill = new EnemySkill { Id = id, Name = name, Damage = enemySkillDamage, DamageMultiplayer = enemySkillDamageMultiplayer, EntityId = enemyId };
            enemiesSkills.Add(enemySkill);
            return enemySkill;
        }
    }
}
