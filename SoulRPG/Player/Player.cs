﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandererOfSouls
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Strenght { get; set; }
        public decimal CritChance { get; set; }
        public List<PlayerSkill> Skills = new List<PlayerSkill>();
    }
}
