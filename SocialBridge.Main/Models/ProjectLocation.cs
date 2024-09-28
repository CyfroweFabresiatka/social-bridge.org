namespace SocialBridge.Main.Models;

public class ProjectLocation
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
}
