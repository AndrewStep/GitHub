using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarStore.Models
{
    public class CarStoreDBInitializer : DropCreateDatabaseAlways<CarsStoreDBContext>
    {
        protected override void Seed(CarsStoreDBContext db)
        {
            db.Roles.Add(new Role { RoleId = 1, Name = "admin" });
            db.Roles.Add(new Role { RoleId = 2, Name = "user" });
            db.Users.Add(new User
            {
                Email = "ffeelex@gmail.com",
                Password = "qwerty123456",
                RoleId = 1
            });
            db.Users.Add(new User
            {
                Email = "pfeelex@gmail.com",
                Password = "asdfgh123456",
                RoleId = 2
            });
            base.Seed(db);
        }
    }
}