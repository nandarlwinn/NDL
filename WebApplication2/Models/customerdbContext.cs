using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication2.Models {
    public class customerdbContext : DbContext {
        public customerdbContext(DbContextOptions<customerdbContext> options)
            : base(options) {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
