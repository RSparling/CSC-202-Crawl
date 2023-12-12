namespace Dungeon_Crawl
{
    partial class DungeonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_MonsterSprite = new System.Windows.Forms.PictureBox();
            this.groupCombatOptions = new System.Windows.Forms.GroupBox();
            this.CombatSubMenu = new System.Windows.Forms.ListBox();
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Attack = new System.Windows.Forms.Button();
            this.button_Item = new System.Windows.Forms.Button();
            this.button_Skill = new System.Windows.Forms.Button();
            this.groupCombatPanel = new System.Windows.Forms.GroupBox();
            this.textbox_CombatLog = new System.Windows.Forms.RichTextBox();
            this.buttonDebugStartEncounter = new System.Windows.Forms.Button();
            this.bar_Player_HealthBar = new System.Windows.Forms.ProgressBar();
            this.groupPlayerVitals = new System.Windows.Forms.GroupBox();
            this.textbox_HitPoints = new System.Windows.Forms.TextBox();
            this.label_Player_HP = new System.Windows.Forms.Label();
            this.buttonDebugEndEncounter = new System.Windows.Forms.Button();
            this.imagePlane_DungeonEnviroment = new System.Windows.Forms.PictureBox();
            this.groupNavigation = new System.Windows.Forms.GroupBox();
            this.button_MoveLeft = new System.Windows.Forms.Button();
            this.button_MoveBack = new System.Windows.Forms.Button();
            this.button_MoveRight = new System.Windows.Forms.Button();
            this.button_MoveForward = new System.Windows.Forms.Button();
            this.button_TurnLeft = new System.Windows.Forms.Button();
            this.button_TurnRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MonsterSprite)).BeginInit();
            this.groupCombatOptions.SuspendLayout();
            this.groupCombatPanel.SuspendLayout();
            this.groupPlayerVitals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlane_DungeonEnviroment)).BeginInit();
            this.groupNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_MonsterSprite
            // 
            this.pictureBox_MonsterSprite.Location = new System.Drawing.Point(753, 229);
            this.pictureBox_MonsterSprite.Name = "pictureBox_MonsterSprite";
            this.pictureBox_MonsterSprite.Size = new System.Drawing.Size(600, 800);
            this.pictureBox_MonsterSprite.TabIndex = 0;
            this.pictureBox_MonsterSprite.TabStop = false;
            // 
            // groupCombatOptions
            // 
            this.groupCombatOptions.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupCombatOptions.Controls.Add(this.CombatSubMenu);
            this.groupCombatOptions.Controls.Add(this.button_Run);
            this.groupCombatOptions.Controls.Add(this.button_Attack);
            this.groupCombatOptions.Controls.Add(this.button_Item);
            this.groupCombatOptions.Controls.Add(this.button_Skill);
            this.groupCombatOptions.Location = new System.Drawing.Point(21, 723);
            this.groupCombatOptions.Name = "groupCombatOptions";
            this.groupCombatOptions.Size = new System.Drawing.Size(364, 306);
            this.groupCombatOptions.TabIndex = 2;
            this.groupCombatOptions.TabStop = false;
            this.groupCombatOptions.Text = "Combat Options";
            // 
            // CombatSubMenu
            // 
            this.CombatSubMenu.FormattingEnabled = true;
            this.CombatSubMenu.Items.AddRange(new object[] {
            "Option 1",
            "Option 2",
            "Option 3",
            "Option 4"});
            this.CombatSubMenu.Location = new System.Drawing.Point(101, 16);
            this.CombatSubMenu.Name = "CombatSubMenu";
            this.CombatSubMenu.Size = new System.Drawing.Size(257, 277);
            this.CombatSubMenu.TabIndex = 1;
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(6, 277);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 4;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            // 
            // button_Attack
            // 
            this.button_Attack.Location = new System.Drawing.Point(6, 38);
            this.button_Attack.Name = "button_Attack";
            this.button_Attack.Size = new System.Drawing.Size(75, 23);
            this.button_Attack.TabIndex = 0;
            this.button_Attack.Text = "Attack";
            this.button_Attack.UseVisualStyleBackColor = true;
            // 
            // button_Item
            // 
            this.button_Item.Location = new System.Drawing.Point(6, 96);
            this.button_Item.Name = "button_Item";
            this.button_Item.Size = new System.Drawing.Size(75, 23);
            this.button_Item.TabIndex = 3;
            this.button_Item.Text = "Item";
            this.button_Item.UseVisualStyleBackColor = true;
            // 
            // button_Skill
            // 
            this.button_Skill.Location = new System.Drawing.Point(6, 67);
            this.button_Skill.Name = "button_Skill";
            this.button_Skill.Size = new System.Drawing.Size(75, 23);
            this.button_Skill.TabIndex = 2;
            this.button_Skill.Text = "Skill";
            this.button_Skill.UseVisualStyleBackColor = true;
            // 
            // groupCombatPanel
            // 
            this.groupCombatPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupCombatPanel.Controls.Add(this.textbox_CombatLog);
            this.groupCombatPanel.Location = new System.Drawing.Point(414, 819);
            this.groupCombatPanel.Name = "groupCombatPanel";
            this.groupCombatPanel.Size = new System.Drawing.Size(1176, 210);
            this.groupCombatPanel.TabIndex = 3;
            this.groupCombatPanel.TabStop = false;
            this.groupCombatPanel.Text = "Combat Log";
            // 
            // textbox_CombatLog
            // 
            this.textbox_CombatLog.Location = new System.Drawing.Point(6, 20);
            this.textbox_CombatLog.Name = "textbox_CombatLog";
            this.textbox_CombatLog.ReadOnly = true;
            this.textbox_CombatLog.Size = new System.Drawing.Size(1164, 177);
            this.textbox_CombatLog.TabIndex = 0;
            this.textbox_CombatLog.Text = "";
            // 
            // buttonDebugStartEncounter
            // 
            this.buttonDebugStartEncounter.Location = new System.Drawing.Point(12, 12);
            this.buttonDebugStartEncounter.Name = "buttonDebugStartEncounter";
            this.buttonDebugStartEncounter.Size = new System.Drawing.Size(127, 23);
            this.buttonDebugStartEncounter.TabIndex = 4;
            this.buttonDebugStartEncounter.Text = "Debug: Start Encoutner";
            this.buttonDebugStartEncounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDebugStartEncounter.UseVisualStyleBackColor = true;
            this.buttonDebugStartEncounter.Click += new System.EventHandler(this.button1_Click);
            // 
            // bar_Player_HealthBar
            // 
            this.bar_Player_HealthBar.Location = new System.Drawing.Point(0, 57);
            this.bar_Player_HealthBar.Name = "bar_Player_HealthBar";
            this.bar_Player_HealthBar.Size = new System.Drawing.Size(182, 23);
            this.bar_Player_HealthBar.TabIndex = 5;
            this.bar_Player_HealthBar.Value = 30;
            // 
            // groupPlayerVitals
            // 
            this.groupPlayerVitals.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupPlayerVitals.Controls.Add(this.textbox_HitPoints);
            this.groupPlayerVitals.Controls.Add(this.label_Player_HP);
            this.groupPlayerVitals.Controls.Add(this.bar_Player_HealthBar);
            this.groupPlayerVitals.Location = new System.Drawing.Point(27, 229);
            this.groupPlayerVitals.Name = "groupPlayerVitals";
            this.groupPlayerVitals.Size = new System.Drawing.Size(200, 140);
            this.groupPlayerVitals.TabIndex = 6;
            this.groupPlayerVitals.TabStop = false;
            this.groupPlayerVitals.Text = "Vitals";
            // 
            // textbox_HitPoints
            // 
            this.textbox_HitPoints.Location = new System.Drawing.Point(62, 30);
            this.textbox_HitPoints.Name = "textbox_HitPoints";
            this.textbox_HitPoints.ReadOnly = true;
            this.textbox_HitPoints.Size = new System.Drawing.Size(37, 20);
            this.textbox_HitPoints.TabIndex = 7;
            this.textbox_HitPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Player_HP
            // 
            this.label_Player_HP.AutoSize = true;
            this.label_Player_HP.Location = new System.Drawing.Point(6, 30);
            this.label_Player_HP.Name = "label_Player_HP";
            this.label_Player_HP.Size = new System.Drawing.Size(49, 13);
            this.label_Player_HP.TabIndex = 6;
            this.label_Player_HP.Text = "HitPoints";
            // 
            // buttonDebugEndEncounter
            // 
            this.buttonDebugEndEncounter.Location = new System.Drawing.Point(12, 52);
            this.buttonDebugEndEncounter.Name = "buttonDebugEndEncounter";
            this.buttonDebugEndEncounter.Size = new System.Drawing.Size(127, 23);
            this.buttonDebugEndEncounter.TabIndex = 7;
            this.buttonDebugEndEncounter.Text = "Debug: End Encounter";
            this.buttonDebugEndEncounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDebugEndEncounter.UseVisualStyleBackColor = true;
            // 
            // imagePlane_DungeonEnviroment
            // 
            this.imagePlane_DungeonEnviroment.Location = new System.Drawing.Point(0, 0);
            this.imagePlane_DungeonEnviroment.Name = "imagePlane_DungeonEnviroment";
            this.imagePlane_DungeonEnviroment.Size = new System.Drawing.Size(1920, 1080);
            this.imagePlane_DungeonEnviroment.TabIndex = 8;
            this.imagePlane_DungeonEnviroment.TabStop = false;
            // 
            // groupNavigation
            // 
            this.groupNavigation.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupNavigation.Controls.Add(this.button_TurnRight);
            this.groupNavigation.Controls.Add(this.button_TurnLeft);
            this.groupNavigation.Controls.Add(this.button_MoveForward);
            this.groupNavigation.Controls.Add(this.button_MoveRight);
            this.groupNavigation.Controls.Add(this.button_MoveBack);
            this.groupNavigation.Controls.Add(this.button_MoveLeft);
            this.groupNavigation.Location = new System.Drawing.Point(254, 220);
            this.groupNavigation.Name = "groupNavigation";
            this.groupNavigation.Size = new System.Drawing.Size(255, 149);
            this.groupNavigation.TabIndex = 9;
            this.groupNavigation.TabStop = false;
            this.groupNavigation.Text = "Navigation";
            // 
            // button_MoveLeft
            // 
            this.button_MoveLeft.Location = new System.Drawing.Point(7, 103);
            this.button_MoveLeft.Name = "button_MoveLeft";
            this.button_MoveLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_MoveLeft.Size = new System.Drawing.Size(75, 23);
            this.button_MoveLeft.TabIndex = 0;
            this.button_MoveLeft.Text = "Left";
            this.button_MoveLeft.UseVisualStyleBackColor = true;
            // 
            // button_MoveBack
            // 
            this.button_MoveBack.Location = new System.Drawing.Point(89, 103);
            this.button_MoveBack.Name = "button_MoveBack";
            this.button_MoveBack.Size = new System.Drawing.Size(75, 23);
            this.button_MoveBack.TabIndex = 1;
            this.button_MoveBack.Text = "Back";
            this.button_MoveBack.UseVisualStyleBackColor = true;
            // 
            // button_MoveRight
            // 
            this.button_MoveRight.Location = new System.Drawing.Point(171, 103);
            this.button_MoveRight.Name = "button_MoveRight";
            this.button_MoveRight.Size = new System.Drawing.Size(75, 23);
            this.button_MoveRight.TabIndex = 2;
            this.button_MoveRight.Text = "Right";
            this.button_MoveRight.UseVisualStyleBackColor = true;
            // 
            // button_MoveForward
            // 
            this.button_MoveForward.Location = new System.Drawing.Point(89, 66);
            this.button_MoveForward.Name = "button_MoveForward";
            this.button_MoveForward.Size = new System.Drawing.Size(75, 23);
            this.button_MoveForward.TabIndex = 3;
            this.button_MoveForward.Text = "Forward";
            this.button_MoveForward.UseVisualStyleBackColor = true;
            // 
            // button_TurnLeft
            // 
            this.button_TurnLeft.Location = new System.Drawing.Point(7, 19);
            this.button_TurnLeft.Name = "button_TurnLeft";
            this.button_TurnLeft.Size = new System.Drawing.Size(75, 23);
            this.button_TurnLeft.TabIndex = 4;
            this.button_TurnLeft.Text = "Turn Left";
            this.button_TurnLeft.UseVisualStyleBackColor = true;
            // 
            // button_TurnRight
            // 
            this.button_TurnRight.Location = new System.Drawing.Point(160, 19);
            this.button_TurnRight.Name = "button_TurnRight";
            this.button_TurnRight.Size = new System.Drawing.Size(75, 23);
            this.button_TurnRight.TabIndex = 5;
            this.button_TurnRight.Text = "Turn Right";
            this.button_TurnRight.UseVisualStyleBackColor = true;
            // 
            // DungeonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dungeon_Crawl.Properties.Resources.Hallway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupNavigation);
            this.Controls.Add(this.buttonDebugEndEncounter);
            this.Controls.Add(this.groupPlayerVitals);
            this.Controls.Add(this.buttonDebugStartEncounter);
            this.Controls.Add(this.groupCombatPanel);
            this.Controls.Add(this.groupCombatOptions);
            this.Controls.Add(this.pictureBox_MonsterSprite);
            this.Controls.Add(this.imagePlane_DungeonEnviroment);
            this.Name = "DungeonForm";
            this.Text = "Dungeon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MonsterSprite)).EndInit();
            this.groupCombatOptions.ResumeLayout(false);
            this.groupCombatPanel.ResumeLayout(false);
            this.groupPlayerVitals.ResumeLayout(false);
            this.groupPlayerVitals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlane_DungeonEnviroment)).EndInit();
            this.groupNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_MonsterSprite;
        private System.Windows.Forms.GroupBox groupCombatOptions;
        private System.Windows.Forms.ListBox CombatSubMenu;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Button button_Attack;
        private System.Windows.Forms.Button button_Item;
        private System.Windows.Forms.Button button_Skill;
        private System.Windows.Forms.GroupBox groupCombatPanel;
        private System.Windows.Forms.Button buttonDebugStartEncounter;
        private System.Windows.Forms.RichTextBox textbox_CombatLog;
        private System.Windows.Forms.ProgressBar bar_Player_HealthBar;
        private System.Windows.Forms.GroupBox groupPlayerVitals;
        private System.Windows.Forms.Label label_Player_HP;
        private System.Windows.Forms.TextBox textbox_HitPoints;
        private System.Windows.Forms.Button buttonDebugEndEncounter;
        private System.Windows.Forms.PictureBox imagePlane_DungeonEnviroment;
        private System.Windows.Forms.GroupBox groupNavigation;
        private System.Windows.Forms.Button button_TurnRight;
        private System.Windows.Forms.Button button_TurnLeft;
        private System.Windows.Forms.Button button_MoveForward;
        private System.Windows.Forms.Button button_MoveRight;
        private System.Windows.Forms.Button button_MoveBack;
        private System.Windows.Forms.Button button_MoveLeft;
    }
}

