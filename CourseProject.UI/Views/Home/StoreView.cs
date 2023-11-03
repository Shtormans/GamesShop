using CourseProject.Domain.Enums;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home;

internal class StoreView : BaseMinimizeView
{
    private class GameRow : Panel
    {
        private PictureBox _picture;
        private Label _title;
        private Label _creationDate;
        private Label _price;

        public Image Picture
        {
            init
            {
                _picture = new PictureBox();
                _picture.Image = value;
            }
        }

        public string Title
        {
            init
            {
                _title = new Label();
                _title.Text = value;
            }
        }

        public string CreationDate
        {
            init
            {
                _creationDate = new Label();
                _creationDate.Text = value;
            }
        }

        public string Price
        {
            init
            {
                _price = new Label();
                _price.Text = value;
            }
        }

        public GameRow InitializeComponent()
        {
            _picture.Location = new System.Drawing.Point(0, 0);
            _picture.Size = new System.Drawing.Size(125, 50);
            _picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _picture.TabIndex = 0;
            _picture.TabStop = false;

            _title.AutoSize = true;
            _title.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(228)))));
            _title.Location = new System.Drawing.Point(135, 22);
            _title.TabIndex = 1;

            _creationDate.AutoSize = true;
            _creationDate.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _creationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            _creationDate.Location = new System.Drawing.Point(348, 22);
            _creationDate.TabIndex = 3;

            _price.AutoSize = true;
            _price.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(223)))));
            _price.Location = new System.Drawing.Point(480, 22);
            _price.TabIndex = 2;

            this.Controls.Add(this._picture);
            this.Controls.Add(this._title);
            this.Controls.Add(this._creationDate);
            this.Controls.Add(this._price);
            this.Size = new System.Drawing.Size(580, 58);

            return this;
        }
    }

    private TextBox _searchTextBox;
    private Button _searchButton;
    private Panel _searchPanel;
    private ComboBox _searchModifierComboBox;
    private Label _label1;
    private TableLayoutPanel _gamesTable;

    public StoreView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        _searchTextBox = new TextBox();
        _searchButton = new Button();
        _searchPanel = new Panel();
        _searchModifierComboBox = new ComboBox();
        _label1 = new Label();
        _gamesTable = new TableLayoutPanel();

        // 
        // textBox1
        // 
        this._searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._searchTextBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._searchTextBox.ForeColor = System.Drawing.Color.White;
        this._searchTextBox.Location = new System.Drawing.Point(9, 7);
        this._searchTextBox.Name = "textBox1";
        this._searchTextBox.Size = new System.Drawing.Size(185, 25);
        this._searchTextBox.TabIndex = 1;
        // 
        // button1
        // 
        this._searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._searchButton.FlatAppearance.BorderSize = 0;
        this._searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._searchButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._searchButton.Location = new System.Drawing.Point(209, 7);
        this._searchButton.Name = "button1";
        this._searchButton.Size = new System.Drawing.Size(75, 25);
        this._searchButton.TabIndex = 2;
        this._searchButton.Text = "Search";
        this._searchButton.UseVisualStyleBackColor = false;
        this._searchButton.Click += _searchButton_Click;
        // 
        // _searchPanel
        // 
        this._searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this._searchPanel.Controls.Add(this._searchModifierComboBox);
        this._searchPanel.Controls.Add(this._label1);
        this._searchPanel.Controls.Add(this._searchTextBox);
        this._searchPanel.Controls.Add(this._searchButton);
        this._searchPanel.Location = new System.Drawing.Point(223, 22);
        this._searchPanel.Name = "_searchPanel";
        this._searchPanel.Size = new System.Drawing.Size(569, 40);
        this._searchPanel.TabIndex = 3;
        // 
        // label1
        // 
        this._label1.AutoSize = true;
        this._label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(108)))), ((int)(((byte)(126)))));
        this._label1.Location = new System.Drawing.Point(351, 10);
        this._label1.Name = "label1";
        this._label1.Size = new System.Drawing.Size(52, 20);
        this._label1.TabIndex = 3;
        this._label1.Text = "Sort by";
        // 
        // comboBox1
        // 
        this._searchModifierComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
        this._searchModifierComboBox.ForeColor = System.Drawing.Color.White;
        this._searchModifierComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._searchModifierComboBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._searchModifierComboBox.FormattingEnabled = true;
        this._searchModifierComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this._searchModifierComboBox.Location = new System.Drawing.Point(409, 6);
        this._searchModifierComboBox.Name = "comboBox1";
        this._searchModifierComboBox.Size = new System.Drawing.Size(144, 28);
        this._searchModifierComboBox.TabIndex = 4;
        this._searchModifierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        this._searchModifierComboBox.Items.AddRange(new object[]
        {
            nameof(SortGamesBy.Title),
            nameof(SortGamesBy.LowestPrice),
            nameof(SortGamesBy.HighestPrice),
            nameof(SortGamesBy.Date),
            nameof(SortGamesBy.DateDescending)
        });
        this._searchModifierComboBox.Text = this._searchModifierComboBox.Items[0].ToString();
        this._searchModifierComboBox.SelectedIndexChanged += _searchModifierComboBox_SelectedIndexChanged;
        // 
        // tableLayoutPanel1
        // 
        this._gamesTable.AutoSize = true;
        this._gamesTable.ColumnCount = 1;
        this._gamesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this._gamesTable.Location = new System.Drawing.Point(223, 68);
        this._gamesTable.Name = "tableLayoutPanel1";
        this._gamesTable.RowCount = 0;
        this._gamesTable.TabIndex = 0;
        this._gamesTable.AutoScroll = true;
        this._gamesTable.MaximumSize = new Size(0, 500);
        this._gamesTable.Scroll += _gamesTable_Scroll;

        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
        this.PerformLayout();
        this._searchPanel.Controls.Add(_searchTextBox);
        this._searchPanel.Controls.Add(_searchButton);
        this._searchPanel.Controls.Add(_searchModifierComboBox);
        this._searchPanel.Controls.Add(_label1);
        this.Controls.Add(_searchPanel);
        this.Controls.Add(_gamesTable);
        this._searchPanel.ResumeLayout(false);
        this._searchPanel.PerformLayout();
        this._gamesTable.ResumeLayout(false);
        this._gamesTable.PerformLayout();
        this.ResumeLayout(false);

        FillDataGrid();
    }

    private void _searchModifierComboBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        ClearDataGrid();
        FillDataGrid();
    }

    private void _gamesTable_Scroll(object? sender, ScrollEventArgs e)
    {
        VScrollProperties vs = _gamesTable.VerticalScroll;
        if (e.NewValue == vs.Maximum - vs.LargeChange + 1)
        {
            FillDataGrid();
        }
    }

    private async void _searchButton_Click(object? sender, EventArgs e)
    {
        ClearDataGrid();
        FillDataGrid();
    }

    private void ClearDataGrid()
    {
        _gamesTable.RowCount = 0;
        _gamesTable.RowStyles.Clear();
        _gamesTable.Controls.Clear();
    }

    private async Task FillDataGrid()
    {
        string title = _searchTextBox.Text;
        SortGamesBy sortBy = (SortGamesBy)Enum.Parse(typeof(SortGamesBy), _searchModifierComboBox.Text);
        int skip = _gamesTable.RowCount;
        List<GameModelWithImage> gamesWithIcons = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(StoreController), "GetNextGames", new object[] { title, sortBy, skip })
                    as List<GameModelWithImage>)!;

        for (int i = 0; i < gamesWithIcons.Count; i++)
        {
            var game = gamesWithIcons[i].Game;
            var gameIcon = gamesWithIcons[i].Icon;

            _gamesTable.RowCount++;

            RowStyle style = new RowStyle();
            style.SizeType = SizeType.AutoSize;

            _gamesTable.RowStyles.Add(style);

            GameRow row = new GameRow()
            {
                Picture = gameIcon,
                Title = game.Title.Value,
                CreationDate = game.CreationDate.DateInLocalTimeZone.ToString("d"),
                Price = $"{game.Price.Amount} {game.Price.Currency}"
            };
            row.InitializeComponent();

            _gamesTable.Controls.Add(row, _gamesTable.RowCount - 1, 0);
        }
    }
}
