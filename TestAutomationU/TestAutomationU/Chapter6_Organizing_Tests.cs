using System;
using NUnit.Framework;


namespace TestAutomationU
{
    public class Chapter6_Organizing_Tests
    {
        [Test(Description = "or here")]
        [Description("useful info here")]

        public void Description()
        {

            var originalRoom = 7;
        }
        [Test(Author = "Nahid Test")]
        [Author(name: "Nahid", email: "nhdrasel@gmail.com")]
        public void Author()
        {

        }

        [Test]
        [Category("Rooms")]
        public void Category()
        {
            
        }
    }
}
