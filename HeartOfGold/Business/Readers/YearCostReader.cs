using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HeartOfGold.DataAccess.Entities;
using HeartOfGold.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace HeartOfGold.Business.Readers
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
