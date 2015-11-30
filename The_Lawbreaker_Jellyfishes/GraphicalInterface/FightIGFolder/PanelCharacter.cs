using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface.Fight
{
    public partial class PanelCharacter : UserControl
    {
        Character _character;
        Monster _monster;

        // Constructor of panels, in argument we get a monster or a character object
        public PanelCharacter(Object obj)
        {   // Panels for members, if the object is a character
            if (obj is Character)
            {
                _character = (Character)obj;
                InitializeComponent();
                labelCharName.Text = _character.Name;
                labelHPResult.Text = _character.HealthPoint.ToString();
                labelStaminaResult.Text = _character.Stamina.ToString();
            }
            // Panels for monsters, if the panel is a monster
            else if( obj is Monster)
            {
                _monster = (Monster)obj;
                InitializeComponent();
                labelCharName.Text = _monster.Name;
                labelHPResult.Text = _monster.HealthPoint.ToString();
                labelStaminaResult.Text = _monster.Stamina.ToString();
            }
        }
    }
}
