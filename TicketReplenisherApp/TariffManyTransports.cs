using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("TariffManyTransports")]
    public class TariffManyTransports : ITariffType
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

            private int groupCategory;
            public ConstValues.FacilityCategories GroupCategory
            {
                get => (ConstValues.FacilityCategories)groupCategory;
                set => groupCategory = (int)value;
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
            private float coefficientNumber;
            public float CoefficientNumber
            {
                get => coefficientNumber;
                set => coefficientNumber = value;
            }

            public TariffGroups() : this(default(ConstValues.FacilityCategories), default(DateTime), default(float)) { }
            public TariffGroups(ConstValues.FacilityCategories GroupCategory, DateTime StartDate, float CoefficientNumber)
            {
                this.GroupCategory = GroupCategory;
                this.StartDate = StartDate;
                this.EndDate = new DateTime(StartDate.Year, StartDate.Month, DateTime.DaysInMonth(StartDate.Year, StartDate.Month));
                this.CoefficientNumber = CoefficientNumber;
            }

            public override string ToString()
            {
                return $"TariffGroup: id - {Id, 2}, group name - {GroupCategory, -23}, start - {StartDate:dd.MM.yyyy}, end - {EndDate:dd.MM.yyyy}, coefficient - {CoefficientNumber:0.000}";
            }
        }
        private decimal priceForTariff;
        public decimal PriceForTariff
        {
            set => priceForTariff = value;
            get => priceForTariff;
        }
        private int quantityOfUsages;
        public int QuantityOfUsages
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

        public TariffManyTransports() { }
        public TariffManyTransports(int QuantityOfUsages, TariffGroups TariffGroup)
        {
            this.QuantityOfUsages = QuantityOfUsages;
            this.TariffGroup = TariffGroup;
            //realisation of formula 2.2
            this.PriceForTariff = Convert.ToDecimal(ConstValues.GetTariffPrice(QuantityOfUsages) * TariffGroup.CoefficientNumber);
        }

        public (DateTime, DateTime) GetTariffDates()
        {
            return (TariffGroup.StartDate, TariffGroup.EndDate);
        }
        public override string ToString()
        {
            return $"TariffManyTransports: id - {Id, 2}, tariff price - {PriceForTariff:C2}, quantity of usages - {QuantityOfUsages}, tariff group id - {TariffGroup.Id}";
        }

        public override decimal TariffGetPrice(Tariff tariff)
        {
            decimal Price = PriceForTariff;//Formula 2.2
            int MonthsStreak = tariff.Ticket.MonthsStreak;
            decimal MonthsStreakDecrease = GetMonthStreakDecrease(MonthsStreak);
            return Price * MonthsStreakDecrease;
        }
        public decimal GetMonthStreakDecrease(int MonthsStreak)
        {
            decimal x = 1 - Convert.ToDecimal(MonthsStreak / ConstValues.NUMBER_OF_MONTHS_FOR_SUM_DECREASE) / 100;
            return x > ConstValues.MIN_COEFFICIENT_OF_TARIFF ? x : ConstValues.MIN_COEFFICIENT_OF_TARIFF;//Formula 2.3
        }

        public override void SetTariffToTicketValues(Tariff tariff)
        {
            tariff.Ticket.MonthsStreak++;// = tariff.CalculateMonthsStreak() + 1;
            tariff.Ticket.ExpireDate = tariff.EndDate;
        }
    }
}
