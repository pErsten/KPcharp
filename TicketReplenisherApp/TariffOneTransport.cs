using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("TariffOneTransport")]
    class TariffOneTransport : ITariffType
    {
        private decimal priceForOneUsage;
        public decimal PriceForOneUsage
        {
            set => priceForOneUsage = value;
            get => priceForOneUsage;
        }
        private uint minPurchasedQuantityOfUsages;
        public uint MinPurchasedQuantityOfUsages
        {
            set => minPurchasedQuantityOfUsages = value;
            get => minPurchasedQuantityOfUsages;
        }

        public TariffOneTransport() : this(default(uint), default(decimal)) { }
        public TariffOneTransport(uint MinPurchasedQuantityOfUsages, decimal PriceForOneUsage)
        {
            this.MinPurchasedQuantityOfUsages = MinPurchasedQuantityOfUsages;
            this.PriceForOneUsage = PriceForOneUsage;
        }

        public override void SetTariffValues(ref DateTime ExpirationDate)
        {
            ExpirationDate = DateTime.MaxValue;
        }
    }
}
