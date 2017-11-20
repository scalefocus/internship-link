using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InternshipLink.Web.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        ""

        public static DataContext Create()
        {
            return new DataContext();
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}