using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Hw
{
    interface ICampaign
    {
        void DiscountCalculate(Game game);
        void SaleInformation(Game game);
    }
}
