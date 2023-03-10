using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VersatClient.Models;

namespace VersatClient.Data
{
    public class VersatClientContext : DbContext
    {
        public VersatClientContext (DbContextOptions<VersatClientContext> options)
            : base(options)
        {
        }

        public DbSet<VersatClient.Models.Client> Client { get; set; } = default!;

        public DbSet<VersatClient.Models.Order> Order { get; set; }
    }
}
