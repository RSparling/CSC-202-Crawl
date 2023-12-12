using Dungeon_Crawl.Properties;
using Dungeon_Crawl.src;
using Dungeon_Crawl.src.Character;
using Dungeon_Crawl.src.Combat;
using Dungeon_Crawl.src.Combat.CombatInputHandler;
using Dungeon_Crawl.src.Dungeon;
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
        private MapData map = new MapData();
        private DungeonRenderer dungeonRenderer;

        private NavigationInputHandler navInput = new NavigationInputHandler();

        public DungeonForm()
        {
            InitializeComponent();

            button_TurnLeft.Click += navInput.TurnLeft;
            button_TurnRight.Click += navInput.TurnRight;
            button_MoveForward.Click += navInput.MoveForward;
            button_MoveRight.Click += navInput.MoveRight;
            button_MoveLeft.Click += navInput.MoveLeft;
            button_MoveBack.Click += navInput.MoveBackward;

            combatInputHandler = new CombatInputHandler(this);

            CombatSubMenu.DoubleClick += CombatInputHandler.Get.OnCombatSubMenuDoubleClick;
            ReSubscribeCombatSubMenu(combatInputHandler);
            buttonDebugStartEncounter.Click += debug_button_StartEncounter;
            buttonDebugEndEncounter.Click += debug_button_EndEncounter;
            dungeonRenderer = new DungeonRenderer(imagePlane_DungeonEnviroment.Width, imagePlane_DungeonEnviroment.Height, Resources.DungeonWall);

            DoubleBuffered = true; //preven flickering
            imagePlane_DungeonEnviroment.Paint += RenderDungeonBackground;
            CombatUIVisible(false);
        }

        public void InvalidateDungeonBackground()
        {
            imagePlane_DungeonEnviroment.Invalidate();
        }

        private void RenderDungeonBackground(object sender, PaintEventArgs e)
        {
            Bitmap frame = dungeonRenderer.RenderFrame();
            e.Graphics.DrawImage(frame, 0, 0);
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

        public void CombatUIVisible(bool setVisible)
        {
            if (setVisible)
            {
                groupCombatOptions.Show();
                groupPlayerVitals.Show();
                groupCombatPanel.Show();
                pictureBox_MonsterSprite.Show();
            }
            else
            {
                groupCombatOptions.Hide();
                groupPlayerVitals.Hide();
                groupCombatPanel.Hide();
                pictureBox_MonsterSprite.Hide();
            }
        }

        public void NavigationUIVisible(bool setVisible)
        {
            if (setVisible)
            {
                groupNavigation.Show();
            }
            else
            {
                groupNavigation.Hide();
            }
        }
    }
}