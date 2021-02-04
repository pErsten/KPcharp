using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("Tickets")]
    public class Ticket
    {
        public class UserAccount
        {
            private int id;
            public int Id
            {
                private set => id = value;
                get => id;
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
                get => ticket;
                set => ticket = value;
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
        private long ticketBarcode;
        private long TicketBarcode
        {
            get => ticketBarcode;
            set => ticketBarcode = value;
        }
        private int monthsStreak;
        public int MonthsStreak
        {
            get => monthsStreak;
            set => monthsStreak = value;
        }

        public Ticket() : this(default(long)) { }
        /*public Ticket(long TicketBarcode, Tariff Tariff) : this(TicketBarcode)
        {
            this.Tariff = Tariff;
            this.Tariff.Ticket = this;//creates 1:1 relation between [Ticket] and [Tariff]
        }*/
        public Ticket(long TicketBarcode)
        {
            this.TicketBarcode = TicketBarcode;
            this.MonthsStreak = 0;
        }

        /*public void TicketSetNewTariff(Tariff Tariff)
        {
            this.Tariff = Tariff;
        }*/
    }
}
