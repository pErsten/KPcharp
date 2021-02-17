using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Linq;

namespace TicketReplenisherApp
{
    [Table("TariffOneTransport")]
    public class TariffOneTransport : ITariffType
    {
        private int coefficientNumber;
        public int CoefficientNumber
        {
            set => coefficientNumber = value;
            get => coefficientNumber;
        }
        private int minUsagesQuantityForCoefficient;
        public int MinUsagesQuantityForCoefficient
        {
            set => minUsagesQuantityForCoefficient = value;
            get => minUsagesQuantityForCoefficient;
        }

        public TariffOneTransport() { }
        public TariffOneTransport(int CoefficientNumber, int MinUsagesQuantityForCoefficient)
        {
            this.CoefficientNumber = CoefficientNumber;
            this.MinUsagesQuantityForCoefficient = MinUsagesQuantityForCoefficient;
        }

        public override string ToString()
        {
            return $"TariffOneTransport: id - {Id}, coefficient for one usage - {CoefficientNumber}, min usage quantity - {MinUsagesQuantityForCoefficient, 2}";
        }
        public static TariffOneTransport GetTariffOneTransport(int QuantityOfUsages)
        {
            return Form1.DB.TariffOneTransportTable
                           .OrderByDescending(x => x.MinUsagesQuantityForCoefficient)
                           .Where(x => x.MinUsagesQuantityForCoefficient <= QuantityOfUsages)
                           .FirstOrDefault();
        }

        public override decimal TariffGetPrice(Tariff tariff)
        {
            return tariff.QuantityOfUses * (ConstValues.ONE_USAGE_COST - ConstValues.COEFFICIENT_QUANTIFICATOR * this.CoefficientNumber);//Formula 2.1
        }
        public override void SetTariffToTicketValues(Tariff tariff)
        {
            if (tariff.Ticket.Tariff.TariffType is TariffOneTransport)
                tariff.QuantityOfUses += tariff.Ticket.Tariff.QuantityOfUses;
        }
    }
}
