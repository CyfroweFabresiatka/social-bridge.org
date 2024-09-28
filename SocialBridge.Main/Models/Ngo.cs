namespace SocialBridge.Main.Models
{
    public class Ngo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
