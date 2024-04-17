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

        public void UseSkill(int skillId, int id)
        {
            
        }
    }
}
