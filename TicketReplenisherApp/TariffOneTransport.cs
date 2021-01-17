using System;
using System.Collections.Generic;
using System.Text;

namespace TicketReplenisherApp
{
    class TariffOneTransport : ITariffType
    {
        private decimal priceForOneUsage;
        public decimal PriceForOneUsage
        {
            set => priceForOneUsage = value;
            get => priceForOneUsage;
        }
        private uint minOrderedQuantityOfUsages;
        public uint MinOrderedQuantityOfUsages
        {
            set => minOrderedQuantityOfUsages = value;
            get => minOrderedQuantityOfUsages;
        }

        public TariffOneTransport() : this(default(uint), default(decimal)) { }
        public TariffOneTransport(uint MinOrderedQuantityOfUsages, decimal PriceForOneUsage)
        {
            this.MinOrderedQuantityOfUsages = MinOrderedQuantityOfUsages;
            this.PriceForOneUsage = PriceForOneUsage;
        }
    }
}
