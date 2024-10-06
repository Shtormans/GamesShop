using CourseProject.Domain.Entities;
using CourseProject.Domain.Shared;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home.Settings;

internal class PersonalSettingsView : BaseMinimizeView
{
    private TextBox _usernameInput;
    private TextBox _firstNameInput;
    private TextBox _secondNameInput;
    private TextBox _emailInput;
    private DateTimePicker _birthdayPicker;
    private Label _label2;
    private Label _label5;
    private Label _label6;
    private Label _label7;
    private Label _label8;
    private Button _changePictureButton;
    private PictureBox _profilePicture;
    private Button _saveChangesButton;

    public PersonalSettingsView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._label2 = new System.Windows.Forms.Label();
        this._label5 = new System.Windows.Forms.Label();
        this._label6 = new System.Windows.Forms.Label();
        this._label7 = new System.Windows.Forms.Label();
        this._label8 = new System.Windows.Forms.Label();
        this._birthdayPicker = new System.Windows.Forms.DateTimePicker();
        this._usernameInput = new System.Windows.Forms.TextBox();
        this._firstNameInput = new System.Windows.Forms.TextBox();
        this._secondNameInput = new System.Windows.Forms.TextBox();
        this._emailInput = new System.Windows.Forms.TextBox();
        this._saveChangesButton = new System.Windows.Forms.Button();
        this._changePictureButton = new System.Windows.Forms.Button();
        this._profilePicture = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this._profilePicture)).BeginInit();
        this.SuspendLayout();
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
        this._saveChangesButton.Text = CurrentSessionController.Session.Language.GetString("UpdateProfile")!;
        this._saveChangesButton.UseVisualStyleBackColor = false;
        this._saveChangesButton.Click += _saveChangesButton_Click;
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
        this._label2.Text = CurrentSessionController.Session.Language.GetString("Username")! + ":";
        // 
        // label5
        // 
        this._label5.AutoSize = true;
        this._label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label5.ForeColor = System.Drawing.Color.White;
        this._label5.Location = new System.Drawing.Point(16, 244);
        this._label5.Name = "label5";
        this._label5.Size = new System.Drawing.Size(92, 22);
        this._label5.TabIndex = 8;
        this._label5.Text = CurrentSessionController.Session.Language.GetString("FirstName")! + ":";
        // 
        // label6
        // 
        this._label6.AutoSize = true;
        this._label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label6.ForeColor = System.Drawing.Color.White;
        this._label6.Location = new System.Drawing.Point(16, 284);
        this._label6.Name = "label6";
        this._label6.Size = new System.Drawing.Size(92, 22);
        this._label6.TabIndex = 8;
        this._label6.Text = CurrentSessionController.Session.Language.GetString("SecondName")! + ":";
        // 
        // label7
        // 
        this._label7.AutoSize = true;
        this._label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label7.ForeColor = System.Drawing.Color.White;
        this._label7.Location = new System.Drawing.Point(16, 324);
        this._label7.Name = "label7";
        this._label7.Size = new System.Drawing.Size(92, 22);
        this._label7.TabIndex = 8;
        this._label7.Text = CurrentSessionController.Session.Language.GetString("Email")! + ":";
        // 
        // label8
        // 
        this._label8.AutoSize = true;
        this._label8.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label8.ForeColor = System.Drawing.Color.White;
        this._label8.Location = new System.Drawing.Point(16, 364);
        this._label8.Name = "label7";
        this._label8.Size = new System.Drawing.Size(92, 22);
        this._label8.TabIndex = 8;
        this._label8.Text = CurrentSessionController.Session.Language.GetString("Birthday")! + ":";
        // 
        // _usernameInput
        // 
        this._usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._usernameInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._usernameInput.ForeColor = System.Drawing.Color.White;
        this._usernameInput.Location = new System.Drawing.Point(170, 204);
        this._usernameInput.Name = "_usernameInput";
        this._usernameInput.Size = new System.Drawing.Size(225, 25);
        this._usernameInput.TabIndex = 9;
        this._usernameInput.Enabled = false;
        // 
        // _firstNameInput
        // 
        this._firstNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._firstNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._firstNameInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._firstNameInput.ForeColor = System.Drawing.Color.White;
        this._firstNameInput.Location = new System.Drawing.Point(170, 244);
        this._firstNameInput.Name = "_firstNameInput";
        this._firstNameInput.Size = new System.Drawing.Size(225, 25);
        this._firstNameInput.TabIndex = 9;
        // 
        // _secondNameInput
        // 
        this._secondNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._secondNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._secondNameInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._secondNameInput.ForeColor = System.Drawing.Color.White;
        this._secondNameInput.Location = new System.Drawing.Point(170, 284);
        this._secondNameInput.Name = "_secondNameInput";
        this._secondNameInput.Size = new System.Drawing.Size(225, 25);
        this._secondNameInput.TabIndex = 9;
        // 
        // _emailInput
        // 
        this._emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._emailInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._emailInput.ForeColor = System.Drawing.Color.White;
        this._emailInput.Location = new System.Drawing.Point(170, 324);
        this._emailInput.Name = "_emailInput";
        this._emailInput.Size = new System.Drawing.Size(225, 25);
        this._emailInput.TabIndex = 9;
        this._emailInput.Enabled = false;
        // 
        // birthdayPicker
        // 
        this._birthdayPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this._birthdayPicker.Location = new System.Drawing.Point(170, 364);
        this._birthdayPicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
        this._birthdayPicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
        this._birthdayPicker.Name = "birthdayPicker";
        this._birthdayPicker.Size = new System.Drawing.Size(200, 23);
        this._birthdayPicker.TabIndex = 13;
        this._birthdayPicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
        // 
        // _changePictureButton
        // 
        this._changePictureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._changePictureButton.FlatAppearance.BorderSize = 0;
        this._changePictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._changePictureButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._changePictureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._changePictureButton.Location = new System.Drawing.Point(224, 55);
        this._changePictureButton.Name = "_changePictureButton";
        this._changePictureButton.Size = new System.Drawing.Size(104, 50);
        this._changePictureButton.TabIndex = 7;
        this._changePictureButton.Text = CurrentSessionController.Session.Language.GetString("ChangePicture")!;
        this._changePictureButton.UseVisualStyleBackColor = false;
        this._changePictureButton.Click += _changePictureButton_Click;
        // 
        // _profilePicture
        // 
        this._profilePicture.Location = new System.Drawing.Point(70, 20);
        this._profilePicture.Name = "_gameIcon";
        this._profilePicture.Size = new System.Drawing.Size(137, 137);
        this._profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this._profilePicture.TabIndex = 5;
        this._profilePicture.TabStop = false;


        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this.PerformLayout();
        this.Controls.Add(this._label2);
        this.Controls.Add(this._label5);
        this.Controls.Add(this._label6);
        this.Controls.Add(this._label7);
        this.Controls.Add(this._label8);
        this.Controls.Add(this._usernameInput);
        this.Controls.Add(this._firstNameInput);
        this.Controls.Add(this._secondNameInput);
        this.Controls.Add(this._emailInput);
        this.Controls.Add(this._birthdayPicker);
        this.Controls.Add(this._saveChangesButton);
        this.Controls.Add(this._changePictureButton);
        this.Controls.Add(this._profilePicture);
        this.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Location = new System.Drawing.Point(178, 0);
        this.Name = "panel1";
        this.Size = new System.Drawing.Size(906, 615);
        this.TabIndex = 5;
        this.ResumeLayout(false);

        SetCurrentProfile();
        SetProfilePicture();
    }

    private async Task SetCurrentProfile()
    {
        User currentUser = (await UIManager
                .Instance
                .UseMethodAsync(nameof(SettingsController), "GetCurrentUser")
                as User)!;

        _usernameInput.Text = currentUser.Username.Value;
        _emailInput.Text = currentUser.Email.Value;
        _birthdayPicker.Value = currentUser.Birthday.DateInLocalTimeZone;

        _firstNameInput.Text = currentUser.FirstName is null ? string.Empty : currentUser.FirstName.Value;
        _secondNameInput.Text = currentUser.SecondName is null ? string.Empty : currentUser.SecondName.Value;
    }

    private async Task SetProfilePicture()
    {
        this._profilePicture.Image = (await UIManager
                .Instance
                .UseMethodAsync(nameof(SettingsController), "GetProfilePicture")
                as Image)!;
    }

    private async void _changePictureButton_Click(object? sender, EventArgs e)
    {
        string filter = "Image Files|*.jpeg";
        string? fileName = await UIManager.Instance.OpenFileDialog(filter);

        if (fileName is not null)
        {
            _profilePicture.Image = new Bitmap(fileName);
        }
    }

    private async void _saveChangesButton_Click(object? sender, EventArgs e)
    {
        string? firstName = _firstNameInput.Text == string.Empty ? null : _firstNameInput.Text;
        string? secondName = _secondNameInput.Text == string.Empty ? null : _secondNameInput.Text;
        DateTime birthday = _birthdayPicker.Value;
        Image profilePicture = _profilePicture.Image;

        Result result = (await UIManager
                .Instance
                .UseMethodAsync(nameof(SettingsController), "UpdateProfile", new object[]
                {
                    firstName,
                    secondName,
                    birthday,
                    profilePicture
                })
                as Result)!;

        if (result.IsFailure)
        {
            await UIManager.Instance.ShowErrorMessage(result.Error.Message);
        }
    }
}
