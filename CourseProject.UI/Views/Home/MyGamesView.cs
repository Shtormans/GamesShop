using CourseProject.Domain.Entities;
using CourseProject.Domain.Shared;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home;

internal class MyGamesView : BaseMinimizeView
{
    private TextBox _titleInput;
    private Label _label2;
    private Button _changePictureButton;
    private PictureBox _gameIcon;
    private ListBox _gamesListBox;
    private NumericUpDown _priceInput;
    private ComboBox _currencyComboBox;
    private Label _label4;
    private Button _saveChangesButton;
    private Label _label3;
    private RichTextBox _descriptionInput;
    private Button _addNewGameButton;
    private Panel _gameInfoPanel;
    private List<Game> _userGames;

    public MyGamesView(ViewBag viewbag) 
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._addNewGameButton = new System.Windows.Forms.Button();
        this._priceInput = new System.Windows.Forms.NumericUpDown();
        this._currencyComboBox = new System.Windows.Forms.ComboBox();
        this._label4 = new System.Windows.Forms.Label();
        this._saveChangesButton = new System.Windows.Forms.Button();
        this._label3 = new System.Windows.Forms.Label();
        this._descriptionInput = new System.Windows.Forms.RichTextBox();
        this._titleInput = new System.Windows.Forms.TextBox();
        this._label2 = new System.Windows.Forms.Label();
        this._changePictureButton = new System.Windows.Forms.Button();
        this._gameIcon = new System.Windows.Forms.PictureBox();
        this._gamesListBox = new System.Windows.Forms.ListBox();
        this._gameInfoPanel = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)(this._priceInput)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this._gameIcon)).BeginInit();
        this.SuspendLayout();
        // 
        // _addNewGameButton
        // 
        this._addNewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._addNewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._addNewGameButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._addNewGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._addNewGameButton.Location = new System.Drawing.Point(1, 583);
        this._addNewGameButton.Name = "_addNewGameButton";
        this._addNewGameButton.Size = new System.Drawing.Size(175, 30);
        this._addNewGameButton.TabIndex = 6;
        this._addNewGameButton.Text = "Add New Game";
        this._addNewGameButton.UseVisualStyleBackColor = false;
        this._addNewGameButton.Click += _addNewGameButton_Click;
        // 
        // _gamePriceInput
        // 
        this._priceInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._priceInput.DecimalPlaces = 2;
        this._priceInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._priceInput.ForeColor = System.Drawing.Color.White;
        this._priceInput.Location = new System.Drawing.Point(183, 252);
        this._priceInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
        this._priceInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
        this._priceInput.Name = "_gamePriceInput";
        this._priceInput.Size = new System.Drawing.Size(120, 25);
        this._priceInput.TabIndex = 15;
        this._priceInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this._priceInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
        // 
        // _currencyComboBox
        // 
        this._currencyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
        this._currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this._currencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._currencyComboBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._currencyComboBox.ForeColor = System.Drawing.Color.White;
        this._currencyComboBox.FormattingEnabled = true;
        this._currencyComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this._currencyComboBox.Items.AddRange(new object[] {
            "USD",
            "UAH"});
        this._currencyComboBox.SelectedIndex = 0;
        this._currencyComboBox.Location = new System.Drawing.Point(316, 251);
        this._currencyComboBox.Name = "_currencyComboBox";
        this._currencyComboBox.Size = new System.Drawing.Size(92, 28);
        this._currencyComboBox.TabIndex = 14;
        // 
        // label4
        // 
        this._label4.AutoSize = true;
        this._label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label4.ForeColor = System.Drawing.Color.White;
        this._label4.Location = new System.Drawing.Point(16, 254);
        this._label4.Name = "label4";
        this._label4.Size = new System.Drawing.Size(97, 22);
        this._label4.TabIndex = 12;
        this._label4.Text = "Game Price:";
        // 
        // _saveChangesButton
        // 
        this._saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._saveChangesButton.FlatAppearance.BorderSize = 0;
        this._saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._saveChangesButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._saveChangesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._saveChangesButton.Location = new System.Drawing.Point(16, 533);
        this._saveChangesButton.Name = "_saveChangesButton";
        this._saveChangesButton.Size = new System.Drawing.Size(108, 25);
        this._saveChangesButton.TabIndex = 5;
        this._saveChangesButton.Text = "Add Game";
        this._saveChangesButton.UseVisualStyleBackColor = false;
        this._saveChangesButton.Click += _saveChangesButton_Click;
        // 
        // label3
        // 
        this._label3.AutoSize = true;
        this._label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label3.ForeColor = System.Drawing.Color.White;
        this._label3.Location = new System.Drawing.Point(16, 333);
        this._label3.Name = "label3";
        this._label3.Size = new System.Drawing.Size(141, 22);
        this._label3.TabIndex = 11;
        this._label3.Text = "Game Description:";
        // 
        // _descriptionInput
        // 
        this._descriptionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._descriptionInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._descriptionInput.ForeColor = System.Drawing.Color.White;
        this._descriptionInput.Location = new System.Drawing.Point(183, 333);
        this._descriptionInput.Name = "_descriptionInput";
        this._descriptionInput.Size = new System.Drawing.Size(488, 163);
        this._descriptionInput.TabIndex = 10;
        this._descriptionInput.Text = "";
        // 
        // _titleInput
        // 
        this._titleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._titleInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._titleInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._titleInput.ForeColor = System.Drawing.Color.White;
        this._titleInput.Location = new System.Drawing.Point(183, 204);
        this._titleInput.Name = "_titleInput";
        this._titleInput.Size = new System.Drawing.Size(225, 25);
        this._titleInput.TabIndex = 9;
        // 
        // label2
        // 
        this._label2.AutoSize = true;
        this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label2.ForeColor = System.Drawing.Color.White;
        this._label2.Location = new System.Drawing.Point(16, 204);
        this._label2.Name = "label2";
        this._label2.Size = new System.Drawing.Size(92, 22);
        this._label2.TabIndex = 8;
        this._label2.Text = "Game Title:";
        // 
        // _changePictureButton
        // 
        this._changePictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._changePictureButton.FlatAppearance.BorderSize = 0;
        this._changePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._changePictureButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._changePictureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._changePictureButton.Location = new System.Drawing.Point(425, 55);
        this._changePictureButton.Name = "_changePictureButton";
        this._changePictureButton.Size = new System.Drawing.Size(104, 50);
        this._changePictureButton.TabIndex = 7;
        this._changePictureButton.Text = "Change Picture";
        this._changePictureButton.UseVisualStyleBackColor = false;
        this._changePictureButton.Click += _changePictureButton_Click;
        // 
        // _gameIcon
        // 
        this._gameIcon.Location = new System.Drawing.Point(70, 20);
        this._gameIcon.Name = "_gameIcon";
        this._gameIcon.Size = new System.Drawing.Size(338, 137);
        this._gameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this._gameIcon.TabIndex = 5;
        this._gameIcon.TabStop = false;
        // 
        // _gamesListBox
        // 
        this._gamesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
        this._gamesListBox.Dock = System.Windows.Forms.DockStyle.Left;
        this._gamesListBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._gamesListBox.ForeColor = System.Drawing.Color.White;
        this._gamesListBox.FormattingEnabled = true;
        this._gamesListBox.ItemHeight = 20;
        this._gamesListBox.Location = new System.Drawing.Point(0, 0);
        this._gamesListBox.Name = "_gamesListBox";
        this._gamesListBox.Size = new System.Drawing.Size(178, 615);
        this._gamesListBox.TabIndex = 4;
        this._gamesListBox.SelectedIndexChanged += _gamesListBox_SelectedIndexChanged;
        // 
        // panel1
        // 
        this._gameInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this._gameInfoPanel.Controls.Add(this._priceInput);
        this._gameInfoPanel.Controls.Add(this._currencyComboBox);
        this._gameInfoPanel.Controls.Add(this._label4);
        this._gameInfoPanel.Controls.Add(this._saveChangesButton);
        this._gameInfoPanel.Controls.Add(this._label3);
        this._gameInfoPanel.Controls.Add(this._descriptionInput);
        this._gameInfoPanel.Controls.Add(this._titleInput);
        this._gameInfoPanel.Controls.Add(this._label2);
        this._gameInfoPanel.Controls.Add(this._changePictureButton);
        this._gameInfoPanel.Controls.Add(this._gameIcon);
        this._gameInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this._gameInfoPanel.Location = new System.Drawing.Point(178, 0);
        this._gameInfoPanel.Name = "panel1";
        this._gameInfoPanel.Size = new System.Drawing.Size(906, 615);
        this._gameInfoPanel.TabIndex = 5;

        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
        this.PerformLayout();
        this.Controls.Add(this._addNewGameButton);
        this.Controls.Add(this._gameInfoPanel);
        this.Controls.Add(this._gamesListBox);
        this._gameInfoPanel.ResumeLayout(false);
        this._gameInfoPanel.PerformLayout();
        this.ResumeLayout(false);

        FillGamesListBox();
        this._addNewGameButton.PerformClick();
    }

    private async void _changePictureButton_Click(object? sender, EventArgs e)
    {
        string filter = "Image Files|*.jpeg";
        string? fileName = await UIManager.Instance.OpenFileDialog(filter);

        if (fileName is not null)
        {
            _gameIcon.Image = new Bitmap(fileName);
        }
    }

    private async void _saveChangesButton_Click(object? sender, EventArgs e)
    {
        int selectedIndex = _gamesListBox.SelectedIndex;
        
        string title = _titleInput.Text;
        string description = _descriptionInput.Text;
        Money price = new Money((_currencyComboBox.SelectedItem as string)!, _priceInput.Value);
        Image icon = _gameIcon.Image;

        Result result;

        if (_gamesListBox.SelectedIndex == -1)
        {
            result = (await UIManager
                .Instance
                .UseMethodAsync(nameof(MyGamesController), "PublishGame", new object[]
                {
                    title,
                    description,
                    price,
                    icon
                })
                as Result)!;
        }
        else
        {
            result = (await UIManager
                .Instance
                .UseMethodAsync(nameof(MyGamesController), "UpdateGame", new object[]
                {
                    _userGames[selectedIndex].Id,
                    title,
                    description,
                    price,
                    icon
                })
                as Result)!;
        }

        if (result.IsFailure)
        {
            await UIManager.Instance.ShowErrorMessage(result.Error.Message);
        }
        else
        {
            await FillGamesListBox();
            this._addNewGameButton.PerformClick();
        }
    }

    private async void _gamesListBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        int selectedIndex = _gamesListBox.SelectedIndex;
        if (selectedIndex == -1)
        {
            return;
        }

        var game = _userGames[selectedIndex];

        this._gameIcon.Image = (await UIManager
                .Instance
                .UseMethodAsync(nameof(MyGamesController), "GetGameIcon", new object[] { game })
                as Image)!;

        this._titleInput.Text = game.Title.Value;
        this._descriptionInput.Text = game.Description.Value;

        this._priceInput.Text = game.Price.Amount.ToString();
        this._currencyComboBox.Text = game.Price.Currency;

        this._saveChangesButton.Text = "Save Changes";
    }

    private async void _addNewGameButton_Click(object? sender, EventArgs e)
    {
        this._gamesListBox.SelectedIndex = -1;

        this._gameIcon.Image = (await UIManager
                .Instance
                .UseMethodAsync(nameof(MyGamesController), "GetDefaultImage")
                as Image)!;

        this._titleInput.ResetText();
        this._descriptionInput.ResetText();

        this._priceInput.Text = "0";
        this._currencyComboBox.SelectedIndex = 0;

        this._saveChangesButton.Text = "Add Game";
    }

    private async Task FillGamesListBox()
    {
        _userGames = (await UIManager
                .Instance
                .UseMethodAsync(nameof(MyGamesController), "GetUserCreatedGames")
                as List<Game>)!;

        this._gamesListBox.Items.Clear();
        this._gamesListBox.Items.AddRange(
            _userGames.Select(g => g.Title.Value).ToArray()
        );
    }
}
