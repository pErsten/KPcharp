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
        public class UserAccount
        {
            private int id;
            public int Id
            {
                private set => id = value;
                get => id;
            }

            public enum FacilityCategories : byte
            {
                NoFacilities,
                Student,
                Schoolchild
            }
            private FacilityCategories facilityCategory;
            public FacilityCategories FacilityCategory
            {
                get => facilityCategory;
                set => facilityCategory = value;
            }
            private string name;
            public string Name
            {
                set => name = value;
                get => name;
            }
            private string surname;
            public string Surname
            {
                set => surname = value;
                get => surname;
            }
            public UserAccount() : this(default(FacilityCategories), default(string), default(string)) { }
            public UserAccount(FacilityCategories FacilityCategory, string Name, string Surname)
            {
                this.FacilityCategory = FacilityCategory;
                this.Name = Name;
                this.Surname = Surname;
            }
        }
        private int id;
        public int Id
        {
            private set => id = value;
            get => id;
        }
        private Tariff tariff;
        public Tariff Tariff
        {
            get => tariff;
            set => tariff = value;
        }
        private UserAccount account;
        public UserAccount Account
        {
            set => account = value;
            get => account;
        }
        private ulong ticketBarcode;
        private ulong TicketBarcode
        {
            get => ticketBarcode;
            set => ticketBarcode = value;
        }

        public Ticket() : this(default(ulong)) { }
        public Ticket(ulong TicketBarcode, Tariff Tariff) : this(TicketBarcode)
        {
            this.Tariff = Tariff;
            this.Tariff.Ticket = this;//creates 1:1 relation between [Ticket] and [Tariff]
        }
        public Ticket(ulong TicketBarcode)
        {
            this.TicketBarcode = TicketBarcode;
        }

        public void TicketSetNewTariff(Tariff Tariff)
        {
            this.Tariff = Tariff;
        }
        public void TicketLanguageUpdate()
        {

        }
    }
}
