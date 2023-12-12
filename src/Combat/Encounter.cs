using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dungeon_Crawl.src.Character;

namespace Dungeon_Crawl.src.Combat
{
    internal class Encounter
    {
        private Monster monster;

        private static Encounter instance;

        private float baseEncounterChance = 3;
        private float encounterChancePerStep = .1f;
        private float currentEncounterChance = 0;

        public static Encounter Get
        {
            get
            {
                if (instance == null)
                    instance = new Encounter();
                return instance;
            }
        }

        private Encounter()
        {
            instance = this;
            monster = new Monster();
        }

        public Monster GetMonster()
        { return monster; }

        public void StartEncoutner()
        {
            NavigationInputHandler.Get.HideUI();
            CombatUI.Get.UpdateHealth();
            monster = new Monster();

            CombatUI.Get.ShowUI();
        }

        public void EndPlayerTurn()
        {
            MessageBox.Show("Player Turn Over");
            CombatUI.Get.UpdateHealth();
            ProcessMonsterTurn();
            if (Player.Get.IsDead())
            {
                MessageBox.Show("You Died");
            }
            else if
                (monster.IsDead())
            {
                MessageBox.Show("You Win");
            }
        }

        private void ProcessMonsterTurn()
        {
            monster.Attack();
            MessageBox.Show("Monster Turn Over");
            CombatUI.Get.UpdateHealth();
            EndMonsterTurn();
        }

        public void EndMonsterTurn()
        {
        }

        public void EndCombat()
        {
            CombatUI.Get.ShowUI();

            NavigationInputHandler.Get.ShowUI();
        }

        public void CheckIfEncounter()
        {
            currentEncounterChance += encounterChancePerStep;
            Random rand = new Random(Guid.NewGuid().ToString().GetHashCode());
            float roll = rand.Next(0, 100);
            if (roll < currentEncounterChance)
            {
                StartEncoutner();
            }
            else
                return;
        }
    }
}