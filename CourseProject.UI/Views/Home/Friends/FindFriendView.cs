using CourseProject.Domain.Entities;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home;

internal class FindFriendView : BaseMinimizeView
{
    private class UserRow : Panel
    {
        private PictureBox _picture;
        private Label _username;
        private Button _addFriendButton;

        private User _user;
        private bool _alreadyFriends;
        private dynamic _viewBag;

        public required User User
        {
            init
            {
                _user = value;
            }
        }

        public required Image Picture
        {
            init
            {
                _picture = new PictureBox();
                _picture.Image = value;
            }
        }

        public required string Username
        {
            init
            {
                _username = new Label();
                _username.Text = value;
            }
        }

        public required bool AlreadyFriends
        {
            init
            {
                _alreadyFriends = value;
            }
        }

        public required ViewBag ViewBag
        {
            init
            {
                _viewBag = value;
            }
        }

        public UserRow InitializeComponent()
        {
            _addFriendButton = new Button();

            _picture.Location = new System.Drawing.Point(0, 0);
            _picture.Size = new System.Drawing.Size(40, 40);
            _picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            _picture.TabIndex = 0;
            _picture.TabStop = false;

            _username.AutoSize = true;
            _username.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(228)))));
            _username.Location = new System.Drawing.Point(55, 14);
            _username.TabIndex = 1;

            _addFriendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            _addFriendButton.FlatAppearance.BorderSize = 0;
            _addFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            _addFriendButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _addFriendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            _addFriendButton.Location = new System.Drawing.Point(200, 6);
            _addFriendButton.Name = "_addFriendButton";
            _addFriendButton.Size = new System.Drawing.Size(150, 28);
            _addFriendButton.TabIndex = 24;
            _addFriendButton.UseVisualStyleBackColor = false;

            if (_alreadyFriends)
            {
                _addFriendButton.Text = CurrentSessionController.Session.Language.GetString("AlreadyFriends")!;
                _addFriendButton.Enabled = false;
            }
            else
            {
                _addFriendButton.Text = CurrentSessionController.Session.Language.GetString("SendRequest")!;
                _addFriendButton.Click += _addFriendButton_Click;
            }

            this.Controls.Add(this._picture);
            this.Controls.Add(this._username);
            this.Controls.Add(this._addFriendButton);
            this.Size = new System.Drawing.Size(355, 50);

            return this;
        }

        private async void _addFriendButton_Click(object? sender, EventArgs e)
        {
            await UIManager
                .Instance
                .UseMethodAsync(nameof(FriendsController), "AddFriend", new object[] { _user.Id });

            _addFriendButton.Text = CurrentSessionController.Session.Language.GetString("AlreadyFriends")!;
            _addFriendButton.Enabled = false;

            _viewBag.UpdateFriendList();
        }
    }

    private TableLayoutPanel _usersTable;
    private TextBox _usernameInput;
    private Button _searchButton;

    public FindFriendView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._usernameInput = new System.Windows.Forms.TextBox();
        this._usersTable = new System.Windows.Forms.TableLayoutPanel();
        this._searchButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // _searchButton
        // 
        this._searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._searchButton.FlatAppearance.BorderSize = 0;
        this._searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._searchButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._searchButton.Location = new System.Drawing.Point(388, 68);
        this._searchButton.Name = "_searchButton";
        this._searchButton.Size = new System.Drawing.Size(159, 28);
        this._searchButton.TabIndex = 24;
        this._searchButton.Text = CurrentSessionController.Session.Language.GetString("Search")!;
        this._searchButton.UseVisualStyleBackColor = false;
        this._searchButton.Click += _searchButton_Click;
        // 
        // _usernameInput
        // 
        this._usernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this._usernameInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._usernameInput.ForeColor = System.Drawing.Color.White;
        this._usernameInput.Location = new System.Drawing.Point(170, 68);
        this._usernameInput.Name = "_usernameInput";
        this._usernameInput.Size = new System.Drawing.Size(213, 28);
        this._usernameInput.TabIndex = 22;
        // 
        // _usersTable
        // 
        this._usersTable.AutoSize = true;
        this._usersTable.ColumnCount = 1;
        this._usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        this._usersTable.Location = new System.Drawing.Point(170, 102);
        this._usersTable.Name = "_usersTable";
        this._usersTable.Size = new System.Drawing.Size(377, 449);
        this._usersTable.TabIndex = 23;
        this._usersTable.HorizontalScroll.Maximum = 0;
        this._usersTable.AutoScroll = false;
        this._usersTable.VerticalScroll.Visible = false;
        this._usersTable.AutoScroll = true;
        this._usersTable.Scroll += _usersTable_Scroll;

        this.AutoScroll = true;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this.Controls.Add(this._searchButton);
        this.Controls.Add(this._usernameInput);
        this.Controls.Add(this._usersTable);
        this.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Location = new System.Drawing.Point(178, 0);
        this.Name = "panel1";
        this.Size = new System.Drawing.Size(918, 1241);
        this.TabIndex = 5;
        this._usersTable.ResumeLayout(false);
        this._usersTable.PerformLayout();
    }

    private void _usersTable_Scroll(object? sender, ScrollEventArgs e)
    {
        VScrollProperties vs = _usersTable.VerticalScroll;
        if (e.NewValue == vs.Maximum - vs.LargeChange + 1)
        {
            FillDataGrid();
        }
    }

    private void _searchButton_Click(object? sender, EventArgs e)
    {
        ClearDataGrid();
        FillDataGrid();
    }

    private void ClearDataGrid()
    {
        _usersTable.RowCount = 0;
        _usersTable.RowStyles.Clear();
        _usersTable.Controls.Clear();
    }

    private async Task FillDataGrid()
    {
        string username = _usernameInput.Text;
        int skip = _usersTable.RowCount;
        List<UserWithProfilePicture> usersWithProfilePictures = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(FriendsController), "FindUsers", new object[] { username, skip })
                    as List<UserWithProfilePicture>)!;

        for (int i = 0; i < usersWithProfilePictures.Count; i++)
        {
            var user = usersWithProfilePictures[i].User;
            var profilePicture = usersWithProfilePictures[i].ProfilePicture;

            _usersTable.RowCount++;

            RowStyle style = new RowStyle();
            style.SizeType = SizeType.AutoSize;

            _usersTable.RowStyles.Add(style);

            UserRow row = new UserRow()
            {
                Picture = profilePicture,
                Username = user.Username.Value,
                User = user,
                AlreadyFriends = ((List<User>)ViewBag.Friends).Any(u => u.Id == user.Id),
                ViewBag = ViewBag
            };
            row.InitializeComponent();

            _usersTable.Controls.Add(row, _usersTable.RowCount - 1, 0);
        }
    }
}