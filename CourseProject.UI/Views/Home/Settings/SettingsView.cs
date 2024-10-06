using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home.Settings;

internal class SettingsView : BaseMinimizeView
{
    private ChangeableMinimizeView _changeableMinimizeView;
    private ListBox _settingsListBox;
    private Button _logOutButton;

    public SettingsView(ViewBag viewbag) 
        : base(viewbag)
    {
    }

    protected override async void InitializeComponent()
    {
        _logOutButton = new Button();
        _settingsListBox = new ListBox();
        // 
        // _addNewFriendButton
        // 
        _logOutButton.BackColor = Color.FromArgb(34, 58, 76);
        _logOutButton.FlatStyle = FlatStyle.Flat;
        _logOutButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
        _logOutButton.ForeColor = Color.FromArgb(227, 87, 125);
        _logOutButton.Location = new Point(1, 583);
        _logOutButton.Name = "_addNewGameButton";
        _logOutButton.Size = new Size(175, 30);
        _logOutButton.TabIndex = 6;
        _logOutButton.Text = CurrentSessionController.Session.Language.GetString("LogOut")!;
        _logOutButton.UseVisualStyleBackColor = false;
        _logOutButton.Click += _logOutButton_Click; ;
        // 
        // _gamesListBox
        // 
        _settingsListBox.BackColor = Color.FromArgb(32, 50, 68);
        _settingsListBox.Dock = DockStyle.Left;
        _settingsListBox.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
        _settingsListBox.ForeColor = Color.White;
        _settingsListBox.FormattingEnabled = true;
        _settingsListBox.ItemHeight = 20;
        _settingsListBox.Location = new Point(0, 0);
        _settingsListBox.Name = "_gamesListBox";
        _settingsListBox.Size = new Size(178, 1241);
        _settingsListBox.TabIndex = 4;
        _settingsListBox.SelectedIndexChanged += _settingsListBox_SelectedIndexChanged;
        _settingsListBox.Items.AddRange(new object[]
        {
            CurrentSessionController.Session.Language.GetString("General")!,
            CurrentSessionController.Session.Language.GetString("Personal")!,
            CurrentSessionController.Session.Language.GetString("Report")!
        });
        // 
        // _changeableMinimizeView
        // 
        _changeableMinimizeView = new();

        Controls.Add(_changeableMinimizeView);
        BackColor = Color.FromArgb(32, 50, 68);
        Controls.Add(_logOutButton);
        Controls.Add(_settingsListBox);
        Dock = DockStyle.Fill;
        Location = new Point(0, 46);
        Name = "_currentViewPanel";
        Size = new Size(1096, 1241);
        TabIndex = 9;
    }

    private void _settingsListBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        string item = (string)_settingsListBox.SelectedItem!;

        if (item == CurrentSessionController.Session.Language.GetString("Personal"))
        {
            _changeableMinimizeView.SetView(new PersonalSettingsView(ViewBag));
        }
        else if (item == CurrentSessionController.Session.Language.GetString("General"))
        {
            _changeableMinimizeView.SetView(new GeneralSettingsView(ViewBag));
        }
        else if (item == CurrentSessionController.Session.Language.GetString("Report"))
        {
            _changeableMinimizeView.SetView(new ReportView(ViewBag));
        }
    }

    private async void _logOutButton_Click(object? sender, EventArgs e)
    {
        await UIManager.Instance.UseMethodAsync(nameof(SettingsController), "LogOut");
    }
}
