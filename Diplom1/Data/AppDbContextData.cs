using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Diplom1.Models;

namespace Diplom1.Data
{
    public class AppDbContextData : IdentityDbContext
    {
        public AppDbContextData(DbContextOptions<AppDbContextData> options)
            : base(options) { }

        public DbSet<Service> DBServices { get; set; }
        public DbSet<CargoObject> DBCargo { get; set; }
        public DbSet<Request> DBRequests { get; set; }
    }
}
