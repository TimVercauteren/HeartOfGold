using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Writers
{
    public class WriterException : BudgetMinerException
    {
        public WriterException(string errorMessage = "Error occured while writing to database")
            : base(errorMessage) { }
    }
}
