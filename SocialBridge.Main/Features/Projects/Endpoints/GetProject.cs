using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialBridge.Main.Data;

namespace SocialBridge.Main.Features.Projects.Endpoints
{
    public class GetProject : IRequest<IResult>
    {
        public string ProjectSlug { get; set; }

        public class Handler : IRequestHandler<GetProject, IResult>
        {
            private readonly AppDbContext _dbContext;

            public Handler(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IResult> Handle(GetProject request, CancellationToken cancellationToken)
            {
                var project = await _dbContext
                    .Projects.Include(x=>x.Ngo)
                    .FirstOrDefaultAsync(x => x.Slug == request.ProjectSlug, 
                        cancellationToken: cancellationToken);

                return project == null ? Results.NotFound() : Results.Ok(project);
            }
        }
    }
}