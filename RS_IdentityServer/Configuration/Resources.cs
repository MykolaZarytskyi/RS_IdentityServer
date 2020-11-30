using IdentityServer4.Models;
using System.Collections.Generic;

namespace RS_IdentityServer.Configuration
{
    internal class Resources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource
                {
                    Name = "role"
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource
                {
                    Name = "RentalServiceApi",
                    DisplayName = "Rental Service Api",
                    Description = "Allow 'Rental Service' application to access 'RentalServiceApi' on your behalf",
                    Scopes = new List<string> { "RentalServiceApiScope" }
                }
            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("RentalServiceApiScope", "Rental Service Api Scope" )
            };
        }
    }
}
