using MediatR;
using SocialBridge.Main.Data;

namespace SocialBridge.Main.Features.Companies.Endpoints
{
    public class CreateCompany : IRequest<IResult>
    {
        public class Handler : IRequestHandler<CreateCompany, IResult>
        {
            private readonly AppDbContext _dbContext;

            public Handler(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IResult> Handle(CreateCompany request, CancellationToken cancellationToken)
            {
                return Results.Created();
            }
        }
    }
}
