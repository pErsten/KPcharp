using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("Tickets")]
    class Ticket
    {
        /// <summary>
        /// A counter for identificator for instance of this class
        /// Do not fucking dare to touch!
        /// </summary>
        //private static uint ID = 0;
        //public readonly uint Id;
        private int id;
        public int Id
        {
            private set => id = value;
            get => id;
        }
        private string ticketName;
        public string TicketName
        {
            get => ticketName;
            set => ticketName = value;
        }
        private Tariff tariff;
        public Tariff Tariff
        {
            get => tariff;
            set => tariff = value;
        }

        public Ticket(string TicketName, Tariff Tariff) : this(TicketName)
        {
            this.Tariff = Tariff;
            this.Tariff.Ticket = this;//creates 1:1 relation between [Ticket] and [Tariff]
        }
        public Ticket(string TicketName)
        {
            //Id = ++ID;
            this.TicketName = TicketName;
        }
        public Ticket() : this(default(string)) { }

        public void TicketLanguageUpdate()
        {

        }
    }
}
