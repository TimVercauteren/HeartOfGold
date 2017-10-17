using HeartOfGold.DataAccess;
using HeartOfGold.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Readers
{
    public class ApplicationReader : IApplicationReader
    { 
        private EntityContext _context;

        public ApplicationReader(EntityContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Application>> GetAll()
        {
            return await _context.Applications.ToListAsync();
        }

        public async Task<Application> Get (int appId)
        {
            return await _context.Applications.FirstOrDefaultAsync(a => a.Id == appId);
        }
    }
}
