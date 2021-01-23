using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalFinanceManager = new PersonalFinanceManager();
            ILoanManager transportLoanManager = new TransportLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();
            ILoanManager traderLoanManager = new TraderLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ApplyManager applyManager = new ApplyManager();
            applyManager.BasvuruYap(traderLoanManager, new SmsLoggerService()); //(new DatabaseLoggerService) de olur


            List<ILoanManager> loans = new List<ILoanManager>() {personalFinanceManager, transportLoanManager };
            //applyManager.LoanPreview(loans);
        }
    }
}
