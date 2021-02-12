﻿using System;
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
            private int facilityCategory;
            public ConstValues.FacilityCategories FacilityCategory
            {
                get => (ConstValues.FacilityCategories)facilityCategory;
                set => facilityCategory = (int)value;
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
            public UserAccount() : this(default(ConstValues.FacilityCategories), default(string), default(string), default(Ticket)) { }
            public UserAccount(ConstValues.FacilityCategories FacilityCategory, string Name, string Surname, Ticket Ticket)
            {
                this.FacilityCategory = FacilityCategory;
                this.Name = Name;
                this.Surname = Surname;
                this.Ticket = Ticket;
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
        private DateTime expireDate;
        public DateTime ExpireDate
        {
            get => expireDate;
            set => expireDate = value;
        }
        private UserAccount account;
        public UserAccount Account
        {
            set => account = value;
            get => account;
        }
        private long ticketBarcode;
        public long TicketBarcode
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
            this.ExpireDate = DateTime.MinValue;
            this.TicketBarcode = TicketBarcode;
            this.MonthsStreak = 0;
        }

        /*public void TicketSetNewTariff(Tariff Tariff)
        {
            this.Tariff = Tariff;
        }*/
    }
}
