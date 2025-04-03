using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Loan
    {
        public double GetOutStandingLoans(int acctNum)
        {
            double res = 0;
            if (acctNum == 12345)
                res = 2100;
            else if (acctNum == 12346)
                res = 7880;
            return res;
        }
    }
}
