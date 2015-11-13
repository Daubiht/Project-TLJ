using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalGame.Test
{
    [TestFixture]
    class MortuaryTests
    {
        [Test]
        public void A_perso_can_go_to_the_mortuary_when_he_is_dead_and_not_when_he_is_alive ()
        {
            Character c = new Character("George", "Dwarf", true);

            Mortuary m = new Mortuary(null);

            Assert.IsFalse(m.DepositBody(c));

            c.Hurt(1000);

            Assert.IsTrue(m.DepositBody(c));
        }
    }
}
