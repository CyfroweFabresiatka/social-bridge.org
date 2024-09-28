using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialBridge.Main.Data;
using SocialBridge.Main.Features.Projects.DTOs;

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
                var entities = await _dbContext.Projects
                    .AsNoTracking()
                    .Include(x => x.Tags)
                    .Include(x => x.Locations)
                    .Include(x => x.Ngo)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToArrayAsync(cancellationToken);

                var projects = entities.Select(x => x.ToDto())
                    .ToArray();
                
                return Results.Ok(projects);
            }
        }
    }
}
