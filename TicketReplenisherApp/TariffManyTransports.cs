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

            [Obsolete]
            private string groupName;
            [Obsolete]
            public string GroupName
            {
                get => groupName;
                set => groupName = value;
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

            public TariffGroups() : this(default(string), default(DateTime), default(float)) { }
            public TariffGroups(string GroupName, DateTime StartDate, float CoefficientNumber)
            {
                this.GroupName = GroupName;
                this.StartDate = StartDate;
                this.EndDate = new DateTime(StartDate.Year, StartDate.Month, DateTime.DaysInMonth(StartDate.Year, StartDate.Month));
                this.CoefficientNumber = CoefficientNumber;
            }

            public override string ToString()
            {
                return $"TariffGroup: id - {Id, 2}, group name - {GroupName, -23}, start - {StartDate:dd.MM.yyyy}, end - {EndDate:dd.MM.yyyy}, coefficient - {CoefficientNumber:0.000}";
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

        public TariffManyTransports() : this(default(int), default(TariffGroups)) { }
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
    }
}
