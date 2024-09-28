using SocialBridge.Data;

namespace SocialBridge.Main.Models;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Ngo Ngo { get; set; }
    public Status Status { get; set; }
}