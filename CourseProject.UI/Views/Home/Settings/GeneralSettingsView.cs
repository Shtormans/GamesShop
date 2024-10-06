using CourseProject.Domain.Enums;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home.Settings;

internal class GeneralSettingsView : BaseMinimizeView
{
    private ComboBox _languageChooser;
    private ComboBox _currencyChooser;
    private Label _label2;
    private Label _label5;

    public GeneralSettingsView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._label2 = new System.Windows.Forms.Label();
        this._label5 = new System.Windows.Forms.Label();
        this._languageChooser = new System.Windows.Forms.ComboBox();
        this._currencyChooser = new System.Windows.Forms.ComboBox();
        this.SuspendLayout();
        // 
        // label2
        // 
        this._label2.AutoSize = true;
        this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label2.ForeColor = System.Drawing.Color.White;
        this._label2.Location = new System.Drawing.Point(16, 20);
        this._label2.Name = "label2";
        this._label2.Size = new System.Drawing.Size(92, 22);
        this._label2.TabIndex = 8;
        this._label2.Text = CurrentSessionController.Session.Language.GetString("ChooseLanguage")!;
        // 
        // label5
        // 
        this._label5.AutoSize = true;
        this._label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label5.ForeColor = System.Drawing.Color.White;
        this._label5.Location = new System.Drawing.Point(16, 60);
        this._label5.Name = "label5";
        this._label5.Size = new System.Drawing.Size(92, 22);
        this._label5.TabIndex = 8;
        this._label5.Text = CurrentSessionController.Session.Language.GetString("ChooseCurrency")!;
        // 
        // _languageChooser
        // 
        this._languageChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
        this._languageChooser.ForeColor = System.Drawing.Color.White;
        this._languageChooser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._languageChooser.Font = new System.Drawing.Font("Tw Cen MT Condensed Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this._languageChooser.FormattingEnabled = true;
        this._languageChooser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this._languageChooser.Location = new System.Drawing.Point(150, 20);
        this._languageChooser.Name = "comboBox1";
        this._languageChooser.Size = new System.Drawing.Size(144, 28);
        this._languageChooser.TabIndex = 4;
        this._languageChooser.DropDownStyle = ComboBoxStyle.DropDownList;
        this._languageChooser.Items.AddRange(new object[]
        {
            CurrentSessionController.Session.Language.GetString("English")!,
            CurrentSessionController.Session.Language.GetString("Ukrainian")!
        });
        this._languageChooser.Text = ConvertLanguageToHumanReadableFormat(CurrentSessionController.Session.Language.BaseName.Split('.')[^1].ToString());
        this._languageChooser.SelectedIndexChanged += _languageChooser_SelectedIndexChanged;
        // 
        // _currencyChooser
        // 
        this._currencyChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
        this._currencyChooser.ForeColor = System.Drawing.Color.White;
        this._currencyChooser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._currencyChooser.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._currencyChooser.FormattingEnabled = true;
        this._currencyChooser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this._currencyChooser.Location = new System.Drawing.Point(150, 60);
        this._currencyChooser.Name = "comboBox1";
        this._currencyChooser.Size = new System.Drawing.Size(144, 28);
        this._currencyChooser.TabIndex = 4;
        this._currencyChooser.DropDownStyle = ComboBoxStyle.DropDownList;
        this._currencyChooser.Items.AddRange(Money.GetAllCurrencies());
        this._currencyChooser.Text = CurrentSessionController.Session.CurrencyType.ToString();
        this._currencyChooser.SelectedIndexChanged += _currencyChooser_SelectedIndexChanged;


        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this.PerformLayout();
        this.Controls.Add(this._label2);
        this.Controls.Add(this._label5);
        this.Controls.Add(this._languageChooser);
        this.Controls.Add(this._currencyChooser);
        this.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Location = new System.Drawing.Point(178, 0);
        this.Name = "panel1";
        this.Size = new System.Drawing.Size(906, 615);
        this.TabIndex = 5;
        this.ResumeLayout(false);
    }

    private async void _currencyChooser_SelectedIndexChanged(object? sender, EventArgs e)
    {
        string currencyTypeString = _currencyChooser.SelectedItem.ToString()!; 
        CurrencyType currencyType = (CurrencyType)Enum.Parse(typeof(CurrencyType), currencyTypeString, true);

        await UIManager
            .Instance
            .UseMethodAsync(nameof(SettingsController), "ChangeCurrency", new object[] { currencyType });
    }

    private async void _languageChooser_SelectedIndexChanged(object? sender, EventArgs e)
    {
        string language = ConvertLanguageToProgramFormat(_languageChooser.SelectedItem.ToString()!);

        await UIManager
            .Instance
            .UseMethodAsync(nameof(SettingsController), "ChangeLanguage", new[] { language });
    }

    private string ConvertLanguageToHumanReadableFormat(string programLanguage)
    {
        if (programLanguage == "en_local")
        {
            return CurrentSessionController.Session.Language.GetString("English")!;
        }
        else if (programLanguage == "ua_local")
        {
            return CurrentSessionController.Session.Language.GetString("Ukrainian")!;
        }

        return CurrentSessionController.Session.Language.GetString("English")!;
    }

    private string ConvertLanguageToProgramFormat(string humanLanguage)
    {
        if (humanLanguage == CurrentSessionController.Session.Language.GetString("English"))
        {
            return "en_local";
        }
        else if (humanLanguage == CurrentSessionController.Session.Language.GetString("Ukrainian"))
        {
            return "ua_local";
        }

        return "en_local";
    }
}
