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
            this._logOutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.commentInput = new System.Windows.Forms.RichTextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._usersTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._usernameInput = new System.Windows.Forms.TextBox();
            this._addCommentButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
            this._commentsTable = new System.Windows.Forms.TableLayoutPanel();
            this._profilePicture = new System.Windows.Forms.PictureBox();
            this._settingsListBox = new System.Windows.Forms.ListBox();
            this._menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._redoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._undoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPicture)).BeginInit();
            this._currentViewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this._usersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._profilePicture)).BeginInit();
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
            this._currentViewPanel.Controls.Add(this._logOutButton);
            this._currentViewPanel.Controls.Add(this.panel1);
            this._currentViewPanel.Controls.Add(this._settingsListBox);
            this._currentViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._currentViewPanel.Location = new System.Drawing.Point(0, 46);
            this._currentViewPanel.Name = "_currentViewPanel";
            this._currentViewPanel.Size = new System.Drawing.Size(1096, 1241);
            this._currentViewPanel.TabIndex = 9;
            // 
            // _logOutButton
            // 
            this._logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this._logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._logOutButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._logOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this._logOutButton.Location = new System.Drawing.Point(1, 583);
            this._logOutButton.Name = "_logOutButton";
            this._logOutButton.Size = new System.Drawing.Size(175, 30);
            this._logOutButton.TabIndex = 6;
            this._logOutButton.Text = "Log out";
            this._logOutButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.commentInput);
            this.panel1.Controls.Add(this._searchButton);
            this.panel1.Controls.Add(this._usersTable);
            this.panel1.Controls.Add(this._usernameInput);
            this.panel1.Controls.Add(this._addCommentButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._label2);
            this.panel1.Controls.Add(this._commentsTable);
            this.panel1.Controls.Add(this._profilePicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 1241);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(684, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 28;
            // 
            // commentInput
            // 
            this.commentInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.commentInput.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commentInput.ForeColor = System.Drawing.Color.White;
            this.commentInput.Location = new System.Drawing.Point(132, 662);
            this.commentInput.Name = "commentInput";
            this.commentInput.Size = new System.Drawing.Size(433, 136);
            this.commentInput.TabIndex = 17;
            this.commentInput.Text = "";
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
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = false;
            // 
            // _usersTable
            // 
            this._usersTable.AutoScroll = true;
            this._usersTable.AutoSize = true;
            this._usersTable.ColumnCount = 2;
            this._usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this._usersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._usersTable.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this._usersTable.Location = new System.Drawing.Point(170, 102);
            this._usersTable.Name = "_usersTable";
            this._usersTable.RowCount = 1;
            this._usersTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._usersTable.Size = new System.Drawing.Size(377, 449);
            this._usersTable.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(30, 0);
            this.tableLayoutPanel3.TabIndex = 13;
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
            // _addCommentButton
            // 
            this._addCommentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this._addCommentButton.FlatAppearance.BorderSize = 0;
            this._addCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addCommentButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._addCommentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(193)))), ((int)(((byte)(245)))));
            this._addCommentButton.Location = new System.Drawing.Point(68, 741);
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
            this.label3.Location = new System.Drawing.Point(134, 852);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "COMMENTS";
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._label2.ForeColor = System.Drawing.Color.White;
            this._label2.Location = new System.Drawing.Point(379, 843);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(186, 22);
            this._label2.TabIndex = 14;
            this._label2.Text = "Games, the friend plays:";
            // 
            // _commentsTable
            // 
            this._commentsTable.ColumnCount = 1;
            this._commentsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._commentsTable.Location = new System.Drawing.Point(123, 893);
            this._commentsTable.Name = "_commentsTable";
            this._commentsTable.RowCount = 2;
            this._commentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._commentsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._commentsTable.Size = new System.Drawing.Size(583, 256);
            this._commentsTable.TabIndex = 13;
            // 
            // _profilePicture
            // 
            this._profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("_profilePicture.Image")));
            this._profilePicture.Location = new System.Drawing.Point(68, 355);
            this._profilePicture.Name = "_profilePicture";
            this._profilePicture.Size = new System.Drawing.Size(100, 100);
            this._profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._profilePicture.TabIndex = 5;
            this._profilePicture.TabStop = false;
            // 
            // _settingsListBox
            // 
            this._settingsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this._settingsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this._settingsListBox.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._settingsListBox.ForeColor = System.Drawing.Color.White;
            this._settingsListBox.FormattingEnabled = true;
            this._settingsListBox.ItemHeight = 20;
            this._settingsListBox.Items.AddRange(new object[] {
            "General",
            "Personal",
            "Report"});
            this._settingsListBox.Location = new System.Drawing.Point(0, 0);
            this._settingsListBox.Name = "_settingsListBox";
            this._settingsListBox.Size = new System.Drawing.Size(178, 1241);
            this._settingsListBox.TabIndex = 4;
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
            this._usersTable.ResumeLayout(false);
            this._usersTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._profilePicture)).EndInit();
            this.ResumeLayout(false);

        }


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
        private PictureBox _profilePicture;
        private ListBox _settingsListBox;
        private Button _logOutButton;
        private TableLayoutPanel _commentsTable;
        private Button _addCommentButton;
        private Label label3;
        private Label _label2;
        private RichTextBox commentInput;
        private TableLayoutPanel _usersTable;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox _usernameInput;
        private Button _searchButton;
        private Button button1;
        private ComboBox comboBox1;
    }
}