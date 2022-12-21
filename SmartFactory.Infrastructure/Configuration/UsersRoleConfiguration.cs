using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Infrastructure.Configuration
{
    public class UsersRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(CreateUsersRole());
        }

        private List<IdentityUserRole<string>> CreateUsersRole()
        {
            var userRole = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>()
                {
                    RoleId ="7eef1923-b5cf-41b5-9ca7-acd1107446a2",
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                },

                 new IdentityUserRole<string>()
                {
                    RoleId ="0a9eb5bf-c65b-4f8d-9d5c-da3d6537683d",
                    UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                },

                new IdentityUserRole<string>()
                {
                    RoleId ="71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d",
                    UserId = "25cb202d-9873-432c-b049-f9184c3ce525"
                },
                   new IdentityUserRole<string>()
                {
                    RoleId ="71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d",
                    UserId = "58434ec1-2216-4b26-869e-94db0c1f7d09"
                },
                   new IdentityUserRole<string>()
                {
                    RoleId ="32d1dbb3-e785-47a1-ab5a-982603422fbd",
                    UserId = "64a268d0-e995-41a0-a640-f9defb7f6f85"
                },
                   new IdentityUserRole<string>()
                {
                    RoleId ="32d1dbb3-e785-47a1-ab5a-982603422fbd",
                    UserId = "7e07d5d6-f082-454c-91c4-4c101a91aee0"
                },
                   new IdentityUserRole<string>()
                {
                    RoleId ="32d1dbb3-e785-47a1-ab5a-982603422fbd",
                    UserId = "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b"
                },
                      new IdentityUserRole<string>()
                {
                    RoleId ="32d1dbb3-e785-47a1-ab5a-982603422fbd",
                    UserId = "c77fc444-d5a0-45c2-a576-667a021b6d1f"
                }




            


            };




            return userRole;
        }

    }
}
