using MediatR;
using SocialBridge.Data;
using SocialBridge.Main.Data;
using SocialBridge.Main.Models;

namespace SocialBridge.Main.Features.Projects.Endpoints
{
    public class CreateProject : IRequest<IResult>
    {
        public required string Name { get; init; }
        public Guid NgoId { get; set; }

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
