using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class EnemyService
    {
        private List<Enemy> enemies = new List<Enemy>();

        public Enemy AddNewEnemy(string name, int level,int healthPoints,int strenght,decimal critChance)
        {
            int enemiesCount = enemies.Count;
            int lastId = 0;
            if (enemiesCount > 0)
            {
                lastId = enemies[enemiesCount - 1].Id;
            }
            Enemy enemy = new Enemy() { Id = lastId, Name = name, Level = level, HP = healthPoints, Strenght = strenght, CritChance = critChance };
            enemies.Add(enemy);
            return enemy;
        }
        public List<Enemy> AllEnemies()
        {
            return enemies;
        }
    }
}
