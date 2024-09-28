using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialBridge.Main.Data;

namespace SocialBridge.Main.Features.Projects.Endpoints
{
    public class GetProjects : IRequest<IResult>
    {
        public class Handler : IRequestHandler<GetProjects, IResult>
        {
            private readonly AppDbContext _dbContext;

            public Handler(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IResult> Handle(GetProjects request, CancellationToken cancellationToken)
            {
                var projects = await _dbContext.Projects.ToListAsync(cancellationToken);
                return Results.Ok(projects);
            }
        }
    }
}
