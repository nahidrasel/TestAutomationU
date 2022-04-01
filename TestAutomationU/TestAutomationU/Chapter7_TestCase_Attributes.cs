using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationU
{
    public class Chapter7_TestCase_Attributes
    {
        //Test Case Attributes
        [TestCase("9", "999")]
        [TestCase("10","1000")]


        // Test Case Attributes with TestName and Description
        [TestCase("9", "999",TestName="")]
        [TestCase("10", "1000",Description ="")]


        //Expected result Parameter
        [TestCase(2,2,ExpectedResult =4)]

        public void AddRooms( string roomNumber, string Price)
        {
        }
    }
}
