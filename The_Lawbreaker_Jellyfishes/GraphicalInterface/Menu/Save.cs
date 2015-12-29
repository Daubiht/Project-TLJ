using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Save : UserControl
    {
        MainForm _contextForm;
        MapWorld _contextWorld;

        public Save(MapWorld contextWorld, MainForm contextForm)
        {
            _contextForm = contextForm;
            _contextWorld = contextWorld;
            InitializeComponent();

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
                    _contextWorld.Save(plop);
                    label1.Visible = true;
                }
            }

        }

        private void retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            ReceptionScreen uc = new ReceptionScreen(_contextForm);
            _contextForm.ChangeUC(uc, false);
        }
    }
}
