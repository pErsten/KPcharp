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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TicketReplenisherApp
{
    public partial class Form1 : Form
    {
        DateTime StartMonthDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime StartSecondHalfMonthDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) / 2);
        public static Form1 ThisForm;

        public Form1()
        {
            InitializeComponent();
            ThisForm = this;
            //--------------
            /*Thread thread = new Thread(async () =>
            {
                Thread.Sleep(10000);
                for (int i = 0; i != 30; i++)
                {
                    Thread.Sleep(2000);
                    this.Invoke(new Action(() => mySeriesOfPoint.ChartType = (SeriesChartType)i));
                    MessageBox.Show(((SeriesChartType)i).ToString());
                }
            });*/
            //----------------------------------------


            /*DB.TariffOneTransportTable.Add(new TariffOneTransport(0, 1));
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
            DB.UserAccountTable.Add(new Ticket.UserAccount(ConstValues.FacilityCategories.Schoolchild, "Mao Zedong","Sasha",     DB.TicketTable.ToList()[3]));*/
            DB.TariffGroupsTable.Load();
            DB.TariffManyTransportsTable.Load();
            DB.TariffOneTransportTable.Load();
            DB.OrderedTariffTable.Load();
            DB.TariffTable.Load();
            DB.TicketTable.Load();
            DB.UserAccountTable.Load();
            if(!DB.OrderedTariffTable.Any(x => x.DateOfOrder == StartMonthDate))
            {
                foreach(var x in DB.TariffManyTransportsTable.ToList())
                    DB.OrderedTariffTable.Add(new OrderedTariffs(x.Id, StartMonthDate));
                foreach(var x in DB.TariffOneTransportTable.ToList())
                    DB.OrderedTariffTable.Add(new OrderedTariffs(x.Id, StartMonthDate));
                DB.SaveChanges();
            }
            
            SetWindow1Values();
            /*listBox1.DataSource = DB.TariffOneTransportTable.Local.ToBindingList();
            listBox2.DataSource = DB.TariffGroupsTable.Local.ToBindingList();
            listBox3.DataSource = DB.TariffManyTransportsTable.Local.ToBindingList();/**/
        }

        static string GetConfigurationBuilder()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder() { };
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            return builder.Build().GetConnectionString("DefaultConnection");
        }
        public static ApplicationDBContext DB = new ApplicationDBContext(new DbContextOptionsBuilder<ApplicationDBContext>().UseSqlServer(GetConfigurationBuilder()).Options);

        //
        // Window 1
        //
                
        private void SetWindow1Values()
        {
            InitializeCustom();
            this.panelGraphHolder.Controls.Add(myChart);
            textBoxStartMenu.PlaceholderText = "Наприклад \"123456789012\"";
            this.FormClosed += (_, _) => DB.Dispose();
            myChart.ChartAreas.Add(chartArea);
        }
        private void buttonStartMenuContinue_Click(object sender, EventArgs e)
        {
            long ticketCode = 0;
            if(textBoxStartMenu.Text == ConstValues.PASSWORD_FOR_ADMINISTRATOR)
            {
                OpenAdministrativeWindow();
            }
            long.TryParse(textBoxStartMenu.Text, out ticketCode);
            Ticket ticket = DB.TicketTable.Where(x => x.TicketBarcode == ticketCode)
                                          .Include(x => x.Account)
                                          .Include(x => x.Tariff)
                                          .SingleOrDefault();
            textBoxStartMenu.ResetText();
            if (ticket != null)
            {
                panelWindow1.Visible = false;
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
            if (tariffOneTransportUses == 0)
                return;
            tariff = new Tariff(tariffOneTransportUses, this.ticket);
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

        private void ButtonManyTransortTariffClick(int QuantityOfUses, DateTime StartDate)
        {
            tariff = new Tariff(DB.TariffManyTransportsTable.Where(x => x.TariffGroup.GroupCategory == this.ticket.Account.FacilityCategory
                                                                && x.TariffGroup.StartDate == StartDate 
                                                                && x.QuantityOfUsages == QuantityOfUses)
                                                            .FirstOrDefault(), this.ticket);
            panelWindow2.Visible = false;
            PanelWindowOrderPrepareOpen();
        }
        private void buttonManyTransportTariff1_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(46          , StartSecondHalfMonthDate);
        private void buttonManyTransportTariff2_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(62          , StartSecondHalfMonthDate);
        private void buttonManyTransportTariff3_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(92          , StartSecondHalfMonthDate);
        private void buttonManyTransportTariff4_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(124         , StartSecondHalfMonthDate);
        private void buttonManyTransportTariff5_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(int.MaxValue, StartSecondHalfMonthDate);
        private void buttonManyTransportTariff6_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(46          , StartMonthDate);
        private void buttonManyTransportTariff7_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(62          , StartMonthDate);
        private void buttonManyTransportTariff8_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(92          , StartMonthDate);
        private void buttonManyTransportTariff9_Click (object sender, EventArgs e) => ButtonManyTransortTariffClick(124         , StartMonthDate);
        private void buttonManyTransportTariff10_Click(object sender, EventArgs e) => ButtonManyTransortTariffClick(int.MaxValue, StartMonthDate);

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

            decimal totalPrice = tariff.CalculatePrice(false);

            labelMonthsOrderedHeader.Text = "";
            labelMonthsOrdered.Text = "";
            if (tariff.TariffType is TariffManyTransports)
            {
                int MonthsStreak = tariff.CalculateMonthsStreak();
                decimal MonthsStreakDecrease = tariff.CalculateMonthsStreakDecrease();
                labelMonthsOrderedHeader.Text = $"Знижка за {MonthsStreak} щомісячних замовлених тарифів: ";
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
            decimal totalPrice = tariff.CalculatePrice(false);
            labelTotalPrice.Text = $"{totalPrice:C2}";
        }

        private void buttonIsByCard_Click(object sender, EventArgs e)
        {
            panelIsByCash.BackColor = Color.Sienna;
            panelIsByCard.BackColor = Color.Yellow;
            labelIsByCard.Visible = true;
            labelIsByCardHeader.Visible = true;
            decimal totalPrice = tariff.CalculatePrice(true);
            labelTotalPrice.Text = $"{totalPrice:C2}";
        }

        private void buttonWindowOrderPrepareCancel_Click(object sender, EventArgs e)
        {
            panelWindowOrderPrepare.Visible = false;
            panelWindow2.Visible = true;
            buttonIsByCash_Click(null, null);
        }

        private void buttonPayOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тариф замовлено");
            tariff.SetTariffToTicket(labelIsByCard.Visible);
            var Order =  DB.OrderedTariffTable.Where(x => x.Tariff.Id == tariff.TariffType.Id && x.DateOfOrder == StartMonthDate).Single();
            Order.QuantityOfTariffs++;
            Order.QuantityOfUses += tariff.QuantityOfUses;
            DB.SaveChanges();
            buttonWindowOrderPrepareCancel_Click(sender, e);
            buttonWindow2Exit_Click(sender, e);
        }

        //
        // Window Administrative
        //

        private bool IsHalfMonth;
        private bool IsQuantityOfUses;
        private DateTime SelectedMonth;
        private enum CurrentDiagram
        {
            OneTrans,
            ManyTrans,
            AllTrans
        }
        private CurrentDiagram currentDiagram;

        private void ManyTransportGraphFill()
        {
            Random rand = new Random();
            Func<int, long> TariffSumCalculate = (Uses)
                => DB.OrderedTariffTable.Where(x => x.Tariff is TariffManyTransports
                                           && (x.Tariff as TariffManyTransports).TariffGroup.StartDate == (IsHalfMonth ? StartSecondHalfMonthDate : StartMonthDate)
                                           && (x.Tariff as TariffManyTransports).QuantityOfUsages == Uses
                                           &&  x.DateOfOrder == SelectedMonth)
                                        .Sum(x => (IsQuantityOfUses) ? x.QuantityOfUses : x.QuantityOfTariffs);

            seriesOfColumns.Points.Clear();
            seriesOfColumns.Points.AddXY($"46 поїздок на {(IsHalfMonth ? "півмісяця" : "місяць")}", TariffSumCalculate(46));
            seriesOfColumns.Points.AddXY($"62 поїздки на {(IsHalfMonth ? "півмісяця" : "місяць")}", TariffSumCalculate(62));
            seriesOfColumns.Points.AddXY($"92 поїздки на {(IsHalfMonth ? "півмісяця" : "місяць")}", TariffSumCalculate(92));
            seriesOfColumns.Points.AddXY($"124 поїздки на {(IsHalfMonth ? "півмісяця" : "місяць")}", TariffSumCalculate(124));
            seriesOfColumns.Points.AddXY($"Безліміт на {(IsHalfMonth ? "півмісяця" : "місяць")}", TariffSumCalculate(int.MaxValue));

            seriesOfColumns.Points.ToList().ForEach(x => x.Color = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }
        private void OneTransportGraphFill()
        {
            Random rand = new Random();
            Func<int, long> TariffSumCalculate = (Uses)
                => DB.OrderedTariffTable.Where(x => x.Tariff is TariffOneTransport
                                           && (x.Tariff as TariffOneTransport).MinUsagesQuantityForCoefficient == Uses
                                           &&  x.DateOfOrder == SelectedMonth)
                                        .Sum(x => IsQuantityOfUses ? x.QuantityOfUses : x.QuantityOfTariffs);

            seriesOfColumns.Points.Clear();
            seriesOfColumns.Points.AddXY($"1-9 поїздок", TariffSumCalculate(1));
            seriesOfColumns.Points.AddXY($"10-19 поїздок", TariffSumCalculate(10));
            seriesOfColumns.Points.AddXY($"20-29 поїздок", TariffSumCalculate(20));
            seriesOfColumns.Points.AddXY($"30-39 поїздок", TariffSumCalculate(30));
            seriesOfColumns.Points.AddXY($"40-49 поїздок", TariffSumCalculate(40));
            seriesOfColumns.Points.AddXY($"50+ поїздок", TariffSumCalculate(50));

            seriesOfColumns.Points.ToList().ForEach(x => x.Color = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
        }
        private void AllTransportGraphFill()
        {
            Random rand = new Random();

            seriesOfDoughnut.Points.Clear();
            seriesOfDoughnut.Points.AddXY("Тарифи на міську електричку", 
                                          DB.OrderedTariffTable.Where(x => x.Tariff is TariffOneTransport)
                                                               .Sum(x => IsQuantityOfUses ? x.QuantityOfUses : x.QuantityOfTariffs));
            seriesOfDoughnut.Points.AddXY("Місячні тарифи на громадський транспорт", 
                                          DB.OrderedTariffTable.Where(x => x.Tariff is TariffManyTransports
                                                                       && (x.Tariff as TariffManyTransports).TariffGroup.StartDate == StartMonthDate)
                                                               .Sum(x => IsQuantityOfUses ? x.QuantityOfUses : x.QuantityOfTariffs));
            seriesOfDoughnut.Points.AddXY("Півмісячні тарифи на громадський транспорт", 
                                          DB.OrderedTariffTable.Where(x => x.Tariff is TariffManyTransports
                                                                  && (x.Tariff as TariffManyTransports).TariffGroup.StartDate == StartSecondHalfMonthDate)
                                                               .Sum(x => IsQuantityOfUses ? x.QuantityOfUses : x.QuantityOfTariffs));
        }
        private void OpenAdministrativeWindow()
        {
            comboBoxDatePicker.Items.Clear();
            comboBoxDatePicker.Items.AddRange(DB.OrderedTariffTable.OrderBy(x => x.DateOfOrder).Select(x => $"{x.DateOfOrder:MM/yyyy}").ToArray().Distinct().ToArray());
            IsHalfMonth = false;
            IsQuantityOfUses = false;
            SelectedMonth = StartMonthDate;
            panelWindowAdministrativeMain.Visible = true;
            panelWindow1.Visible = false;
        }
        

        private void ButtonColorChange(Color GeneralButton, Color ManyTransButton, Color OneTransButton, Color AllButton)
        {
            buttonAdministrativeGeneral.BackColor = GeneralButton;
            buttonAdminitrativeManyTrans.BackColor = ManyTransButton;
            buttonAdministrativeOneTrans.BackColor = OneTransButton;
            buttonAdministrativeAll.BackColor = AllButton;
        }
        private void buttonAdministrativeGeneral_Click(object sender, EventArgs e)
        {
            panelAdministrativeTariffSetup.Visible = false;
            panelAdministrativeGeneral.Visible = true;
            ButtonColorChange(Color.Yellow, Color.DimGray, Color.DimGray, Color.DimGray);
        }
        private void buttonAdminitrativeManyTrans_Click(object sender, EventArgs e)
        {
            panelAdministrativeTariffSetup.Visible = true;
            panelAdministrativeGeneral.Visible = false;
            currentDiagram = CurrentDiagram.ManyTrans;
            myChart.Series.Clear();
            myChart.Series.Add(seriesOfColumns);
            comboBoxDatePicker.SelectedIndex = comboBoxDatePicker.FindStringExact($"{StartMonthDate:MM/yyyy}");
            comboBoxStartPicker.SelectedIndex = comboBoxStartPicker.FindStringExact("На місяць");
            comboBoxValuePicker.SelectedIndex = comboBoxValuePicker.FindStringExact("Замовлені тарифи");
            comboBoxStartPicker.Enabled = true;
            chartArea.BackColor = Color.PowderBlue;
            ManyTransportGraphFill();
            ButtonColorChange(Color.DimGray, Color.Lime, Color.DimGray, Color.DimGray);
        }
        private void buttonAdministrativeOneTrans_Click(object sender, EventArgs e)
        {
            panelAdministrativeTariffSetup.Visible = true;
            panelAdministrativeGeneral.Visible = false;
            currentDiagram = CurrentDiagram.OneTrans;
            myChart.Series.Clear();
            myChart.Series.Add(seriesOfColumns);
            comboBoxDatePicker.SelectedIndex = comboBoxDatePicker.FindStringExact($"{StartMonthDate:MM/yyyy}");
            comboBoxValuePicker.SelectedIndex = comboBoxValuePicker.FindStringExact("Замовлені тарифи");
            comboBoxStartPicker.Enabled = false;
            chartArea.BackColor = Color.PowderBlue;
            OneTransportGraphFill();
            ButtonColorChange(Color.DimGray, Color.DimGray, Color.Red, Color.DimGray);
        }
        private void buttonAdministrativeAll_Click(object sender, EventArgs e)
        {
            panelAdministrativeTariffSetup.Visible = true;
            panelAdministrativeGeneral.Visible = false;
            comboBoxDatePicker.SelectedIndex = comboBoxDatePicker.FindStringExact($"{StartMonthDate:MM/yyyy}");
            comboBoxStartPicker.Enabled = false;
            comboBoxValuePicker.SelectedIndex = comboBoxValuePicker.FindStringExact("Замовлені тарифи");
            currentDiagram = CurrentDiagram.AllTrans;
            myChart.Series.Clear();
            myChart.Series.Add(seriesOfDoughnut);
            chartArea.BackColor = Color.LightSeaGreen;
            AllTransportGraphFill();
            ButtonColorChange(Color.DimGray, Color.DimGray, Color.DimGray, Color.FromArgb(255, 128, 0));
        }


        private void button7_Click(object sender, EventArgs e)
        {
            buttonAdministrativeGeneral_Click(sender, e);
            panelWindowAdministrativeMain.Visible = false;
            panelWindow1.Visible = true;
        }


        private void GraphFill()
        {
            switch (currentDiagram)
            {
                case CurrentDiagram.AllTrans: AllTransportGraphFill(); break;
                case CurrentDiagram.ManyTrans: ManyTransportGraphFill(); break;
                case CurrentDiagram.OneTrans: OneTransportGraphFill();break;
            }
        }
        private void comboBoxDatePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] date = (sender as ComboBox).SelectedItem.ToString().Split('.');
            SelectedMonth = new DateTime(Convert.ToInt32(date[1]), Convert.ToInt32(date[0]), 1);
            GraphFill();
        }

        private void comboBoxStartPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedItem)
            {
                case "На місяць": IsHalfMonth = false; break;
                case "На півмісяця": IsHalfMonth = true; break;
            }
            GraphFill();
        }

        private void comboBoxValuePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedItem)
            {
                case "Замовлені тарифи": IsQuantityOfUses = false; break;
                case "Замовлені поїздки": IsQuantityOfUses = true; break;
            }
            GraphFill();
        }
    }
}