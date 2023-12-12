using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Crawl.src.Character;
using Dungeon_Crawl.src.Combat;

namespace Dungeon_Crawl.src.Combat.Skills
{
    internal class RiskySlash : ISkill
    {
        public string GetName()
        { return "Risky Attack"; }

        public bool IsSuccessful(ICombatant attacker, ICombatant defender)
        {
            int roll = Combat.Roll();
            return roll <= attacker.GetStat(Stat.Agility) - 7;
        }

        public void OnSuccess(ICombatant attacker, ICombatant defender)
        {
            int damage = Combat.Roll(2) + (attacker.GetStat(Stat.Stregnth) / 2);
            defender.TakeDamage((damage / 2) * 3);
            CombatUI.Get.UpdateCombatLog(attacker.GetName() + " manage to hit them with a risky blow dealing: " + damage + " damage.");
        }

        public void OnFail(ICombatant attacker, ICombatant defender)
        {
            int damage = Combat.Roll(2) + (attacker.GetStat(Stat.Stregnth) / 2);
            attacker.TakeDamage(damage);
            CombatUI.Get.UpdateCombatLog(attacker.GetName() + " overexerted their fighting spirit and took: " + damage + " damage.");
        }
    }
}