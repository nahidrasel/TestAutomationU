using NUnit.Framework;

namespace TestAutomationU
{
    public class Chapter7_Parameterizing
    {
        private object price;
        private object roomNumber;
        [Test]
        public void AddRoom(
            [Values("9","99")]string roomNumber,
            [Values("10", "100")] string Price)
        {  
        }
        [Test]
        [Pairwise]
        public void AddRooms(
            [Values("9", "99")] string roomNumber,
            [Values("10", "100")] string Price)
        {
        }

        [Test]
        [Sequential]
        public void AddSequence(
           [Values("9", "99")] string roomNumber,
           [Values("10", "100")] string Price)
        {
        }

    }
}
