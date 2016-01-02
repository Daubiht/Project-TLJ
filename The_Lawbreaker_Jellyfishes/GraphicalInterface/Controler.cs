using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicalGame;
using System.Windows.Forms;

namespace GraphicalInterface
{
    public class Controller
    {
        MainForm _form;
        MapWorld _w;

        //Constructor
        public Controller(MainForm form)
        {
            _form = form;
        }

        //Manage UserControl
        public void ChangeUC(UserControl UCI, bool Menu)
        {
            _form.Controls.Clear();
            _form.Controls.Add(UCI);
            if (Menu)
            {
                Menu UCM = new Menu(_w, this);
                _form.Controls.Add(UCM);
            }
        }

        public void ChangeUC(UserControl UCI, bool Menu, bool multipleMenu)
        {

            for (int i = 0; i < _form.Controls.Count; i++)
            {
                UserControl uc = (UserControl)_form.Controls[i];
                if (uc.Visible)
                {
                    _form.Controls.Remove(uc);
                    i--;
                }
            }

            _form.Controls.Add(UCI);
            if (Menu)
            {
                Menu UCM = new Menu(_w, this);
                _form.Controls.Add(UCM);
            }
        }

        public void ToMenu(UserControl UCM, bool Menu)
        {
            foreach (UserControl uc in _form.Controls)
            {
                if ((uc is Menu) && Menu)
                {
                    uc.Visible = true;
                }
                else
                {
                    uc.Visible = false;
                }
            }
            _form.Controls.Add(UCM);
        }

        public void ExitMenu(UserControl ucm)
        {
            _form.Controls.Remove(ucm);
            foreach (UserControl uc in _form.Controls)
            {
                uc.Visible = true;
            }
        }

        //Request display UserControl
        public void ToHome()
        {
            ReceptionScreen uc = new ReceptionScreen(this);
            ChangeUC(uc, false);
        }

        public void Quit()
        {
            _form.Close();
        }

        public void ToCreateMainCharacter1()
        {
            CreateMainCharacter1 uc = new CreateMainCharacter1(this);
            ChangeUC(uc, false);
        }

        public void ToCreateMainCharacter2(Character c)
        {
            CreateMainCharacter2 uc = new CreateMainCharacter2(c, this);
            ChangeUC(uc, false);
        }

        public void ToCreateMainCharacter3(Character c, int[] stats)
        {
            CreateMainCharacter3 uc = new CreateMainCharacter3(c, this, stats);
            ChangeUC(uc, false);
        }

        public void ToWorld(MapWorld w ,bool militia)
        {
            _w = w;
            World uc = new World(w, this, militia);
            ChangeUC(uc, true);
        }

        public void ToWorld(MapWorld w, bool militia, MapIsland I)
        {
            _w.ActualPosition = I;
            _w = w;
            World uc = new World(w, this, militia);
            ChangeUC(uc, true);
        }

        public void ToLoadGame()
        {
            LoadGame uc = new LoadGame(this);
            ChangeUC(uc, false);
        }

        public void ToIsland(MapIsland I)
        {
            _w.ActualPosition = I;
            Island uc = new Island(this, _w, I);
            ChangeUC(uc, true);
        }

        public void ToInstance(MapInstance I)
        {
            _w.ActualPosition = I;
            Instance uc = new Instance(this, _w, I);
            ChangeUC(uc, true);
        }

        public void ToCity(MapCity c)
        {
            _w.ActualPosition = c;
            City uc = new City(this, _w, c);
            ChangeUC(uc, true);
        }

        public void ToMeet(int EventRandom, MapZone Z)
        {
            Meet uc = new Meet(EventRandom, this, _w, Z);
            ToMenu(uc, false);
        }

        public void ToService(object service)
        {
            UserControl uc = new UserControl();

            if(service is LogicalGame.Merchant)
            {
                uc = new Merchant(this, (LogicalGame.Merchant)service, _w.Team.Invent);
            }
            else if(service is LogicalGame.Militia)
            {
                uc = new Militia(this, _w);
            }
            else if(service is LogicalGame.Mortuary)
            {
                uc = new Mortuary(_w.Team, this, (LogicalGame.Mortuary)service);
            }
            else if(service is LogicalGame.Taverne)
            {
                uc = new Taverne(_w.Team, this, _w);
            }
            ToMenu(uc, false);
        }

        public void ToFight(List<Monster> listMob)
        {
            FightUserControl uc = new FightUserControl(listMob, _w.Team, this);
            ChangeUC(uc, false, true);
        }

        public void ToCharacterInfoTaverne(Character c)
        {
            CharacterInformations uc = new CharacterInformations(c, _w.Team, this);
            ChangeUC(uc, false, true);
        }

        public void ToDefeatScreen(bool AllDead)
        {
            EndFightDefeat uc = new EndFightDefeat(this, AllDead, _w.ActualPosition);
            ChangeUC(uc, false, true);
        }

        public void ToVictoryScreen(bool RunAway, List<Monster> listMob)
        {
            EndFightVictory uc = new EndFightVictory(this, listMob, RunAway, _w);
            ChangeUC(uc, false, true);
        }

        public void ToTeam(Team T, bool menu)
        {
            TeamManagement uc = new TeamManagement(T, this);
            if(menu)
            {
                ToMenu(uc, false);
            }
            else
            {
                ChangeUC(uc, false, true);
            }
        }

        public void ToInventory(Invent I)
        {
            Inventory uc = new Inventory(this, I);
            ToMenu(uc, false);
        }

        public void ToNotif()
        {
            Notifications uc = new Notifications(_w, this);
            ToMenu(uc, false);
        }

        public void ToSave()
        {
            Save uc = new Save(_w, this);
            ToMenu(uc, false);
        }

        public void ToCharacterManagement(Character c)
        {
            CharacterManagement uc = new CharacterManagement(c, _w.Team, this);
            ChangeUC(uc, false, true);
        }

        public void ToFiltredInventory(Team t, Character c, string type, bool InFight)
        {
            FiltredInventory uc = new FiltredInventory(t, c, type, this, false);
            ChangeUC(uc, false, true);
        }
    }
}
