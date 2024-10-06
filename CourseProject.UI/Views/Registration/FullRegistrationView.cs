using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.User;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using Microsoft.IdentityModel.Tokens;

namespace CourseProject.UI.Views.Registration;

internal class FullRegistrationView : BaseFullScreenView
{
    private Label _label1;
    private TextBox _usernameInput;
    private TextBox _passwordInput;
    private Label _label2;
    private Button _registerButton;
    private TextBox _confirmPasswordInput;
    private Label _label3;
    private TextBox _firstNameInput;
    private Label label4;
    private TextBox _secondNameInput;
    private Label _label5;
    private Label _label6;
    private DateTimePicker _birthdayPicker;

    public FullRegistrationView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._label1 = new System.Windows.Forms.Label();
        this._usernameInput = new System.Windows.Forms.TextBox();
        this._passwordInput = new System.Windows.Forms.TextBox();
        this._label2 = new System.Windows.Forms.Label();
        this._registerButton = new System.Windows.Forms.Button();
        this._confirmPasswordInput = new System.Windows.Forms.TextBox();
        this._label3 = new System.Windows.Forms.Label();
        this._firstNameInput = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this._secondNameInput = new System.Windows.Forms.TextBox();
        this._label5 = new System.Windows.Forms.Label();
        this._label6 = new System.Windows.Forms.Label();
        this._birthdayPicker = new System.Windows.Forms.DateTimePicker();
        this.SuspendLayout();
        // 
        // label1
        // 
        this._label1.AutoSize = true;
        this._label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label1.ForeColor = System.Drawing.Color.CornflowerBlue;
        this._label1.Location = new System.Drawing.Point(25, 53);
        this._label1.Name = "label1";
        this._label1.Size = new System.Drawing.Size(84, 20);
        this._label1.TabIndex = 0;
        this._label1.Text = CurrentSessionController.Session.Language.GetString("Username")!.ToUpper() + "*";
        // 
        // UsernameInput
        // 
        this._usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._usernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this._usernameInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._usernameInput.Location = new System.Drawing.Point(30, 76);
        this._usernameInput.Name = "UsernameInput";
        this._usernameInput.Size = new System.Drawing.Size(347, 23);
        this._usernameInput.TabIndex = 1;
        // 
        // PasswordInput
        // 
        this._passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._passwordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this._passwordInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._passwordInput.Location = new System.Drawing.Point(30, 136);
        this._passwordInput.Name = "PasswordInput";
        this._passwordInput.Size = new System.Drawing.Size(347, 23);
        this._passwordInput.TabIndex = 3;
        this._passwordInput.PasswordChar = '*';
        // 
        // label2
        // 
        this._label2.AutoSize = true;
        this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this._label2.Location = new System.Drawing.Point(25, 113);
        this._label2.Name = "label2";
        this._label2.Size = new System.Drawing.Size(84, 20);
        this._label2.TabIndex = 2;
        this._label2.Text = CurrentSessionController.Session.Language.GetString("Password")!.ToUpper() + "*";
        // 
        // RegisterButton
        // 
        this._registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
        this._registerButton.FlatAppearance.BorderSize = 0;
        this._registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._registerButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this._registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
        this._registerButton.Location = new System.Drawing.Point(147, 475);
        this._registerButton.Name = "RegisterButton";
        this._registerButton.Size = new System.Drawing.Size(253, 45);
        this._registerButton.TabIndex = 5;
        this._registerButton.Text = CurrentSessionController.Session.Language.GetString("Register")!;
        this._registerButton.UseVisualStyleBackColor = false;
        this._registerButton.Click += RegisterButton_Click;
        // 
        // textBox1
        // 
        this._confirmPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._confirmPasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this._confirmPasswordInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._confirmPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._confirmPasswordInput.Location = new System.Drawing.Point(30, 198);
        this._confirmPasswordInput.Name = "textBox1";
        this._confirmPasswordInput.Size = new System.Drawing.Size(347, 23);
        this._confirmPasswordInput.TabIndex = 7;
        this._confirmPasswordInput.PasswordChar = '*';
        // 
        // label3
        // 
        this._label3.AutoSize = true;
        this._label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this._label3.Location = new System.Drawing.Point(25, 175);
        this._label3.Name = "label3";
        this._label3.Size = new System.Drawing.Size(182, 20);
        this._label3.TabIndex = 6;
        this._label3.Text = CurrentSessionController.Session.Language.GetString("ConfirmYourPassword")!.ToUpper() + "*";
        // 
        // textBox2
        // 
        this._firstNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._firstNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this._firstNameInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._firstNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._firstNameInput.Location = new System.Drawing.Point(30, 264);
        this._firstNameInput.Name = "textBox2";
        this._firstNameInput.Size = new System.Drawing.Size(347, 23);
        this._firstNameInput.TabIndex = 9;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this.label4.Location = new System.Drawing.Point(25, 241);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(82, 20);
        this.label4.TabIndex = 8;
        this.label4.Text = CurrentSessionController.Session.Language.GetString("FirstName")!.ToUpper();
        // 
        // textBox3
        // 
        this._secondNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._secondNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this._secondNameInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._secondNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._secondNameInput.Location = new System.Drawing.Point(30, 329);
        this._secondNameInput.Name = "textBox3";
        this._secondNameInput.Size = new System.Drawing.Size(347, 23);
        this._secondNameInput.TabIndex = 11;
        // 
        // label5
        // 
        this._label5.AutoSize = true;
        this._label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this._label5.Location = new System.Drawing.Point(25, 306);
        this._label5.Name = "label5";
        this._label5.Size = new System.Drawing.Size(100, 20);
        this._label5.TabIndex = 10;
        this._label5.Text = CurrentSessionController.Session.Language.GetString("SecondName")!.ToUpper();
        // 
        // label6
        // 
        this._label6.AutoSize = true;
        this._label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this._label6.Location = new System.Drawing.Point(25, 375);
        this._label6.Name = "label6";
        this._label6.Size = new System.Drawing.Size(76, 20);
        this._label6.TabIndex = 12;
        this._label6.Text = CurrentSessionController.Session.Language.GetString("Birthday")!.ToUpper() + "*";
        // 
        // birthdayPicker
        // 
        this._birthdayPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this._birthdayPicker.Location = new System.Drawing.Point(30, 398);
        this._birthdayPicker.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
        this._birthdayPicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
        this._birthdayPicker.Name = "birthdayPicker";
        this._birthdayPicker.Size = new System.Drawing.Size(200, 23);
        this._birthdayPicker.TabIndex = 13;
        this._birthdayPicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
        // 
        // TestForm
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
        this.ClientSize = new System.Drawing.Size(584, 532);
        this.Controls.Add(this._birthdayPicker);
        this.Controls.Add(this._label6);
        this.Controls.Add(this._secondNameInput);
        this.Controls.Add(this._label5);
        this.Controls.Add(this._firstNameInput);
        this.Controls.Add(this.label4);
        this.Controls.Add(this._confirmPasswordInput);
        this.Controls.Add(this._label3);
        this.Controls.Add(this._registerButton);
        this.Controls.Add(this._passwordInput);
        this.Controls.Add(this._label2);
        this.Controls.Add(this._usernameInput);
        this.Controls.Add(this._label1);
        this.Name = "TestForm";
        this.Text = "TestForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private async void RegisterButton_Click(object? sender, EventArgs e)
    {
        var result = CheckData();
        if (result.IsFailure)
        {
            await UIManager.Instance.ShowErrorMessage(result.Error.Message);
            return;
        }

        var check = await UIManager.Instance
            .UseMethodAsync(nameof(RegistrationController), "RegisterUser", new [] 
            {
                _usernameInput.Text,
                ViewBag.Email,
                _passwordInput.Text,
                (object)_birthdayPicker.Value,
                _firstNameInput.Text.IsNullOrEmpty() ? null : _firstNameInput.Text,
                _secondNameInput.Text.IsNullOrEmpty() ? null : _secondNameInput.Text
            })
            as Result;
        
        if (check!.IsFailure) 
        {
            await UIManager.Instance.ShowErrorMessage(check!.Error.Message);
        }
    }

    private Result CheckData()
    {
        var usernameResult = Username.Create(_usernameInput.Text);
        if (usernameResult.IsFailure)
        {
            return usernameResult;
        }

        var passwordResult = UserPassword.Create(_passwordInput.Text);
        if (passwordResult.IsFailure)
        {
            return passwordResult;
        }

        if (_passwordInput.Text != _confirmPasswordInput.Text)
        {
            return Result.Failure(new Error("Password.NotConfirmed", "Password is not confirmed."));
        }

        if (_firstNameInput.Text != string.Empty)
        {
            var firstNameResult = UserFirstName.Create(_firstNameInput.Text);
            if (firstNameResult.IsFailure)
            {
                return firstNameResult;
            }
        }

        if (_secondNameInput.Text != string.Empty)
        {
            var secondNameResult = UserSecondName.Create(_secondNameInput.Text);
            if (secondNameResult.IsFailure)
            {
                return secondNameResult;
            }
        }

        var birthdayResult = UserBirthday.Create(_birthdayPicker.Value);
        if (usernameResult.IsFailure)
        {
            return usernameResult;
        }

        return Result.Success();
    }
}
