﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;
using System.Runtime.InteropServices;

namespace GraphicalInterface.Fighting
{
    public partial class FightMenu : UserControl
    {
        Character _selectedMember;
        Fight _fight;
        public FightMenu(Character selectedMember, Fight fight)
        {
            _selectedMember = selectedMember;
            _fight = fight;
            InitializeComponent();
            // Display the name of the character
            labelCharName.Text = selectedMember.Name;
            // Set the X and Y location of the fight menu
            Location = new Point(0, 440-Height);
            // By default an arrow is displayd near the toolstrip, here we hide the arrows
            toolStripSkills.ShowDropDownArrow = false;
            toolStripInventory.ShowDropDownArrow = false;
            // We set the value of the HP BAR
            progressBarHP.Maximum = selectedMember.MaxHealthPoint;
            progressBarHP.Value = selectedMember.HealthPoint;
            // We set the value of the STAMINA BAR
            progressBarStamina.Maximum = selectedMember.MaxStaminaPoint;
            progressBarStamina.Value = selectedMember.StaminaPoint;
            ModifyProgressBarColor.SetState(progressBarStamina, 2); // 1 = green, 2 = yellow, 3 = red
            // We add a left click event on the basic attack button
            toolStripAttack.Click += new EventHandler(BasicAttack);
        }
        // Method to get the character who is launching a basic attack
        public void BasicAttack(object sender, EventArgs e)
        {

            _fight.GetMemberWhoAttack(_selectedMember, null, _selectedMember.PhysicalAttack);
        }
    }

    // Change the color of the progress bars
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
