using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("TariffManyTransports")]
    class TariffManyTransports : ITariffType
    {
        [Table("TariffGroups")]
        public class TariffGroups
        {
            private int id;
            public int Id
            {
                private set => id = value;
                get => id;
            }
            private string groupName;
            public string GroupName
            {
                get => groupName;
                set => groupName = value;
            }
            private DateTime expirationDate;
            public DateTime ExpirationDate 
            {
                get => expirationDate;
                set => expirationDate = value;
            }

            public TariffGroups() : this(default(string), default(DateTime)) { }
            public TariffGroups(string GroupName, DateTime ExpirationDate)
            {
                this.GroupName = GroupName;
                this.ExpirationDate = ExpirationDate;
            }
        }
        private decimal priceForTariff;
        public decimal PriceForTariff
        {
            set => priceForTariff = value;
            get => priceForTariff;
        }
        private uint quantityOfUsages;
        public uint QuantityOfUsages
        {
            set => quantityOfUsages = value;
            get => quantityOfUsages;
        }
        private TariffGroups tariffGroup; 
        public TariffGroups TariffGroup
        {
            get => tariffGroup;
            set => tariffGroup = value;
        }

        public TariffManyTransports() : this(default(decimal), default(uint), default(TariffGroups)) { }
        public TariffManyTransports(decimal PriceForTariff, uint QuantityOfUsages, TariffGroups TariffGroup)
        {
            this.PriceForTariff = PriceForTariff;
            this.QuantityOfUsages = QuantityOfUsages;
            this.TariffGroup = TariffGroup;
        }

        public override void SetTariffValues(ref DateTime ExpirationDate)
        {
            ExpirationDate = TariffGroup.ExpirationDate;
        }
    }
}
