using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon_Crawl.src.Character;

namespace Dungeon_Crawl.src.Combat.Skills
{
    internal class NormalSlash : ISkill
    {
        // Check if the skill is successful
        public bool IsSuccessful(ICombatant attacker, ICombatant defender)
        {
            // Roll a dice and compare it to the attacker's agility stat minus 4
            return Combat.Roll(3) > attacker.GetStat(Stat.Agility) - 4;
        }

        // Perform actions when the skill is successful
        public void OnSuccess(ICombatant attacker, ICombatant defender)
        {
            // Calculate damage based on a dice roll and the attacker's strength stat
            int damage = Combat.Roll() + attacker.GetStat(Stat.Stregnth) / 3;
            // Inflict damage on the defender
            defender.TakeDamage(damage);

            CombatUI.Get.UpdateCombatLog(attacker.GetName() + " slash at the enemy dealing: " + damage);
        }

        // Perform actions when the skill fails
        public void OnFail(ICombatant attacker, ICombatant defender)
        {
            CombatUI.Get.UpdateCombatLog("Somehow," + attacker.GetName() + " missed.");
            return;
        }

        // Get the name of the skill
        public string GetName()
        {
            return "Normal Slash";
        }
    }
}