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

            public TariffGroups() : this(default(string)) { }
            public TariffGroups(string GroupName)
            {
                this.GroupName = GroupName;
            }
        }
        private decimal priceForTariff;
        public decimal PriceForTariff
        {
            set => priceForTariff = value;
            get => priceForTariff;
        }
        private uint orderedQuantityOfUsages;
        public uint OrderedQuantityOfUsages
        {
            set => orderedQuantityOfUsages = value;
            get => orderedQuantityOfUsages;
        }
        private TariffGroups tariffGroup; 
        public TariffGroups TariffGroup
        {
            get => tariffGroup;
            set => tariffGroup = value;
        }

        public TariffManyTransports() : this(default(decimal), default(uint), default(TariffGroups)) { }
        public TariffManyTransports(decimal PriceForTariff, uint OrderedQuantityOfUsages, TariffGroups TariffGroup)
        {
            this.PriceForTariff = PriceForTariff;
            this.OrderedQuantityOfUsages = OrderedQuantityOfUsages;
            this.TariffGroup = TariffGroup;
        }
    }
}
