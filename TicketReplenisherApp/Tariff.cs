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
        public DateTime StartDate
        {
            get => startDate;
            set => startDate = value;
        }
        private DateTime endDate;
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

        public Tariff() : this(default(TariffManyTransports)) { Console.WriteLine("empty Tariff created"); }
        //TariffOneTransport
        public Tariff(int QuantityOfUses)
        {
            this.QuantityOfUses = QuantityOfUses;
            this.TariffType = TariffOneTransport.GetTariffOneTransport(QuantityOfUses);
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MaxValue;
        }
        //TariffManyTransports
        public Tariff(TariffManyTransports TariffType)
        {
            this.QuantityOfUses = TariffType.QuantityOfUsages;
            this.TariffType = TariffType;
            (this.StartDate, this.EndDate) = TariffType.GetTariffDates();
        }

        public void SetTariffToTicket(Ticket Ticket)
        {
            /*if(this.TariffType is TariffManyTransports)
            {
                if (Ticket.Tariff.EndDate.Year == this.EndDate.Year && Ticket.Tariff.EndDate.Month == this.EndDate.Month)
                    Ticket.MonthsStreak++;
                else
                    Ticket.MonthsStreak = 0;
            }*/
            this.Ticket = Ticket;
            this.Ticket.Tariff = this;
        }
        
        public (decimal, int, decimal) CalculatePriceAndMonthsStreak(bool isPayedByCard, Ticket ticket)
        {
            int MonthsStreak = ticket.MonthsStreak;
            decimal Price;
            decimal MonthsStreakDecrease = 1M;
            if (this.TariffType is TariffOneTransport) 
                Price = this.QuantityOfUses * (ConstValues.ONE_USAGE_COST - ConstValues.COEFFICIENT_QUANTIFICATOR * (this.TariffType as TariffOneTransport).CoefficientNumber);//Formula 2.1
            else
            {
                Price = (this.TariffType as TariffManyTransports).PriceForTariff;//Formula 2.2

                if (ticket.ExpireDate == this.EndDate)
                    MonthsStreak--;
                else if (ticket.ExpireDate.Month == 12 ?
                    (ticket.ExpireDate.Year != this.EndDate.Year - 1 || this.EndDate.Month != 1)
                    : (ticket.ExpireDate.Year != this.EndDate.Year || ticket.ExpireDate.Month != this.EndDate.Month - 1))
                    MonthsStreak = 0;

                decimal x = 1 - Convert.ToDecimal(MonthsStreak/ConstValues.NUMBER_OF_MONTHS_FOR_SUM_DECREASE)/100;
                MonthsStreak++;
                MonthsStreakDecrease = x > ConstValues.MIN_COEFFICIENT_OF_TARIFF ? x : ConstValues.MIN_COEFFICIENT_OF_TARIFF;//Formula 2.3
                Price *= MonthsStreakDecrease;
            }
            if (isPayedByCard)
                Price *= 0.995M;//Formula 2.4
            return (Price, MonthsStreak, 1 - MonthsStreakDecrease);
        }
        /*public Tariff(ITariffType TariffType, int QuantityOfUses, Ticket Ticket)
        {
            this.QuantityOfUses = QuantityOfUses;
            this.TariffType = TariffType;
            this.Ticket = Ticket;
            this.Ticket.Tariff = this;//this creates 1:1 relation between [Ticket] and [Tariff]
        }*/
    }
}
