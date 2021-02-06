using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReplenisherApp
{
    public class OrderedTariffs
    {
        private int tariffId;
        public int TariffId
        {
            get => tariffId;
            set => tariffId = value;
        }
        private ITariffType tariff;
        public ITariffType Tariff
        {
            get => tariff;
            private set => tariff = value;
        }
        private DateTime dateOfOrder;
        [Column(TypeName = "date")]
        public DateTime DateOfOrder
        {
            get => dateOfOrder;
            private set => dateOfOrder = value;
        }

        private int quantityOfTariffs;
        public int QuantityOfTariffs
        {
            get => quantityOfTariffs;
            set => quantityOfTariffs = value;
        }
        private long quantityOfUses;
        public long QuantityOfUses
        {
            get => quantityOfUses;
            set => quantityOfUses = value;
        }

    }
}
