using CourseProject.UI.Models;
using CourseProject.UI.StaticData;

namespace CourseProject.UI
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this._menuPanel = new System.Windows.Forms.Panel();
            this._redoButton = new System.Windows.Forms.PictureBox();
            this._undoButton = new System.Windows.Forms.PictureBox();
            this.accountPicture = new System.Windows.Forms.PictureBox();
            this._accountLink = new System.Windows.Forms.LinkLabel();
            this._friendsLink = new System.Windows.Forms.LinkLabel();
            this._myGamesLink = new System.Windows.Forms.LinkLabel();
            this._libraryLink = new System.Windows.Forms.LinkLabel();
            this._storeLink = new System.Windows.Forms.LinkLabel();
            this._currentViewPanel = new System.Windows.Forms.Panel();
            this._addNewGameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._commentInput = new System.Windows.Forms.RichTextBox();
            this._addCommentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._commentsTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.testComment = new System.Windows.Forms.RichTextBox();
            this.testDate = new System.Windows.Forms.Label();
            this.testUsername = new System.Windows.Forms.Label();
            this.testPictureBox = new System.Windows.Forms.PictureBox();
            this._firendsThatAlsoPlayTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._downloadButton = new System.Windows.Forms.Button();
            this._descriptionOutput = new System.Windows.Forms.RichTextBox();
            this._gameIcon = new System.Windows.Forms.PictureBox();
            this._gamesListBox = new System.Windows.Forms.ListBox();
            this._menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._redoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._undoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicture)).BeginInit();
            this._currentViewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this._commentsTable.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._gameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuPanel
            // 
            this._menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this._menuPanel.Controls.Add(this._redoButton);
            this._menuPanel.Controls.Add(this._undoButton);
            this._menuPanel.Controls.Add(this.accountPicture);
            this._menuPanel.Controls.Add(this._accountLink);
            this._menuPanel.Controls.Add(this._friendsLink);
            this._menuPanel.Controls.Add(this._myGamesLink);
            this._menuPanel.Controls.Add(this._libraryLink);
            this._menuPanel.Controls.Add(this._storeLink);
            this._menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._menuPanel.Location = new System.Drawing.Point(0, 0);
            this._menuPanel.Name = "_menuPanel";
            this._menuPanel.Size = new System.Drawing.Size(1096, 46);
            this._menuPanel.TabIndex = 8;
            // 
            // _redoButton
            // 
            this._redoButton.Image = ((System.Drawing.Image)(resources.GetObject("_redoButton.Image")));
            this._redoButton.Location = new System.Drawing.Point(41, 15);
            this._redoButton.Name = "_redoButton";
            this._redoButton.Size = new System.Drawing.Size(20, 20);
            this._redoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._redoButton.TabIndex = 7;
            this._redoButton.TabStop = false;
            // 
            // _undoButton
            // 
            this._undoButton.Image = ((System.Drawing.Image)(resources.GetObject("_undoButton.Image")));
            this._undoButton.InitialImage = null;
            this._undoButton.Location = new System.Drawing.Point(14, 15);
            this._undoButton.Name = "_undoButton";
            this._undoButton.Size = new System.Drawing.Size(20, 20);
            this._undoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._undoButton.TabIndex = 6;
            this._undoButton.TabStop = false;
            // 
            // accountPicture
            // 
            this.accountPicture.Location = new System.Drawing.Point(944, 15);
            this.accountPicture.Name = "accountPicture";
            this.accountPicture.Size = new System.Drawing.Size(20, 20);
            this.accountPicture.TabIndex = 5;
            this.accountPicture.TabStop = false;
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
            this._accountLink.Text = "Friends";
            this._accountLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // _friendsLink
            // 
            this._friendsLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
            this._friendsLink.AutoSize = true;
            this._friendsLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._friendsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this._friendsLink.LinkColor = System.Drawing.Color.White;
            this._friendsLink.Location = new System.Drawing.Point(361, 11);
            this._friendsLink.Name = "_friendsLink";
            this._friendsLink.Size = new System.Drawing.Size(76, 27);
            this._friendsLink.TabIndex = 3;
            this._friendsLink.TabStop = true;
            this._friendsLink.Text = "Friends";
            this._friendsLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // _myGamesLink
            // 
            this._myGamesLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
            this._myGamesLink.AutoSize = true;
            this._myGamesLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._myGamesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this._myGamesLink.LinkColor = System.Drawing.Color.White;
            this._myGamesLink.Location = new System.Drawing.Point(246, 11);
            this._myGamesLink.Name = "_myGamesLink";
            this._myGamesLink.Size = new System.Drawing.Size(104, 27);
            this._myGamesLink.TabIndex = 2;
            this._myGamesLink.TabStop = true;
            this._myGamesLink.Text = "My Games";
            this._myGamesLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // _libraryLink
            // 
            this._libraryLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(228)))));
            this._libraryLink.AutoSize = true;
            this._libraryLink.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._libraryLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this._libraryLink.LinkColor = System.Drawing.Color.White;
            this._libraryLink.Location = new System.Drawing.Point(156, 11);
            this._libraryLink.Name = "_libraryLink";
            this._libraryLink.Size = new System.Drawing.Size(74, 27);
            this._libraryLink.TabIndex = 1;
            this._libraryLink.TabStop = true;
            this._libraryLink.Text = "Library";
            this._libraryLink.VisitedLinkColor = System.Drawing.Color.White;
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
            this._storeLink.Text = "Store";
            this._storeLink.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // _currentViewPanel
            // 
            this._currentViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this._currentViewPanel.Controls.Add(this._addNewGameButton);
            this._currentViewPanel.Controls.Add(this.panel1);
            this._currentViewPanel.Controls.Add(this._gamesListBox);
            this._currentViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._currentViewPanel.Location = new System.Drawing.Point(0, 46);
            this._currentViewPanel.Name = "_currentViewPanel";
            this._currentViewPanel.Size = new System.Drawing.Size(1096, 1241);
            this._currentViewPanel.TabIndex = 9;
            // 
            // _addNewGameButton
            // 
            this._addNewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this._addNewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addNewGameButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._addNewGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this._addNewGameButton.Location = new System.Drawing.Point(1, 583);
            this._addNewGameButton.Name = "_addNewGameButton";
            this._addNewGameButton.Size = new System.Drawing.Size(175, 30);
            this._addNewGameButton.TabIndex = 6;
            this._addNewGameButton.Text = "Add New Game";
            this._addNewGameButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this._commentInput);
            this.panel1.Controls.Add(this._addCommentButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._commentsTable);
            this.panel1.Controls.Add(this._firendsThatAlsoPlayTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._downloadButton);
            this.panel1.Controls.Add(this._descriptionOutput);
            this.panel1.Controls.Add(this._gameIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 1241);
            this.panel1.TabIndex = 5;
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
            this._addCommentButton.Text = "Add your comment";
            this._addCommentButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "COMMENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "ABOUT THIS GAME";
            // 
            // _commentsTable
            // 
            this._commentsTable.ColumnCount = 1;
            this._commentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._commentsTable.Controls.Add(this.panel2, 0, 1);
            this._commentsTable.Location = new System.Drawing.Point(43, 896);
            this._commentsTable.Name = "_commentsTable";
            this._commentsTable.RowCount = 2;
            this._commentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._commentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._commentsTable.Size = new System.Drawing.Size(583, 256);
            this._commentsTable.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.testComment);
            this.panel2.Controls.Add(this.testDate);
            this.panel2.Controls.Add(this.testUsername);
            this.panel2.Controls.Add(this.testPictureBox);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 250);
            this.panel2.TabIndex = 0;
            // 
            // testComment
            // 
            this.testComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.testComment.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testComment.ForeColor = System.Drawing.Color.White;
            this.testComment.Location = new System.Drawing.Point(3, 61);
            this.testComment.Name = "testComment";
            this.testComment.Size = new System.Drawing.Size(574, 186);
            this.testComment.TabIndex = 18;
            this.testComment.Text = "";
            // 
            // testDate
            // 
            this.testDate.AutoSize = true;
            this.testDate.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(68)))), ((int)(((byte)(91)))));
            this.testDate.Location = new System.Drawing.Point(481, 9);
            this.testDate.Name = "testDate";
            this.testDate.Size = new System.Drawing.Size(81, 20);
            this.testDate.TabIndex = 17;
            this.testDate.Text = "12.12.2005";
            // 
            // testUsername
            // 
            this.testUsername.AutoSize = true;
            this.testUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(186)))), ((int)(((byte)(228)))));
            this.testUsername.Location = new System.Drawing.Point(49, 9);
            this.testUsername.Name = "testUsername";
            this.testUsername.Size = new System.Drawing.Size(71, 20);
            this.testUsername.TabIndex = 16;
            this.testUsername.Text = "Username";
            // 
            // testPictureBox
            // 
            this.testPictureBox.Location = new System.Drawing.Point(3, 3);
            this.testPictureBox.Name = "testPictureBox";
            this.testPictureBox.Size = new System.Drawing.Size(30, 30);
            this.testPictureBox.TabIndex = 0;
            this.testPictureBox.TabStop = false;
            // 
            // _firendsThatAlsoPlayTable
            // 
            this._firendsThatAlsoPlayTable.AutoSize = true;
            this._firendsThatAlsoPlayTable.ColumnCount = 2;
            this._firendsThatAlsoPlayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._firendsThatAlsoPlayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._firendsThatAlsoPlayTable.Location = new System.Drawing.Point(661, 272);
            this._firendsThatAlsoPlayTable.Name = "_firendsThatAlsoPlayTable";
            this._firendsThatAlsoPlayTable.RowCount = 1;
            this._firendsThatAlsoPlayTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._firendsThatAlsoPlayTable.Size = new System.Drawing.Size(187, 331);
            this._firendsThatAlsoPlayTable.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Friends that also play:";
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
            this._downloadButton.Text = "Download Now";
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
            this._descriptionOutput.Text = "";
            // 
            // _gameIcon
            // 
            this._gameIcon.Image = ((System.Drawing.Image)(resources.GetObject("_gameIcon.Image")));
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
            this._gamesListBox.Items.AddRange(new object[] {
            "Titanfall 2",
            "Minecraft",
            "Spiderman"});
            this._gamesListBox.Location = new System.Drawing.Point(0, 0);
            this._gamesListBox.Name = "_gamesListBox";
            this._gamesListBox.Size = new System.Drawing.Size(178, 1241);
            this._gamesListBox.TabIndex = 4;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1096, 1287);
            this.Controls.Add(this._currentViewPanel);
            this.Controls.Add(this._menuPanel);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this._menuPanel.ResumeLayout(false);
            this._menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._redoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._undoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicture)).EndInit();
            this._currentViewPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._commentsTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._gameIcon)).EndInit();
            this.ResumeLayout(false);

        }


        private ComboBox _roleComboBox;
        private Label _label5;
        #endregion

        private Panel _menuPanel;
        private PictureBox _redoButton;
        private PictureBox _undoButton;
        private PictureBox accountPicture;
        private LinkLabel _accountLink;
        private LinkLabel _friendsLink;
        private LinkLabel _myGamesLink;
        private LinkLabel _libraryLink;
        private LinkLabel _storeLink;
        private Panel _currentViewPanel;
        private Panel panel1;
        private PictureBox _gameIcon;
        private ListBox _gamesListBox;
        private Button _downloadButton;
        private RichTextBox _descriptionOutput;
        private Button _addNewGameButton;
        private TableLayoutPanel _commentsTable;
        private TableLayoutPanel _firendsThatAlsoPlayTable;
        private Label label1;
        private Button _addCommentButton;
        private Label label3;
        private Label label2;
        private RichTextBox _commentInput;
        private Panel panel2;
        private Label testUsername;
        private PictureBox testPictureBox;
        private RichTextBox testComment;
        private Label testDate;
    }
}