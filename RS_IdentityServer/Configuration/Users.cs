using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace RS_IdentityServer.Configuration
{
    internal class Users
    {
        public static IEnumerable<TestUser>GetUsers()
        {
            return new List<TestUser> { 
                new TestUser
                {
                    Username = "bob",
                    Password = "bob",
                    SubjectId = "1",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Name, "Bob Marley"),
                        new Claim(JwtClaimTypes.GivenName, "Bob"),
                        new Claim(JwtClaimTypes.FamilyName, "Marley"),
                        new Claim(JwtClaimTypes.Role, "admin")
                    }
                },
                new TestUser
                {
                    Username = "bryan",
                    Password = "bryan",
                    SubjectId = "2",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Name, "Bryan Adams"),
                        new Claim(JwtClaimTypes.GivenName, "Bryan"),
                        new Claim(JwtClaimTypes.FamilyName, "Adams"),
                        new Claim(JwtClaimTypes.Role, "manager")
                    }
                },
                new TestUser
                {
                    Username = "robert",
                    Password = "robert",
                    SubjectId = "3",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Name, "Robert Miles"),
                        new Claim(JwtClaimTypes.GivenName, "Robert"),
                        new Claim(JwtClaimTypes.FamilyName, "Miles"),
                        new Claim(JwtClaimTypes.Role, "seller")
                    }
                },
                new TestUser
                {
                    Username = "celine",
                    Password = "celine",
                    SubjectId = "4",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Name, "Celine Dion"),
                        new Claim(JwtClaimTypes.GivenName, "Celine"),
                        new Claim(JwtClaimTypes.FamilyName, "Dion"),
                        new Claim(JwtClaimTypes.Role, "consumer")
                    }
                }
            };
        }
    }
}
