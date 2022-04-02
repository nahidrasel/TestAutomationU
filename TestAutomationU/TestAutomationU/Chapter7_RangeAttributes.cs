using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationU
{
    public class Chapter7_RangeAttributes
    {
        private object price;
        private object roomNumber;
        [Test]
        public void AddRoom(
            [Values("9", "99")] string roomNumber,
            [Range(10, 100)] string Price,
            [Values] bool accessible)
        {
        }
        
    }
}
