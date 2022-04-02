using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomationU
{
   //TestClass
    public class AdminTests
    {
        public IWebDriver driver { get; set; }
        //public AdminPage adminPage { get; set; }
        
        [SetUp]
        public void SetupTest()
        {
             driver = new ChromeDriver();
             //adminPage = new AdminPage(driver);
            //adminPage.Login();
        }

        [TearDown]
        public void CleanUpTests()
        {
           // adminPage.LogOut();
            driver.Quit();
        }
        //TestMethod
        [Test]
        public void AddRoom()
        {
            SetupTest();
           // var originalRoomsCount = adminPage.GetRooms().Count;

           // var room = new Room()
            {
             //   Name = "g",
            //    Type = RoomType.Family,
            //    Price = "88",
             //   Accessible = true,
             //   HasWifi = true,
              //  HasView = true,
            };

            //adminPage.AddRoom(room);
           // 
           // var rooms = adminPage.GetRooms();

           // var createdRoom = rooms.First(rooms => rooms.Number == room.Number);
            driver.Quit();

           /* Assert.That(rooms.Count, Is.GreaterThan(originalRoomsCount));
            Assert.That(createdRoom.Price, Is.EqualTo(createdRoom.Price));
            Assert.That(createdRoom.Accessible, Is.True);
            Assert.That(createdRoom.HasWifi, Is.True);
            Assert.That(createdRoom.HasView, Is.True);
            Assert.That(createdRoom.HasRadio, Is.False);
            Assert.That(createdRoom.HasRefreshments, Is.False);
            Assert.That(createdRoom.HasSafe, Is.False);
            Assert.That(createdRoom.HasTelevision, Is.False);
           */
        }
        [Test]
        public void AddSuite()
        {
           /* var originalRoomsCount = adminPage.GetRooms().Count;

            var room = new Room()
            {
                Number = "100",
                TypeAttribut = RoomType.Suite,
                Price = "500",
                Accessible = true,
                HasWifi = true,
                HasView = true
            };
            adminPage.AddRoom(room);
            var rooms = adminPage.GetRooms();
            var createRoom = rooms.First(rooms => room.Number);
            adminPage.LogOut();
            driver.Quit();
           */

        }

    }
}
