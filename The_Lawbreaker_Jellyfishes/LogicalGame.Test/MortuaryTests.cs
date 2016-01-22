using NUnit.Framework;

namespace LogicalGame.Test
{
    [TestFixture]
    class MortuaryTests
    {
        [Test]
        public void A_perso_can_go_to_the_mortuary_when_he_is_dead_and_not_when_he_is_alive ()
        {
            Character a = new Character("George", "Dwarf", true);
            Character b = new Character("George", "Dwarf", true);
            Character c = new Character("George", "Dwarf", true);
            Character d = new Character("George", "Dwarf", true);
            Character e = new Character("George", "Dwarf", true);
            Character f = new Character("George", "Dwarf", true);
            Character g = new Character("George", "Dwarf", true);
            Character h = new Character("George", "Dwarf", true);
            Character i = new Character("George", "Dwarf", true);
            Character j = new Character("George", "Dwarf", true);
            Character k = new Character("George", "Dwarf", true);
            Character l = new Character("George", "Dwarf", true);

            l.IsMain = true;

            Mortuary m = new Mortuary(null);

            Assert.IsFalse(m.DepositBody(c));

            a.isAlive = false;
            b.isAlive = false;
            c.isAlive = false;
            d.isAlive = false;
            e.isAlive = false;
            f.isAlive = false;
            g.isAlive = false;
            h.isAlive = false;
            i.isAlive = false;
            j.isAlive = false;
            k.isAlive = false;

            Assert.IsFalse(m.DepositBody(l));
            Assert.IsTrue(m.DepositBody(a));
            Assert.IsTrue(m.DepositBody(b));
            Assert.IsTrue(m.DepositBody(c));
            Assert.IsTrue(m.DepositBody(d));
            Assert.IsFalse(m.DepositBody(e));
            Assert.IsFalse(m.DepositBody(f));
            Assert.IsFalse(m.DepositBody(g));
            Assert.IsFalse(m.DepositBody(h));
            Assert.IsFalse(m.DepositBody(i));
            Assert.IsFalse(m.DepositBody(j));
            Assert.IsFalse(m.DepositBody(k));
        }
    }
}
