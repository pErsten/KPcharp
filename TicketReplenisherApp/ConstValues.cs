using System;
using System.Collections.Generic;
using System.Text;

namespace TicketReplenisherApp
{
    static class ConstValues
    {
        /// <summary>
        /// For TariffOneTransport
        /// </summary>
        public const decimal ONE_USAGE_COST = 8M;

        /// <summary>
        /// For TariffOneTransport in formula 2.1
        /// </summary>
        public const decimal COEFFICIENT_QUANTIFICATOR = 0.3M;
        
        /// <summary>
        /// For TariffManyTransports in formula 2.3
        /// </summary>
        public const decimal MIN_COEFFICIENT_OF_TARIFF = 0.9M;

        /// <summary>
        /// For TariffManyTransports in formula 2.3
        /// </summary>
        public const int NUMBER_OF_MONTHS_FOR_SUM_DECREASE = 6;

        /// <summary>
        /// For TariffManyTransports in formula 2.2
        /// </summary>
        /// <param name="QuantityOfUsages"></param>
        /// <returns>Main tariff price (without calculating the actual price)</returns>
        public static float GetTariffPrice(int QuantityOfUsages)
        {
            return QuantityOfUsages switch
            {
                46 => 290f,
                62 => 390f,
                92 => 575f,
                124 => 770f,
                int.MaxValue => 1300f,
                _ => -1f
            };
        }
    }
}
