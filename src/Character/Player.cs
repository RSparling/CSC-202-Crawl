using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dungeon_Crawl.src.Combat;
using Dungeon_Crawl.src.Combat.Skills;

namespace Dungeon_Crawl.src.Character
{
    internal class Player : ICombatant
    {
        private static Player instance; // Singleton instance of Player
        private Stats stats = new Stats(); // Player's stats

        private List<ISkill> attacks = new List<ISkill>(); // List of attack skills
        private List<ISkill> skills = new List<ISkill>(); // List of skills
        private List<IItem> items = new List<IItem>(); // List of items

        private void LoadSkillsAndAttacks()
        {
            attacks.Add(new NormalSlash());
            attacks.Add(new HeavySlash());
            attacks.Add(new RiskySlash());
        }

        public void PreformAttack(int index)
        {
            //check if index is in bounds
            if (index < 0 || index >= attacks.Count) // Check if the index is out of range
                throw new IndexOutOfRangeException(); // Throw an exception if the index is out of range

            CombatUI.Get.UpdateCombatLog("You preform " + attacks[index].GetName() + "."); // Update the combat log with the attack name
            if (attacks.ToArray()[index].IsSuccessful(this, Encounter.Get.GetMonster())) // Check if the attack is successful
            {
                attacks.ToArray()[index].OnSuccess(this, Encounter.Get.GetMonster()); // Preform the attack
            }
            else
            {
                attacks.ToArray()[index].OnFail(this, Encounter.Get.GetMonster()); // Preform the fail
            }
            Encounter.Get.EndPlayerTurn();
        }

        public void PreformSkill(int index)
        {
            if (index <= 0 || index >= skills.Count) // Check if the index is out of range
                throw new IndexOutOfRangeException(); // Throw an exception if the index is out of range

            CombatUI.Get.UpdateCombatLog("You preform " + skills[index].GetName() + "."); // Update the combat log with the attack name
            if (attacks[index].IsSuccessful(this, Encounter.Get.GetMonster())) // Check if the attack is successful
            {
                CombatUI.Get.UpdateCombatLog("You hit the enemy!"); // Update the combat log with the success message
                skills[index].OnSuccess(this, Encounter.Get.GetMonster()); // Preform the attack
            }
            else
            {
                CombatUI.Get.UpdateCombatLog("You missed the enemy!"); // Update the combat log with the fail message
                skills[index].OnFail(this, Encounter.Get.GetMonster()); // Preform the fail
            }
            Encounter.Get.EndPlayerTurn();
        }

        public void UseItem(int index)
        {
            if (index <= 0 || index >= items.Count) // Check if the index is out of range
                throw new IndexOutOfRangeException(); // Throw an exception if the index is out of range

            CombatUI.Get.UpdateCombatLog("You use " + items[index].GetName() + "."); // Update the combat log with the item name
            items[index].Use(this); // Use the item
            Encounter.Get.EndPlayerTurn();
        }

        public List<string> GetListOfAttacks()
        {
            List<string> names = new List<string>(); // Create a new list to store attack names
            foreach (ISkill skill in attacks)
            {
                names.Add(skill.GetName()); // Add each attack name to the list
            }

            return names; // Return the list of attack names
        }

        public List<string> GetListOfSkills()
        {
            List<string> names = new List<string>(); // Create a new list to store skill names
            foreach (ISkill skill in skills)
            {
                names.Add(skill.GetName()); // Add each skill name to the list
            }

            return names; // Return the list of skill names
        }

        public List<string> GetListOfItems()
        {
            List<string> names = new List<string>(); // Create a new list to store item names
            foreach (IItem item in items)
            {
                names.Add(item.GetName()); // Add each item name to the list
            }
            return names; // Return the list of item names
        }

        public Player()
        {
            instance = this; // Set the instance of Player to this

            LoadSkillsAndAttacks(); // Load skills and attacks

            stats[Stat.Hitpoints] = 20; // Set the hitpoints stat to 100
            stats[Stat.MaxHitpoints] = 20;
        }

        public static Player Get
        {
            get
            {
                if (instance == null)
                    instance = new Player(); // Create a new instance of Player if it doesn't exist
                return instance; // Return the instance of Player
            }
        }

        //ICombatant implementation
        public int GetHitpoints()
        {
            return stats[Stat.Hitpoints]; // Return the hitpoints stat
        }

        public int GetMaxHitpoints()
        {
            return stats[Stat.MaxHitpoints]; // Return the max hitpoints stat
        }

        public int GetFatigue()
        {
            return stats[Stat.FatiguePoints]; // Return the fatigue points stat
        }

        public int GetMaxFatigue()
        {
            return stats[Stat.MaxFatiguePoints]; // Return the max fatigue points stat
        }

        public void TakeDamage(int damage)
        {
            stats.TakeDamage(damage); // Take damage to the player's stats
        }

        public void Heal(int heal)
        {
            stats.Heal(heal); // Heal the player's stats
        }

        public bool IsDead()
        {
            return stats[Stat.Hitpoints] <= 0; // Check if the player is dead
        }

        public int GetStat(Stat stat)
        {
            return stats[stat]; // Return the specified stat
        }

        public string GetName()
        {
            return "Yu"; // Return the player's name
        }
    }
}