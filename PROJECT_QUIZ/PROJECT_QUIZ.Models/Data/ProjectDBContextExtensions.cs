using Microsoft.AspNetCore.Identity;
using PROJECT_QUIZ.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_QUIZ.Models.Data
{
    public class ProjectDBContextExtensions
    {
        public async static Task SeedRoles(RoleManager<IdentityRole> RoleMgr)
        {
            IdentityResult roleResult;
            string[] roleNames = { "Admin", "Student" };

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleMgr.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleMgr.CreateAsync(new IdentityRole(roleName));
                }
            }
        }

        public async static Task SeedUsers(UserManager<Person> userMgr)
        {
            var  test = await userMgr.FindByNameAsync("Docent@MCT");
            //1. Admin aanmaken ---------------------------------------------------
            if (await userMgr.FindByNameAsync("Docent@MCT") == null)  //controleer de UserName
            {
                var user = new Person()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "Docent@MCT",
                    Name = "De Bakker Luka",
                    Email = "Docent@MCT",

                };

                var userResult = await userMgr.CreateAsync(user, "Docent@1");
                var roleResult = await userMgr.AddToRoleAsync(user, "Admin");
                // var claimResult = await userMgr.AddClaimAsync(user, new Claim("DocentWeb", "True"));

                if (!userResult.Succeeded || !roleResult.Succeeded)
                {
                    throw new InvalidOperationException("Failed to build user and roles");
                }
            }
        }
    }
}
