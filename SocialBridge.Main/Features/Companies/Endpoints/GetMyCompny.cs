﻿using MediatR;
using SocialBridge.Main.Data;
using SocialBridge.Main.Features.Companies.DTOs;

namespace SocialBridge.Main.Features.Companies.Endpoints
{
    public class GetMyCompany : IRequest<IResult>
    {
        public class Handler : IRequestHandler<GetMyCompany, IResult>
        {
            private readonly AppDbContext _dbContext;

            public Handler(AppDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<IResult> Handle(GetMyCompany request, CancellationToken cancellationToken)
            {
                var mockCompany = new CompanyGetDto
                {
                    Name = "Fabres",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec vel eros ut orci volutpat pharetra vitae eget justo. In sit amet efficitur enim. Aenean ultrices tincidunt nunc. Praesent sit amet viverra nisi. Aliquam sed lorem elit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse euismod ex arcu, vel interdum tortor faucibus nec. Integer ut auctor velit, et auctor lectus. Quisque pellentesque aliquam ex quis sodales. Sed nunc ex, rhoncus id lacinia vitae, commodo vel ipsum. Proin sagittis nibh eu ex facilisis vehicula. Integer eu lorem bibendum, posuere lorem vitae, tristique metus. Phasellus at sem diam. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla iaculis volutpat dolor, vitae pretium tellus accumsan nec. Fusce et gravida lorem.",
                    Location = "Poznan",
                    Tags = new[] { "Środowisko", "Zwierzęta" }
                };
                return Results.Ok(mockCompany);
            }
        }
    }
}
