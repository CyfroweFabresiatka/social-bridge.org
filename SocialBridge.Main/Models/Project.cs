using SocialBridge.Data;

namespace SocialBridge.Main.Models;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public decimal BudgetAmountFrom { get; set; }
    public decimal? BudgetAmountTo { get; set; }
    public BudgetType BudgetType { get; set; }
    public DateTime? PlannedStartDate { get; set; }
    public DateTime? PlannedEndDate { get; set; }
    public Status Status { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public Ngo Ngo { get; set; }
    public ICollection<ProjectLocation> Locations { get; set; } = [];
    public ICollection<ProjectTag> Tags { get; set; } = [];
}

public enum BudgetType
{
    Money,
    People,
}
