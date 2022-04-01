using NUnit.Framework;

namespace TestAutomationU
{
    public class Chapter6_TestOrder
    {
        [Test]
        [Order(2)]
        public void testOrder()
        {

        }
        [Test]
        [Order(1)]
        public void testOrder1()
        {

     }

        //same order doesn't have
        //guarrantee which one will run first
    }
}
