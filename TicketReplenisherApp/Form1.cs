using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TicketReplenisherApp
{
    public partial class Form1 : Form
    {
        DateTime StartMonthDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime StartSecondHalfMonthDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) / 2);

        public Form1()
        {
            InitializeComponent();
            //--------------
            /*ChartArea chartArea1 = new ChartArea() { Name = "ChartArea1" };
            this.myChart.ChartAreas.Add(chartArea1);
            this.myChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myChart.Location = new System.Drawing.Point(0, 512);
            //this.myChart.Size = new System.Drawing.Size(800, 200);
            this.myChart.Name = "myChart";
            this.myChart.TabIndex = 3;
            this.myChart.Text = "chart1";
            this.Controls.Add(myChart);
            Series mySeriesOfPoint;
            mySeriesOfPoint = new Series("Графік функції");
            mySeriesOfPoint.Color = Color.Orange;
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "ChartArea1";
            for (double x = 0; x <= 10; x += 0.1)
            {
                mySeriesOfPoint.Points.AddXY(x, Math.Sin(x));
            }

            //myChart.Series?.Remove(myChart.Series?.Last());
            myChart.Series.Add(mySeriesOfPoint);*/
            //--------------------
            
            DB.TariffOneTransportTable.Add(new TariffOneTransport(0, 1));
            DB.TariffOneTransportTable.Add(new TariffOneTransport(1, 10));
            DB.TariffOneTransportTable.Add(new TariffOneTransport(2, 20));
            DB.TariffOneTransportTable.Add(new TariffOneTransport(3, 30));
            DB.TariffOneTransportTable.Add(new TariffOneTransport(4, 40));
            DB.TariffOneTransportTable.Add(new TariffOneTransport(5, 50));
            DB.SaveChanges();
            DB.TariffGroupsTable.Add(new TariffManyTransports.TariffGroups(ConstValues.FacilityCategories.Schoolchild, StartSecondHalfMonthDate, 0.125f));
            DB.TariffGroupsTable.Add(new TariffManyTransports.TariffGroups(ConstValues.FacilityCategories.Schoolchild, StartMonthDate,           0.25f));
            DB.TariffGroupsTable.Add(new TariffManyTransports.TariffGroups(ConstValues.FacilityCategories.Student,     StartMonthDate,           0.5f));
            DB.TariffGroupsTable.Add(new TariffManyTransports.TariffGroups(ConstValues.FacilityCategories.Full,        StartSecondHalfMonthDate, 0.5f));
            DB.TariffGroupsTable.Add(new TariffManyTransports.TariffGroups(ConstValues.FacilityCategories.Full,        StartMonthDate,           1f));
            DB.SaveChanges();
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[0]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[1]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[2]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[3]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(int.MaxValue, DB.TariffGroupsTable.ToList()[4]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(46,           DB.TariffGroupsTable.ToList()[0]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(46,           DB.TariffGroupsTable.ToList()[1]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(46,           DB.TariffGroupsTable.ToList()[2]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(46,           DB.TariffGroupsTable.ToList()[3]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(62,           DB.TariffGroupsTable.ToList()[0]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(62,           DB.TariffGroupsTable.ToList()[1]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(62,           DB.TariffGroupsTable.ToList()[2]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(62,           DB.TariffGroupsTable.ToList()[3]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(92,           DB.TariffGroupsTable.ToList()[0]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(92,           DB.TariffGroupsTable.ToList()[1]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(92,           DB.TariffGroupsTable.ToList()[2]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(92,           DB.TariffGroupsTable.ToList()[3]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(124,          DB.TariffGroupsTable.ToList()[0]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(124,          DB.TariffGroupsTable.ToList()[1]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(124,          DB.TariffGroupsTable.ToList()[2]));
            DB.TariffManyTransportsTable.Add(new TariffManyTransports(124,          DB.TariffGroupsTable.ToList()[3]));
            DB.SaveChanges();
            DB.TicketTable.Add(new Ticket(100010626575));
            DB.TicketTable.Add(new Ticket(1));
            DB.TicketTable.Add(new Ticket(2));
            DB.TicketTable.Add(new Ticket(3));
            DB.TicketTable.Add(new Ticket(4));
            DB.SaveChanges();
            DB.UserAccountTable.Add(new Ticket.UserAccount(ConstValues.FacilityCategories.Student,     "Vladislav", "Paplinsky", DB.TicketTable.ToList()[0]));
            DB.UserAccountTable.Add(new Ticket.UserAccount(ConstValues.FacilityCategories.Student,     "David",     "Zhezhkov",  DB.TicketTable.ToList()[1]));
            DB.UserAccountTable.Add(new Ticket.UserAccount(ConstValues.FacilityCategories.Full,        "Peshkesh",  "Dozhev",    DB.TicketTable.ToList()[2]));
            DB.UserAccountTable.Add(new Ticket.UserAccount(ConstValues.FacilityCategories.Schoolchild, "Mao Zedong","Sasha",     DB.TicketTable.ToList()[3]));
            DB.SaveChanges();

            
            SetWindow1Values();
            /*listBox1.DataSource = DB.TariffOneTransportTable.Local.ToBindingList();
            listBox2.DataSource = DB.TariffGroupsTable.Local.ToBindingList();
            listBox3.DataSource = DB.TariffManyTransportsTable.Local.ToBindingList();/**/
        }

        static string getConfigurationBuilder()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder() { };
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            return builder.Build().GetConnectionString("DefaultConnection");
        }
        public static ApplicationDBContext DB = new ApplicationDBContext(new DbContextOptionsBuilder<ApplicationDBContext>().UseSqlServer(getConfigurationBuilder()).Options);



        //
        // Window 1
        //


        
        private void SetWindow1Values()
        {
            textBoxStartMenu.PlaceholderText = "Наприклад \"123456789012\"";
        }
        private void buttonStartMenuContinue_Click(object sender, EventArgs e)
        {
            long ticketCode = 0;
            long.TryParse(textBoxStartMenu.Text, out ticketCode);
            Ticket ticket = DB.TicketTable.Where(x => x.TicketBarcode == ticketCode)
                                          .Include(x => x.Account)
                                          .Include(x => x.Tariff)
                                          .SingleOrDefault();
            textBoxStartMenu.ResetText();
            if (ticket != null)
            {
                panelWindow1.Visible = false;
                SetWindow1Values();
                OpenWindow2(ticket);
            }
            else
            {
                textBoxStartMenu.PlaceholderText = "Введіть будь-ласка ще раз";
            }
        }



        //
        // Window 2
        //

        Ticket ticket { get; set; }
        int tariffOneTransportUses { get; set; }
        Tariff tariff { get; set; }

        private void OpenWindow2(Ticket ticket)
        {
            this.ticket = ticket;
            panelWindow2.Visible = true;
            labelWindow2UpName.Text = $"{ticket.Account.Surname} {ticket.Account.Name}";
            if (ticket.Tariff != null) labelWindow2UpTariff.Text = $"Баланс: {ticket.Tariff.QuantityOfUses}, дійсний до: {ticket.Tariff.EndDate:dd/MM/yyyy}";
            
            listBoxTariffsManyTransports.Items.Add("Поїздки     Дійсний від Дійсний до  Ціна тарифу");
            listBoxTariffsManyTransports.Items.AddRange(DB.TariffManyTransportsTable
                                                          .Where(x => x.TariffGroup.GroupCategory == ticket.Account.FacilityCategory)
                                                          .OrderBy(x => x.TariffGroup.StartDate)
                                                          .ThenBy(x => x.QuantityOfUsages)
                                                          .Select(x => $"{(x.QuantityOfUsages == int.MaxValue ? "Безлімітний" : x.QuantityOfUsages),-12}" +
                                                                       $"{x.TariffGroup.StartDate,-12:dd/MM/yyyy}" +
                                                                       $"{x.TariffGroup.EndDate,-12:dd/MM/yyyy}" +
                                                                       $"{x.PriceForTariff:C2}").ToArray());
            listBoxTariffsSingleTransport.Items.Add("Замовлені поїздки   Ціна за одну поїздку");
            for (int i = 0; i < DB.TariffOneTransportTable.Count(); i++)
            {
                listBoxTariffsSingleTransport.Items.Add($"{DB.TariffOneTransportTable.ToList()[i].MinUsagesQuantityForCoefficient,2}" +
                                                        $"{(i + 1 < DB.TariffOneTransportTable.Count() ? "-" + (DB.TariffOneTransportTable.ToList()[i + 1].MinUsagesQuantityForCoefficient - 1).ToString() : "+"),-18}" +
                                                        $"{ConstValues.ONE_USAGE_COST - DB.TariffOneTransportTable.ToList()[i].CoefficientNumber * ConstValues.COEFFICIENT_QUANTIFICATOR:C2}");
            }
            buttonManyTransportTariff1.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 46);
            buttonManyTransportTariff2.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 62);
            buttonManyTransportTariff3.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 92);
            buttonManyTransportTariff4.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 124);
            buttonManyTransportTariff5.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == int.MaxValue);
            buttonManyTransportTariff6.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate           && x.QuantityOfUsages == 46);
            buttonManyTransportTariff7.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate           && x.QuantityOfUsages == 62);
            buttonManyTransportTariff8.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate           && x.QuantityOfUsages == 92);
            buttonManyTransportTariff9.Visible  = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate           && x.QuantityOfUsages == 124);
            buttonManyTransportTariff10.Visible = DB.TariffManyTransportsTable.Any(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate           && x.QuantityOfUsages == int.MaxValue);
        }

        private void buttonWindow2Exit_Click(object sender, EventArgs e)
        {
            this.ticket = null;
            listBoxTariffsManyTransports.Items.Clear();
            listBoxTariffsSingleTransport.Items.Clear();
            panelWindow1.Visible = true;
            panelWindow2.Visible = false;
            panelWindow2Central.Visible = true;
            panelWindow2_1Central.Visible = false;
            panelWindow2_2Central.Visible = false;
            panelWindow2_3Central.Visible = false;
            numericUpDown1.Value = 0;
            panelIsByCash.BackColor = Color.Yellow;
            panelIsByCard.BackColor = Color.Sienna;
            labelIsByCard.Visible = false;
            labelIsByCardHeader.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelWindow2Central.Visible = false;
            panelWindow2_1Central.Visible = true;
            labelWindow2_1TariffCost.Text = $"{0:C2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelWindow2Central.Visible = false;
            panelWindow2_2Central.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelWindow2Central.Visible = false;
            panelWindow2_3Central.Visible = true;
        }

        //
        // Window 2_1
        //

        private void buttonWindow2_1Next_Click(object sender, EventArgs e)
        {
            //panelWindowBlocker.Visible = true;
            if (tariffOneTransportUses == 0)
                return;
            //panelWindow2.Visible = false;
            tariff = new Tariff(tariffOneTransportUses);
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tariffOneTransportUses = (int)(sender as NumericUpDown).Value;
            if (tariffOneTransportUses > 0)
            {
                TariffOneTransport tariff = TariffOneTransport.GetTariffOneTransport(tariffOneTransportUses);
                labelWindow2_1TariffCost.Text = $"{tariffOneTransportUses * (ConstValues.ONE_USAGE_COST - tariff.CoefficientNumber * ConstValues.COEFFICIENT_QUANTIFICATOR):C2}";
            }
            else
                labelWindow2_1TariffCost.Text = $"{0:C2}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelWindow2Central.Visible = true;
            panelWindow2_1Central.Visible = false;
            numericUpDown1.Value = 0;
        }

        //
        //Window 2_2
        //

        private void button5_Click(object sender, EventArgs e)
        {
            panelWindow2Central.Visible = true;
            panelWindow2_2Central.Visible = false;
        }

        private void buttonManyTransportTariff1_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 46).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff2_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 62).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff3_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 92).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff4_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == 124).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff5_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartSecondHalfMonthDate && x.QuantityOfUsages == int.MaxValue).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff6_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate && x.QuantityOfUsages == 46).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff7_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate && x.QuantityOfUsages == 62).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff8_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate && x.QuantityOfUsages == 92).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff9_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate && x.QuantityOfUsages == 124).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        private void buttonManyTransportTariff10_Click(object sender, EventArgs e)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory && x.TariffGroup.StartDate == StartMonthDate && x.QuantityOfUsages == int.MaxValue).FirstOrDefault());
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }

        //
        // Window 2_3
        //

        private void buttonWindow2_3Back_Click(object sender, EventArgs e)
        {
            panelWindow2Central.Visible = true;
            panelWindow2_3Central.Visible = false;
        }

        //
        // Window Order Prepare
        //

        private void PanelWindowOrderPrepareOpen()
        {
            panelWindowOrderPrepare.Visible = true;
            panelWindowOrderPrepare.BringToFront();
            (decimal totalPrice, int MonthsStreak, decimal MonthsStreakDecrease) = tariff.CalculatePriceAndMonthsStreak(false, ticket);
            if (tariff.TariffType is TariffManyTransports)
            {
                labelMonthsOrderedHeader.Text = $"Знижка за {MonthsStreak - 1} щомісячних замовлених тарифів: ";
                labelMonthsOrdered.Text = $"{MonthsStreakDecrease:##0.##%}";
            }
            labelTotalPrice.Text = $"{totalPrice:C2}";
        }

        private void buttonIsByCash_Click(object sender, EventArgs e)
        {
            panelIsByCash.BackColor = Color.Yellow;
            panelIsByCard.BackColor = Color.Sienna;
            labelIsByCard.Visible = false;
            labelIsByCardHeader.Visible = false;
            (decimal totalPrice, _, _) = tariff.CalculatePriceAndMonthsStreak(false, ticket);
            labelTotalPrice.Text = $"{totalPrice:C2}";
        }

        private void buttonIsByCard_Click(object sender, EventArgs e)
        {
            panelIsByCash.BackColor = Color.Sienna;
            panelIsByCard.BackColor = Color.Yellow;
            labelIsByCard.Visible = true;
            labelIsByCardHeader.Visible = true;
            (decimal totalPrice, _, _) = tariff.CalculatePriceAndMonthsStreak(true, ticket);
            labelTotalPrice.Text = $"{totalPrice:C2}";
        }

        private void buttonWindowOrderPrepareCancel_Click(object sender, EventArgs e)
        {
            panelWindowOrderPrepare.Visible = false;
            panelWindow2.Visible = true;
            buttonIsByCash_Click(null, null);
        }

        //--



    }
}