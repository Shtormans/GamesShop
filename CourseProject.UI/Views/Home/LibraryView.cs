using CourseProject.Domain.Entities;
using CourseProject.Domain.Shared;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home;

internal class LibraryView : BaseMinimizeView
{
    private class CommentRow : Panel
    {
        private PictureBox _profilePicture;
        private Label _authorName;
        private Label _creationDate;
        private RichTextBox _text;

        public Image Picture
        {
            init
            {
                _profilePicture = new PictureBox();
                _profilePicture.Image = value;
            }
        }

        public string AuthorName
        {
            init
            {
                _authorName = new Label();
                _authorName.Text = value;
            }
        }

        public string CreationDate
        {
            init
            {
                _creationDate = new Label();
                _creationDate.Text = value;
            }
        }

        public string Text
        {
            init
            {
                _text = new RichTextBox();
                _text.Text = value;
            }
        }

        public CommentRow InitializeComponent()
        {
            this._profilePicture.Location = new System.Drawing.Point(3, 3);
            this._profilePicture.Name = "testPictureBox";
            this._profilePicture.Size = new System.Drawing.Size(30, 30);
            this._profilePicture.TabIndex = 0;
            this._profilePicture.TabStop = false;
            this._profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this._authorName.AutoSize = true;
            this._authorName.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._authorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(228)))));
            this._authorName.Location = new System.Drawing.Point(49, 9);
            this._authorName.Name = "testUsername";
            this._authorName.Size = new System.Drawing.Size(71, 20);
            this._authorName.TabIndex = 16;

            this._creationDate.AutoSize = true;
            this._creationDate.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._creationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this._creationDate.Location = new System.Drawing.Point(441, 9);
            this._creationDate.Name = "testDate";
            this._creationDate.Size = new System.Drawing.Size(81, 60);
            this._creationDate.TabIndex = 17;

            this._text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this._text.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._text.ForeColor = System.Drawing.Color.White;
            this._text.Location = new System.Drawing.Point(3, 50);
            this._text.Name = "testComment";
            this._text.Size = new System.Drawing.Size(574, 100);
            this._text.TabIndex = 18;
            this._text.ReadOnly = true;

            this.Controls.Add(this._profilePicture);
            this.Controls.Add(this._authorName);
            this.Controls.Add(this._creationDate);
            this.Controls.Add(this._text);
            this.Size = new System.Drawing.Size(580, 200);

            return this;
        }
    }

    private PictureBox _gameIcon;
    private ListBox _gamesListBox;
    private Button _downloadButton;
    private RichTextBox _descriptionOutput;
    private TableLayoutPanel _commentsTable;
    private TableLayoutPanel _friendsThatAlsoPlayTable;
    private Label _label1;
    private Button _addCommentButton;
    private Label _label3;
    private Label _label2;
    private RichTextBox _commentInput;
    private Panel _gameInfoPanel;

    private List<Game> _userLibrary;

    public LibraryView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        this._commentsTable = new System.Windows.Forms.TableLayoutPanel();
        this._friendsThatAlsoPlayTable = new System.Windows.Forms.TableLayoutPanel();
        this._gameInfoPanel = new System.Windows.Forms.Panel();
        this._label1 = new System.Windows.Forms.Label();
        this._downloadButton = new System.Windows.Forms.Button();
        this._descriptionOutput = new System.Windows.Forms.RichTextBox();
        this._gameIcon = new System.Windows.Forms.PictureBox();
        this._gamesListBox = new System.Windows.Forms.ListBox();
        this._label2 = new System.Windows.Forms.Label();
        this._label3 = new System.Windows.Forms.Label();
        this._addCommentButton = new System.Windows.Forms.Button();
        this._commentInput = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        // 
        // _commentsTable
        // 
        this._commentsTable.AutoSize = true;
        this._commentsTable.ColumnCount = 1;
        this._commentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this._commentsTable.Location = new System.Drawing.Point(43, 896);
        this._commentsTable.Name = "_commentsTable";
        this._commentsTable.Size = new System.Drawing.Size(583, 256);
        this._commentsTable.TabIndex = 13;
        // 
        // _firendsThatAlsoPlayTable
        // 
        this._friendsThatAlsoPlayTable.AutoSize = true;
        this._friendsThatAlsoPlayTable.ColumnCount = 2;
        this._friendsThatAlsoPlayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        this._friendsThatAlsoPlayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
        this._friendsThatAlsoPlayTable.Location = new System.Drawing.Point(661, 272);
        this._friendsThatAlsoPlayTable.Name = "_firendsThatAlsoPlayTable";
        this._friendsThatAlsoPlayTable.TabIndex = 12;
        // 
        // label1
        // 
        this._label1.AutoSize = true;
        this._label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label1.ForeColor = System.Drawing.Color.White;
        this._label1.Location = new System.Drawing.Point(661, 238);
        this._label1.Name = "label1";
        this._label1.Size = new System.Drawing.Size(172, 22);
        this._label1.TabIndex = 11;
        this._label1.Text = CurrentSessionController.Session.Language.GetString("FriendsThatAlsoPlay")! + ":";
        // 
        // _downloadButton
        // 
        this._downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
        this._downloadButton.FlatAppearance.BorderSize = 0;
        this._downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._downloadButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._downloadButton.ForeColor = System.Drawing.Color.White;
        this._downloadButton.Location = new System.Drawing.Point(646, 35);
        this._downloadButton.Name = "_downloadButton";
        this._downloadButton.Size = new System.Drawing.Size(167, 63);
        this._downloadButton.TabIndex = 5;
        this._downloadButton.Text = CurrentSessionController.Session.Language.GetString("DownloadNow")!;
        this._downloadButton.UseVisualStyleBackColor = false;
        // 
        // _descriptionOutput
        // 
        this._descriptionOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this._descriptionOutput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._descriptionOutput.ForeColor = System.Drawing.Color.White;
        this._descriptionOutput.Location = new System.Drawing.Point(43, 272);
        this._descriptionOutput.Name = "_descriptionOutput";
        this._descriptionOutput.Size = new System.Drawing.Size(583, 255);
        this._descriptionOutput.TabIndex = 10;
        this._descriptionOutput.ReadOnly = true;
        // 
        // _gameIcon
        // 
        this._gameIcon.Location = new System.Drawing.Point(43, 6);
        this._gameIcon.Name = "_gameIcon";
        this._gameIcon.Size = new System.Drawing.Size(536, 172);
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
        this._gamesListBox.Size = new System.Drawing.Size(178, 1241);
        this._gamesListBox.TabIndex = 4;
        this._gamesListBox.SelectedIndexChanged += _gamesListBox_SelectedIndexChanged;
        // 
        // label2
        // 
        this._label2.AutoSize = true;
        this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label2.ForeColor = System.Drawing.Color.White;
        this._label2.Location = new System.Drawing.Point(43, 238);
        this._label2.Name = "label2";
        this._label2.Size = new System.Drawing.Size(145, 22);
        this._label2.TabIndex = 14;
        this._label2.Text = CurrentSessionController.Session.Language.GetString("AboutThisGame")!.ToUpper();
        // 
        // label3
        // 
        this._label3.AutoSize = true;
        this._label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._label3.ForeColor = System.Drawing.Color.White;
        this._label3.Location = new System.Drawing.Point(43, 587);
        this._label3.Name = "label3";
        this._label3.Size = new System.Drawing.Size(93, 22);
        this._label3.TabIndex = 15;
        this._label3.Text = CurrentSessionController.Session.Language.GetString("Comments")!.ToUpper();
        // 
        // _addCommentButton
        // 
        this._addCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._addCommentButton.FlatAppearance.BorderSize = 0;
        this._addCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._addCommentButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._addCommentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
        this._addCommentButton.Location = new System.Drawing.Point(43, 775);
        this._addCommentButton.Name = "_addCommentButton";
        this._addCommentButton.Size = new System.Drawing.Size(159, 34);
        this._addCommentButton.TabIndex = 16;
        this._addCommentButton.Text = CurrentSessionController.Session.Language.GetString("AddYourComment")!;
        this._addCommentButton.UseVisualStyleBackColor = false;
        this._addCommentButton.Click += _addCommentButton_Click;
        // 
        // _commentInput
        // 
        this._commentInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
        this._commentInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._commentInput.ForeColor = System.Drawing.Color.White;
        this._commentInput.Location = new System.Drawing.Point(43, 621);
        this._commentInput.Name = "_commentInput";
        this._commentInput.Size = new System.Drawing.Size(433, 136);
        this._commentInput.TabIndex = 17;
        this._commentInput.Text = "";
        // 
        // gameInfoPanel
        // 
        this._gameInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this._gameInfoPanel.Controls.Add(_gameIcon);
        this._gameInfoPanel.Controls.Add(_downloadButton);
        this._gameInfoPanel.Controls.Add(_descriptionOutput);
        this._gameInfoPanel.Controls.Add(_commentsTable);
        this._gameInfoPanel.Controls.Add(_friendsThatAlsoPlayTable);
        this._gameInfoPanel.Controls.Add(_label1);
        this._gameInfoPanel.Controls.Add(_addCommentButton);
        this._gameInfoPanel.Controls.Add(_label3);
        this._gameInfoPanel.Controls.Add(_label2);
        this._gameInfoPanel.Controls.Add(_commentInput);
        this._gameInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this._gameInfoPanel.Location = new System.Drawing.Point(178, 0);
        this._gameInfoPanel.Name = "panel1";
        this._gameInfoPanel.TabIndex = 5;
        this._gameInfoPanel.AutoScroll = true;
        this._gameInfoPanel.Visible = false;
        this._gameInfoPanel.Scroll += _gameInfoPanel_Scroll;

        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
        this.PerformLayout();
        this.Controls.Add(_gameInfoPanel);
        this.Controls.Add(_gamesListBox);
        this._gameInfoPanel.ResumeLayout(false);
        this._gameInfoPanel.PerformLayout();
        this.ResumeLayout(false);

        FillGamesListBox();
    }

    private void _gameInfoPanel_Scroll(object? sender, ScrollEventArgs e)
    {
        VScrollProperties vs = _gameInfoPanel.VerticalScroll;
        if (e.NewValue == vs.Maximum - vs.LargeChange + 1)
        {
            FillCommentsGrid();
        }
    }

    private async void _addCommentButton_Click(object? sender, EventArgs e)
    {
        int selectedIndex = _gamesListBox.SelectedIndex;
        var game = _userLibrary[selectedIndex];
        string commentText = _commentInput.Text;

        Result result = (await UIManager
                .Instance
                .UseMethodAsync(nameof(LibraryController), "CreateComment", new object[] { game, commentText })
                as Result)!;

        if (result.IsFailure)
        {
            await UIManager.Instance.ShowErrorMessage(result.Error.Message);
        }
        else
        {
            ClearComments();
            FillCommentsGrid();

            this._commentInput.Text = string.Empty;
        }
    }

    private async void _gamesListBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        int selectedIndex = _gamesListBox.SelectedIndex;
        if (_gamesListBox.SelectedIndex == -1)
        {
            return;
        }

        if (!this._gameInfoPanel.Visible)
        {
            this._gameInfoPanel.Visible = true;
        }

        var game = _userLibrary[selectedIndex];

        this._gameIcon.Image = (await UIManager
                .Instance
                .UseMethodAsync(nameof(LibraryController), "GetGameIcon", new object[] { game })
                as Image)!;

        this._descriptionOutput.Text = game.Description.Value;
        this._commentInput.Text = string.Empty;

        ClearDataGrids();

        await FillFriendsGrid();
        await FillCommentsGrid();
    }

    private void ClearComments()
    {
        _commentsTable.RowCount = 0;
        _commentsTable.RowStyles.Clear();
        _commentsTable.Controls.Clear();
    }

    private void ClearDataGrids()
    {
        ClearComments();

        _friendsThatAlsoPlayTable.RowCount = 0;
        _friendsThatAlsoPlayTable.RowStyles.Clear();
        _friendsThatAlsoPlayTable.Controls.Clear();
    }

    private async Task FillGamesListBox()
    {
        _userLibrary = (await UIManager
                .Instance
                .UseMethodAsync(nameof(LibraryController), "GetUserLibrary")
                as List<Game>)!;

        this._gamesListBox.Items.Clear();
        this._gamesListBox.Items.AddRange(
            _userLibrary.Select(g => g.Title.Value).ToArray()
        );
    }

    private async Task FillCommentsGrid()
    {
        int selectedIndex = _gamesListBox.SelectedIndex;
        var currentGame = _userLibrary[selectedIndex];
        int skip = _commentsTable.RowCount;

        List<CommentWithAuthorImage> comments = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(LibraryController), "GetNextComments", new object[] { currentGame, skip })
                    as List<CommentWithAuthorImage>)!;

        for (int i = 0; i < comments.Count; i++)
        {
            var comment = comments[i].Comment;
            var user = comments[i].Author;
            var profilePicture = comments[i].AuthorPicture;

            _commentsTable.RowCount++;

            RowStyle style = new RowStyle();
            style.SizeType = SizeType.AutoSize;

            _commentsTable.RowStyles.Add(style);

            CommentRow row = new CommentRow()
            {
                Picture = profilePicture,
                AuthorName = user.Username.Value,
                CreationDate = comment.CreationDate.DateInLocalTimeZone.ToString("G"),
                Text = comment.Text.Value
            };
            row.InitializeComponent();

            _commentsTable.Controls.Add(row, _commentsTable.RowCount - 1, 0);
        }
    }

    private async Task FillFriendsGrid()
    {
        int selectedIndex = _gamesListBox.SelectedIndex;
        var currentGame = _userLibrary[selectedIndex];

        List<UserWithProfilePicture> friendsWithPictures = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(LibraryController), "GetNextFriends", new object[] { currentGame })
                    as List<UserWithProfilePicture>)!;

        for (int i = 0; i < friendsWithPictures.Count; i++)
        {
            var user = friendsWithPictures[i].User;
            var profilePicture = friendsWithPictures[i].ProfilePicture;

            _friendsThatAlsoPlayTable.RowCount++;

            RowStyle style = new RowStyle();
            style.SizeType = SizeType.AutoSize;

            _friendsThatAlsoPlayTable.RowStyles.Add(style);

            var friendPictureBox = new PictureBox()
            {
                Image = profilePicture,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(30, 30)
            };

            var friendUsername = new Label()
            {
                Text = user.Username.Value,
                Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                ForeColor = Color.White,
                Location = new Point(0, 25)
            };

            _friendsThatAlsoPlayTable.Controls.Add(friendPictureBox, 0, _friendsThatAlsoPlayTable.RowCount - 1);
            _friendsThatAlsoPlayTable.Controls.Add(friendUsername, 1, _friendsThatAlsoPlayTable.RowCount - 1);
        }
    }
}
