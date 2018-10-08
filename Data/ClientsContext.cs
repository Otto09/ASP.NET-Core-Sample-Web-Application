using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class ClientsContext : DbContext
    {
        public ClientsContext (DbContextOptions<ClientsContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Clients> Clients { get; set; }
    }
}
