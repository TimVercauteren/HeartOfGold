using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartOfGold
{
    public class HeartOfGoldException : Exception
    {
        public HeartOfGoldException(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; set; }
    }
}
