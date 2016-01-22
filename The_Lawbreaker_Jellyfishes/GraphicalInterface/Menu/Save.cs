using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Save : UserControl
    {
        Controller _ctrler;
        MapWorld _ctrlerWorld;

        public Save(MapWorld contextWorld, Controller ctrler)
        {
            _ctrler = ctrler;
            _ctrlerWorld = contextWorld;
            InitializeComponent();
        }

        public void Save_Load(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4, radioButton5 };
            string[] fileName = Directory.GetFiles(@"../../../Saves");

            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = fileName[i].Substring(15);
                radioButtons[(int)Char.GetNumericValue(fileName[i][0]) - 1].Text = fileName[i].Substring(0, fileName[i].Length - 5);
                radioButtons[(int)Char.GetNumericValue(fileName[i][0]) - 1].Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton btn in panel1.Controls.OfType<RadioButton>())
            {
                if (btn.Checked)
                {
                    int plop = (int) Char.GetNumericValue(btn.Name[btn.Name.Length - 1]);
                    _ctrlerWorld.Save(plop);
                    label1.Visible = true;
                }
            }
            Save_Load(null, null);
        }

        private void retour_Click(object sender, EventArgs e)
        {
            _ctrler.ExitMenu(this);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            _ctrler.ToHome();
        }
    }
}
