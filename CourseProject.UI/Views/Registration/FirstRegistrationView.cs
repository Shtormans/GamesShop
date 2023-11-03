using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.User;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Registration;

internal class FirstRegistrationView : BaseFullScreenView
{
    private Label _label1;
    private TextBox _emailInput;
    private TextBox _confirmEmailInput;
    private Label _label2;
    private Button _nextButton;
    private Label _label3;
    private LinkLabel _signInLink;

    public FirstRegistrationView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._label1 = new System.Windows.Forms.Label();
        this._emailInput = new System.Windows.Forms.TextBox();
        this._confirmEmailInput = new System.Windows.Forms.TextBox();
        this._label2 = new System.Windows.Forms.Label();
        this._nextButton = new System.Windows.Forms.Button();
        this._label3 = new System.Windows.Forms.Label();
        this._signInLink = new System.Windows.Forms.LinkLabel();
        this.SuspendLayout();
        // 
        // label1
        // 
        this._label1.AutoSize = true;
        this._label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label1.ForeColor = System.Drawing.Color.CornflowerBlue;
        this._label1.Location = new System.Drawing.Point(25, 53);
        this._label1.Name = "label1";
        this._label1.Size = new System.Drawing.Size(47, 20);
        this._label1.TabIndex = 0;
        this._label1.Text = "EMAIL";
        // 
        // UsernameInput
        // 
        this._emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._emailInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this._emailInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._emailInput.Location = new System.Drawing.Point(30, 76);
        this._emailInput.Name = "UsernameInput";
        this._emailInput.Size = new System.Drawing.Size(347, 23);
        this._emailInput.TabIndex = 1;
        // 
        // PasswordInput
        // 
        this._confirmEmailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
        this._confirmEmailInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this._confirmEmailInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._confirmEmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._confirmEmailInput.Location = new System.Drawing.Point(30, 136);
        this._confirmEmailInput.Name = "PasswordInput";
        this._confirmEmailInput.Size = new System.Drawing.Size(347, 23);
        this._confirmEmailInput.TabIndex = 3;
        // 
        // label2
        // 
        this._label2.AutoSize = true;
        this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this._label2.Location = new System.Drawing.Point(25, 113);
        this._label2.Name = "label2";
        this._label2.Size = new System.Drawing.Size(107, 20);
        this._label2.TabIndex = 2;
        this._label2.Text = "CONFIRM EMAIL";
        // 
        // NextButton
        // 
        this._nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
        this._nextButton.FlatAppearance.BorderSize = 0;
        this._nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._nextButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this._nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
        this._nextButton.Location = new System.Drawing.Point(163, 229);
        this._nextButton.Name = "NextButton";
        this._nextButton.Size = new System.Drawing.Size(253, 45);
        this._nextButton.TabIndex = 5;
        this._nextButton.Text = "Next";
        this._nextButton.UseVisualStyleBackColor = false;
        this._nextButton.Click += _nextButton_Click;
        // 
        // label3
        // 
        this._label3.AutoSize = true;
        this._label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this._label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._label3.Location = new System.Drawing.Point(12, 359);
        this._label3.Name = "label3";
        this._label3.Size = new System.Drawing.Size(184, 19);
        this._label3.TabIndex = 6;
        this._label3.Text = "Already have an account ?";
        // 
        // SignInLabel
        // 
        this._signInLink.AutoSize = true;
        this._signInLink.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
        this._signInLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._signInLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._signInLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._signInLink.Location = new System.Drawing.Point(195, 359);
        this._signInLink.Name = "SignInLabel";
        this._signInLink.Size = new System.Drawing.Size(54, 19);
        this._signInLink.TabIndex = 7;
        this._signInLink.Text = "Sign in";
        this._signInLink.LinkClicked += RegistrationLink_LinkClicked;
        // 
        // TestForm
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
        this.ClientSize = new System.Drawing.Size(584, 387);
        this.Controls.Add(this._signInLink);
        this.Controls.Add(this._label3);
        this.Controls.Add(this._nextButton);
        this.Controls.Add(this._confirmEmailInput);
        this.Controls.Add(this._label2);
        this.Controls.Add(this._emailInput);
        this.Controls.Add(this._label1);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private async void _nextButton_Click(object? sender, EventArgs e)
    {
        var result = await CheckData();
        if (result.IsFailure)
        {
            await UIManager.Instance.ShowErrorMessage(result.Error.Message);
            return;
        }

        await UIManager.Instance.ShowView(nameof(RegistrationController), "ShowNextRegistrationForm", new[] { _emailInput.Text });
    }

    private async void RegistrationLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        await UIManager.Instance.ShowView(nameof(LoginController), "ShowLoginForm");
    }

    private async Task<Result> CheckData()
    {
        var emailResult = UserEmail.Create(_emailInput.Text);
        if (emailResult.IsFailure)
        {
            return emailResult;
        }

        if (_emailInput.Text != _confirmEmailInput.Text)
        {
            return Result.Failure(new Error("Email.NotConfirmed", "Email address is not confirmed."));
        }

        var isEmailValidResult = await UIManager
                .Instance
                .UseMethodAsync(nameof(RegistrationController), "CheckIfEmailAlreadyExistInUsers", new[] { emailResult.Value.Value })
                as Result;

        if (isEmailValidResult!.IsFailure)
        {
            return Result.Failure(isEmailValidResult.Error);
        }

        return Result.Success();
    }
}
