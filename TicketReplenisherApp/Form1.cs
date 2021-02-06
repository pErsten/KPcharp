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
        static string getConfigurationBuilder()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder() { };
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            return builder.Build().GetConnectionString("DefaultConnection");
        }
        public static ApplicationDBContext DB = new ApplicationDBContext(new DbContextOptionsBuilder<ApplicationDBContext>().UseSqlServer(getConfigurationBuilder()).Options);
        public Form1()
        {
            //--------------
            ChartArea chartArea1 = new ChartArea() { Name = "ChartArea1" };
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
            myChart.Series.Add(mySeriesOfPoint);
            //--------------------
            InitializeComponent();
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
