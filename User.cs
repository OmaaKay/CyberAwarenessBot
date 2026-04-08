namespace CyberAwarenessBot
{
    public class User
    {
        // This is an "Automatic Property" (Requirement #1 & #7)
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}


