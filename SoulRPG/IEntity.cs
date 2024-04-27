using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public interface IEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        int Level { get; set; }
        int HP { get; set; }
        int MaxHP { get; set; }
        int Strenght { get; set; }
        decimal CritChance { get; set; }
        enum Skills;
    }
}
