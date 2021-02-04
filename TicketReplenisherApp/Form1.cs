using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReplenisherApp
{
    public partial class Form1 : Form
    {
        public static ApplicationDBContext DB = new ApplicationDBContext(new DbContextOptionsBuilder<ApplicationDBContext>().UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TicketReplenisherDB;Trusted_Connection=True;").Options);
        public Form1()
        {
            InitializeComponent();
            {
                //DateTime EndMonthDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                DateTime StartMonthDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime StartSecondHalfMonthDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) / 2);
                DB.TariffOneTransportTable.AddRange(new TariffOneTransport(0, 1),
                                                    new TariffOneTransport(1, 10),
                                                    new TariffOneTransport(2, 20),
                                                    new TariffOneTransport(3, 30),
                                                    new TariffOneTransport(4, 40),
                                                    new TariffOneTransport(5, 50)); ;
                DB.TariffGroupsTable.AddRange(new TariffManyTransports.TariffGroups("Full, month", StartMonthDate, 1f),
                                              new TariffManyTransports.TariffGroups("Full, half month", StartSecondHalfMonthDate, 0.5f),
                                              new TariffManyTransports.TariffGroups("Student, month", StartMonthDate, 0.5f),
                                              new TariffManyTransports.TariffGroups("Schoolchild, month", StartMonthDate, 0.25f),
                                              new TariffManyTransports.TariffGroups("Schoolchild, half month", StartSecondHalfMonthDate, 0.125f));
                DB.SaveChanges();
                DB.TariffManyTransportsTable.AddRange(new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[0]),
                                                      new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[1]),
                                                      new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[2]),
                                                      new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[3]),
                                                      new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[4]));
                DB.SaveChanges();
                listBox1.DataSource = DB.TariffOneTransportTable.Local.ToBindingList();
                listBox2.DataSource = DB.TariffGroupsTable.Local.ToBindingList();
                listBox3.DataSource = DB.TariffManyTransportsTable.Local.ToBindingList();
            }
        }
    }
}
