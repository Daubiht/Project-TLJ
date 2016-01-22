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
            Dictionary<string, int> effect = new Dictionary<string, int>();

            Dictionary<string, int> effectsp1 = new Dictionary<string, int>();
            effectsp1.Add("attaque physique", 150);
            Skill sp1 = new Skill("Frappe Concentré", "Met toute sa concentration en un coup puissant", new int[] { 5, 0, 0, 0, 0, 0 }, 2, 1, effectsp1, new int[] { 0, 1 }, false);
            Dictionary<string, int> effectsp2 = new Dictionary<string, int>();
            effectsp2.Add("attaque physique", 100);
            effectsp2.Add("fatigue", 1);
            Skill sp2 = new Skill("Coup déstabilisant", "", new int[] { 30, 0, 0, 0, 0, 0 }, 0, 1, null, new int[] { 0, 3 }, false);
            sp2.PreviousSkill = sp1;
            Dictionary<string, int> effectsp3 = new Dictionary<string, int>();
            effectsp3.Add("attaque physique", 300);
            Skill sp3 = new Skill("Douleur Partagée", "Puise dans sa force vital pour donner un coup surpuissant", new int[] { 60, 0, 0, 0, 0, 0 }, 0, 1, effectsp3, new int[] { 10, 2 }, false);
            sp3.PreviousSkill = sp1;
            Dictionary<string, int> effectsp4 = new Dictionary<string, int>();
            effectsp4.Add("attaque physique", 100);
            Skill sp4 = new Skill("Coup Mesuré", "Frappe l'ennemie tout en prevoyant son prochain mouvement", new int[] { 40, 0, 0, 0, 0, 0 }, 0, 1, effectsp4, new int[] { 0, 3 }, false);
            sp4.PreviousSkill = sp2;
            Dictionary<string, int> effectsp5 = new Dictionary<string, int>();
            effectsp5.Add("attaque physique", 120);
            effectsp5.Add("baisse vie", 3);
            Skill sp5 = new Skill("Déchirement des chair", "Donne un coup déchirant la chair de l'ennemie, l'empechant de guerir", new int[] { 50, 0, 0, 0, 0, 0 }, 0, 1, effectsp5, new int[] { 0, 3 }, false);
            sp5.PreviousSkill = sp2;

            //Magic Attack
            Dictionary<string, int> effectsm1 = new Dictionary<string, int>();
            effectsm1.Add("attaque magique", 150);
            Skill sm1 = new Skill("Tir Energetique", "Envoie un tir magique de pur énergie", new int[] { 0, 5, 0, 0, 0, 0 }, 2, 0, effectsm1, new int[] { 0, 1 }, false);
            Dictionary<string, int> effectsm2 = new Dictionary<string, int>();
            effectsm2.Add("attaque magique", 170);
            Skill sm2 = new Skill("Tir Elementaire", "Envoie un tir élémentaire magique", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, effectsm2, new int[] { 0, 2 }, false);
            sm2.PreviousSkill = sm1;
            Dictionary<string, int> effectsm3 = new Dictionary<string, int>();
            effectsm3.Add("soin", 50);
            Skill sm3 = new Skill("Orbe Revigorente", "Englobe un allier d'une orbe de magie soignant ses blessures", new int[] { 0, 15, 0, 0, 0, 0 }, 0, 0, effectsm3, new int[] { 0, 2 }, false);
            sm3.PreviousSkill = sm1;
            Dictionary<string, int> effectsm4 = new Dictionary<string, int>();
            effectsm4.Add("attaque magique", 150);
            Skill sm4 = new Skill("Tir de Glace", "Lance un pic de glace vers un ennemie", new int[] { 0, 30, 0, 0, 0, 0 }, 0, 0, effectsm4, new int[] { 0, 3 }, false);
            sm4.PreviousSkill = sm2;
            Dictionary<string, int> effectsm5 = new Dictionary<string, int>();
            effectsm5.Add("attaque magique", 170);
            Skill sm5 = new Skill("Boule de Feu", "Lance une boule de feu vers un ennemie", new int[] { 0, 30, 0, 0, 0, 0 }, 0, 0, effectsm5, new int[] { 0, 3 }, false);
            sm5.TimeEffects.Add(new Effect("brulure", 15, 2, null));
            sm5.PreviousSkill = sm2;
            Dictionary<string, int> effectsm6 = new Dictionary<string, int>();
            effectsm6.Add("soin team", 30);
            Skill sm6 = new Skill("Vague Revigorente", "Fait couler une vague d'energie soignante sur son équipe", new int[] { 0, 30, 0, 0, 0, 0 }, 0, 0, effectsm6, new int[] { 0, 3 }, false);
            sm6.PreviousSkill = sm3;
            Dictionary<string, int> effectsm7 = new Dictionary<string, int>();
            effectsm7.Add("magique+", 15);
            Skill sm7 = new Skill("Résidu de Flamme", "La maitrise des éléments permet d'impreigner toute les attaques d'une chaleur intense", new int[] { 0, 50, 0, 0, 0, 0 }, 0, 0, effectsm7, new int[] { 0, 0 }, true);
            sm7.PreviousSkill = sm5;


            //Robustness
            Skill sr1 = new Skill("Position défensive", "Position dans laquelle la défense est plus efficace", new int[] { 0, 0, 0, -1, 0, 0 }, 0, 0, effect, new int[] { 0, 1 }, false);
            sr1.TimeEffects.Add(new Effect("defense+", 10, 2, null));
            Skill sr2 = new Skill("Protection", "Se jette devant un allier pour prendre les coups à sa place", new int[] { 0, 0, 0, 40, 0, 0 }, 1, 1, effect, new int[] { 0, 3 }, false);
            sr2.TimeEffects.Add(new Effect("protection", 10, 2, null));
            sr2.PreviousSkill = sr1;
            Skill sr3 = new Skill("Bouclier Magique", "Englobe un allier d'un bouclier de pur energie", new int[] { 0, 0, 0, 40, 0, 0 }, 1, 1, effect, new int[] { 0, 2 }, false);
            sr3.PreviousSkill = sr1;
            sr3.TimeEffects.Add(new Effect("defense+", 10, 2, null));
            Skill sr4 = new Skill("Epine Magique", "Entoure un allier d'épine magique qui blesse les ennemies s'approchant de trop près", new int[] { 0, 0, 0, 50, 0, 0 }, 1, 1, effect, new int[] { 0, 4 }, false);
            sr4.TimeEffects.Add(new Effect("epine", 10, 2, null));
            sr4.PreviousSkill = sr3;

            //Health
            Dictionary<string, int> effectsh1 = new Dictionary<string, int>();
            effectsh1.Add("vie", 6);
            Skill sh1 = new Skill("Vitalité", "Augmente le capital de santé", new int[] { 0, 0, 5, 0, 0, 0 }, 0, 0, effectsh1, new int[] { 0, 0 }, true);
            Skill sh2 = new Skill("Dépassement de soi", "Puise dans ses forces pour continuer à tenir debout", new int[] { 0, 0, 40, 0, 0, 0 }, 0, 0, effect, new int[] { 0, 10 }, false);
            sh2.PreviousSkill = sh1;
            Dictionary<string, int> effectsh3 = new Dictionary<string, int>();
            effectsh3.Add("vie", 7);
            Skill sh3 = new Skill("Vitalité 2", "Augmente le capital de santé", new int[] { 0, 0, 15, 0, 0, 0 }, 0, 0, effectsh3, new int[] { 0, 0 }, true);
            sh3.PreviousSkill = sh1;
            Dictionary<string, int> effectsh4 = new Dictionary<string, int>();
            effectsh4.Add("vie", 8);
            Skill sh4 = new Skill("Vitalité 3", "Augmente le capital de santé", new int[] { 0, 0, 30, 0, 0, 0 }, 0, 0, effectsh4, new int[] { 0, 0 }, true);
            sh4.PreviousSkill = sh3;
            Dictionary<string, int> effectsh5 = new Dictionary<string, int>();
            effectsh5.Add("vie", 9);
            Skill sh5 = new Skill("Vitalité d'Ogre", "Augmente le capital de santé", new int[] { 0, 0, 55, 0, 0, 0 }, 0, 0, effectsh5, new int[] { 0, 0 }, true);
            sh5.PreviousSkill = sh4;
            Dictionary<string, int> effectsh6 = new Dictionary<string, int>();
            effectsh6.Add("vie", 15);
            Skill sh6 = new Skill("Vitalité de Titan", "Augmente le capital de santé", new int[] { 0, 0, 80, 0, 0, 0 }, 0, 0, effectsh6, new int[] { 0, 0 }, true);
            sh6.PreviousSkill = sh5;

            //Dodge
            Dictionary<string, int> effectsd1 = new Dictionary<string, int>();
            effectsd1.Add("esquive", 10);
            Skill sd1 = new Skill("Instinct", "Augmente le capital d'esquive", new int[] { 0, 0, 0, 0, 0, 5 }, 0, 0, effectsd1, new int[] { 0, 10 }, true);
            Skill sd2 = new Skill("Anticipation", "Se concentre sur tout ce qui l'entoure et permet d'éviter une attaque", new int[] { 0, 0, 0, 0, 0, 50 }, 0, 0, effect, new int[] { 0, 3 }, false);
            sd2.PreviousSkill = sd1;
            Skill sd3 = new Skill("Retour de bâton", "Permet de contre attaquer la prochaine attaque", new int[] { 0, 0, 0, 0, 0, 60 }, 0, 0, effect, new int[] { 0, 3 }, false);
            sd3.PreviousSkill = sd1;

            //Stamina
            Dictionary<string, int> effectss1 = new Dictionary<string, int>();
            effectss1.Add("fatigue", 10);
            Skill ss1 = new Skill("Infatigable", "Augmente le capital de fatigue", new int[] { 0, 0, 0, 0, 5, 0 }, 0, 0, effectss1, new int[] { 0, 0 }, true);
            Dictionary<string, int> effectss2 = new Dictionary<string, int>();
            effectss2.Add("gain fatigue", 2);
            Skill ss2 = new Skill("Effort", "Permet de continuer d'attaquer mais blesse le corp par trop d'épreuve", new int[] { 0, 0, 0, 0, 15, 0 }, 0, 0, effectss2, new int[] { 10, 0 }, false);
            ss2.PreviousSkill = ss1;

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
