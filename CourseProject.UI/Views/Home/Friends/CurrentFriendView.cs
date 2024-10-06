using CourseProject.Domain.Entities;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home.Friends;

internal class CurrentFriendView : BaseMinimizeView
{
    private PictureBox _profilePicture;
    private TableLayoutPanel _friendsTable;
    private Label _label1;
    private Label _label2;
    private TextBox _usernameOutput;
    private Label _label4;
    private TableLayoutPanel _gamesTable;
    private TextBox _realNameOutput;
    private Label _label7;

    private User _currentFriend;

    public CurrentFriendView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        _currentFriend = ViewBag.CurrentFriend;

        _usernameOutput = new TextBox();
        _label4 = new Label();
        _label2 = new Label();
        _friendsTable = new TableLayoutPanel();
        _label1 = new Label();
        _profilePicture = new PictureBox();
        _realNameOutput = new TextBox();
        _label7 = new Label();
        _gamesTable = new TableLayoutPanel();
        SuspendLayout();
        // 
        // _usernameOutput
        // 
        _usernameOutput.BackColor = Color.FromArgb(34, 58, 76);
        _usernameOutput.BorderStyle = BorderStyle.FixedSingle;
        _usernameOutput.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        _usernameOutput.ForeColor = Color.White;
        _usernameOutput.Location = new Point(263, 33);
        _usernameOutput.Name = "_usernameOutput";
        _usernameOutput.ReadOnly = true;
        _usernameOutput.Size = new Size(213, 28);
        _usernameOutput.TabIndex = 20;
        _usernameOutput.Text = _currentFriend.Username;
        // 
        // _label4
        // 
        _label4.AutoSize = true;
        _label4.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        _label4.ForeColor = Color.White;
        _label4.Location = new Point(170, 35);
        _label4.Name = "_label4";
        _label4.Size = new Size(87, 22);
        _label4.TabIndex = 19;
        _label4.Text = CurrentSessionController.Session.Language.GetString("Username")! + ":";
        // 
        // _label2
        // 
        _label2.AutoSize = true;
        _label2.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        _label2.ForeColor = Color.White;
        _label2.Location = new Point(43, 238);
        _label2.Name = "_label2";
        _label2.Size = new Size(186, 22);
        _label2.TabIndex = 14;
        _label2.Text = CurrentSessionController.Session.Language.GetString("GamesTheFriendPlays")! + ":";
        // 
        // _gamesTable
        // 
        _gamesTable.AutoSize = true;
        _gamesTable.ColumnCount = 1;
        _gamesTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        _gamesTable.Location = new Point(42, 284);
        _gamesTable.Name = "_gamesTable";
        _gamesTable.TabIndex = 23;
        // 
        // _friendsTable
        // 
        _friendsTable.AutoSize = true;
        _friendsTable.ColumnCount = 1;
        _friendsTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        _friendsTable.Location = new Point(661, 272);
        _friendsTable.Name = "_firendsTable";
        _friendsTable.TabIndex = 12;
        // 
        // _label1
        // 
        _label1.AutoSize = true;
        _label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        _label1.ForeColor = Color.White;
        _label1.Location = new Point(661, 238);
        _label1.Name = "_label1";
        _label1.Size = new Size(149, 22);
        _label1.TabIndex = 11;
        _label1.Text = CurrentSessionController.Session.Language.GetString("FriendsOfAFriend")! + ":";
        // 
        // _profilePicture
        // 
        _profilePicture.Image = ViewBag.ProfilePicture;
        _profilePicture.Location = new Point(49, 35);
        _profilePicture.Name = "_profilePicture";
        _profilePicture.Size = new Size(100, 100);
        _profilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
        _profilePicture.TabIndex = 5;
        _profilePicture.TabStop = false;
        // 
        // _realNameOutput
        // 
        _realNameOutput.BackColor = Color.FromArgb(34, 58, 76);
        _realNameOutput.BorderStyle = BorderStyle.FixedSingle;
        _realNameOutput.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        _realNameOutput.ForeColor = Color.White;
        _realNameOutput.Location = new Point(263, 87);
        _realNameOutput.Name = "_realNameOutput";
        _realNameOutput.ReadOnly = true;
        _realNameOutput.Size = new Size(213, 28);
        _realNameOutput.TabIndex = 22;

