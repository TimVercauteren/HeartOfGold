using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BudgetMiner.DataAccess.Entities;
using BudgetMiner.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BudgetMiner.Business.Readers
{
    public class YearCostReader : IYearCostReader
    {
        private EntityContext _context;

        public YearCostReader(EntityContext context)
        {
            _context = context;
        }

        public async Task<YearCost> Get(int id)
        {
            return await _context.YearlyCosts.FirstOrDefaultAsync(yc => yc.Id == id);
        }

        public async Task<IEnumerable<YearCost>> GetAll()
        {
            return await _context.YearlyCosts.ToListAsync();
        }
    }
}
