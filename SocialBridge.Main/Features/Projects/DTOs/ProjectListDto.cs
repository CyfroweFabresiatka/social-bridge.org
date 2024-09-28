using SocialBridge.Main.Models;

namespace SocialBridge.Main.Features.Projects.DTOs;

public class ProjectListDto
{
    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public static class ProjectListDtoMapper
{
    public static ProjectListDto ToDto(this Project project) => new ProjectListDto
    {
        Slug = project.Slug,
        Name = project.Name,
        Description = project.Description,
    };
}
