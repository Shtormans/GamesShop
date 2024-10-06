using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;

namespace CourseProject.UI.Views.Home;

internal class BuyGameView : BaseMinimizeView
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
            this.Size = new System.Drawing.Size(580, 180);

            return this;
        }
    }

    private PictureBox _gameIcon;
    private Button _buyGameButton;
    private RichTextBox _descriptionOutput;
    private TableLayoutPanel _commentsTable;
    private TableLayoutPanel _friendsThatAlsoPlayTable;
    private Label _label1;
    private Label _label3;
    private Label _label2;

    private GameModelWithImage _currentGameModel;

    public BuyGameView(ViewBag viewbag)
        : base(viewbag)
    {
    }

    protected override void InitializeComponent()
    {
        _currentGameModel = ViewBag.GameModel;

        this._commentsTable = new System.Windows.Forms.TableLayoutPanel();
        this._friendsThatAlsoPlayTable = new System.Windows.Forms.TableLayoutPanel();
        this._label1 = new System.Windows.Forms.Label();
        this._buyGameButton = new System.Windows.Forms.Button();
        this._descriptionOutput = new System.Windows.Forms.RichTextBox();
        this._gameIcon = new System.Windows.Forms.PictureBox();
        this._label2 = new System.Windows.Forms.Label();
        this._label3 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // _commentsTable
        // 
        this._commentsTable.AutoSize = true;
        this._commentsTable.ColumnCount = 1;
        this._commentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this._commentsTable.Location = new System.Drawing.Point(43, 620);
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
        this._buyGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
        this._buyGameButton.FlatAppearance.BorderSize = 0;
        this._buyGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._buyGameButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._buyGameButton.ForeColor = System.Drawing.Color.White;
        this._buyGameButton.Location = new System.Drawing.Point(646, 35);
        this._buyGameButton.Name = "_downloadButton";
        this._buyGameButton.Size = new System.Drawing.Size(250, 40);
        this._buyGameButton.TabIndex = 5;
        this._buyGameButton.UseVisualStyleBackColor = false;
        this._buyGameButton.Click += _buyGameButton_Click;
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
        this._descriptionOutput.Text = _currentGameModel.Game.Description.Value;
        // 
        // _gameIcon
        // 
        this._gameIcon.Location = new System.Drawing.Point(43, 6);
        this._gameIcon.Name = "_gameIcon";
        this._gameIcon.Size = new System.Drawing.Size(536, 172);
        this._gameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this._gameIcon.TabIndex = 5;
        this._gameIcon.TabStop = false;
        this._gameIcon.Image = _currentGameModel.Icon;
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

        this.PerformLayout();
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
        this.Controls.Add(_gameIcon);
        this.Controls.Add(_buyGameButton);
        this.Controls.Add(_descriptionOutput);
        this.Controls.Add(_commentsTable);
        this.Controls.Add(_friendsThatAlsoPlayTable);
        this.Controls.Add(_label1);
        this.Controls.Add(_label3);
        this.Controls.Add(_label2);
        this.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Location = new System.Drawing.Point(178, 0);
        this.Name = "panel1";
        this.TabIndex = 5;
        this.AutoScroll = true;
        this.Scroll += BuyGameView_Scroll;
        this.ResumeLayout(false);

        FillDataGrids();
    }

    private async void _buyGameButton_Click(object? sender, EventArgs e)
    {
        await UIManager
            .Instance
            .UseMethodAsync(nameof(BuyGameController), "BuyGame", new object[] { _currentGameModel.Game });

        this._buyGameButton.Text = CurrentSessionController.Session.Language.GetString("AlreadyInYourLibrary")!;
        this._buyGameButton.Enabled = false;
    }

    private void BuyGameView_Scroll(object? sender, ScrollEventArgs e)
    {
        VScrollProperties vs = this.VerticalScroll;
        if (e.NewValue == vs.Maximum - vs.LargeChange + 1)
        {
            FillCommentsGrid();
        }
    }

    private async Task FillDataGrids()
    {
        bool alreadyBought = (bool)(await UIManager
                    .Instance
                    .UseMethodAsync(nameof(BuyGameController), "CheckIfGameIsAlreadyBought", new object[] { _currentGameModel.Game }))!;
        if (alreadyBought)
        {
            this._buyGameButton.Text = CurrentSessionController.Session.Language.GetString("AlreadyInYourLibrary")!;
            this._buyGameButton.Enabled = false;
        }
        else
        {
            Money price = _currentGameModel.Game.Price.ConvertTo(CurrentSessionController.Session.CurrencyType);
            this._buyGameButton.Text = $"{CurrentSessionController.Session.Language.GetString("BuyNowFor")!} {price}";
        }

        await FillCommentsGrid();
        await FillFriendsGrid();
    }

    private async Task FillCommentsGrid()
    {
        int skip = _commentsTable.RowCount;

        List<CommentWithAuthorImage> comments = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(BuyGameController), "GetNextComments", new object[] { _currentGameModel.Game, skip })
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
        List<UserWithProfilePicture> friendsWithPictures = (await UIManager
                    .Instance
                    .UseMethodAsync(nameof(BuyGameController), "GetNextFriends", new object[] { _currentGameModel.Game })
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
