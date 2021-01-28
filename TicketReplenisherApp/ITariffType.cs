using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TicketReplenisherApp
{
    [Table("ITariffTypes")]
    abstract class ITariffType
    {
        private int id;
        public int Id
        {
            private set => id = value;
            get => id;
        }
    }
}
