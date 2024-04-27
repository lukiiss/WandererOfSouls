using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class EnemySkill : ISkill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public decimal DamageMultiplayer { get; set; }
        public int EntityId { get; set; }

        public void UseSkill(int playerId,List<Enemy> enemies, List<Player> players,List<EnemySkill> enemySkills)
        {
            PlayerService playerService = new PlayerService();
            EnemySkillService enemySkillService = new EnemySkillService();
            Random random = new Random();
            int playerIndex = -1;
            int skillIndex = random.Next(0, enemySkills.Count);
            int damage;
            for (int i = 0; i < players.Count; i++)
            {
                if (playerId == players[i].Id)
                {
                    playerIndex = i;
                }
            }
            if (playerIndex != -1)
            {
                damage = enemySkills[skillIndex].Damage;
                players[playerIndex].HP = players[playerIndex].HP - damage;
                Console.WriteLine("Enemy use an attack named " + enemySkills[skillIndex].Name + " and dealt " + enemySkills[skillIndex].Damage + " dmg.");
                Thread.Sleep(2000);
            }
        }
    }
}
