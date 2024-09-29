using SocialBridge.Main.Extensions;
using SocialBridge.Main.Features.Companies.Endpoints;

namespace SocialBridge.Main.Features.Ngos
{
    public static class NgosFeature
    {
        public static void MapNgos(this RouteGroupBuilder api)
        {
            api.MapGet<GetMyCompany>("ngos/my")
                .WithOpenApiDescription("Get my ngo");
        }
    }
}
