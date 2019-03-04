using DualContextDbInitializerExample.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace UIControlsExample.Models
{
    public class ApplicationContextInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        public ApplicationContextInitializer()
        {
            // Will Fire when App starts up for the first time
        }
        protected override void Seed(ApplicationDbContext context)
        {
            Random r = new Random();
            PasswordHasher hasher = new PasswordHasher();

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {

                    UserName = "powell.paul@itsligo.ie",
                    Email = "powell.paul@itsligo.ie",
                    EmailConfirmed = true,
                    FirstName = "Paul",
                    SecondName = "Powell",
                    PasswordHash = hasher.HashPassword("itsPaul$1"),
                    SecurityStamp = Guid.NewGuid().ToString()
                });
            context.SaveChanges();
            base.Seed(context);
        }

    }
}