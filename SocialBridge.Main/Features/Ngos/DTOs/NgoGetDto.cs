namespace SocialBridge.Main.Features.Ngos.DTOs
{
    public class NgoGetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Location { get; set; } = "";
        public IEnumerable<string> Tags { get; set; } = Array.Empty<string>();
    }
}
