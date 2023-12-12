using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dungeon_Crawl;

namespace Dungeon_Crawl.src.Character

{
    internal class NavigationInputHandler
    {
        public static NavigationInputHandler Get { get; internal set; }

        public NavigationInputHandler()
        {
            Get = this;
        }

        public void TurnLeft(object sender, EventArgs e)
        {
            Player.Get.TurnLeft();
        }

        public void TurnRight(object sender, EventArgs e)
        {
            Player.Get.TurnRight();
        }

        public void MoveForward(object sender, EventArgs e)
        {
            int facingDirection = Player.Get.facingRotation;

            switch (facingDirection)
            {
                case 0:
                    Player.Get.Move(0, 1);
                    return;

                case 90:
                    Player.Get.Move(1, 0);
                    return;

                case 180:
                    Player.Get.Move(0, -1);
                    return;

                case 270:
                    Player.Get.Move(-1, 0);
                    return;

                default:
                    return;
            }
        }

        public void MoveBackward(object sender, EventArgs e)
        {
            int facingDirection = Player.Get.facingRotation;

            switch (facingDirection)
            {
                case 0:
                    Player.Get.Move(0, -1);
                    return;

                case 90:
                    Player.Get.Move(-1, 0);
                    return;

                case 180:
                    Player.Get.Move(0, 1);
                    return;

                case 270:
                    Player.Get.Move(1, 0);
                    return;

                default:
                    return;
            }
        }

        public void MoveLeft(object sender, EventArgs e)
        {
            int facingDirection = Player.Get.facingRotation;

            switch (facingDirection)
            {
                case 0:
                    Player.Get.Move(-1, 0);
                    return;

                case 90:
                    Player.Get.Move(0, 1);
                    return;

                case 180:
                    Player.Get.Move(1, 0);
                    return;

                case 270:
                    Player.Get.Move(0, -1);
                    return;

                default:
                    return;
            }
        }

        public void MoveRight(object sender, EventArgs e)
        {
            int facingDirection = Player.Get.facingRotation;

            switch (facingDirection)
            {
                case 0:
                    Player.Get.Move(1, 0);
                    return;

                case 90:
                    Player.Get.Move(0, -1);
                    return;

                case 180:
                    Player.Get.Move(-1, 0);
                    return;

                case 270:
                    Player.Get.Move(0, 1);
                    return;

                default:
                    return;
            }
        }

        public void HideUI()
        {
            DungeonForm form = Form.ActiveForm as DungeonForm;
            form.NavigationUIVisible(false);
        }

        public void ShowUI()
        {
            DungeonForm form = Form.ActiveForm as DungeonForm;
            form.NavigationUIVisible(true);
        }
    }
}