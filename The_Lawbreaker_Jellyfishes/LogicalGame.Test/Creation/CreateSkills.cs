using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LogicalGame.Test.Creation
{
    [TestFixture]
    public class CreateSkills
    {
        [Test]
        public void We_can_add_a_skill_in_the_file_of_skill_and_recup_a_list_of_skill()
        {
            //Physical Attack
            Skill sp1 = new Skill("Frappe Concentré", "Met toute sa concentration en un coup puissant", new int[] { 5, 0, 0, 0, 0, 0 }, 0, 1, null, new int[] { 0, 1 });
            Skill sp2 = new Skill("Coup déstabilisant", "", new int[] { 30, 0, 0, 0, 0, 0 }, 0, 1, null, new int[] { 0, 3 });
            sp2.PreviousSkill = sp1;
            Skill sp3 = new Skill("Douleur Partagée", "Puise dans sa force vital pour donner un coup surpuissant", new int[] { 60, 0, 0, 0, 0, 0 }, 0, 1, null, new int[] { 10, 2 });
            sp3.PreviousSkill = sp1;
            Skill sp4 = new Skill("Coup Mesuré", "Frappe l'ennemie tout en prevoyant son prochain mouvement", new int[] { 40, 0, 0, 0, 0, 0 }, 0, 1, null, new int[] { 0, 3 });
            sp4.PreviousSkill = sp2;
            Skill sp5 = new Skill("Déchirement des chair", "Donne un coup déchirant la chair de l'ennemie, l'empechant de guerir", new int[] { 50, 0, 0, 0, 0, 0 }, 0, 1, null, new int[] { 0, 3 });
            sp5.PreviousSkill = sp2;

            //Magic Attack
            Skill sm1 = new Skill("Tir Energetique", "Envoie un tir magique de pur énergie", new int[] { 0, 5, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 1 });
            Skill sm2 = new Skill("Tir Elementaire", "Envoie un tir élémentaire magique", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 2 });
            sm2.PreviousSkill = sm1;
            Skill sm3 = new Skill("Orbe Revigorente", "Englobe un allier d'une orbe de magie soignant ses blessures", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 2 });
            sm3.PreviousSkill = sm1;
            Skill sm4 = new Skill("Tir de Glace", "Lance un pic de glace vers un ennemie", new int[] { 0, 30, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 3 });
            sm4.PreviousSkill = sm2;
            Skill sm5 = new Skill("Boule de Feu", "Lance une boule de feu vers un ennemie", new int[] { 0, 30, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 3 });
            sm5.PreviousSkill = sm2;
            Skill sm6 = new Skill("Vague Revigorente", "Fait couler une vague d'energie soignante sur son équipe", new int[] { 0, 30, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 3 });
            sm6.PreviousSkill = sm3;
            Skill sm7 = new Skill("Résidu de Flamme", "La maitrise des éléments permet d'impreigner toute les attaque d'une chaleur intense", new int[] { 0, 50, 0, 0, 0, 0 }, 0, 0, null, new int[] { 0, 0 });
            sm7.PreviousSkill = sm5;


            //Robustness
            Skill sr1 = new Skill("Position défensive", "Position dans laquelle la défense est plus efficace", new int[] { 0, 0, 0, -1, 0, 0 }, 0, 0, null, new int[] { 0, 1 });
            Skill sr2 = new Skill("Protection", "Se jette devant un allier pour prendre les coups à sa place", new int[] { 0, 0, 0, 40, 0, 0 }, 1, 1, null, new int[] { 0, 3 });
            sr2.PreviousSkill = sr1;
            Skill sr3 = new Skill("Bouclier Magique", "Englobe un allier d'un bouclier de pur energie", new int[] { 0, 0, 0, 40, 0, 0 }, 1, 1, null, new int[] { 0, 2 });
            sr3.PreviousSkill = sr1;
            Skill sr4 = new Skill("Epine Magique", "Entoure un allier d'épine magique qui blesse les ennemies s'approchant de trop près", new int[] { 0, 0, 0, 50, 0, 0 }, 1, 1, null, new int[] { 0, 4 });
            sr4.PreviousSkill = sr3;

            //Health
            Skill sh1 = new Skill("Vitalité", "Augmente le capital de santé", new int[] { 0, 0, 5, 0, 0, 0 }, 0, 0, null, new int[] { 0, 0 });
            Skill sh2 = new Skill("Dépassement de soi", "Puise dans ses forces pour continuer à tenir debout", new int[] { 0, 0, 40, 0, 0, 0 }, 0, 0, null, new int[] { 0, 10 });
            sh2.PreviousSkill = sh1;
            Skill sh3 = new Skill("Vitalité 2", "Augmente le capital de santé", new int[] { 0, 0, 15, 0, 0, 0 }, 0, 0, null, new int[] { 0, 0 });
            sh3.PreviousSkill = sh1;
            Skill sh4 = new Skill("Vitalité 3", "Augmente le capital de santé", new int[] { 0, 0, 30, 0, 0, 0 }, 0, 0, null, new int[] { 0, 0 });
            sh4.PreviousSkill = sh3;
            Skill sh5 = new Skill("Vitalité d'Ogre", "Augmente le capital de santé", new int[] { 0, 0, 55, 0, 0, 0 }, 0, 0, null, new int[] { 0, 0 });
            sh5.PreviousSkill = sh4;
            Skill sh6 = new Skill("Vitalité de Titan", "Augmente le capital de santé", new int[] { 0, 0, 80, 0, 0, 0 }, 0, 0, null, new int[] { 0, 0 });
            sh6.PreviousSkill = sh5;

            //Dodge
            Skill sd1 = new Skill("Instinct", "Augmente le capital d'esquive", new int[] { 0, 0, 0, 0, 0, 5 }, 0, 0, null, new int[] { 0, 10 });
            Skill sd2 = new Skill("Anticipation", "Se concentre sur tout ce qui l'entoure et permet d'éviter une attaque", new int[] { 0, 0, 0, 0, 0, 50 }, 0, 0, null, new int[] { 0, 3 });
            sd2.PreviousSkill = sd1;
            Skill sd3 = new Skill("Retour de bâton", "Permet de contre attaquer la prochaine attaque", new int[] { 0, 0, 0, 0, 0, 60 }, 0, 0, null, new int[] { 0, 3 });
            sd3.PreviousSkill = sd1;

            //Stamina
            Skill ss1 = new Skill("Infatigable", "Augmente le capital de fatigue", new int[] { 0, 0, 0, 0, 5, 0 }, 0, 0, null, new int[] { 0, 0 });
            Skill ss2 = new Skill("Effort", "Permet de continuer d'attaquer mais blesse le corp par trop d'épreuve", new int[] { 0, 0, 0, 0, 15, 0 }, 0, 0, null, new int[] { 10, 0 });
            ss2.PreviousSkill = ss1;

            Character p = new Character("lol", "Dwarf", true);

            Dictionary<string, Skill> skillList = new Dictionary<string, Skill>();

            //Physical
            skillList.Add(sp1.Name, sp1);
            skillList.Add(sp2.Name, sp2);
            skillList.Add(sp3.Name, sp3);
            skillList.Add(sp4.Name, sp4);
            skillList.Add(sp5.Name, sp5);
            //Magic
            skillList.Add(sm1.Name, sm1);
            skillList.Add(sm2.Name, sm2);
            skillList.Add(sm3.Name, sm3);
            skillList.Add(sm4.Name, sm4);
            skillList.Add(sm5.Name, sm5);
            skillList.Add(sm6.Name, sm6);
            skillList.Add(sm7.Name, sm7);

            //Robustness
            skillList.Add(sr1.Name, sr1);
            skillList.Add(sr2.Name, sr2);
            skillList.Add(sr3.Name, sr3);
            skillList.Add(sr4.Name, sr4);
            //Stamina
            skillList.Add(ss1.Name, ss1);
            skillList.Add(ss2.Name, ss2);
            //Health
            skillList.Add(sh1.Name, sh1);
            skillList.Add(sh2.Name, sh2);
            skillList.Add(sh3.Name, sh3);
            skillList.Add(sh4.Name, sh4);
            skillList.Add(sh5.Name, sh5);
            skillList.Add(sh6.Name, sh6);
            //Dodge
            skillList.Add(sd1.Name, sd1);
            skillList.Add(sd2.Name, sd2);
            skillList.Add(sd3.Name, sd3);




            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("../../../Ressources/skillList.bin", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                formatter.Serialize(stream, skillList);
            }
        }
    }
}
