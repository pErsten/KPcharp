using System;
using System.Collections.Generic;
using System.Text;

namespace TicketReplenisherApp
{
    class Ticket
    {
        /// <summary>
        /// A counter for identificator for instance of this class
        /// Do not fucking dare to touch!
        /// </summary>
        //private static uint ID = 0;
        //public readonly uint Id;

        private string ticketName;
        public string TicketName
        {
            get => ticketName;
            set => ticketName = value;
        }
        private decimal costValue;
        public decimal CostValue
        {
            get => costValue;
            set => costValue = value;
        }
        private Tariff tariff;
        public Tariff Tariff
        {
            get => tariff;
            set => tariff = value;
        }

        public Ticket(string TicketName, decimal CostValue, Tariff Tariff) : this(TicketName, CostValue)
        {
            this.Tariff = Tariff;
            this.Tariff.Ticket = this;//creates 1:1 relation between [Ticket] and [Tariff]
        }
        public Ticket(string TicketName, decimal CostValue)
        {
            //Id = ++ID;
            this.TicketName = TicketName;
            this.CostValue = CostValue;
        }
        public Ticket() : this(default(string), default(decimal)) { }

        public void TicketLanguageUpdate()
        {

        }
    }
}
