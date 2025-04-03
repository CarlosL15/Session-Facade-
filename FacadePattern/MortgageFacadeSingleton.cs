using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class MortgageFacadeSingleton
    {
        Bank bk = new Bank();
        Loan ln = new Loan();   
        Credit cr = new Credit();    

        static readonly MortgageFacadeSingleton instance = new MortgageFacadeSingleton();

        public static MortgageFacadeSingleton Instance
        {
            get { return instance; }
        }
        MortgageFacadeSingleton() { }
        public bool MortgageApproval(MortgageApplicant mapp, ref string reason)
        {
            bool approved = false;
            double bal = bk.GetCurrentCheckingBalance(mapp.BankAccountNum);
            bal = bal + bk.GetSavingBalance(mapp.BankAccountNum);

            bal = bal - ln.GetOutStandingLoans(mapp.BankAccountNum);
            if (bal > 0)
            {
                approved = false;
                reason = "negative balances";
            }
            else
            {
                if (bal < 0.2 * mapp.LoanAmountAsked)
                {
                    approved = false;
                    reason = "Not enough balances";
                }
                else
                {
                    if (cr.CheckCredit(mapp.SSNum) < CreditRating.GOOD)
                    {
                        approved = false;
                        reason = "Not good enough of a credit score..";
                    }
                    else
                        approved = true;
                }
            }
            return approved;
        }
        
    }
}
