using Database.Properties;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    partial class DemoUser
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoUser));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.blue_search_panel = new System.Windows.Forms.Panel();
            this.genreLabel = new System.Windows.Forms.Label();
            this.disneyButton = new System.Windows.Forms.Button();
            this.animeButton = new System.Windows.Forms.Button();
            this.hiphopButton = new System.Windows.Forms.Button();
            this.countrButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.rbButton = new System.Windows.Forms.Button();
            this.kpopButton = new System.Windows.Forms.Button();
            this.popButton = new System.Windows.Forms.Button();
            this.searchBarTxtBox = new System.Windows.Forms.TextBox();
            this.latinButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.tk_search_picture = new System.Windows.Forms.PictureBox();
            this.Library = new System.Windows.Forms.TabPage();
            this.durationTxtBox = new System.Windows.Forms.TextBox();
            this.dateCreated = new System.Windows.Forms.TextBox();
            this.likeButton = new System.Windows.Forms.Button();
            this.deleteFromPlaylistButton = new System.Windows.Forms.Button();
            this.songInfoTabControl = new System.Windows.Forms.TabControl();
            this.songsTab = new System.Windows.Forms.TabPage();
            this.playlistSongDataGridView = new System.Windows.Forms.DataGridView();
            this.SongPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.SongInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songInfoTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.songInfoTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lyrics = new System.Windows.Forms.TabPage();
            this.lyricsTxtBox = new System.Windows.Forms.TextBox();
            this.playlistDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invisiblePlaylistDataGridView = new System.Windows.Forms.DataGridView();
            this.PlaylistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.accTab = new System.Windows.Forms.TabPage();
            this.my_account_label = new System.Windows.Forms.Label();
            this.blue_acc_panel = new System.Windows.Forms.Panel();
            this.phoneNumTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.user_name_txtbox = new System.Windows.Forms.TextBox();
            this.tk_acc_picture = new System.Windows.Forms.PictureBox();
            this.light_gray_panel = new System.Windows.Forms.Panel();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryButton = new System.Windows.Forms.Button();
            this.dobButton = new System.Windows.Forms.Button();
            this.sexButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passwordButton = new System.Windows.Forms.Button();
            this.emailButtonSave = new System.Windows.Forms.Button();
            this.phoneNumButtonSave = new System.Windows.Forms.Button();
            this.passwordButtonSave = new System.Windows.Forms.Button();
            this.dobButtonSave = new System.Windows.Forms.Button();
            this.sexButtonSave = new System.Windows.Forms.Button();
            this.countryButtonSave = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchTab.SuspendLayout();
            this.blue_search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tk_search_picture)).BeginInit();
            this.Library.SuspendLayout();
            this.songInfoTabControl.SuspendLayout();
            this.songsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistSongDataGridView)).BeginInit();
            this.songInfoTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Lyrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invisiblePlaylistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.accTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tk_acc_picture)).BeginInit();
            this.light_gray_panel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LAPTOP-E031DC8S\\SQLEXPRESS;Initial Catalog=DigitalMusicLibraryTK;Inte" +
    "grated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // searchTab
            // 
            this.searchTab.BackColor = System.Drawing.Color.White;
            this.searchTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTab.Controls.Add(this.blue_search_panel);
            this.searchTab.Controls.Add(this.disneyButton);
            this.searchTab.Controls.Add(this.animeButton);
            this.searchTab.Controls.Add(this.hiphopButton);
            this.searchTab.Controls.Add(this.countrButton);
            this.searchTab.Controls.Add(this.rockButton);
            this.searchTab.Controls.Add(this.rbButton);
            this.searchTab.Controls.Add(this.kpopButton);
            this.searchTab.Controls.Add(this.popButton);
            this.searchTab.Controls.Add(this.searchBarTxtBox);
            this.searchTab.Controls.Add(this.latinButton);
            this.searchTab.Controls.Add(this.searchButton);
            this.searchTab.Controls.Add(this.tk_search_picture);
            this.searchTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.searchTab.Location = new System.Drawing.Point(4, 34);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(1004, 962);
            this.searchTab.TabIndex = 2;
            this.searchTab.Text = "Home";
            // 
            // blue_search_panel
            // 
            this.blue_search_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.blue_search_panel.Controls.Add(this.genreLabel);
            this.blue_search_panel.Location = new System.Drawing.Point(-1, 95);
            this.blue_search_panel.Name = "blue_search_panel";
            this.blue_search_panel.Size = new System.Drawing.Size(1009, 36);
            this.blue_search_panel.TabIndex = 26;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(37, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(106, 34);
            this.genreLabel.TabIndex = 49;
            this.genreLabel.Text = "Genres";
            // 
            // disneyButton
            // 
            this.disneyButton.BackColor = System.Drawing.Color.White;
            this.disneyButton.BackgroundImage = global::Database.Properties.Resources.DisneyButton;
            this.disneyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.disneyButton.FlatAppearance.BorderSize = 0;
            this.disneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disneyButton.Location = new System.Drawing.Point(684, 492);
            this.disneyButton.Name = "disneyButton";
            this.disneyButton.Size = new System.Drawing.Size(282, 125);
            this.disneyButton.TabIndex = 44;
            this.disneyButton.UseVisualStyleBackColor = false;
            this.disneyButton.Click += new System.EventHandler(this.disneyButton_Click);
            // 
            // animeButton
            // 
            this.animeButton.BackColor = System.Drawing.Color.White;
            this.animeButton.BackgroundImage = global::Database.Properties.Resources.AnimeButton;
            this.animeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animeButton.FlatAppearance.BorderSize = 0;
            this.animeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animeButton.Location = new System.Drawing.Point(363, 492);
            this.animeButton.Name = "animeButton";
            this.animeButton.Size = new System.Drawing.Size(282, 125);
            this.animeButton.TabIndex = 43;
            this.animeButton.UseVisualStyleBackColor = false;
            this.animeButton.Click += new System.EventHandler(this.animeButton_Click);
            // 
            // hiphopButton
            // 
            this.hiphopButton.BackColor = System.Drawing.Color.White;
            this.hiphopButton.BackgroundImage = global::Database.Properties.Resources.HipHopButton;
            this.hiphopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hiphopButton.FlatAppearance.BorderSize = 0;
            this.hiphopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiphopButton.Location = new System.Drawing.Point(40, 492);
            this.hiphopButton.Name = "hiphopButton";
            this.hiphopButton.Size = new System.Drawing.Size(282, 125);
            this.hiphopButton.TabIndex = 42;
            this.hiphopButton.UseVisualStyleBackColor = false;
            this.hiphopButton.Click += new System.EventHandler(this.hiphopButton_Click);
            // 
            // countrButton
            // 
            this.countrButton.BackColor = System.Drawing.Color.White;
            this.countrButton.BackgroundImage = global::Database.Properties.Resources.CountryButton;
            this.countrButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countrButton.FlatAppearance.BorderSize = 0;
            this.countrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countrButton.Location = new System.Drawing.Point(684, 330);
            this.countrButton.Name = "countrButton";
            this.countrButton.Size = new System.Drawing.Size(282, 125);
            this.countrButton.TabIndex = 41;
            this.countrButton.UseVisualStyleBackColor = false;
            this.countrButton.Click += new System.EventHandler(this.countrButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.White;
            this.rockButton.BackgroundImage = global::Database.Properties.Resources.RockButton;
            this.rockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockButton.FlatAppearance.BorderSize = 0;
            this.rockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rockButton.Location = new System.Drawing.Point(363, 330);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(282, 125);
            this.rockButton.TabIndex = 40;
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // rbButton
            // 
            this.rbButton.BackColor = System.Drawing.Color.White;
            this.rbButton.BackgroundImage = global::Database.Properties.Resources.RBButton;
            this.rbButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbButton.FlatAppearance.BorderSize = 0;
            this.rbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbButton.Location = new System.Drawing.Point(40, 330);
            this.rbButton.Name = "rbButton";
            this.rbButton.Size = new System.Drawing.Size(282, 125);
            this.rbButton.TabIndex = 39;
            this.rbButton.UseVisualStyleBackColor = false;
            this.rbButton.Click += new System.EventHandler(this.rbButton_Click);
            // 
            // kpopButton
            // 
            this.kpopButton.BackColor = System.Drawing.Color.White;
            this.kpopButton.BackgroundImage = global::Database.Properties.Resources.KpopButton2;
            this.kpopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kpopButton.FlatAppearance.BorderSize = 0;
            this.kpopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kpopButton.Location = new System.Drawing.Point(40, 169);
            this.kpopButton.Name = "kpopButton";
            this.kpopButton.Size = new System.Drawing.Size(282, 125);
            this.kpopButton.TabIndex = 38;
            this.kpopButton.UseVisualStyleBackColor = false;
            this.kpopButton.Click += new System.EventHandler(this.kpopButton_Click);
            // 
            // popButton
            // 
            this.popButton.BackColor = System.Drawing.Color.White;
            this.popButton.BackgroundImage = global::Database.Properties.Resources.PopButton;
            this.popButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.popButton.FlatAppearance.BorderSize = 0;
            this.popButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popButton.Location = new System.Drawing.Point(684, 169);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(282, 125);
            this.popButton.TabIndex = 36;
            this.popButton.UseVisualStyleBackColor = false;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // searchBarTxtBox
            // 
            this.searchBarTxtBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.searchBarTxtBox.Location = new System.Drawing.Point(136, 33);
            this.searchBarTxtBox.Multiline = true;
            this.searchBarTxtBox.Name = "searchBarTxtBox";
            this.searchBarTxtBox.Size = new System.Drawing.Size(419, 30);
            this.searchBarTxtBox.TabIndex = 29;
            this.searchBarTxtBox.Text = "Search for Songs, Artists";
            this.searchBarTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchBarTxtBox.GotFocus += new System.EventHandler(this.searchBarTxtBox_GotFocus);
            // 
            // latinButton
            // 
            this.latinButton.BackColor = System.Drawing.Color.White;
            this.latinButton.BackgroundImage = global::Database.Properties.Resources.LatinButton1;
            this.latinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.latinButton.FlatAppearance.BorderSize = 0;
            this.latinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.latinButton.Location = new System.Drawing.Point(363, 169);
            this.latinButton.Name = "latinButton";
            this.latinButton.Size = new System.Drawing.Size(282, 125);
            this.latinButton.TabIndex = 32;
            this.latinButton.UseVisualStyleBackColor = false;
            this.latinButton.Click += new System.EventHandler(this.latinButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = global::Database.Properties.Resources.Picture7;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(553, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 30);
            this.searchButton.TabIndex = 28;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tk_search_picture
            // 
            this.tk_search_picture.BackColor = System.Drawing.Color.White;
            this.tk_search_picture.BackgroundImage = global::Database.Properties.Resources.Picture31;
            this.tk_search_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tk_search_picture.Location = new System.Drawing.Point(36, 23);
            this.tk_search_picture.Name = "tk_search_picture";
            this.tk_search_picture.Size = new System.Drawing.Size(68, 47);
            this.tk_search_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tk_search_picture.TabIndex = 30;
            this.tk_search_picture.TabStop = false;
            // 
            // Library
            // 
            this.Library.BackColor = System.Drawing.Color.White;
            this.Library.Controls.Add(this.durationTxtBox);
            this.Library.Controls.Add(this.dateCreated);
            this.Library.Controls.Add(this.likeButton);
            this.Library.Controls.Add(this.deleteFromPlaylistButton);
            this.Library.Controls.Add(this.songInfoTabControl);
            this.Library.Controls.Add(this.playlistDataGridView);
            this.Library.Controls.Add(this.panel1);
            this.Library.Controls.Add(this.label2);
            this.Library.Controls.Add(this.invisiblePlaylistDataGridView);
            this.Library.Controls.Add(this.musicPlayer);
            this.Library.Controls.Add(this.pictureBox3);
            this.Library.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.Library.Location = new System.Drawing.Point(4, 34);
            this.Library.Name = "Library";
            this.Library.Padding = new System.Windows.Forms.Padding(3);
            this.Library.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Library.Size = new System.Drawing.Size(1004, 962);
            this.Library.TabIndex = 1;
            this.Library.Text = "Library";
            // 
            // durationTxtBox
            // 
            this.durationTxtBox.BackColor = System.Drawing.Color.White;
            this.durationTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.durationTxtBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTxtBox.ForeColor = System.Drawing.Color.Black;
            this.durationTxtBox.Location = new System.Drawing.Point(709, 333);
            this.durationTxtBox.Name = "durationTxtBox";
            this.durationTxtBox.ReadOnly = true;
            this.durationTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.durationTxtBox.Size = new System.Drawing.Size(259, 19);
            this.durationTxtBox.TabIndex = 103;
            // 
            // dateCreated
            // 
            this.dateCreated.BackColor = System.Drawing.Color.White;
            this.dateCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateCreated.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreated.ForeColor = System.Drawing.Color.Black;
            this.dateCreated.Location = new System.Drawing.Point(376, 333);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.ReadOnly = true;
            this.dateCreated.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateCreated.Size = new System.Drawing.Size(259, 19);
            this.dateCreated.TabIndex = 102;
            this.dateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.likeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.ForeColor = System.Drawing.Color.Black;
            this.likeButton.Location = new System.Drawing.Point(888, 355);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(43, 35);
            this.likeButton.TabIndex = 101;
            this.likeButton.Text = "👍";
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // deleteFromPlaylistButton
            // 
            this.deleteFromPlaylistButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteFromPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteFromPlaylistButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.deleteFromPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFromPlaylistButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFromPlaylistButton.ForeColor = System.Drawing.Color.Black;
            this.deleteFromPlaylistButton.Location = new System.Drawing.Point(926, 355);
            this.deleteFromPlaylistButton.Name = "deleteFromPlaylistButton";
            this.deleteFromPlaylistButton.Size = new System.Drawing.Size(43, 35);
            this.deleteFromPlaylistButton.TabIndex = 89;
            this.deleteFromPlaylistButton.Text = "❌";
            this.deleteFromPlaylistButton.UseVisualStyleBackColor = false;
            this.deleteFromPlaylistButton.Click += new System.EventHandler(this.deleteFromPlaylistButton_Click);
            // 
            // songInfoTabControl
            // 
            this.songInfoTabControl.Controls.Add(this.songsTab);
            this.songInfoTabControl.Controls.Add(this.songInfoTab);
            this.songInfoTabControl.Controls.Add(this.Lyrics);
            this.songInfoTabControl.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfoTabControl.Location = new System.Drawing.Point(656, 353);
            this.songInfoTabControl.Name = "songInfoTabControl";
            this.songInfoTabControl.SelectedIndex = 0;
            this.songInfoTabControl.Size = new System.Drawing.Size(313, 399);
            this.songInfoTabControl.TabIndex = 100;
            // 
            // songsTab
            // 
            this.songsTab.Controls.Add(this.playlistSongDataGridView);
            this.songsTab.Location = new System.Drawing.Point(4, 38);
            this.songsTab.Name = "songsTab";
            this.songsTab.Size = new System.Drawing.Size(305, 357);
            this.songsTab.TabIndex = 2;
            this.songsTab.Text = "Songs";
            this.songsTab.UseVisualStyleBackColor = true;
            // 
            // playlistSongDataGridView
            // 
            this.playlistSongDataGridView.AllowUserToAddRows = false;
            this.playlistSongDataGridView.AllowUserToDeleteRows = false;
            this.playlistSongDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playlistSongDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.playlistSongDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.playlistSongDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistSongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistSongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongPic,
            this.SongInfo});
            this.playlistSongDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistSongDataGridView.GridColor = System.Drawing.Color.White;
            this.playlistSongDataGridView.Location = new System.Drawing.Point(0, 0);
            this.playlistSongDataGridView.Name = "playlistSongDataGridView";
            this.playlistSongDataGridView.ReadOnly = true;
            this.playlistSongDataGridView.Size = new System.Drawing.Size(305, 357);
            this.playlistSongDataGridView.TabIndex = 90;
            this.playlistSongDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playlistSongDataGridViewCellClick);
            // 
            // SongPic
            // 
            this.SongPic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SongPic.HeaderText = "SongPic";
            this.SongPic.Name = "SongPic";
            this.SongPic.ReadOnly = true;
            this.SongPic.Width = 104;
            // 
            // SongInfo
            // 
            this.SongInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SongInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.SongInfo.HeaderText = "SongInfo";
            this.SongInfo.Name = "SongInfo";
            this.SongInfo.ReadOnly = true;
            this.SongInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // songInfoTab
            // 
            this.songInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.songInfoTab.Controls.Add(this.panel3);
            this.songInfoTab.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfoTab.Location = new System.Drawing.Point(4, 38);
            this.songInfoTab.Name = "songInfoTab";
            this.songInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.songInfoTab.Size = new System.Drawing.Size(305, 357);
            this.songInfoTab.TabIndex = 1;
            this.songInfoTab.Text = "Info";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.songInfoTxtBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 351);
            this.panel3.TabIndex = 72;
            // 
            // songInfoTxtBox
            // 
            this.songInfoTxtBox.BackColor = System.Drawing.Color.White;
            this.songInfoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songInfoTxtBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfoTxtBox.ForeColor = System.Drawing.Color.Black;
            this.songInfoTxtBox.Location = new System.Drawing.Point(0, 0);
            this.songInfoTxtBox.Multiline = true;
            this.songInfoTxtBox.Name = "songInfoTxtBox";
            this.songInfoTxtBox.ReadOnly = true;
            this.songInfoTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.songInfoTxtBox.Size = new System.Drawing.Size(299, 351);
            this.songInfoTxtBox.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 34);
            this.label6.TabIndex = 46;
            // 
            // Lyrics
            // 
            this.Lyrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.Lyrics.Controls.Add(this.lyricsTxtBox);
            this.Lyrics.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lyrics.Location = new System.Drawing.Point(4, 38);
            this.Lyrics.Name = "Lyrics";
            this.Lyrics.Padding = new System.Windows.Forms.Padding(3);
            this.Lyrics.Size = new System.Drawing.Size(305, 357);
            this.Lyrics.TabIndex = 0;
            this.Lyrics.Text = "Lyrics";
            // 
            // lyricsTxtBox
            // 
            this.lyricsTxtBox.BackColor = System.Drawing.Color.White;
            this.lyricsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lyricsTxtBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyricsTxtBox.ForeColor = System.Drawing.Color.Black;
            this.lyricsTxtBox.Location = new System.Drawing.Point(3, 3);
            this.lyricsTxtBox.Multiline = true;
            this.lyricsTxtBox.Name = "lyricsTxtBox";
            this.lyricsTxtBox.ReadOnly = true;
            this.lyricsTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lyricsTxtBox.Size = new System.Drawing.Size(299, 351);
            this.lyricsTxtBox.TabIndex = 54;
            // 
            // playlistDataGridView
            // 
            this.playlistDataGridView.AllowUserToAddRows = false;
            this.playlistDataGridView.AllowUserToDeleteRows = false;
            this.playlistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.playlistDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.playlistDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.playlistDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playlistDataGridView.GridColor = System.Drawing.Color.White;
            this.playlistDataGridView.Location = new System.Drawing.Point(40, 160);
            this.playlistDataGridView.Name = "playlistDataGridView";
            this.playlistDataGridView.ReadOnly = true;
            this.playlistDataGridView.Size = new System.Drawing.Size(929, 165);
            this.playlistDataGridView.TabIndex = 89;
            this.playlistDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playlistDataGridViewCellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 36);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 49;
            this.label1.Text = "Playlists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 61);
            this.label2.TabIndex = 37;
            this.label2.Text = "My Library";
            // 
            // invisiblePlaylistDataGridView
            // 
            this.invisiblePlaylistDataGridView.AllowUserToAddRows = false;
            this.invisiblePlaylistDataGridView.AllowUserToDeleteRows = false;
            this.invisiblePlaylistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.invisiblePlaylistDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.invisiblePlaylistDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.invisiblePlaylistDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invisiblePlaylistDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.invisiblePlaylistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invisiblePlaylistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlaylistName});
            this.invisiblePlaylistDataGridView.GridColor = System.Drawing.Color.White;
            this.invisiblePlaylistDataGridView.Location = new System.Drawing.Point(12, 160);
            this.invisiblePlaylistDataGridView.Name = "invisiblePlaylistDataGridView";
            this.invisiblePlaylistDataGridView.ReadOnly = true;
            this.invisiblePlaylistDataGridView.Size = new System.Drawing.Size(22, 165);
            this.invisiblePlaylistDataGridView.TabIndex = 92;
            // 
            // PlaylistName
            // 
            this.PlaylistName.HeaderText = "PlaylistName";
            this.PlaylistName.Name = "PlaylistName";
            this.PlaylistName.ReadOnly = true;
            this.PlaylistName.Visible = false;
            this.PlaylistName.Width = 92;
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(40, 353);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(595, 399);
            this.musicPlayer.TabIndex = 91;
            this.musicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPlayer_PlayStateChange);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::Database.Properties.Resources.Picture31;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(40, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // accTab
            // 
            this.accTab.BackColor = System.Drawing.Color.White;
            this.accTab.Controls.Add(this.my_account_label);
            this.accTab.Controls.Add(this.blue_acc_panel);
            this.accTab.Controls.Add(this.phoneNumTxtBox);
            this.accTab.Controls.Add(this.emailTxtBox);
            this.accTab.Controls.Add(this.user_name_txtbox);
            this.accTab.Controls.Add(this.tk_acc_picture);
            this.accTab.Controls.Add(this.light_gray_panel);
            this.accTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.accTab.Location = new System.Drawing.Point(4, 34);
            this.accTab.Name = "accTab";
            this.accTab.Padding = new System.Windows.Forms.Padding(3);
            this.accTab.Size = new System.Drawing.Size(1004, 962);
            this.accTab.TabIndex = 0;
            this.accTab.Text = "Account";
            // 
            // my_account_label
            // 
            this.my_account_label.AutoSize = true;
            this.my_account_label.Font = new System.Drawing.Font("Georgia", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my_account_label.Location = new System.Drawing.Point(124, 14);
            this.my_account_label.Name = "my_account_label";
            this.my_account_label.Size = new System.Drawing.Size(307, 61);
            this.my_account_label.TabIndex = 36;
            this.my_account_label.Text = "My Account";
            // 
            // blue_acc_panel
            // 
            this.blue_acc_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.blue_acc_panel.Location = new System.Drawing.Point(0, 93);
            this.blue_acc_panel.Name = "blue_acc_panel";
            this.blue_acc_panel.Size = new System.Drawing.Size(1008, 36);
            this.blue_acc_panel.TabIndex = 35;
            // 
            // phoneNumTxtBox
            // 
            this.phoneNumTxtBox.BackColor = System.Drawing.Color.White;
            this.phoneNumTxtBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumTxtBox.ForeColor = System.Drawing.Color.Black;
            this.phoneNumTxtBox.Location = new System.Drawing.Point(445, 322);
            this.phoneNumTxtBox.Multiline = true;
            this.phoneNumTxtBox.Name = "phoneNumTxtBox";
            this.phoneNumTxtBox.ReadOnly = true;
            this.phoneNumTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phoneNumTxtBox.Size = new System.Drawing.Size(388, 33);
            this.phoneNumTxtBox.TabIndex = 32;
            this.phoneNumTxtBox.Text = "112-358-1321";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BackColor = System.Drawing.Color.White;
            this.emailTxtBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.ForeColor = System.Drawing.Color.Black;
            this.emailTxtBox.Location = new System.Drawing.Point(445, 254);
            this.emailTxtBox.Multiline = true;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.ReadOnly = true;
            this.emailTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailTxtBox.Size = new System.Drawing.Size(388, 33);
            this.emailTxtBox.TabIndex = 30;
            this.emailTxtBox.Text = "demoUser@tk.com";
            // 
            // user_name_txtbox
            // 
            this.user_name_txtbox.BackColor = System.Drawing.Color.White;
            this.user_name_txtbox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_txtbox.ForeColor = System.Drawing.Color.Black;
            this.user_name_txtbox.Location = new System.Drawing.Point(445, 188);
            this.user_name_txtbox.Multiline = true;
            this.user_name_txtbox.Name = "user_name_txtbox";
            this.user_name_txtbox.ReadOnly = true;
            this.user_name_txtbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.user_name_txtbox.Size = new System.Drawing.Size(388, 33);
            this.user_name_txtbox.TabIndex = 28;
            this.user_name_txtbox.Text = "Demo User";
            // 
            // tk_acc_picture
            // 
            this.tk_acc_picture.BackColor = System.Drawing.Color.White;
            this.tk_acc_picture.BackgroundImage = global::Database.Properties.Resources.Picture31;
            this.tk_acc_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tk_acc_picture.Location = new System.Drawing.Point(34, 20);
            this.tk_acc_picture.Name = "tk_acc_picture";
            this.tk_acc_picture.Size = new System.Drawing.Size(68, 47);
            this.tk_acc_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tk_acc_picture.TabIndex = 24;
            this.tk_acc_picture.TabStop = false;
            // 
            // light_gray_panel
            // 
            this.light_gray_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.light_gray_panel.Controls.Add(this.countryComboBox);
            this.light_gray_panel.Controls.Add(this.countryButton);
            this.light_gray_panel.Controls.Add(this.dobButton);
            this.light_gray_panel.Controls.Add(this.sexButton);
            this.light_gray_panel.Controls.Add(this.passwordTextBox);
            this.light_gray_panel.Controls.Add(this.phoneNumButton);
            this.light_gray_panel.Controls.Add(this.emailButton);
            this.light_gray_panel.Controls.Add(this.sexComboBox);
            this.light_gray_panel.Controls.Add(this.userNameLabel);
            this.light_gray_panel.Controls.Add(this.dobDateTimePicker);
            this.light_gray_panel.Controls.Add(this.passwordButton);
            this.light_gray_panel.Controls.Add(this.emailButtonSave);
            this.light_gray_panel.Controls.Add(this.phoneNumButtonSave);
            this.light_gray_panel.Controls.Add(this.passwordButtonSave);
            this.light_gray_panel.Controls.Add(this.dobButtonSave);
            this.light_gray_panel.Controls.Add(this.sexButtonSave);
            this.light_gray_panel.Controls.Add(this.countryButtonSave);
            this.light_gray_panel.Location = new System.Drawing.Point(141, 171);
            this.light_gray_panel.Name = "light_gray_panel";
            this.light_gray_panel.Size = new System.Drawing.Size(714, 478);
            this.light_gray_panel.TabIndex = 34;
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.countryComboBox.Location = new System.Drawing.Point(304, 417);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countryComboBox.Size = new System.Drawing.Size(388, 37);
            this.countryComboBox.TabIndex = 44;
            this.countryComboBox.Text = "United States";
            // 
            // countryButton
            // 
            this.countryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.countryButton.FlatAppearance.BorderSize = 0;
            this.countryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countryButton.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryButton.ForeColor = System.Drawing.Color.White;
            this.countryButton.Location = new System.Drawing.Point(21, 413);
            this.countryButton.Name = "countryButton";
            this.countryButton.Size = new System.Drawing.Size(243, 46);
            this.countryButton.TabIndex = 41;
            this.countryButton.Text = "Country/Region";
            this.countryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countryButton.UseVisualStyleBackColor = false;
            this.countryButton.Click += new System.EventHandler(this.countryButton_Click);
            // 
            // dobButton
            // 
            this.dobButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.dobButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.dobButton.FlatAppearance.BorderSize = 0;
            this.dobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dobButton.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobButton.ForeColor = System.Drawing.Color.White;
            this.dobButton.Location = new System.Drawing.Point(21, 283);
            this.dobButton.Name = "dobButton";
            this.dobButton.Size = new System.Drawing.Size(243, 43);
            this.dobButton.TabIndex = 37;
            this.dobButton.Text = "Date of Birth";
            this.dobButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dobButton.UseVisualStyleBackColor = false;
            this.dobButton.Click += new System.EventHandler(this.dobButton_Click);
            // 
            // sexButton
            // 
            this.sexButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.sexButton.FlatAppearance.BorderSize = 0;
            this.sexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexButton.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexButton.ForeColor = System.Drawing.Color.White;
            this.sexButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sexButton.Location = new System.Drawing.Point(21, 348);
            this.sexButton.Name = "sexButton";
            this.sexButton.Size = new System.Drawing.Size(243, 42);
            this.sexButton.TabIndex = 39;
            this.sexButton.Text = "Sex";
            this.sexButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sexButton.UseVisualStyleBackColor = false;
            this.sexButton.Click += new System.EventHandler(this.sexButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(304, 221);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordTextBox.Size = new System.Drawing.Size(388, 33);
            this.passwordTextBox.TabIndex = 42;
            this.passwordTextBox.Text = "**********";
            // 
            // phoneNumButton
            // 
            this.phoneNumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.phoneNumButton.FlatAppearance.BorderSize = 0;
            this.phoneNumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneNumButton.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumButton.ForeColor = System.Drawing.Color.White;
            this.phoneNumButton.Location = new System.Drawing.Point(21, 140);
            this.phoneNumButton.Name = "phoneNumButton";
            this.phoneNumButton.Size = new System.Drawing.Size(243, 46);
            this.phoneNumButton.TabIndex = 31;
            this.phoneNumButton.Text = "Phone Number";
            this.phoneNumButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.phoneNumButton.UseVisualStyleBackColor = false;
            this.phoneNumButton.Click += new System.EventHandler(this.phoneNumButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.emailButton.FlatAppearance.BorderSize = 0;
            this.emailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailButton.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.ForeColor = System.Drawing.Color.Transparent;
            this.emailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailButton.Location = new System.Drawing.Point(21, 78);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(258, 42);
            this.emailButton.TabIndex = 29;
            this.emailButton.Text = "Email Address";
            this.emailButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailButton.UseVisualStyleBackColor = false;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // sexComboBox
            // 
            this.sexComboBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Non-binary"});
            this.sexComboBox.Location = new System.Drawing.Point(304, 355);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sexComboBox.Size = new System.Drawing.Size(388, 37);
            this.sexComboBox.TabIndex = 43;
            this.sexComboBox.Text = "Female";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(21, 17);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(148, 34);
            this.userNameLabel.TabIndex = 48;
            this.userNameLabel.Text = "Username";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.CalendarFont = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.dobDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.dobDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.dobDateTimePicker.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(304, 287);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.dobDateTimePicker.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dobDateTimePicker.Size = new System.Drawing.Size(388, 35);
            this.dobDateTimePicker.TabIndex = 0;
            this.dobDateTimePicker.Value = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.passwordButton.FlatAppearance.BorderSize = 0;
            this.passwordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordButton.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordButton.ForeColor = System.Drawing.Color.White;
            this.passwordButton.Location = new System.Drawing.Point(21, 210);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(243, 46);
            this.passwordButton.TabIndex = 44;
            this.passwordButton.Text = "Password";
            this.passwordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // emailButtonSave
            // 
            this.emailButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.emailButtonSave.FlatAppearance.BorderSize = 0;
            this.emailButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailButtonSave.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButtonSave.ForeColor = System.Drawing.Color.Transparent;
            this.emailButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailButtonSave.Location = new System.Drawing.Point(21, 78);
            this.emailButtonSave.Name = "emailButtonSave";
            this.emailButtonSave.Size = new System.Drawing.Size(258, 42);
            this.emailButtonSave.TabIndex = 49;
            this.emailButtonSave.Text = "Email Address";
            this.emailButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailButtonSave.UseVisualStyleBackColor = false;
            this.emailButtonSave.Click += new System.EventHandler(this.emailButtonSave_Click);
            // 
            // phoneNumButtonSave
            // 
            this.phoneNumButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.phoneNumButtonSave.FlatAppearance.BorderSize = 0;
            this.phoneNumButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneNumButtonSave.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumButtonSave.ForeColor = System.Drawing.Color.White;
            this.phoneNumButtonSave.Location = new System.Drawing.Point(21, 140);
            this.phoneNumButtonSave.Name = "phoneNumButtonSave";
            this.phoneNumButtonSave.Size = new System.Drawing.Size(243, 46);
            this.phoneNumButtonSave.TabIndex = 50;
            this.phoneNumButtonSave.Text = "Phone Number";
            this.phoneNumButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.phoneNumButtonSave.UseVisualStyleBackColor = false;
            this.phoneNumButtonSave.Click += new System.EventHandler(this.phoneNumButtonSave_Click);
            // 
            // passwordButtonSave
            // 
            this.passwordButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.passwordButtonSave.FlatAppearance.BorderSize = 0;
            this.passwordButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordButtonSave.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordButtonSave.ForeColor = System.Drawing.Color.White;
            this.passwordButtonSave.Location = new System.Drawing.Point(21, 210);
            this.passwordButtonSave.Name = "passwordButtonSave";
            this.passwordButtonSave.Size = new System.Drawing.Size(243, 46);
            this.passwordButtonSave.TabIndex = 51;
            this.passwordButtonSave.Text = "Password";
            this.passwordButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordButtonSave.UseVisualStyleBackColor = false;
            this.passwordButtonSave.Click += new System.EventHandler(this.passwordButtonSave_Click);
            // 
            // dobButtonSave
            // 
            this.dobButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.dobButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.dobButtonSave.FlatAppearance.BorderSize = 0;
            this.dobButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dobButtonSave.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobButtonSave.ForeColor = System.Drawing.Color.White;
            this.dobButtonSave.Location = new System.Drawing.Point(21, 283);
            this.dobButtonSave.Name = "dobButtonSave";
            this.dobButtonSave.Size = new System.Drawing.Size(243, 43);
            this.dobButtonSave.TabIndex = 52;
            this.dobButtonSave.Text = "Date of Birth";
            this.dobButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dobButtonSave.UseVisualStyleBackColor = false;
            this.dobButtonSave.Click += new System.EventHandler(this.dobButtonSave_Click);
            // 
            // sexButtonSave
            // 
            this.sexButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.sexButtonSave.FlatAppearance.BorderSize = 0;
            this.sexButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexButtonSave.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexButtonSave.ForeColor = System.Drawing.Color.White;
            this.sexButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sexButtonSave.Location = new System.Drawing.Point(21, 348);
            this.sexButtonSave.Name = "sexButtonSave";
            this.sexButtonSave.Size = new System.Drawing.Size(243, 42);
            this.sexButtonSave.TabIndex = 53;
            this.sexButtonSave.Text = "Sex";
            this.sexButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sexButtonSave.UseVisualStyleBackColor = false;
            this.sexButtonSave.Click += new System.EventHandler(this.sexButtonSave_Click);
            // 
            // countryButtonSave
            // 
            this.countryButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.countryButtonSave.FlatAppearance.BorderSize = 0;
            this.countryButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countryButtonSave.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryButtonSave.ForeColor = System.Drawing.Color.White;
            this.countryButtonSave.Location = new System.Drawing.Point(21, 413);
            this.countryButtonSave.Name = "countryButtonSave";
            this.countryButtonSave.Size = new System.Drawing.Size(243, 46);
            this.countryButtonSave.TabIndex = 54;
            this.countryButtonSave.Text = "Country/Region";
            this.countryButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.countryButtonSave.UseVisualStyleBackColor = false;
            this.countryButtonSave.Click += new System.EventHandler(this.countryButtonSave_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.accTab);
            this.tabControl.Controls.Add(this.Library);
            this.tabControl.Controls.Add(this.searchTab);
            this.tabControl.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-4, -3);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1012, 1000);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // DemoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1106, 749);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.Name = "DemoUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DemoUser_FormClosing);
            this.Load += new System.EventHandler(this.DemoUser_Load);
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            this.blue_search_panel.ResumeLayout(false);
            this.blue_search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tk_search_picture)).EndInit();
            this.Library.ResumeLayout(false);
            this.Library.PerformLayout();
            this.songInfoTabControl.ResumeLayout(false);
            this.songsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playlistSongDataGridView)).EndInit();
            this.songInfoTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Lyrics.ResumeLayout(false);
            this.Lyrics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invisiblePlaylistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.accTab.ResumeLayout(false);
            this.accTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tk_acc_picture)).EndInit();
            this.light_gray_panel.ResumeLayout(false);
            this.light_gray_panel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private TabPage searchTab;
        private Panel blue_search_panel;
        private Label genreLabel;
        private Button disneyButton;
        private Button animeButton;
        private Button hiphopButton;
        private Button countrButton;
        private Button rockButton;
        private Button rbButton;
        private Button kpopButton;
        private Button popButton;
        private TextBox searchBarTxtBox;
        private Button latinButton;
        private PictureBox tk_search_picture;
        private Button searchButton;
        private TabPage Library;
        private Button likeButton;
        private Button deleteFromPlaylistButton;
        private TabControl songInfoTabControl;
        private TabPage songsTab;
        private DataGridView playlistSongDataGridView;
        private DataGridViewImageColumn SongPic;
        private DataGridViewTextBoxColumn SongInfo;
        private TabPage songInfoTab;
        private Panel panel3;
        private TextBox songInfoTxtBox;
        private Label label6;
        private TabPage Lyrics;
        private TextBox lyricsTxtBox;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private DataGridView playlistDataGridView;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox3;
        private DataGridView invisiblePlaylistDataGridView;
        private DataGridViewTextBoxColumn PlaylistName;
        private TabPage accTab;
        private Label my_account_label;
        private Panel blue_acc_panel;
        private TextBox phoneNumTxtBox;
        private TextBox emailTxtBox;
        private TextBox user_name_txtbox;
        private PictureBox tk_acc_picture;
        private Panel light_gray_panel;
        private ComboBox countryComboBox;
        private Button countryButton;
        private Button dobButton;
        private Button sexButton;
        private TextBox passwordTextBox;
        private Button phoneNumButton;
        private Button emailButton;
        private ComboBox sexComboBox;
        private Label userNameLabel;
        private DateTimePicker dobDateTimePicker;
        private Button passwordButton;
        private Button emailButtonSave;
        private Button phoneNumButtonSave;
        private Button passwordButtonSave;
        private Button dobButtonSave;
        private Button sexButtonSave;
        private Button countryButtonSave;
        private TabControl tabControl;
        private TextBox dateCreated;
        private TextBox durationTxtBox;
    }
}