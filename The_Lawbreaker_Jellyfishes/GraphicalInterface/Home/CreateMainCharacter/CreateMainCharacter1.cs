using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class CreateMainCharacter1 : UserControl
    {

        // Theses bool allow to know if the fields are completed, if not we can't click on "next" button
        bool _fullPseudo;
        bool _fullRace;

        // Basic parameters which will be used to create a character
        bool _isFemale;
        string _name;
        string _race;

        Character _C1;
        private MainForm _context;

        // CONSTRUCTOR
        public CreateMainCharacter1(MainForm context)
        {
            _context = context;
            InitializeComponent();


            // Validate button is grey
            ValidButton.Enabled = false;

            // Races for combo box
            ComboBoxRace.Items.Add("Humain");
            ComboBoxRace.Items.Add("Nain");
            ComboBoxRace.Items.Add("Geant");
            ComboBoxRace.Items.Add("Elfe");

            //Define the style of the combo box
            ComboBoxRace.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Pseudo field
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // if the pseudo field is not empty we can click on validate
            if ( !string.IsNullOrEmpty(PseudoField.Text) )
            {
                _fullPseudo=true;
                CheckValidateButton(_fullPseudo, _fullRace);
                _name = PseudoField.Text;
            }
            // if the pseudo field is empty we can't click on validate
            if (string.IsNullOrEmpty(PseudoField.Text))
            {
                _fullPseudo = false;
                CheckValidateButton(_fullPseudo, _fullRace);
            }
        }

        // Here we choose the race
        private void ComboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxRace.SelectedIndex > -1)
            {
                if((string)ComboBoxRace.SelectedItem == "Humain")
                {
                    label1.Text = "bonus de 5 pourcent à l'achat ou la vente d'objets";
                }
                else if ((string)ComboBoxRace.SelectedItem == "Nain")
                {
                    label1.Text = "bonus de 5 pourcent de pièces après un combat";
                }
                else if ((string)ComboBoxRace.SelectedItem == "Geant")
                {
                    label1.Text = "bonus 30kg en plus pour l'inventaire";
                }
                else if ((string)ComboBoxRace.SelectedItem == "Elfe")
                {
                    label1.Text = "soigne d'1 pourcent les membres entre deux zones";
                }
                _fullRace = true;
                CheckValidateButton(_fullPseudo, _fullRace);
            }

            label1.Location = new System.Drawing.Point(Width / 2 - label1.Size.Width / 2, 250);
            _race = ((string)ComboBoxRace.SelectedItem).ToUpper();
        }

        // Check if the fields are full to enable "next" button
        private void CheckValidateButton(bool fullPseudo, bool fullRace)
        {
            if ( fullPseudo & fullRace )
            {
                ValidButton.Enabled = true;
            }
            else { ValidButton.Enabled = false; }
        }

        // Create Button validate and give him the pseudo, the sex and the race of the character
        private void Valid_Click(object sender, EventArgs e)
        {
            _C1 = new Character(_name, _race, _isFemale);
            CreateMainCharacter2 uc = new CreateMainCharacter2(_C1, _context);
            _context.ChangeUC(uc, false);
        }

        // Create Back button
        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionScreen uc = new ReceptionScreen(_context);
            _context.ChangeUC(uc, false);
        }

        private void ButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            _isFemale = true;
        }

        private void ButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            _isFemale = false;
        }
    }
}
