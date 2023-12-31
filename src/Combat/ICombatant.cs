﻿using Dungeon_Crawl.src.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawl.src.Combat
{
    internal interface ICombatant
    {
        int GetHitpoints();

        int GetMaxHitpoints();

        int GetFatigue();

        int GetMaxFatigue();

        void TakeDamage(int damage);

        int GetStat(Stat stat);

        void Heal(int heal);

        bool IsDead();

        string GetName();
    }
}