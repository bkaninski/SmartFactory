using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartFactory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SmartFactory.Infrastructure.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
             
            public void Configure(EntityTypeBuilder<IdentityRole> builder)
            {
                builder.HasData(CreateRoles());
            }

            private List<IdentityRole> CreateRoles()
            {
                var roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                   Id="7eef1923-b5cf-41b5-9ca7-acd1107446a2",
                   Name="factoryManager",
                   NormalizedName = "factoryManager",
                   ConcurrencyStamp = "fa2ca1a5-e9d4-4d07-899b-2e8537663382"
                },

                new IdentityRole()
                {
                   Id="0a9eb5bf-c65b-4f8d-9d5c-da3d6537683d",
                   Name="Manager",
                   NormalizedName = "Manager",
                   ConcurrencyStamp = "9e2681ea-93fb-448c-8840-e1e982c2573a"
                },

                  new IdentityRole()
                {
                   Id="71b1fb4c-6b83-434a-b8d0-2d4dfe3b1b9d",
                   Name="Electrical",
                   NormalizedName = "Electrical",
                   ConcurrencyStamp = "0070bc5f-05e0-4169-bd52-6096e85c0ffe"
                },


                  new IdentityRole()
                {
                   Id="32d1dbb3-e785-47a1-ab5a-982603422fbd",
                   Name="Operator",
                   NormalizedName = "Operator",
                   ConcurrencyStamp = "8c2e01b5-a78d-4187-ba52-357c52228e99"
                },


            };




                return roles;
            }
        
    }
}
