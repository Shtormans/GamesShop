using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home.Settings;

internal class ReportView : BaseMinimizeView
{
    private class ReportRow : Panel
    {
        private Label _title;
        private Label _price;
        private Label _amount;
        private Label _cost;

        private Size _panelSize;

        public required string Title
        {
            init
            {
                _title = new Label();
                _title.Text = value;
            }
        }

        public required string Price
        {
            init
            {
                _price = new Label();
                _price.Text = value;
            }
        }

        public required string Amount
        {
            init
            {
                _amount = new Label();
                _amount.Text = value;
            }
        }

        public required string Cost
        {
            init
            {
                _cost = new Label();
                _cost.Text = value;
            }
        }

        public required Size PanelSize
        {
            init
            {
                _panelSize = value;
            }
        }

        public ReportRow InitializeComponent()
        {
            _title.AutoSize = true;
            _title.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(228)))));
            _title.Location = new System.Drawing.Point(20, 16);
            _title.TabIndex = 1;

            _price.AutoSize = true;
            _price.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            _price.Location = new System.Drawing.Point(150, 16);
            _price.TabIndex = 2;

            _amount.AutoSize = true;
            _amount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            _amount.Location = new System.Drawing.Point(280, 16);
            _amount.TabIndex = 2;

            _cost.AutoSize = true;
            _cost.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            _cost.Location = new System.Drawing.Point(420, 16);
            _cost.TabIndex = 2;

            this.Controls.Add(this._title);
            this.Controls.Add(this._price);
            this.Controls.Add(this._amount);
            this.Controls.Add(this._cost);
            this.Size = _panelSize;

            return this;
        }
    }

    private Panel _searchPanel;
    private Button _showReportButton;
    private Label _label1;
    private Label _label2;
    private DateTimePicker _fromDate;
    private DateTimePicker _toDate;
    private TableLayoutPanel _resultTable;

    public ReportView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        _fromDate = new DateTimePicker();
        _toDate = new DateTimePicker();
        _showReportButton = new Button();
        _searchPanel = new Panel();
        _label1 = new Label();
        _label2 = new Label();
        _resultTable = new TableLayoutPanel();
        // 
        // _showReportButton
        // 
        this._showReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._showReportButton.FlatAppearance.BorderSize = 0;
        this._showReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._showReportButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._showReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._showReportButton.Location = new System.Drawing.Point(360, 5);
        this._showReportButton.Name = "button1";
        this._showReportButton.Size = new System.Drawing.Size(180, 30);
        this._showReportButton.TabIndex = 2;
        this._showReportButton.Text = CurrentSessionController.Session.Language.GetString("ShowReport")!;
        this._showReportButton.UseVisualStyleBackColor = false;
        this._showReportButton.Click += _showReportButton_Click;
        // 
        // _searchPanel
        // 
        this._searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this._searchPanel.Controls.Add(this._label1);
        this._searchPanel.Controls.Add(this._label2);
        this._searchPanel.Controls.Add(this._fromDate);
        this._searchPanel.Controls.Add(this._toDate);
        this._searchPanel.Controls.Add(this._showReportButton);
        this._searchPanel.Location = new System.Drawing.Point(170, 22);
        this._searchPanel.Name = "_searchPanel";
        this._searchPanel.Size = new System.Drawing.Size(569, 40);
        this._searchPanel.TabIndex = 3;
        //
        // _fromDate
        //
        this._fromDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._fromDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._fromDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._fromDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this._fromDate.Location = new System.Drawing.Point(58, 8);
        this._fromDate.Name = "fromDate";
        this._fromDate.Size = new System.Drawing.Size(100, 20);
        this._fromDate.TabIndex = 13;
        this._fromDate.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
        //
        // _toDate
        //
        this._toDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._toDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._toDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._toDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this._toDate.Location = new System.Drawing.Point(230, 8);
        this._toDate.Name = "toDate";
        this._toDate.Size = new System.Drawing.Size(100, 17);
        this._toDate.TabIndex = 13;
        this._toDate.Value = DateTime.Now;
        // 
        // label1
        // 
        this._label1.AutoSize = true;
        this._label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
        this._label1.Location = new System.Drawing.Point(10, 10);
        this._label1.Name = "label1";
        this._label1.Size = new System.Drawing.Size(52, 17);
        this._label1.TabIndex = 3;
        this._label1.Text = CurrentSessionController.Session.Language.GetString("From")!;
        // 
        // label2
        // 
        this._label2.AutoSize = true;
        this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
        this._label2.Location = new System.Drawing.Point(200, 10);
        this._label2.Name = "label1";
        this._label2.Size = new System.Drawing.Size(52, 20);
        this._label2.TabIndex = 3;
        this._label2.Text = CurrentSessionController.Session.Language.GetString("To")!;
        // 
        // _resultTable
        // 
        this._resultTable.AutoSize = true;
        this._resultTable.ColumnCount = 1;
        this._resultTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
        this._resultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this._resultTable.Location = new System.Drawing.Point(170, 72);
        this._resultTable.Name = "tableLayoutPanel1";
        this._resultTable.RowCount = 0;
        this._resultTable.TabIndex = 0;
        this._resultTable.MaximumSize = new Size(1000, 500);
        this._resultTable.HorizontalScroll.Maximum = 0;
        this._resultTable.AutoScroll = false;
        this._resultTable.VerticalScroll.Visible = false;
        this._resultTable.AutoScroll = true;
        this._resultTable.Visible = false;

        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
        this.PerformLayout();
        this.Controls.Add(this._searchPanel);
        this.Controls.Add(this._resultTable);
        this._searchPanel.ResumeLayout(false);
        this._searchPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    private void _showReportButton_Click(object? sender, EventArgs e)
    {
        if (!_resultTable.Visible)
        {
            _resultTable.Visible = true;
        }

        FillDataGrid();
    }

    private async Task FillDataGrid()
    {
        _resultTable.Controls.Clear();

        List<Transaction> transactions = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(SettingsController), "GetBuyingStatisics", new object[] { _fromDate.Value, _toDate.Value })
                    as List<Transaction>)!;

        var purchases = transactions.GroupBy(t => t.Game);

        AddHeader();

        int amountSum = 0;
        decimal costSum = 0;
        foreach (var purchase in purchases)
        {
            string title = purchase.Key.Title.Value;
            Money price = purchase.Key.Price.ConvertTo(CurrentSessionController.Session.CurrencyType);
            int amount = purchase.Count();
            Money cost = new Money(nameof(CurrencyType.USD), purchase.Sum(p => p.Price.ConvertToUSD().Amount)).ConvertTo(CurrentSessionController.Session.CurrencyType);

            amountSum += amount;
            costSum += cost.Amount;

            _resultTable.RowCount++;

            RowStyle style = new RowStyle();
            style.SizeType = SizeType.AutoSize;

            _resultTable.RowStyles.Add(style);

            ReportRow row = new()
            {
                Title = title,
                Price = price.ToString(),
                Amount = amount.ToString(),
                Cost = cost.ToString(),
                PanelSize = new System.Drawing.Size(580, 58)
            };
            row.InitializeComponent();

            _resultTable.Controls.Add(row, _resultTable.RowCount - 1, 0);
        }

        Money costSumAsMoney = new(CurrentSessionController.Session.CurrencyType.ToString(), costSum);
        AddBottom(amountSum, costSumAsMoney);
    }

    private void AddBottom(int amount, Money cost)
    {
        _resultTable.RowCount++;

        RowStyle style = new RowStyle();
        style.SizeType = SizeType.AutoSize;

        _resultTable.RowStyles.Add(style);

        ReportRow row = new()
        {
            Title = string.Empty,
            Price = CurrentSessionController.Session.Language.GetString("Totally")!.ToUpper(),
            Amount = amount.ToString(),
            Cost = cost.ToString(),
            PanelSize = new System.Drawing.Size(580, 38)
        };
        row.InitializeComponent();

        _resultTable.Controls.Add(row, _resultTable.RowCount - 1, 0);
    }

    private void AddHeader()
    {
        _resultTable.RowCount++;

        RowStyle style = new RowStyle();
        style.SizeType = SizeType.AutoSize;

        _resultTable.RowStyles.Add(style);

        ReportRow row = new()
        {
            Title = CurrentSessionController.Session.Language.GetString("Title")!.ToUpper(),
            Price = CurrentSessionController.Session.Language.GetString("GamePrice")!.ToUpper(),
            Amount = CurrentSessionController.Session.Language.GetString("AmountOfSold")!.ToUpper(),
            Cost = CurrentSessionController.Session.Language.GetString("Cost")!.ToUpper(),
            PanelSize = new System.Drawing.Size(580, 38)
        };
        row.InitializeComponent();

        _resultTable.Controls.Add(row, _resultTable.RowCount - 1, 0);
    }
}
