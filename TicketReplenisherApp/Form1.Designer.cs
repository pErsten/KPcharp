
namespace TicketReplenisherApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelStartMenu = new System.Windows.Forms.Panel();
            this.buttonStartMenuContinue = new System.Windows.Forms.Button();
            this.textBoxStartMenu = new System.Windows.Forms.TextBox();
            this.labelStartMenu = new System.Windows.Forms.Label();
            this.panelWindow1 = new System.Windows.Forms.Panel();
            this.panelWindow2 = new System.Windows.Forms.Panel();
            this.panelWindow2_3Central = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxTariffsManyTransports = new System.Windows.Forms.ListBox();
            this.buttonWindow2_3Back = new System.Windows.Forms.Button();
            this.listBoxTariffsSingleTransport = new System.Windows.Forms.ListBox();
            this.panelWindow2Central = new System.Windows.Forms.Panel();
            this.tableLayoutPanelWindow2Central = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelWindow2Upper = new System.Windows.Forms.Panel();
            this.tableLayoutPanelWindow2Up = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelWindow2UpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelWindow2UpName = new System.Windows.Forms.Label();
            this.labelWindow2UpNameHeader = new System.Windows.Forms.Label();
            this.labelWindow2UpTariff = new System.Windows.Forms.Label();
            this.labelWindow2UpTariffHeader = new System.Windows.Forms.Label();
            this.buttonWindow2Exit = new System.Windows.Forms.Button();
            this.panelUserImage = new System.Windows.Forms.Panel();
            this.panelStartMenu.SuspendLayout();
            this.panelWindow1.SuspendLayout();
            this.panelWindow2.SuspendLayout();
            this.panelWindow2_3Central.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelWindow2Central.SuspendLayout();
            this.tableLayoutPanelWindow2Central.SuspendLayout();
            this.panelWindow2Upper.SuspendLayout();
            this.tableLayoutPanelWindow2Up.SuspendLayout();
            this.tableLayoutPanelWindow2UpLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStartMenu
            // 
            this.panelStartMenu.BackColor = System.Drawing.Color.DarkGray;
            this.panelStartMenu.Controls.Add(this.buttonStartMenuContinue);
            this.panelStartMenu.Controls.Add(this.textBoxStartMenu);
            this.panelStartMenu.Controls.Add(this.labelStartMenu);
            this.panelStartMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStartMenu.Location = new System.Drawing.Point(200, 120);
            this.panelStartMenu.Name = "panelStartMenu";
            this.panelStartMenu.Padding = new System.Windows.Forms.Padding(80, 110, 80, 110);
            this.panelStartMenu.Size = new System.Drawing.Size(625, 383);
            this.panelStartMenu.TabIndex = 0;
            // 
            // buttonStartMenuContinue
            // 
            this.buttonStartMenuContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStartMenuContinue.BackColor = System.Drawing.Color.Brown;
            this.buttonStartMenuContinue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStartMenuContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartMenuContinue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartMenuContinue.Location = new System.Drawing.Point(80, 227);
            this.buttonStartMenuContinue.Name = "buttonStartMenuContinue";
            this.buttonStartMenuContinue.Size = new System.Drawing.Size(465, 46);
            this.buttonStartMenuContinue.TabIndex = 1;
            this.buttonStartMenuContinue.Text = "Продовжити";
            this.buttonStartMenuContinue.UseVisualStyleBackColor = false;
            this.buttonStartMenuContinue.Click += new System.EventHandler(this.buttonStartMenuContinue_Click);
            // 
            // textBoxStartMenu
            // 
            this.textBoxStartMenu.BackColor = System.Drawing.Color.Linen;
            this.textBoxStartMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStartMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStartMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStartMenu.Location = new System.Drawing.Point(80, 163);
            this.textBoxStartMenu.Name = "textBoxStartMenu";
            this.textBoxStartMenu.Size = new System.Drawing.Size(465, 38);
            this.textBoxStartMenu.TabIndex = 2;
            // 
            // labelStartMenu
            // 
            this.labelStartMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStartMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStartMenu.Location = new System.Drawing.Point(80, 110);
            this.labelStartMenu.Margin = new System.Windows.Forms.Padding(30);
            this.labelStartMenu.Name = "labelStartMenu";
            this.labelStartMenu.Size = new System.Drawing.Size(465, 53);
            this.labelStartMenu.TabIndex = 0;
            this.labelStartMenu.Text = "Введіть код вашого е-квитка:";
            this.labelStartMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWindow1
            // 
            this.panelWindow1.BackColor = System.Drawing.Color.DimGray;
            this.panelWindow1.Controls.Add(this.panelStartMenu);
            this.panelWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow1.Location = new System.Drawing.Point(0, 0);
            this.panelWindow1.Name = "panelWindow1";
            this.panelWindow1.Padding = new System.Windows.Forms.Padding(200, 120, 200, 120);
            this.panelWindow1.Size = new System.Drawing.Size(1025, 599);
            this.panelWindow1.TabIndex = 1;
            // 
            // panelWindow2
            // 
            this.panelWindow2.BackColor = System.Drawing.Color.White;
            this.panelWindow2.Controls.Add(this.panelWindow2_3Central);
            this.panelWindow2.Controls.Add(this.panelWindow2Central);
            this.panelWindow2.Controls.Add(this.panelWindow2Upper);
            this.panelWindow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow2.Location = new System.Drawing.Point(0, 0);
            this.panelWindow2.Name = "panelWindow2";
            this.panelWindow2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelWindow2.Size = new System.Drawing.Size(1025, 599);
            this.panelWindow2.TabIndex = 0;
            this.panelWindow2.Visible = false;
            // 
            // panelWindow2_3Central
            // 
            this.panelWindow2_3Central.BackColor = System.Drawing.Color.Silver;
            this.panelWindow2_3Central.Controls.Add(this.tableLayoutPanel1);
            this.panelWindow2_3Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow2_3Central.Location = new System.Drawing.Point(0, 70);
            this.panelWindow2_3Central.Name = "panelWindow2_3Central";
            this.panelWindow2_3Central.Padding = new System.Windows.Forms.Padding(50, 5, 50, 50);
            this.panelWindow2_3Central.Size = new System.Drawing.Size(1025, 509);
            this.panelWindow2_3Central.TabIndex = 2;
            this.panelWindow2_3Central.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxTariffsManyTransports, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonWindow2_3Back, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxTariffsSingleTransport, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 454);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listBoxTariffsManyTransports
            // 
            this.listBoxTariffsManyTransports.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxTariffsManyTransports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTariffsManyTransports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTariffsManyTransports.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTariffsManyTransports.FormattingEnabled = true;
            this.listBoxTariffsManyTransports.ItemHeight = 18;
            this.listBoxTariffsManyTransports.Location = new System.Drawing.Point(30, 80);
            this.listBoxTariffsManyTransports.Margin = new System.Windows.Forms.Padding(30);
            this.listBoxTariffsManyTransports.Name = "listBoxTariffsManyTransports";
            this.listBoxTariffsManyTransports.Size = new System.Drawing.Size(402, 344);
            this.listBoxTariffsManyTransports.TabIndex = 0;
            // 
            // buttonWindow2_3Back
            // 
            this.buttonWindow2_3Back.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonWindow2_3Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonWindow2_3Back.FlatAppearance.BorderSize = 0;
            this.buttonWindow2_3Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonWindow2_3Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonWindow2_3Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWindow2_3Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWindow2_3Back.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonWindow2_3Back.Location = new System.Drawing.Point(3, 3);
            this.buttonWindow2_3Back.Name = "buttonWindow2_3Back";
            this.buttonWindow2_3Back.Size = new System.Drawing.Size(94, 44);
            this.buttonWindow2_3Back.TabIndex = 1;
            this.buttonWindow2_3Back.Text = "Назад";
            this.buttonWindow2_3Back.UseVisualStyleBackColor = false;
            this.buttonWindow2_3Back.Click += new System.EventHandler(this.buttonWindow2_3Back_Click);
            // 
            // listBoxTariffsSingleTransport
            // 
            this.listBoxTariffsSingleTransport.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxTariffsSingleTransport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTariffsSingleTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTariffsSingleTransport.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTariffsSingleTransport.FormattingEnabled = true;
            this.listBoxTariffsSingleTransport.ItemHeight = 18;
            this.listBoxTariffsSingleTransport.Location = new System.Drawing.Point(492, 80);
            this.listBoxTariffsSingleTransport.Margin = new System.Windows.Forms.Padding(30);
            this.listBoxTariffsSingleTransport.Name = "listBoxTariffsSingleTransport";
            this.listBoxTariffsSingleTransport.Size = new System.Drawing.Size(403, 344);
            this.listBoxTariffsSingleTransport.TabIndex = 0;
            // 
            // panelWindow2Central
            // 
            this.panelWindow2Central.BackColor = System.Drawing.Color.Silver;
            this.panelWindow2Central.Controls.Add(this.tableLayoutPanelWindow2Central);
            this.panelWindow2Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow2Central.Location = new System.Drawing.Point(0, 70);
            this.panelWindow2Central.Name = "panelWindow2Central";
            this.panelWindow2Central.Padding = new System.Windows.Forms.Padding(50);
            this.panelWindow2Central.Size = new System.Drawing.Size(1025, 509);
            this.panelWindow2Central.TabIndex = 2;
            // 
            // tableLayoutPanelWindow2Central
            // 
            this.tableLayoutPanelWindow2Central.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelWindow2Central.ColumnCount = 3;
            this.tableLayoutPanelWindow2Central.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelWindow2Central.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelWindow2Central.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelWindow2Central.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelWindow2Central.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanelWindow2Central.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanelWindow2Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWindow2Central.Location = new System.Drawing.Point(50, 50);
            this.tableLayoutPanelWindow2Central.Name = "tableLayoutPanelWindow2Central";
            this.tableLayoutPanelWindow2Central.RowCount = 2;
            this.tableLayoutPanelWindow2Central.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelWindow2Central.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelWindow2Central.Size = new System.Drawing.Size(925, 409);
            this.tableLayoutPanelWindow2Central.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(15);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15);
            this.button1.Size = new System.Drawing.Size(278, 297);
            this.button1.TabIndex = 0;
            this.button1.Text = "Замовити тариф тільки для міської електрички";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(631, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(15);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(15);
            this.button3.Size = new System.Drawing.Size(279, 297);
            this.button3.TabIndex = 0;
            this.button3.Text = "Побачити ціни на усі тарифи";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(323, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(15);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15);
            this.button2.Size = new System.Drawing.Size(278, 297);
            this.button2.TabIndex = 0;
            this.button2.Text = "Замовити тариф для міського громадського транспорту";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelWindow2Upper
            // 
            this.panelWindow2Upper.BackColor = System.Drawing.Color.Firebrick;
            this.panelWindow2Upper.Controls.Add(this.tableLayoutPanelWindow2Up);
            this.panelWindow2Upper.Controls.Add(this.panelUserImage);
            this.panelWindow2Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindow2Upper.Location = new System.Drawing.Point(0, 0);
            this.panelWindow2Upper.Name = "panelWindow2Upper";
            this.panelWindow2Upper.Size = new System.Drawing.Size(1025, 70);
            this.panelWindow2Upper.TabIndex = 0;
            // 
            // tableLayoutPanelWindow2Up
            // 
            this.tableLayoutPanelWindow2Up.ColumnCount = 2;
            this.tableLayoutPanelWindow2Up.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWindow2Up.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelWindow2Up.Controls.Add(this.tableLayoutPanelWindow2UpLeft, 0, 0);
            this.tableLayoutPanelWindow2Up.Controls.Add(this.buttonWindow2Exit, 1, 0);
            this.tableLayoutPanelWindow2Up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWindow2Up.Location = new System.Drawing.Point(70, 0);
            this.tableLayoutPanelWindow2Up.Name = "tableLayoutPanelWindow2Up";
            this.tableLayoutPanelWindow2Up.RowCount = 1;
            this.tableLayoutPanelWindow2Up.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWindow2Up.Size = new System.Drawing.Size(955, 70);
            this.tableLayoutPanelWindow2Up.TabIndex = 1;
            // 
            // tableLayoutPanelWindow2UpLeft
            // 
            this.tableLayoutPanelWindow2UpLeft.ColumnCount = 2;
            this.tableLayoutPanelWindow2UpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWindow2UpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWindow2UpLeft.Controls.Add(this.labelWindow2UpName, 0, 1);
            this.tableLayoutPanelWindow2UpLeft.Controls.Add(this.labelWindow2UpNameHeader, 0, 0);
            this.tableLayoutPanelWindow2UpLeft.Controls.Add(this.labelWindow2UpTariff, 1, 1);
            this.tableLayoutPanelWindow2UpLeft.Controls.Add(this.labelWindow2UpTariffHeader, 1, 0);
            this.tableLayoutPanelWindow2UpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWindow2UpLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelWindow2UpLeft.Name = "tableLayoutPanelWindow2UpLeft";
            this.tableLayoutPanelWindow2UpLeft.RowCount = 2;
            this.tableLayoutPanelWindow2UpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWindow2UpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWindow2UpLeft.Size = new System.Drawing.Size(769, 64);
            this.tableLayoutPanelWindow2UpLeft.TabIndex = 3;
            // 
            // labelWindow2UpName
            // 
            this.labelWindow2UpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindow2UpName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWindow2UpName.Location = new System.Drawing.Point(3, 32);
            this.labelWindow2UpName.Name = "labelWindow2UpName";
            this.labelWindow2UpName.Size = new System.Drawing.Size(378, 32);
            this.labelWindow2UpName.TabIndex = 1;
            this.labelWindow2UpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWindow2UpNameHeader
            // 
            this.labelWindow2UpNameHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWindow2UpNameHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWindow2UpNameHeader.Location = new System.Drawing.Point(3, 0);
            this.labelWindow2UpNameHeader.Name = "labelWindow2UpNameHeader";
            this.labelWindow2UpNameHeader.Size = new System.Drawing.Size(378, 30);
            this.labelWindow2UpNameHeader.TabIndex = 3;
            this.labelWindow2UpNameHeader.Text = "Власник е-квитка:";
            this.labelWindow2UpNameHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWindow2UpTariff
            // 
            this.labelWindow2UpTariff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindow2UpTariff.Enabled = false;
            this.labelWindow2UpTariff.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWindow2UpTariff.Location = new System.Drawing.Point(387, 32);
            this.labelWindow2UpTariff.Name = "labelWindow2UpTariff";
            this.labelWindow2UpTariff.Size = new System.Drawing.Size(379, 32);
            this.labelWindow2UpTariff.TabIndex = 2;
            this.labelWindow2UpTariff.Text = "Немає";
            this.labelWindow2UpTariff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWindow2UpTariffHeader
            // 
            this.labelWindow2UpTariffHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindow2UpTariffHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWindow2UpTariffHeader.Location = new System.Drawing.Point(387, 0);
            this.labelWindow2UpTariffHeader.Name = "labelWindow2UpTariffHeader";
            this.labelWindow2UpTariffHeader.Size = new System.Drawing.Size(379, 32);
            this.labelWindow2UpTariffHeader.TabIndex = 2;
            this.labelWindow2UpTariffHeader.Text = "Замовлений тариф";
            this.labelWindow2UpTariffHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonWindow2Exit
            // 
            this.buttonWindow2Exit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonWindow2Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWindow2Exit.FlatAppearance.BorderSize = 0;
            this.buttonWindow2Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonWindow2Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonWindow2Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWindow2Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWindow2Exit.Location = new System.Drawing.Point(785, 10);
            this.buttonWindow2Exit.Margin = new System.Windows.Forms.Padding(10);
            this.buttonWindow2Exit.Name = "buttonWindow2Exit";
            this.buttonWindow2Exit.Size = new System.Drawing.Size(160, 50);
            this.buttonWindow2Exit.TabIndex = 4;
            this.buttonWindow2Exit.Text = "Вихід";
            this.buttonWindow2Exit.UseVisualStyleBackColor = false;
            this.buttonWindow2Exit.Click += new System.EventHandler(this.buttonWindow2Exit_Click);
            // 
            // panelUserImage
            // 
            this.panelUserImage.BackColor = System.Drawing.Color.Brown;
            this.panelUserImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUserImage.BackgroundImage")));
            this.panelUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUserImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUserImage.Location = new System.Drawing.Point(0, 0);
            this.panelUserImage.Name = "panelUserImage";
            this.panelUserImage.Size = new System.Drawing.Size(70, 70);
            this.panelUserImage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 599);
            this.Controls.Add(this.panelWindow2);
            this.Controls.Add(this.panelWindow1);
            this.MinimumSize = new System.Drawing.Size(900, 646);
            this.Name = "Form1";
            this.Text = "Тарифопоповнювач 3000";
            this.panelStartMenu.ResumeLayout(false);
            this.panelStartMenu.PerformLayout();
            this.panelWindow1.ResumeLayout(false);
            this.panelWindow2.ResumeLayout(false);
            this.panelWindow2_3Central.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelWindow2Central.ResumeLayout(false);
            this.tableLayoutPanelWindow2Central.ResumeLayout(false);
            this.panelWindow2Upper.ResumeLayout(false);
            this.tableLayoutPanelWindow2Up.ResumeLayout(false);
            this.tableLayoutPanelWindow2UpLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.DataVisualization.Charting.Chart myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
        private System.Windows.Forms.Panel panelStartMenu;
        private System.Windows.Forms.TextBox textBoxStartMenu;
        private System.Windows.Forms.Label labelStartMenu;
        private System.Windows.Forms.Button buttonStartMenuContinue;
        private System.Windows.Forms.Panel panelWindow1;
        private System.Windows.Forms.Panel panelWindow2;
        private System.Windows.Forms.Panel panelWindow2Upper;
        private System.Windows.Forms.Panel panelUserImage;
        private System.Windows.Forms.Label labelWindow2UpName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindow2Central;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindow2Up;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWindow2UpLeft;
        private System.Windows.Forms.Label labelWindow2UpNameHeader;
        private System.Windows.Forms.Label labelWindow2UpTariff;
        private System.Windows.Forms.Label labelWindow2UpTariffHeader;
        private System.Windows.Forms.Button buttonWindow2Exit;
        private System.Windows.Forms.Panel panelWindow2_3Central;
        private System.Windows.Forms.Panel panelWindow2Central;
        private System.Windows.Forms.ListBox listBoxTariffsManyTransports;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonWindow2_3Back;
        private System.Windows.Forms.ListBox listBoxTariffsSingleTransport;
    }
}

