using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("ITariffTypes")]
    public abstract class ITariffType
    {
        private int id;
        public int Id
        {
            private set => id = value;
            get => id;
        }
        public abstract decimal TariffGetPrice(Tariff tariff);
        public abstract void SetTariffToTicketValues(Tariff tariff);
    }
}
