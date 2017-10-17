using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeartOfGold.DataAccess.Entities;
using HeartOfGold.DataAccess;

namespace HeartOfGold.Business.Writers
{
    public class ApplicationWriter : IApplicationWriter
    {
        private EntityContext Context => Context as EntityContext;

        public void Insert(Application application)
        {
            try
            {
                Context.Applications.Add(application);
                Context.SaveChangesAsync();
            }
            catch 
            {
                throw new WriterException();
            }
        }

        public void Update(Application application, int id)
        {
            try
            {
                if (id == application.Id)
                {
                    Context.Applications.Update(application);
                    Context.SaveChangesAsync();
                }
                else
                    throw new WriterException();
            }
            catch
            {
                throw new WriterException();
            }
        }
    }
}
