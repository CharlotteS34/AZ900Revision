using AZ9000Revision.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ9000Revision.Database
{
    public class AZ900RevisionContext : DbContext
    {
        public DbSet<Module> Modules { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<RevisionPoint> RevisionPoint { get; set; }
    }
}
