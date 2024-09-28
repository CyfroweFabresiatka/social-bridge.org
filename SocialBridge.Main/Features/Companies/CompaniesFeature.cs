using SocialBridge.Main.Extensions;
using SocialBridge.Main.Features.Companies.Endpoints;

namespace SocialBridge.Main.Features.Projects;

public static class CompaniesFeature
{
    public static void MapCompanies(this RouteGroupBuilder api)
    {
        api.MapGet<GetCompanies>("companies")
            .WithOpenApiDescription("Get companies");

        api.MapPost<CreateCompany>("companies")
            .WithOpenApiDescription("Create a new company");

        api.MapPost<UpdateCompany>("companies/{companyId:int}")
            .WithOpenApiDescription("Update selected company");
    }
}