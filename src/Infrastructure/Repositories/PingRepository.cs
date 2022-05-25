using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Ping.Repositories;
using CleanArchitecture.Infrastructure.Persistence.DataModels;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class PingRepository : IRepository
    {
        private readonly EfDbContext _context;

        public PingRepository(EfDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetQueryAsync()
        {
            List<PingModel> res;
            try
            {
                res = await _context.PingDb.FromSqlRaw("SELECT 1+1 as Ping").ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res.FirstOrDefault()?.Ping ?? 0;
        }
    }
}