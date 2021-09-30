using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountManagement
{
    class StockPortFolio
    {
        internal static double StockValue(double SharePrice, int NoOfShares)
        {
            double result = SharePrice * NoOfShares;
            return result;
        }
    }
}
