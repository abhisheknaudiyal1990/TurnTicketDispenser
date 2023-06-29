namespace TurnTicketDispenser.Tests
{
    public class TestHelper
    {
        public static TestHelper ObjectTicketDispenser()
        {
            return new TestHelper();
        }

        public TicketDispenser BuildTicketDispenserClass()
        {
            return new TicketDispenser();
        }
    }
}
