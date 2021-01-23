using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        //method injection
        public void BasvuruYap(ILoanManager loanManager, ILoggerService loggerService)
        {
            //Başvuran bilgileri değerlendirme
            //
            loanManager.Calculate();
            loggerService.Log();
        }

        public void LoanPreview(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }


    }
}
