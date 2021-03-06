﻿using System;
using NUnit.Framework;
using System.Threading;

namespace LogicalGame.Test
{
    [TestFixture]
    public class RandomCharacterTests
    {
        [Test]
        public void New_return_a_random_caracter_with_goods_values()
        {
            Random ran = new Random();
            //Character p;
            int[] stats;

            for (int j = 0; j < 10; j++)
            {
                Thread.Sleep(30);
               // RandomCharacter RP = new RandomCharacter();
                Character p = new Taverne().New(1, 6, null);

                stats = p.Stats;

                Console.WriteLine("Nom : {0}  ||  Niveau : {1}  ||  PA : {2}  ||  PM : {3}  ||  H : {4}  ||  S : {5}  ||  R : {6}  ||  D : {7}  ", p.Name, p.Level, stats[0], stats[1], stats[2], stats[3], stats[4], stats[5]);
                foreach (Skill i in p.Skills.Values)
                {
                    Console.WriteLine("Skill {0} : {1}", i, i.Name);
                }
            }
            

        }
        
    }
}
