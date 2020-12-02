using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace RS_IdentityServer.Configuration
{
    internal class Clients
    {
        public static IEnumerable<Client>GetClients()
        {
            return new List<Client> { 
                new Client
                {
                    ClientId = "RentalService",
                    ClientName = "Rental Service",
                    ClientSecrets = new List<Secret>
                    { 
                        new Secret("EC14A81A-E59E-4455-A452-8471CB701602".Sha256())
                    } ,
                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RedirectUris = new List<string>
                    {
                        "https://localhost:5071/signin-oidc",
                    },
                    PostLogoutRedirectUris = new List<string> 
                    {
                        "https://localhost:5071/signout-callback-oidc"
                    },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "role",
                        "RentalServiceApiScope"
                    },
                    RequirePkce = true,
                    
                }
            };
        }
    }
}
