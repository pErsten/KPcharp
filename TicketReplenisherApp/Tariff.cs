using System;
using System.Collections.Generic;
using System.Text;

namespace TicketReplenisherApp
{
    class Tariff
    {
        private ITariffType tariffType;
        public ITariffType TariffType
        {
            set => tariffType = value;
            get => tariffType;
        }
        private uint quantityOfUses;
        public uint QuantityOfUses
        {
            set => quantityOfUses = value;
            get => quantityOfUses;
        }
        private Ticket ticket;
        public Ticket Ticket
        {
            set => ticket = value;
            get => ticket;
        }

        public Tariff(ITariffType TariffType, uint QuantityOfUses, Ticket Ticket)
        {
            this.TariffType = TariffType;
            this.QuantityOfUses = QuantityOfUses;
            this.Ticket = Ticket;
            this.Ticket.Tariff = this;//this creates 1:1 relation between [Ticket] and [Tariff]
        }
    }
}
