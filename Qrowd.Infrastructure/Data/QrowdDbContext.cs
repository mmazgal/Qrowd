using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Qrowd.Domain.Entities;

namespace Qrowd.Infrastructure.Data
{
    public class QrowdDbContext : DbContext
    {
        public QrowdDbContext(DbContextOptions<QrowdDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
