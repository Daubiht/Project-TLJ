using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class CreateMainCharacter2 : UserControl
    {

        // Number of points we can assign to basic stats
        static int _assignedStats1 = 10;
        int _assignedStats = _assignedStats1;

        // At the begining every basic stats is equal to _defaultStat
        static int _defaultStat = 5;

        // Basic stats
        int _health = _defaultStat;  
        int _robustness = _defaultStat;
        int _stamina = _defaultStat;
        int _physicalAttack = _defaultStat;
        int _magicAttack = _defaultStat;
        int _dodge = _defaultStat;

        Character _C1;
        private MainForm _context;

        // Constructor
        public CreateMainCharacter2(Character CreatedCharacter, MainForm context)
        {
            InitializeComponent();

            _context = context;
            _C1 = CreatedCharacter;

            // Show the results of statistics 
            resultatVie.Text = _health.ToString();
            resultatRobustesse.Text = _robustness.ToString();
            resultatFatigue.Text = _stamina.ToString();
            resultatAttaquePhysique.Text = _physicalAttack.ToString();
            resultatAttaqueMagique.Text = _magicAttack.ToString();
            resultatEsquive.Text = _dodge.ToString();

            // Show the rest of basic points we can assign
            assignedStats.Text = _assignedStats.ToString();

            // Disabled all the buttons [-] by default
            mVie.Enabled = false;
            mRobustesse.Enabled = false;
            mFatigue.Enabled = false;
            mAttaquePhysique.Enabled = false;
            mAttaqueMagique.Enabled = false;
            mEsquive.Enabled = false;

            // Disabled button Next by default
            buttonNext.Enabled = false;

            // Create tooltip to display more informations about the basic stats

            // tooltip for health
            ToolTip TooltipHealth = new ToolTip(); 
            TooltipHealth.InitialDelay = 250;
            TooltipHealth.ReshowDelay = 500;
            TooltipHealth.ShowAlways = true;
            TooltipHealth.AutoPopDelay = 32000;
            TooltipHealth.SetToolTip(TextLife, "Nombre de point de vie (PV)");

            // tooltip for robustness
            ToolTip TooltipRobustness = new ToolTip(); 
            TooltipRobustness.InitialDelay = 250;
            TooltipRobustness.ReshowDelay = 500;
            TooltipRobustness.ShowAlways = true;
            TooltipRobustness.AutoPopDelay = 32000;
            TooltipRobustness.SetToolTip(TextRobustness, "Augmente la résistance aux attaques");

            // tooltip for stamina
            ToolTip TooltipStamina = new ToolTip();
            TooltipStamina.InitialDelay = 250;
            TooltipStamina.ReshowDelay = 500;
            TooltipStamina.ShowAlways = true;
            TooltipStamina.AutoPopDelay = 32000;
            TooltipStamina.SetToolTip(TextStamina, "Permet d'utiliser des compétences spéciales");

            // tooltip for physic attack
            ToolTip TooltipPhysicAttack = new ToolTip();
            TooltipPhysicAttack.InitialDelay = 250;
            TooltipPhysicAttack.ReshowDelay = 500;
            TooltipPhysicAttack.ShowAlways = true;
            TooltipPhysicAttack.AutoPopDelay = 32000;
            TooltipPhysicAttack.SetToolTip(TextPhysicalDamage, "Les attaques physiques sont plus puissantes");

            // tooltip for magic attack
            ToolTip TooltipMagicAttack = new ToolTip();
            TooltipMagicAttack.InitialDelay = 250;
            TooltipMagicAttack.ReshowDelay = 500;
            TooltipMagicAttack.ShowAlways = true;
            TooltipMagicAttack.AutoPopDelay = 32000;
            TooltipMagicAttack.SetToolTip(TextMagicDamage, "Les attaques magiques sont plus puissantes");

            // tooltip for dodge
            ToolTip TooltipDodge = new ToolTip();
            TooltipDodge.InitialDelay = 250;
            TooltipDodge.ReshowDelay = 500;
            TooltipDodge.ShowAlways = true;
            TooltipDodge.AutoPopDelay = 32000;
            TooltipDodge.SetToolTip(TextDodge, "Le joueur a plus de chance d'esquiver les attaques ennemis");
        }

        // __________________Check if we must disabled [-] buttons ____________________
        public bool CheckMinusButton(int StatTested)
        {
            if (StatTested == _defaultStat) return false;
            if (StatTested > _defaultStat) return true;
            return false;
        }

        // ___________________CHeck if we must disabled all [+] buttons ___________________
        public void CheckPlusButton()
        {
            if ( _assignedStats == 0 )
            {
                pVie.Enabled = false;
                pRobustesse.Enabled = false;
                pFatigue.Enabled = false;
                pAttaquePhysique.Enabled = false;
                pAttaqueMagique.Enabled = false;
                pEsquive.Enabled = false;

                // Button Next is enabled if all the points are assigned
                buttonNext.Enabled = true;  
            }
            if (_assignedStats > 0)
            {
                pVie.Enabled = true;
                pRobustesse.Enabled = true;
                pFatigue.Enabled = true;
                pAttaquePhysique.Enabled = true;
                pAttaqueMagique.Enabled = true;
                pEsquive.Enabled = true;
                
                // Button Next is disabled if there are still some point to assign
                buttonNext.Enabled = false;
            }
        }


        // _________________________________Button back _________________________
        private void button14_Click(object sender, EventArgs e)
        {
            CreateMainCharacter1 uc = new CreateMainCharacter1(_context);
            _context.ChangeUC(uc, false);
        }

        // _________________________________Button next _________________________
        private void button13_Click(object sender, EventArgs e)
        {
            // Here we change the basic stats of the created character
            _C1.StatsUp(_physicalAttack-_defaultStat, _magicAttack-_defaultStat, _health- _defaultStat, _robustness- _defaultStat, _stamina- _defaultStat, _dodge- _defaultStat);

            CreateMainCharacter3 uc = new CreateMainCharacter3(_C1, _context, new int[] {_physicalAttack, _magicAttack,_health,_robustness,_stamina,_dodge, _defaultStat });
            _context.ChangeUC(uc, false);
        }

        // [+] vie
        private void button7_Click(object sender, EventArgs e)
        {
            _assignedStats -= 1;
            assignedStats.Text = _assignedStats.ToString();
            _health += 1;
            resultatVie.Text = _health.ToString();
            mVie.Enabled = CheckMinusButton(_health);
            CheckPlusButton();
        }
        // [-] vie
        private void mVie_Click(object sender, EventArgs e)
        {
            _assignedStats += 1;
            assignedStats.Text = _assignedStats.ToString();
            _health -= 1;
            resultatVie.Text = _health.ToString();
            mVie.Enabled = CheckMinusButton(_health);
            CheckPlusButton();
        }

        // [+] Robustesse
        private void pRobustesse_Click(object sender, EventArgs e)
        {
            _assignedStats -= 1;
            assignedStats.Text = _assignedStats.ToString();
            _robustness += 1;
            resultatRobustesse.Text = _robustness.ToString();
            mRobustesse.Enabled = CheckMinusButton(_robustness);
            CheckPlusButton();
        }

        // [-] Robustesse
        private void mRobustesse_Click(object sender, EventArgs e)
        {
            _assignedStats += 1;
            assignedStats.Text = _assignedStats.ToString();
            _robustness -= 1;
            resultatRobustesse.Text = _robustness.ToString();
            mRobustesse.Enabled = CheckMinusButton(_robustness);
            CheckPlusButton();
        }

        // [+] Fatigue
        private void pFatigue_Click_1(object sender, EventArgs e)
        {
            _assignedStats -= 1;
            assignedStats.Text = _assignedStats.ToString();
            _stamina += 1;
            resultatFatigue.Text = _stamina.ToString();
            mFatigue.Enabled = CheckMinusButton(_stamina);
            CheckPlusButton();

        }

        // [-] Fatigue
        private void mFatigue_Click(object sender, EventArgs e)
        {
            _assignedStats += 1;
            assignedStats.Text = _assignedStats.ToString();
            _stamina -= 1;
            resultatFatigue.Text = _stamina.ToString();
            mFatigue.Enabled = CheckMinusButton(_stamina);
            CheckPlusButton();
        }

        // [+] Attaque physique
        private void pAttaquePhysique_Click(object sender, EventArgs e)
        {
            _assignedStats -= 1;
            assignedStats.Text = _assignedStats.ToString();
            _physicalAttack += 1;
            resultatAttaquePhysique.Text = _physicalAttack.ToString();
            mAttaquePhysique.Enabled = CheckMinusButton(_physicalAttack);
            CheckPlusButton();

        }
        // [-] Attaque physique
        private void mAttaquePhysique_Click(object sender, EventArgs e)
        {
            _assignedStats += 1;
            assignedStats.Text = _assignedStats.ToString();
            _physicalAttack -= 1;
            resultatAttaquePhysique.Text = _physicalAttack.ToString();
            mAttaquePhysique.Enabled = CheckMinusButton(_physicalAttack);
            CheckPlusButton();

        }
        // [+] Attaque magique
        private void pAttaqueMagique_Click(object sender, EventArgs e)
        {
            _assignedStats -= 1;
            assignedStats.Text = _assignedStats.ToString();
            _magicAttack += 1;
            resultatAttaqueMagique.Text = _magicAttack.ToString();
            mAttaqueMagique.Enabled = CheckMinusButton(_magicAttack);
            CheckPlusButton();

        }

        // [-] Attaque magique
        private void mAttaqueMagique_Click(object sender, EventArgs e)
        {
            _assignedStats += 1;
            assignedStats.Text = _assignedStats.ToString();
            _magicAttack -= 1;
            resultatAttaqueMagique.Text = _magicAttack.ToString();
            mAttaqueMagique.Enabled = CheckMinusButton(_magicAttack);
            CheckPlusButton();

        }

        // [+] Esquive
        private void pEsquive_Click(object sender, EventArgs e)
        {
            _assignedStats -= 1;
            assignedStats.Text = _assignedStats.ToString();
            _dodge += 1;
            resultatEsquive.Text = _dodge.ToString();
            mEsquive.Enabled = CheckMinusButton(_dodge);
            CheckPlusButton();

        }

        // [-] Esquive
        private void mEsquive_Click(object sender, EventArgs e)
        {
            _assignedStats += 1;
            assignedStats.Text = _assignedStats.ToString();
            _dodge -= 1;
            resultatEsquive.Text = _dodge.ToString();
            mEsquive.Enabled = CheckMinusButton(_dodge);
            CheckPlusButton();
        }

        // [Reset] button
        private void buttonReset_Click(object sender, EventArgs e)
        {
            _assignedStats = _assignedStats1;
            assignedStats.Text = _assignedStats.ToString();

            _health = _defaultStat;
            _robustness = _defaultStat;
            _stamina = _defaultStat;
            _physicalAttack = _defaultStat;
            _magicAttack = _defaultStat;
            _dodge = _defaultStat;

            resultatVie.Text = _health.ToString();
            resultatRobustesse.Text = _robustness.ToString();
            resultatFatigue.Text = _stamina.ToString();
            resultatAttaquePhysique.Text = _physicalAttack.ToString();
            resultatAttaqueMagique.Text = _magicAttack.ToString();
            resultatEsquive.Text = _dodge.ToString();

            CheckPlusButton();

            mVie.Enabled = false;
            mRobustesse.Enabled = false;
            mFatigue.Enabled = false;
            mAttaquePhysique.Enabled = false;
            mAttaqueMagique.Enabled = false;
            mEsquive.Enabled = false;
        }
    }
}
