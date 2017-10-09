using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoInspectors.Models;

namespace AutoInspectors.Models
{
    public class AutoInspectorsContext : DbContext
    {
        public AutoInspectorsContext (DbContextOptions<AutoInspectorsContext> options)
            : base(options)
        {
        }

        public DbSet<AutoInspectors.Models.Vehicle> Vehicle { get; set; }

        public DbSet<AutoInspectors.Models.Inspection> Inspection { get; set; }
    }
}
