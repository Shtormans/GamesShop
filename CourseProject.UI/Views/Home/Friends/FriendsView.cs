using CourseProject.Domain.Entities;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home.Friends;

internal class FriendsView : BaseMinimizeView
{
    private ChangeableMinimizeView _changeableMinimizeView;
    private ListBox _friendsListBox;
    private Button _addNewFriendButton;

    private List<User> _userFriends;

    public FriendsView(ViewBag viewbag)
        : base(viewbag)
    {
        _userFriends = new List<User>();
    }

    protected override async void InitializeComponent()
    {
        _addNewFriendButton = new Button();
        _friendsListBox = new ListBox();
        // 
        // _addNewFriendButton
        // 
        _addNewFriendButton.BackColor = Color.FromArgb(34, 58, 76);
        _addNewFriendButton.FlatStyle = FlatStyle.Flat;
        _addNewFriendButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
        _addNewFriendButton.ForeColor = Color.FromArgb(103, 193, 245);
        _addNewFriendButton.Location = new Point(1, 583);
        _addNewFriendButton.Name = "_addNewGameButton";
        _addNewFriendButton.Size = new Size(175, 30);
        _addNewFriendButton.TabIndex = 6;
        _addNewFriendButton.Text = CurrentSessionController.Session.Language.GetString("AddFriend")!;
        _addNewFriendButton.UseVisualStyleBackColor = false;
        _addNewFriendButton.Click += _addNewFriendButton_Click;
        // 
        // _gamesListBox
        // 
        _friendsListBox.BackColor = Color.FromArgb(32, 50, 68);
        _friendsListBox.Dock = DockStyle.Left;
        _friendsListBox.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
        _friendsListBox.ForeColor = Color.White;
        _friendsListBox.FormattingEnabled = true;
        _friendsListBox.ItemHeight = 20;
        _friendsListBox.Location = new Point(0, 0);
        _friendsListBox.Name = "_gamesListBox";
        _friendsListBox.Size = new Size(178, 1241);
        _friendsListBox.TabIndex = 4;
        _friendsListBox.SelectedIndexChanged += _friendsListBox_SelectedIndexChanged;
        // 
        // _changeableMinimizeView
        // 
        _changeableMinimizeView = new();

        Controls.Add(_changeableMinimizeView);
        BackColor = Color.FromArgb(32, 50, 68);
        Controls.Add(_addNewFriendButton);
        Controls.Add(_friendsListBox);
        Dock = DockStyle.Fill;
        Location = new Point(0, 46);
        Name = "_currentViewPanel";
        Size = new Size(1096, 1241);
        TabIndex = 9;

        await FillFriendsListBox();

        ViewBag.Friends = _userFriends;
        UpdateFriendListBoxAction = UpdateFriendListBox;
        ViewBag.UpdateFriendList = UpdateFriendListBoxAction;
        _changeableMinimizeView.SetView(new FindFriendView(ViewBag));
    }

    private Action UpdateFriendListBoxAction;

    private async void UpdateFriendListBox()
    {
        _friendsListBox.Items.Clear();

        await FillFriendsListBox();
    }

    private void _addNewFriendButton_Click(object? sender, EventArgs e)
    {
        ViewBag.Friends = _userFriends;

        _changeableMinimizeView.SetView(new FindFriendView(ViewBag));
    }

    private async void _friendsListBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        int selectedIndex = _friendsListBox.SelectedIndex;
        if (selectedIndex == -1)
        {
            return;
        }

        var friend = _userFriends[selectedIndex];

        var friendProfilePicture = (await UIManager
                .Instance
                .UseMethodAsync(nameof(FriendsController), "GetFriendProfilePicture", new object[] { friend })
                as Image)!;

        ViewBag.ProfilePicture = friendProfilePicture;
        ViewBag.CurrentFriend = friend;

        _changeableMinimizeView.SetView(new CurrentFriendView(ViewBag));
    }

    private async Task FillFriendsListBox()
    {
        var userFriends = (await UIManager
                .Instance
                .UseMethodAsync(nameof(FriendsController), "GetCurrentUserFriends")
                as List<User>)!;

        _userFriends.Clear();
        _userFriends.AddRange(userFriends);

        _friendsListBox.Items.Clear();
        _friendsListBox.Items.AddRange(
            _userFriends.Select(f => f.Username.Value).ToArray()
        );
    }
}
