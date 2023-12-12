/// <summary>
/// This class handles the input for combat in a dungeon crawl game. It manages the main menu options (Attack, Skill, Item) and the corresponding submenus. It also handles button events for each menu option and the flee button. It communicates with the CombatUI class to update the UI based on the selected options.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawl.src.Combat.CombatInputHandler
{
    public class CombatInputHandler
    {
        private static CombatInputHandler instance;

        private DungeonForm form;

        public CombatInputHandler(DungeonForm form)
        {
            instance = this;
            if (form == null)
                form = Form.ActiveForm as DungeonForm; // Set the form to the active form if it is null
            else
                this.form = form;

            form.ReSubscribeCombatSubMenu(this); // Re-subscribe the combat submenu to this input handler
        }

        public static CombatInputHandler Get
        {
            get
            {
                if (instance == null)
                    instance = new CombatInputHandler(Form.ActiveForm as DungeonForm); // Create a new instance of CombatInputHandler if it is null
                return instance;
            }
        }

        private MenuOptionSelected menuMain = MenuOptionSelected.Attack; // Set the default main menu option to Attack

        // Reset any variables after combat is over
        public void Reset()
        {
        }

        public void Initialize()
        {
            menuMain = MenuOptionSelected.Attack; // Set the main menu option to Attack
            CombatUI.Get.SubMenuShowAttacks(); // Show the submenu for attacks
        }

        public void OnAttackButton(object sender, EventArgs e)
        {
            menuMain = MenuOptionSelected.Attack; // Set the main menu option to Attack
            CombatUI.Get.SubMenuShowAttacks(); // Show the submenu for attacks
        }

        public void OnItemButton(object sender, EventArgs e)
        {
            menuMain = MenuOptionSelected.Item; // Set the main menu option to Item
            CombatUI.Get.SubMenuShowItems(); // Show the submenu for items
        }

        public void OnSkillButton(object sender, EventArgs e)
        {
            menuMain = MenuOptionSelected.Skill; // Set the main menu option to Skill
            CombatUI.Get.SubMenuShowSkills(); // Show the submenu for skills
        }

        public void OnFleeButton(object sender, EventArgs e)
        {
            MessageBox.Show("Flee Button Pressed"); // Show a message box indicating that the flee button was pressed
        }

        public void OnCombatSubMenuDoubleClick(object sender, EventArgs e)
        {
            int i = form.GetSelectedItem();

            CombatUI.Get.OptionSelected(i, menuMain); // Call the OptionSelected method in CombatUI with the selected index and the main menu option
        }
    }

    public enum MenuOptionSelected
    {
        Attack, Skill, Item
    }
}