using MediatR;
using SocialBridge.Data;
using SocialBridge.Main.Data;
using SocialBridge.Main.Models;

namespace SocialBridge.Main.Features.Projects.Endpoints
{
    public class CreateProject : IRequest<IResult>
    {
        public Guid NgoId { get; set; }
        public string Name { get; init; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public decimal BudgetAmountFrom { get; set; }
        public decimal? BudgetAmountTo { get; set; }
        public BudgetType BudgetType { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public ICollection<Guid> LocationsIds { get; set; } = [];
        public ICollection<Tag> TagsIds { get; set; } = [];

        public class Handler : IRequestHandler<CreateProject, IResult>
        {
            private readonly AppDbContext _dbContext;

            public Handler(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IResult> Handle(CreateProject request, CancellationToken cancellationToken)
            {
                var ngo = _dbContext.Ngos.SingleOrDefault(n => n.Id == request.NgoId);
                if (ngo is null)
                {
                    throw new ArgumentException("Ngo does not exist");
                }

                var newProject = new Project
                {
                    Id = Guid.NewGuid(),
                    Name = request.Name,
                    Ngo = ngo,
                    Status = Status.Published
                };

                await _dbContext.Projects.AddAsync(newProject, cancellationToken);
                await _dbContext.SaveChangesAsync(cancellationToken);

                return Results.Created();
            }
        }
    }
}
