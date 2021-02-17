using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("Tariffs")]
    public class Tariff
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
            }
            get => tariffType;
        }
        private int quantityOfUses;
        public int QuantityOfUses
        {
            set => quantityOfUses = value;
            get => quantityOfUses;
        }
        private DateTime startDate;
        [Column(TypeName = "date")]
        public DateTime StartDate
        {
            get => startDate;
            set => startDate = value;
        }
        private DateTime endDate;
        [Column(TypeName = "date")]
        public DateTime EndDate
        {
            get => endDate;
            set => endDate = value;
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

        //constructors
        public Tariff() { }
        //TariffOneTransport
        public Tariff(int QuantityOfUses, Ticket Ticket)
        {
            this.QuantityOfUses = QuantityOfUses;
            this.TariffType = TariffOneTransport.GetTariffOneTransport(QuantityOfUses);
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MaxValue;
            this.Ticket = Ticket;
        }
        //TariffManyTransports
        public Tariff(TariffManyTransports TariffType, Ticket Ticket)
        {
            this.QuantityOfUses = TariffType.QuantityOfUsages;
            this.TariffType = TariffType;
            (StartDate, EndDate) = TariffType.GetTariffDates();
            this.Ticket = Ticket;
        }

        public void SetTariffToTicket(bool isPayedByCard)
        {
            TariffType.SetTariffToTicketValues(this);
            Ticket.Tariff = this;
        }
        
        //facade methods
        public decimal CalculateMonthsStreakDecrease()
        {
            return (TariffType as TariffManyTransports)?.GetMonthStreakDecrease(Ticket.MonthsStreak) ?? 1;
        }
        public int CalculateMonthsStreak()
        {
            return Ticket.MonthsStreak;
        }
        public decimal CalculatePrice(bool isPayedByCard)
        {
            decimal Price = TariffType.TariffGetPrice(this);
            if (isPayedByCard)
                Price *= 0.995M;//Formula 2.4
            return Price;
        }
    }
}
