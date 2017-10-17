using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Writers
{
    public class WriterException : BusinessException
    {
        public WriterException(string errorMessage = "Error occured while writing to database")
            : base(errorMessage) { }
    }
}
