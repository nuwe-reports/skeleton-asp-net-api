using System;
using CleanArchitecture.Infrastructure.Persistence.DataModels;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {
        }

        public DbSet<PingModel> PingDb { get; set; }
    }
}