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
            set
            {
                tariffType = value;
                tariffType.SetTariffValues(ref expirationDate);
            }
            get => tariffType;
        }
        private uint quantityOfUses;
        public uint QuantityOfUses
        {
            set => quantityOfUses = value;
            get => quantityOfUses;
        }
        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get => expirationDate;
            set => expirationDate = value;
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
            this.QuantityOfUses = QuantityOfUses;
            this.TariffType = TariffType;
            this.Ticket = Ticket;
            this.Ticket.Tariff = this;//this creates 1:1 relation between [Ticket] and [Tariff]
        }
    }
}
