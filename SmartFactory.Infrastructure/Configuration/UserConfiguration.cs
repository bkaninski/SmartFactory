using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SmartFactory.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<IdentityUser> CreateUsers()
        {
            var users = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            var user = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "factoryManager@mail.com",
                NormalizedUserName = "factoryManager@mail.com",
                Email = "factoryManager@mail.com",
                NormalizedEmail = "factoryManager@mail.com"
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "factoryManager123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "supervisor@mail.com",
                NormalizedUserName = "supervisor@mail.com",
                Email = "supervisor@mail.com",
                NormalizedEmail = "supervisor@mail.com"
            };

            user.PasswordHash =
             hasher.HashPassword(user, "supervisor123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "64a268d0-e995-41a0-a640-f9defb7f6f85",
                UserName = "operator1@mail.com",
                NormalizedUserName = "operator1@mail.com",
                Email = "operator1@mail.com",
                NormalizedEmail = "operator1@mail.com"
            };

            user.PasswordHash =
             hasher.HashPassword(user, "operator1123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "7e07d5d6-f082-454c-91c4-4c101a91aee0",
                UserName = "operator2@mail.com",
                NormalizedUserName = "operator2@mail.com",
                Email = "operator2@mail.com",
                NormalizedEmail = "operator2@mail.com"
            };

            user.PasswordHash =
             hasher.HashPassword(user, "operator2123");

            users.Add(user);


            user = new IdentityUser()
            {
                Id = "82ebe75b-2512-4a2f-af3d-b9edf0d1ef5b",
                UserName = "operator3@mail.com",
                NormalizedUserName = "operator3@mail.com",
                Email = "operator3@mail.com",
                NormalizedEmail = "operator3@mail.com"
            };

            user.PasswordHash =
             hasher.HashPassword(user, "operator3123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "c77fc444-d5a0-45c2-a576-667a021b6d1f",
                UserName = "operator4@mail.com",
                NormalizedUserName = "operator4@mail.com",
                Email = "operator4@mail.com",
                NormalizedEmail = "operator4@mail.com"
            };

            user.PasswordHash =
             hasher.HashPassword(user, "operator4123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "25cb202d-9873-432c-b049-f9184c3ce525",
                UserName = "electrician1@mail.com",
                NormalizedUserName = "electrician1@mail.com",
                Email = "electrician1@mail.com",
                NormalizedEmail = "electrician1@mail.com"
            };

            user.PasswordHash =
             hasher.HashPassword(user, "electrician1123");

            users.Add(user);

            user = new IdentityUser()
            {
                Id = "58434ec1-2216-4b26-869e-94db0c1f7d09",
                UserName = "electrician2@mail.com",
                NormalizedUserName = "electrician2@mail.com",
                Email = "electrician2@mail.com",
                NormalizedEmail = "electrician2@mail.com"
            };

            user.PasswordHash =
             hasher.HashPassword(user, "electrician2123");

            users.Add(user);


                 user = new IdentityUser()
                 {
                     Id = " 67905730 - 9c1f - 43fb - bf6b - e8dfd5abfd83",
                     UserName = "operatorleave@mail.com",
                     NormalizedUserName = "operatorleave@mail.com",
                     Email = "operatorleave@mail.com",
                     NormalizedEmail = "operatorleave@mail.com"
                 };

            user.PasswordHash =
             hasher.HashPassword(user, "operatorleave123");

            users.Add(user);

            return users;
        }

    }
}
