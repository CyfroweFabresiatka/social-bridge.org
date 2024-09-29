using SocialBridge.Main.Models;

namespace SocialBridge.Main.Features.Projects.DTOs;

public class ProjectListDto
{
    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string City { get; set; }
    public decimal BudgetAmountFrom { get; set; }
    public decimal? BudgetAmountTo { get; set; }
    public string BudgetType { get; set; } = "";
    public string NgoName { get; set; }
}

public class ProjectLocationDto
{ 
    public string City { get; set; } = string.Empty;
}

public static class ProjectListDtoMapper
{
    public static ProjectListDto ToDto(this Project project)
    {
        var location = project.Locations.First();
        
        return new ProjectListDto
        {
            Slug = project.Slug,
            Name = project.Name,
            City = location.City,
            BudgetType = project.BudgetType.ToString(),
            BudgetAmountFrom = project.BudgetAmountFrom,
            BudgetAmountTo = project.BudgetAmountTo,
            NgoName = project.Ngo.Name,
        };
    }
}
