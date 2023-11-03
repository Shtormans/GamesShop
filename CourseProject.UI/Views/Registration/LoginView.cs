using CourseProject.Domain.Shared;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Registration;

internal class LoginView : BaseFullScreenView
{
    private Label _label1;
    private TextBox _usernameInput;
    private TextBox _passwordInput;
    private Label _label2;
    private CheckBox _rememberMeCheckBox;
    private Button _signInButton;
    private Label _label3;
    private LinkLabel _registrationLink;

    public LoginView(ViewBag viewbag) 
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._label1 = new System.Windows.Forms.Label();
        this._usernameInput = new System.Windows.Forms.TextBox();
        this._passwordInput = new System.Windows.Forms.TextBox();
        this._label2 = new System.Windows.Forms.Label();
        this._rememberMeCheckBox = new System.Windows.Forms.CheckBox();
        this._signInButton = new System.Windows.Forms.Button();
        this._label3 = new System.Windows.Forms.Label();
        this._registrationLink = new System.Windows.Forms.LinkLabel();
        this.SuspendLayout();
        // 
        // label1
        // 
        this._label1.AutoSize = true;
        this._label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label1.ForeColor = System.Drawing.Color.CornflowerBlue;
        this._label1.Location = new System.Drawing.Point(25, 53);
        this._label1.Name = "label1";
        this._label1.Size = new System.Drawing.Size(228, 20);
        this._label1.TabIndex = 0;
        this._label1.Text = "SIGN IN WITH EMAIL OR USERNAME";
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
        // 
        // label2
        // 
        this._label2.AutoSize = true;
        this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this._label2.Location = new System.Drawing.Point(25, 113);
        this._label2.Name = "label2";
        this._label2.Size = new System.Drawing.Size(78, 20);
        this._label2.TabIndex = 2;
        this._label2.Text = "PASSWORD";
        // 
        // RememberMeCheckBox
        // 
        this._rememberMeCheckBox.AutoSize = true;
        this._rememberMeCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this._rememberMeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(148)))));
        this._rememberMeCheckBox.Location = new System.Drawing.Point(30, 183);
        this._rememberMeCheckBox.Name = "RememberMeCheckBox";
        this._rememberMeCheckBox.Size = new System.Drawing.Size(127, 23);
        this._rememberMeCheckBox.TabIndex = 4;
        this._rememberMeCheckBox.Text = "Remember me";
        this._rememberMeCheckBox.UseVisualStyleBackColor = true;
        // 
        // SignInButton
        // 
        this._signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
        this._signInButton.FlatAppearance.BorderSize = 0;
        this._signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._signInButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this._signInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
        this._signInButton.Location = new System.Drawing.Point(163, 229);
        this._signInButton.Name = "SignInButton";
        this._signInButton.Size = new System.Drawing.Size(253, 45);
        this._signInButton.TabIndex = 5;
        this._signInButton.Text = "Sign in";
        this._signInButton.UseVisualStyleBackColor = false;
        this._signInButton.Click += SignInButton_Click;
        // 
        // label3
        // 
        this._label3.AutoSize = true;
        this._label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this._label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._label3.Location = new System.Drawing.Point(12, 359);
        this._label3.Name = "label3";
        this._label3.Size = new System.Drawing.Size(146, 19);
        this._label3.TabIndex = 6;
        this._label3.Text = "Don\'t have account ?";
        // 
        // label4
        // 
        this._registrationLink.AutoSize = true;
        this._registrationLink.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
        this._registrationLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._registrationLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._registrationLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(106)))));
        this._registrationLink.Location = new System.Drawing.Point(155, 359);
        this._registrationLink.Name = "label4";
        this._registrationLink.Size = new System.Drawing.Size(156, 19);
        this._registrationLink.TabIndex = 7;
        this._registrationLink.Text = "Create a Free Account";
        this._registrationLink.LinkClicked += RegistrationLink_LinkClicked;
        // 
        // TestForm
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
        this.ClientSize = new System.Drawing.Size(584, 387);
        this.Controls.Add(this._registrationLink);
        this.Controls.Add(this._label3);
        this.Controls.Add(this._signInButton);
        this.Controls.Add(this._rememberMeCheckBox);
        this.Controls.Add(this._passwordInput);
        this.Controls.Add(this._label2);
        this.Controls.Add(this._usernameInput);
        this.Controls.Add(this._label1);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private async void SignInButton_Click(object? sender, EventArgs e)
    {
        string emailOrUsername = _usernameInput.Text;
        string password = _passwordInput.Text;

        var result = await UIManager.Instance
            .UseMethodAsync(nameof(LoginController), "LoginUser", new[] {emailOrUsername, password})
            as Result;

        if (result!.IsFailure)
        {
            await UIManager.Instance.ShowErrorMessage(result!.Error.Message);
        }
    }

    private async void RegistrationLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        await UIManager.Instance.ShowView(nameof(RegistrationController), "ShowFirstRegistrationForm");
    }
}
