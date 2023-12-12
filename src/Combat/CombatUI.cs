using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dungeon_Crawl.src.Character;
using Dungeon_Crawl.src.Combat.CombatInputHandler;

namespace Dungeon_Crawl.src.Combat
{
    /// <summary>
    /// Represents the user interface for combat interactions in a game.
    /// </summary>
    internal class CombatUI
    {
        private static CombatUI instance; // Declare a static instance of CombatUI class

        private DungeonForm form; // Declare a DungeonForm object

        private List<string> combatLog = new List<string>();

        /// <summary>
        /// Initializes a new instance of the CombatUI class.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        public CombatUI()
        {
            instance = this; // Set the instance to the current object
            form = Form.ActiveForm as DungeonForm; // Set the form to the active form as DungeonForm
        }

        /// <summary>
        /// Gets the instance of the CombatUI class.
        /// </summary>
        /// <returns>
        /// The instance of the CombatUI class.
        /// </returns>
        public static CombatUI Get // Declare a static property to get the instance of CombatUI class
        {
            get
            {
                if (instance == null) // If the instance is null
                    instance = new CombatUI(); // Create a new instance of CombatUI class
                return instance; // Return the instance
            }
        }

        /// <summary>
        /// Retrieves the active form and sets it as the DungeonForm.
        /// </summary>
        public void RetrieveForm() // Declare a method to retrieve the active form
        {
            if (Form.ActiveForm != null) // If the active form is not null
                form = Form.ActiveForm as DungeonForm; // Set the form to the active form as DungeonForm
        }

        /// <summary>
        /// Method to show the submenu options for attacks.
        /// If the form is not null, set the submenu options to the list of attacks of the player.
        /// </summary>
        public void SubMenuShowAttacks() // Declare a method to show the submenu options for attacks
        {
            if (form != null) // If the form is not null
                form.SetSubmenuOptions(Player.Get.GetListOfAttacks()); // Set the submenu options to the list of attacks of the player
        }

        /// <summary>
        /// Method to show the submenu options for skills.
        /// Sets the submenu options to the list of skills of the player if the form is not null.
        /// </summary>
        public void SubMenuShowSkills() // Declare a method to show the submenu options for skills
        {
            if (form != null) // If the form is not null
                form.SetSubmenuOptions(Player.Get.GetListOfSkills()); // Set the submenu options to the list of skills of the player
        }

        /// <summary>
        /// Method to show the submenu options for items.
        /// </summary>
        public void SubMenuShowItems() // Declare a method to show the submenu options for items
        {
            if (form != null) // If the form is not null
                form.SetSubmenuOptions(Player.Get.GetListOfItems());
        }

        /// <summary>
        /// Updates the combat log with the given string and sets the combat log in the form.
        /// </summary>
        /// <param name="append">The string to append to the combat log.</param>
        public void UpdateCombatLog(string append)
        {
            combatLog.Add(append);
            form.SetCombatLog(combatLog);
        }

        /// <summary>
        /// Executes the selected option based on the given index and menu option.
        /// </summary>
        /// <param name="index">The index of the selected option.</param>
        /// <param name="option">The menu option selected.</param>
        public void OptionSelected(int index, MenuOptionSelected option)
        {
            switch (option)
            {
                case MenuOptionSelected.Attack:
                    Player.Get.PreformAttack(index);
                    break;

                case MenuOptionSelected.Skill:
                    Player.Get.PreformSkill(index);
                    break;

                case MenuOptionSelected.Item:
                    Player.Get.UseItem(index);
                    break;

                default:
                    return;
            }
        }

        /// <summary>
        /// Method for fleeing.
        /// </summary>
        public void Flee() // Declare a method for fleeing
        {
        }

        public void SetMonsterImage(Image image)
        {
            form.SetMonsterImage(image);
        }

        public void UpdateHealth()
        {
            form.SetHPBarPercentage(Player.Get.GetHitpoints() / Player.Get.GetMaxHitpoints());
            form.SetHPText(Player.Get.GetHitpoints(), Player.Get.GetMaxHitpoints());
        }

        public void ShowUI()
        {
        }

        public void HideUI()
        {
        }
    }
}