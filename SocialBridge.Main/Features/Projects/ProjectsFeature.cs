using SocialBridge.Main.Extensions;
using SocialBridge.Main.Features.Projects.Endpoints;

namespace SocialBridge.Main.Features.Projects
{
    public static class ProjectsFeature
    {
        public static void MapProjects(this RouteGroupBuilder api)
        {
            api.MapGet<GetProject>("project")
                .WithOpenApiDescription("Get project");
            
            api.MapGet<GetProjects>("projects")
                .WithOpenApiDescription("Get projects");

            api.MapPost<CreateProject>("projects")
                .WithOpenApiDescription("Create a new project");

            api.MapPost<UpdateProject>("projects/{projectId:int}")
                .WithOpenApiDescription("Update selected project");
        }
    }
}
