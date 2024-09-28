namespace SocialBridge.Main.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string HackYeahPassword { get; set; }
        public Ngo Ngo { get; set; }
        public Company Company { get; set; }
    }
}
