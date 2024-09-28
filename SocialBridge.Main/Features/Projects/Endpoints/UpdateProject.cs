using MediatR;
using SocialBridge.Main.Data;

namespace SocialBridge.Main.Features.Projects.Endpoints
{
    public class UpdateProject : IRequest<IResult>
    {
        public class Handler : IRequestHandler<UpdateProject, IResult>
        {
            private readonly AppDbContext _dbContext;

            public Handler(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IResult> Handle(UpdateProject request, CancellationToken cancellationToken)
            {
                return Results.Created();
            }
        }
    }
}
