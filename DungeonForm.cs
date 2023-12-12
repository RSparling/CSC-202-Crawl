using Dungeon_Crawl.src.Character;
using Dungeon_Crawl.src.Combat;
using Dungeon_Crawl.src.Combat.CombatInputHandler;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Crawl
{
    public partial class DungeonForm : Form
    {
        private CombatInputHandler combatInputHandler;
        private Player player = new Player();

        public DungeonForm()
        {
            InitializeComponent();
            combatInputHandler = new CombatInputHandler(this);

            CombatSubMenu.DoubleClick += CombatInputHandler.Get.OnCombatSubMenuDoubleClick;
            ReSubscribeCombatSubMenu(combatInputHandler);
            buttonDebugStartEncounter.Click += debug_button_StartEncounter;
            buttonDebugEndEncounter.Click += debug_button_EndEncounter;
        }

        public int GetSelectedItem()
        {
            return CombatSubMenu.SelectedIndex;
        }

        public void SetSubmenuOptions(List<string> options)
        {
            CombatSubMenu.Items.Clear();
            CombatSubMenu.Items.AddRange(options.ToArray());
        }

        private void groupCombatPanel_Enter(object sender, EventArgs e)
        {
        }

        public void ReSubscribeCombatSubMenu(CombatInputHandler cih)
        {
            button_Attack.Click += cih.OnAttackButton;
            button_Skill.Click += cih.OnSkillButton;
            button_Item.Click += cih.OnItemButton;
            button_Run.Click += cih.OnFleeButton;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        internal void SetCombatLog(List<string> combatLog)
        {
            string log = String.Empty;

            combatLog.Count();

            //add the last ten lines of the combatLog to log with the line number next to it with the most recent at the top
            for (int i = combatLog.Count() - 1; i >= 0; i--)
            {
                log += (combatLog.Count() - i) + ": " + combatLog[i] + "\r\n";
            }

            textbox_CombatLog.Text = log;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void debug_button_StartEncounter(object sender, EventArgs e)
        {
            Encounter.Get.StartEncoutner();
        }

        private void debug_button_EndEncounter(object sender, EventArgs e)
        {
            Encounter.Get.EndCombat();
        }

        public void SetHPBarPercentage(int percent)
        {
            if (percent < 0)
                percent = 0;
            if (percent > 100)
                percent = 100;

            bar_Player_HealthBar.Value = 100 - percent;
        }

        public void SetMonsterImage(Image image)
        {
            pictureBox_MonsterSprite.Image = image;
        }

        internal void SetHPText(int getHitpoints, int getMaxHitpoints)
        {
            textbox_HitPoints.Clear();

            textbox_HitPoints.Text = getHitpoints + "/" + getMaxHitpoints;
        }

        public void HidCombatUI()
        {
        }
    }
}