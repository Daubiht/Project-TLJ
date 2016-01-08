using System;
using System.Windows.Forms;
using LogicalGame;

namespace GraphicalInterface
{
    public partial class Doctor : UserControl
    {
        MainForm _contextForm;
        MapWorld _contextWorld;

        public Doctor(MainForm contextForm, MapWorld contextWorld)
        {
            InitializeComponent();
            _contextWorld = contextWorld;
            _contextForm = contextForm;

            Reload();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            _contextForm.ExitMenu(this);
        }

        private void Heal_Click(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            int heal = (int)button.Tag;
            int cost;

            switch (heal)
            {
                case 25:
                    cost = 0;
                    break;
                case 50:
                    cost = 20;
                    break;
                case 75:
                    cost = 50;
                    break;
                case 100:
                    cost = 100;
                    break;
                default:
                    cost = 0;
                    break;
            }

            _contextWorld.Team.Invent.RemoveGold(cost);

            foreach (Character chara in _contextWorld.Team.Members)
            {
                if (chara.HealthPoint < chara.MaxHealthPoint * (heal / 100))
                {
                    chara.HealthPoint = chara.MaxHealthPoint * (heal / 100);
                }
            }

            Reload();
        }

        public void Reload()
        {
            int[] heal = new int[] { 25, 50, 75, 100 };
            int cost;
            int totalCost = 0;
            Label label = null;

            LMoney.Text = _contextWorld.Team.Invent.GetGold + " PO";

            for (int i = 0; i < heal.Length; i++)
            {
                switch (heal[i])
                {
                    case 25:
                        cost = 0;
                        label = LCostLow;
                        break;
                    case 50:
                        cost = 20;
                        label = LCostMid;
                        break;
                    case 75:
                        cost = 50;
                        label = LCostHigh;
                        break;
                    case 100:
                        cost = 100;
                        label = LCostTotal;
                        break;
                    default:
                        cost = 0;
                        break;
                }

                foreach (Character chara in _contextWorld.Team.Members)
                {
                    if (chara.HealthPoint < chara.MaxHealthPoint * (heal[i] / 100))
                    {
                        totalCost += cost;
                    }
                }

                label.Text = totalCost + " PO";
            }
            
        }


    }
}
