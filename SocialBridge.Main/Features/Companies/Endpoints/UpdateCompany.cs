using MediatR;
using SocialBridge.Main.Data;

namespace SocialBridge.Main.Features.Companies.Endpoints;

public class UpdateCompany : IRequest<IResult>
{
    public class Handler : IRequestHandler<UpdateCompany, IResult>
    {
        private readonly AppDbContext _dbContext;

        public Handler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IResult> Handle(UpdateCompany request, CancellationToken cancellationToken)
        {
            return Results.Created();
        }
    }
}