        if (_currentFriend.FirstName is null && _currentFriend.SecondName is null)
        {
            _realNameOutput.Text = CurrentSessionController.Session.Language.GetString("Unknown")!;
        }
        else
        {
            if (_currentFriend.FirstName is null)
            {
                _realNameOutput.Text = _currentFriend.SecondName!.Value;
            }
            else if (_currentFriend.SecondName is null)
            {
                _realNameOutput.Text = _currentFriend.FirstName!.Value;
            }
            else
            {
                _realNameOutput.Text = $"{_currentFriend.FirstName!.Value} {_currentFriend.SecondName!.Value}";
            }
        }
        // 
        // _label7
        // 
        _label7.AutoSize = true;
        _label7.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
        _label7.ForeColor = Color.White;
        _label7.Location = new Point(170, 89);
        _label7.Name = "_label7";
        _label7.Size = new Size(99, 22);
        _label7.TabIndex = 21;
        _label7.Text = CurrentSessionController.Session.Language.GetString("RealName")! + ":";

        AutoScroll = true;
        BackColor = Color.FromArgb(16, 24, 34);
        PerformLayout();
        Controls.Add(_gamesTable);
        Controls.Add(_realNameOutput);
        Controls.Add(_label7);
        Controls.Add(_usernameOutput);
        Controls.Add(_label4);
        Controls.Add(_label2);
        Controls.Add(_friendsTable);
        Controls.Add(_label1);
        Controls.Add(_profilePicture);
        ResumeLayout(false);
        Dock = DockStyle.Fill;
        Location = new Point(178, 0);
        Name = "panel1";
        Size = new Size(918, 1241);
        TabIndex = 5;

        FillDataGrids();
    }

    private async Task FillDataGrids()
    {
        await FillFriendsGrid();
        await FillGamesGrid();
    }

    private async Task FillFriendsGrid()
    {
        List<UserWithProfilePicture> friendsWithPictures = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(FriendsController), "GetNextFriends", new object[] { _currentFriend })
                    as List<UserWithProfilePicture>)!;

        for (int i = 0; i < friendsWithPictures.Count; i++)
        {
            var user = friendsWithPictures[i].User;
            var profilePicture = friendsWithPictures[i].ProfilePicture;

            _friendsTable.RowCount++;

            RowStyle style = new RowStyle();
            style.SizeType = SizeType.AutoSize;

            _friendsTable.RowStyles.Add(style);

            var friendPictureBox = new PictureBox()
            {
                Image = profilePicture,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(30, 30)
            };

            var friendUsername = new Label()
            {
                Text = user.Username.Value,
                Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 5)
            };

            var panel = new Panel()
            {
                AutoSize = true
            };
            panel.Controls.Add(friendPictureBox);
            panel.Controls.Add(friendUsername);

            _friendsTable.Controls.Add(panel, 0, _friendsTable.RowCount - 1);
        }
    }

    private async Task FillGamesGrid()
    {
        List<GameModelWithImage> GamesWithIcons = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(FriendsController), "GetNextGames", new object[] { _currentFriend })
                    as List<GameModelWithImage>)!;

        for (int i = 0; i < GamesWithIcons.Count; i++)
        {
            var game = GamesWithIcons[i].Game;
            var gameIcon = GamesWithIcons[i].Icon;

            _gamesTable.RowCount++;

            RowStyle style = new RowStyle();
            style.SizeType = SizeType.AutoSize;

            _gamesTable.RowStyles.Add(style);

            var gamePictureBox = new PictureBox()
            {
                Image = gameIcon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(125, 50)
            };

            var gameTitle = new Label()
            {
                Text = game.Title.Value,
                Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.White,
                Size = new Size(200, 20),
                Location = new Point(135, 15)
            };

            var panel = new Panel()
            {
                Size = new Size(500, 60)
            };
            panel.Controls.Add(gamePictureBox);
            panel.Controls.Add(gameTitle);

            _gamesTable.Controls.Add(panel, _gamesTable.RowCount - 1, 0);
        }
    }
}
