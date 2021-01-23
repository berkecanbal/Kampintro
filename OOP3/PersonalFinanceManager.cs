using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceManager : ILoanManager
    {
        public void DoIt()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
