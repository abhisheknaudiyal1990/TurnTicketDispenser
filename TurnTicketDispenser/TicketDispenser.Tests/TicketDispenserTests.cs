using NUnit.Framework;
using TurnTicketDispenser;
using TurnTicketDispenser.Tests;

namespace TicketDispenser.Tests
{
    public class Tests
    {
        [SetUp]
        public void Test()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void CheckTurnTicketTurnNumber()
        {
            var alarm = TestHelper.ObjectTicketDispenser().BuildTicketDispenserClass();

            alarm.GetTurnTicket();

            Assert.AreEqual(1, alarm.GetTurnTicket().TurnNumber);
        }
    }
}