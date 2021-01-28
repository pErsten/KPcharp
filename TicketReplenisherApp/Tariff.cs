using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("Tariffs")]
    class Tariff
    {
        private int id;
        public int Id
        {
            private set => id = value;
            get => id;
        }
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

        private int ticketId;
        public int TicketId
        {
            get => ticketId;
            set => ticketId = value;
        }
        private Ticket ticket;
        public Ticket Ticket
        {
            set => ticket = value;
            get => ticket;
        }

        public Tariff() : this(default(ITariffType), default(uint), default(Ticket)) { }
        public Tariff(ITariffType TariffType, uint QuantityOfUses, Ticket Ticket)
        {
            this.TariffType = TariffType;
            this.QuantityOfUses = QuantityOfUses;
            this.Ticket = Ticket;
            this.Ticket.Tariff = this;//this creates 1:1 relation between [Ticket] and [Tariff]
        }
    }
}
