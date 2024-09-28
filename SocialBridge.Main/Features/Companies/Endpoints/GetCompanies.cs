using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialBridge.Main.Data;
using SocialBridge.Main.Features.Companies.Mappers;

namespace SocialBridge.Main.Features.Companies.Endpoints;

public class GetCompanies : IRequest<IResult>
{
    public class Handler : IRequestHandler<GetCompanies, IResult>
    {
        private readonly AppDbContext _dbContext;

        public Handler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IResult> Handle(GetCompanies request, CancellationToken cancellationToken)
        {
            var companies = await _dbContext.Companies.Select(c => c.ToGetDto()).ToListAsync(cancellationToken);
            return Results.Ok(companies);
        }
    }
}