using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawl.src.Character
{
    internal class Stats
    {
        private Dictionary<Stat, int> stats;

        public Stats()
        {
            stats = new Dictionary<Stat, int>();
            stats.Add(Stat.Stregnth, 10);
            stats.Add(Stat.Agility, 10);
            stats.Add(Stat.Intelligence, 10);
            stats.Add(Stat.Vitality, 10);
            stats.Add(Stat.Hitpoints, 10);
            stats.Add(Stat.MaxHitpoints, 10);
            stats.Add(Stat.FatiguePoints, 10);
            stats.Add(Stat.MaxFatiguePoints, 10);
        }

        public int this[Stat stat]
        {
            get { return stats[stat]; }
            set { stats[stat] = value; }
        }

        public void TakeDamage(int damage)
        {
            this[Stat.Hitpoints] -= damage;
            if (this[Stat.Hitpoints] < 0)
                this[Stat.Hitpoints] = 0;
        }

        public void Heal(int heal)
        {
            this[Stat.Hitpoints] += heal;
            if (this[Stat.Hitpoints] > this[Stat.MaxHitpoints])
                this[Stat.Hitpoints] = this[Stat.MaxHitpoints];
        }
    }

    internal enum Stat
    {
        Stregnth,
        Agility,
        Intelligence,
        Vitality,
        Hitpoints,
        MaxHitpoints,
        FatiguePoints,
        MaxFatiguePoints
    }
}