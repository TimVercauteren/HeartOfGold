using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Readers
{
    public class ReaderException : BusinessException
    {
        public ReaderException(string errorMessage = "Error occured while reading to database")
            : base(errorMessage) { }
    }
}
