namespace SocialBridge.Main.Models;

public class Application
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string CompanyName { get; set; }
    public string Comment { get; set; }
    public Project? Project { get; set; }
    public Grant? Grant { get; set; }
}