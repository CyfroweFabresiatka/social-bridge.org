using SocialBridge.Data;

namespace SocialBridge.Main.Models;

public class Grant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Company Company { get; set; }
    public Status Status { get; set; }
}