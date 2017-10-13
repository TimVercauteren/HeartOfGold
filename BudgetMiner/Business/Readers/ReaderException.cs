using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers
{
    public class ReaderException : BudgetMinerException
    {
        public ReaderException(string errorMessage = "Error occured while reading to database")
            : base(errorMessage) { }
    }
}
