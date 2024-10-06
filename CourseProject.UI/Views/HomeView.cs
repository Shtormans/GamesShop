using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using CourseProject.UI.Views.Home;
using CourseProject.UI.Views.Home.Friends;
using CourseProject.UI.Views.Home.Settings;

namespace CourseProject.UI.Views;

internal class HomeView : BaseFullScreenView
{
    private Panel _menuPanel;
    private PictureBox _redoButton;
    private PictureBox _undoButton;
    private PictureBox _accountPicture;
    private LinkLabel _accountLink;
    private LinkLabel _friendsLink;
    private LinkLabel _myGamesLink;
    private LinkLabel _libraryLink;
    private LinkLabel _storeLink;
    private ChangeableMinimizeView _changeableMinimizeView;

    public HomeView(ViewBag viewbag)
        : base(viewbag)
    {

    }

    protected override void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
        this._menuPanel = new System.Windows.Forms.Panel();
        this._storeLink = new System.Windows.Forms.LinkLabel();
        this._libraryLink = new System.Windows.Forms.LinkLabel();
        this._myGamesLink = new System.Windows.Forms.LinkLabel();
        this._friendsLink = new System.Windows.Forms.LinkLabel();
        this._accountLink = new System.Windows.Forms.LinkLabel();
        this._accountPicture = new System.Windows.Forms.PictureBox();
        this._undoButton = new System.Windows.Forms.PictureBox();
        this._redoButton = new System.Windows.Forms.PictureBox();
        this._menuPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this._accountPicture)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this._undoButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this._redoButton)).BeginInit();
        this.SuspendLayout();
        // 
        // _menuPanel
        // 
        this._menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
        this._menuPanel.Controls.Add(this._redoButton);
        this._menuPanel.Controls.Add(this._undoButton);
        this._menuPanel.Controls.Add(this._accountPicture);
        this._menuPanel.Controls.Add(this._accountLink);
        this._menuPanel.Controls.Add(this._friendsLink);
        this._menuPanel.Controls.Add(this._myGamesLink);
        this._menuPanel.Controls.Add(this._libraryLink);
        this._menuPanel.Controls.Add(this._storeLink);
        this._menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
        this._menuPanel.Location = new System.Drawing.Point(0, 0);
        this._menuPanel.Name = "_menuPanel";
        this._menuPanel.Size = new System.Drawing.Size(1088, 46);
        this._menuPanel.TabIndex = 8;
        // 
        // _storeLink
        // 
        this._storeLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
        this._storeLink.AutoSize = true;
        this._storeLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._storeLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        this._storeLink.LinkColor = System.Drawing.Color.White;
        this._storeLink.Location = new System.Drawing.Point(85, 11);
        this._storeLink.Name = "_storeLink";
        this._storeLink.Size = new System.Drawing.Size(56, 27);
        this._storeLink.TabIndex = 0;
        this._storeLink.TabStop = true;
        this._storeLink.Text = CurrentSessionController.Session.Language.GetString("Store")!;
        this._storeLink.VisitedLinkColor = System.Drawing.Color.White;
        this._storeLink.LinkClicked += _storeLink_LinkClicked;
        // 
        // _libraryLink
        // 
        this._libraryLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
        this._libraryLink.AutoSize = true;
        this._libraryLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._libraryLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        this._libraryLink.LinkColor = System.Drawing.Color.White;
        this._libraryLink.Location = new System.Drawing.Point(180, 11);
        this._libraryLink.Name = "_libraryLink";
        this._libraryLink.Size = new System.Drawing.Size(74, 27);
        this._libraryLink.TabIndex = 1;
        this._libraryLink.TabStop = true;
        this._libraryLink.Text = CurrentSessionController.Session.Language.GetString("Library")!;
        this._libraryLink.VisitedLinkColor = System.Drawing.Color.White;
        this._libraryLink.LinkClicked += _libraryLink_LinkClicked;
        // 
        // _myGamesLink
        // 
        this._myGamesLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
        this._myGamesLink.AutoSize = true;
        this._myGamesLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._myGamesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        this._myGamesLink.LinkColor = System.Drawing.Color.White;
        this._myGamesLink.Location = new System.Drawing.Point(295, 11);
        this._myGamesLink.Name = "_myGamesLink";
        this._myGamesLink.Size = new System.Drawing.Size(104, 27);
        this._myGamesLink.TabIndex = 2;
        this._myGamesLink.TabStop = true;
        this._myGamesLink.Text = CurrentSessionController.Session.Language.GetString("MyGames")!;
        this._myGamesLink.VisitedLinkColor = System.Drawing.Color.White;
        this._myGamesLink.LinkClicked += _myGamesLink_LinkClicked;
        // 
        // _friendsLink
        // 
        this._friendsLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
        this._friendsLink.AutoSize = true;
        this._friendsLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._friendsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        this._friendsLink.LinkColor = System.Drawing.Color.White;
        this._friendsLink.Location = new System.Drawing.Point(400, 11);
        this._friendsLink.Name = "_friendsLink";
        this._friendsLink.Size = new System.Drawing.Size(76, 27);
        this._friendsLink.TabIndex = 3;
        this._friendsLink.TabStop = true;
        this._friendsLink.Text = CurrentSessionController.Session.Language.GetString("Friends")!;
        this._friendsLink.VisitedLinkColor = System.Drawing.Color.White;
        this._friendsLink.LinkClicked += _friendsLink_LinkClicked;
        // 
        // _accountLink
        // 
        this._accountLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
        this._accountLink.AutoSize = true;
        this._accountLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this._accountLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        this._accountLink.LinkColor = System.Drawing.Color.White;
        this._accountLink.Location = new System.Drawing.Point(967, 11);
        this._accountLink.Name = "_accountLink";
        this._accountLink.Size = new System.Drawing.Size(76, 27);
        this._accountLink.TabIndex = 4;
        this._accountLink.TabStop = true;
        this._accountLink.Text = ViewBag.Username;
        this._accountLink.VisitedLinkColor = System.Drawing.Color.White;
        this._accountLink.LinkClicked += _accountLink_LinkClicked;
        // 
        // accountPicture
        // 
        this._accountPicture.Location = new System.Drawing.Point(944, 15);
        this._accountPicture.Name = "accountPicture";
        this._accountPicture.Size = new System.Drawing.Size(20, 20);
        this._accountPicture.TabIndex = 5;
        this._accountPicture.TabStop = false;
        this._accountPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        this._accountPicture.Image = ViewBag.AccountPicture;
        this._accountPicture.Click += _accountPicture_Click;
        // 
        // _undoButton
        // 
        this._undoButton.Image = (System.Drawing.Image)resources.GetObject("_undoButton.Image")!;
        this._undoButton.InitialImage = null;
        this._undoButton.Location = new System.Drawing.Point(14, 15);
        this._undoButton.Name = "_undoButton";
        this._undoButton.Size = new System.Drawing.Size(20, 20);
        this._undoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this._undoButton.TabIndex = 6;
        this._undoButton.TabStop = false;
        // 
        // _redoButton
        // 
        this._redoButton.Image = (System.Drawing.Image)resources.GetObject("_redoButton.Image")!;
        this._redoButton.Location = new System.Drawing.Point(41, 15);
        this._redoButton.Name = "_redoButton";
        this._redoButton.Size = new System.Drawing.Size(20, 20);
        this._redoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this._redoButton.TabIndex = 7;
        this._redoButton.TabStop = false;
        // 
        // _changeableMinimizeView
        // 
        _changeableMinimizeView = new();
        _changeableMinimizeView.SetView(new StoreView(ViewBag));

        this.Controls.Add(this._changeableMinimizeView);
        this.Controls.Add(this._menuPanel);
        this._menuPanel.ResumeLayout(false);
        this._menuPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this._accountPicture).EndInit();
        ((System.ComponentModel.ISupportInitialize)this._undoButton).EndInit();
        ((System.ComponentModel.ISupportInitialize)this._redoButton).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

        ChangeViewAction = ChangeView;
        ViewBag.ChangeView = ChangeViewAction;
    }

    public Action<BaseMinimizeView> ChangeViewAction;

    private void ChangeView(BaseMinimizeView view)
    {
        _changeableMinimizeView.SetView(view);
    }

    private void _accountLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        _changeableMinimizeView.SetView(new SettingsView(ViewBag));
    }

    private void _accountPicture_Click(object? sender, EventArgs e)
    {
        _changeableMinimizeView.SetView(new SettingsView(ViewBag));
    }

    private void _friendsLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        _changeableMinimizeView.SetView(new FriendsView(ViewBag));
    }

    private void _myGamesLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        _changeableMinimizeView.SetView(new MyGamesView(ViewBag));
    }

    private void _libraryLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        _changeableMinimizeView.SetView(new LibraryView(ViewBag));
    }

    private void _storeLink_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        _changeableMinimizeView.SetView(new StoreView(ViewBag));
    }
}
