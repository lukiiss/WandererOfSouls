using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public interface ISkill
    {
        int Id { get; set; }
        string Name { get; set; }
        int Damage { get; set; }
        decimal DamageMultiplayer { get; set; }
        int EntityId { get; set; }
    }
}
