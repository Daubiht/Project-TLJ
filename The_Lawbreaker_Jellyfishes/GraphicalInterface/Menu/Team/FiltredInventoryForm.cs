using LogicalGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public partial class FiltredInventoryForm : Form
    {
        List<PanelCharacter> _panelCharacter;
        Fight _fight;
        public FiltredInventoryForm(UserControl uc, List<PanelCharacter> PanelList, Fight CurrentFight)
        {
            InitializeComponent();
            _panelCharacter = PanelList;
            _fight = CurrentFight;
            Controls.Add(uc);
        }

        public Fight Fight { get { return _fight; } }
        public List<PanelCharacter> PanelCharacter { get { return _panelCharacter; } }
    }
}
