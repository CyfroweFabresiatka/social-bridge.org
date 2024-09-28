using SocialBridge.Main.Features.Companies.DTOs;
using SocialBridge.Main.Models;

namespace SocialBridge.Main.Features.Companies.Mappers
{
    public static class ComapniesMapper
    {
        public static CompanyGetDto ToGetDto(this Company company)
        {
            return new CompanyGetDto
            {
                Id = company.Id,
                Name = company.Name
            };
        }
    }
}
