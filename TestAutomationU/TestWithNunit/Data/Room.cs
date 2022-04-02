namespace TestAutomationU
{
    internal class Room
    {
        public Room()
        {
        }

        public string Name { get; set; }
        public object Type { get; set; }
        public string Price { get; set; }
        public bool Accessible { get; set; }
        public bool HasWifi { get; set; }
        public bool HasView { get; set; }
    }
}