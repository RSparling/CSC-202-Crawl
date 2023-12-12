// Import necessary namespaces
using Dungeon_Crawl.src.Combat;
using Dungeon_Crawl.src.Combat.Skills;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Crawl.src.Character
{
    internal class Monster : ICombatant
    {
        private Stats stats = new Stats(); // Declare a private variable to store the monster's stats

        private Image image;

        public Monster()
        {
            stats = new Stats(); // Initialize the stats object with default values
            attacks = new List<ISkill>(); // Initialize the list of attacks
            attacks.Add(new HeavySlash());
            attacks.Add(new RiskySlash());
        }

        public void SetMonsterImage()
        {
            CombatUI.Get.SetMonsterImage(image);
        }

        public void SetStats(Stats stats)
        {
            this.stats = stats; // Set the monster's stats to the provided stats object
        }

        private string name = "Monster";

        public int GetFatigue()
        {
            return 10; // Return a constant value of 10 for the monster's fatigue
        }

        public int GetHitpoints()
        {
            return stats[Stat.Hitpoints]; // Return the current hitpoints of the monster
        }

        public int GetMaxFatigue()
        {
            return 10; // Return a constant value of 10 for the monster's maximum fatigue
        }

        public int GetMaxHitpoints()
        {
            return stats[Stat.MaxHitpoints]; // Return the maximum hitpoints of the monster
        }

        public int GetStat(Stat stat)
        {
            return stats[stat]; // Return the value of the specified stat for the monster
        }

        public void Heal(int heal)
        {
            stats.Heal(heal); // Heal the monster by the specified amount
        }

        public bool IsDead()
        {
            return stats[Stat.Hitpoints] <= 0; // Check if the monster's hitpoints are less than or equal to 0
        }

        public void TakeDamage(int damage)
        {
            stats.TakeDamage(damage); // Reduce the monster's hitpoints by the specified amount
        }

        private List<ISkill> attacks;

        //preform random skill with monster as attacker and player as defender
        public void Attack()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());

            int i = rand.Next(0, attacks.Count); // Get a random number between 0 and the number of attacks the monster has
            if (attacks[i].IsSuccessful(this, Player.Get))
                attacks[i].OnSuccess(this, Player.Get); // If the attack is successful, perform the attack
            else
                attacks[i].OnFail(this, Player.Get); // If the attack is unsuccessful, perform the fail action
        }

        public string GetName()
        {
            return name;
        }
    }
}