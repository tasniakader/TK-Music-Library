using System.Windows.Forms;

namespace Database
{
    partial class SearchResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResults));
            this.artistNameComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.artistIdTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.artistPicTxtBox1 = new System.Windows.Forms.TextBox();
            this.browseButton1 = new System.Windows.Forms.Button();
            this.bioTxtBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.listenersTxtBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.followersTxtBox = new System.Windows.Forms.TextBox();
            this.monthTxtBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.playlistComboBox = new System.Windows.Forms.ComboBox();
            this.addToPlaylistButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.artistTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.songTab = new System.Windows.Forms.TabPage();
            this.artistSongDataGridView = new System.Windows.Forms.DataGridView();
            this.ArtistSongPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.ArtistSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalStreams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTab = new System.Windows.Forms.TabPage();
            this.albumDataGridView = new System.Windows.Forms.DataGridView();
            this.AlbumPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.AlbumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfSongs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.artistLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.artistDataGridView = new System.Windows.Forms.DataGridView();
            this.ArtistPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songDataGridView = new System.Windows.Forms.DataGridView();
            this.SongPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.SongTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songPicBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.songInfoTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.songInfoTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Lyrics = new System.Windows.Forms.TabPage();
            this.lyricsTxtBox = new System.Windows.Forms.TextBox();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tk_search_picture = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.songLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.artistTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.songTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistSongDataGridView)).BeginInit();
            this.albumTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPicBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.songInfoTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Lyrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_search_picture)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // artistNameComboBox
            // 
            this.artistNameComboBox.Enabled = false;
            this.artistNameComboBox.FormattingEnabled = true;
            this.artistNameComboBox.Location = new System.Drawing.Point(241, 91);
            this.artistNameComboBox.Name = "artistNameComboBox";
            this.artistNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.artistNameComboBox.Size = new System.Drawing.Size(440, 21);
            this.artistNameComboBox.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 34);
            this.label11.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(35, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 34);
            this.label10.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 34);
            this.label9.TabIndex = 47;
            // 
            // artistIdTxtBox
            // 
            this.artistIdTxtBox.Enabled = false;
            this.artistIdTxtBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistIdTxtBox.ForeColor = System.Drawing.Color.Black;
            this.artistIdTxtBox.Location = new System.Drawing.Point(241, 24);
            this.artistIdTxtBox.Multiline = true;
            this.artistIdTxtBox.Name = "artistIdTxtBox";
            this.artistIdTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.artistIdTxtBox.Size = new System.Drawing.Size(440, 37);
            this.artistIdTxtBox.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 34);
            this.label8.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 34);
            this.label7.TabIndex = 56;
            // 
            // artistPicTxtBox1
            // 
            this.artistPicTxtBox1.Enabled = false;
            this.artistPicTxtBox1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistPicTxtBox1.ForeColor = System.Drawing.Color.Black;
            this.artistPicTxtBox1.Location = new System.Drawing.Point(241, 158);
            this.artistPicTxtBox1.Name = "artistPicTxtBox1";
            this.artistPicTxtBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.artistPicTxtBox1.Size = new System.Drawing.Size(406, 35);
            this.artistPicTxtBox1.TabIndex = 59;
            // 
            // browseButton1
            // 
            this.browseButton1.BackColor = System.Drawing.Color.White;
            this.browseButton1.Enabled = false;
            this.browseButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton1.ForeColor = System.Drawing.Color.Black;
            this.browseButton1.Location = new System.Drawing.Point(646, 159);
            this.browseButton1.Name = "browseButton1";
            this.browseButton1.Size = new System.Drawing.Size(35, 33);
            this.browseButton1.TabIndex = 58;
            this.browseButton1.Text = "...";
            this.browseButton1.UseVisualStyleBackColor = false;
            // 
            // bioTxtBox
            // 
            this.bioTxtBox.Enabled = false;
            this.bioTxtBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioTxtBox.ForeColor = System.Drawing.Color.Black;
            this.bioTxtBox.Location = new System.Drawing.Point(241, 223);
            this.bioTxtBox.Multiline = true;
            this.bioTxtBox.Name = "bioTxtBox";
            this.bioTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bioTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bioTxtBox.Size = new System.Drawing.Size(440, 173);
            this.bioTxtBox.TabIndex = 60;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(29, 426);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(251, 34);
            this.label17.TabIndex = 64;
            // 
            // listenersTxtBox
            // 
            this.listenersTxtBox.Enabled = false;
            this.listenersTxtBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenersTxtBox.ForeColor = System.Drawing.Color.Black;
            this.listenersTxtBox.Location = new System.Drawing.Point(468, 426);
            this.listenersTxtBox.Multiline = true;
            this.listenersTxtBox.Name = "listenersTxtBox";
            this.listenersTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listenersTxtBox.Size = new System.Drawing.Size(213, 37);
            this.listenersTxtBox.TabIndex = 65;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(29, 493);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(286, 34);
            this.label18.TabIndex = 66;
            // 
            // followersTxtBox
            // 
            this.followersTxtBox.Enabled = false;
            this.followersTxtBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followersTxtBox.ForeColor = System.Drawing.Color.Black;
            this.followersTxtBox.Location = new System.Drawing.Point(353, 493);
            this.followersTxtBox.Multiline = true;
            this.followersTxtBox.Name = "followersTxtBox";
            this.followersTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.followersTxtBox.Size = new System.Drawing.Size(328, 37);
            this.followersTxtBox.TabIndex = 67;
            // 
            // monthTxtBox
            // 
            this.monthTxtBox.Enabled = false;
            this.monthTxtBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTxtBox.ForeColor = System.Drawing.Color.Black;
            this.monthTxtBox.Location = new System.Drawing.Point(353, 426);
            this.monthTxtBox.Multiline = true;
            this.monthTxtBox.Name = "monthTxtBox";
            this.monthTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthTxtBox.Size = new System.Drawing.Size(116, 37);
            this.monthTxtBox.TabIndex = 68;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LAPTOP-E031DC8S\\SQLEXPRESS;Initial Catalog=DigitalMusicLibraryTK;Inte" +
    "grated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.artistDataGridView);
            this.panel1.Controls.Add(this.songDataGridView);
            this.panel1.Controls.Add(this.songPicBox);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.musicPlayer);
            this.panel1.Controls.Add(this.tk_search_picture);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 1179);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel7.Location = new System.Drawing.Point(17, 602);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(227, 34);
            this.panel7.TabIndex = 111;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.playlistComboBox);
            this.panel2.Controls.Add(this.addToPlaylistButton);
            this.panel2.Controls.Add(this.likeButton);
            this.panel2.Location = new System.Drawing.Point(769, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 34);
            this.panel2.TabIndex = 110;
            // 
            // playlistComboBox
            // 
            this.playlistComboBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistComboBox.FormattingEnabled = true;
            this.playlistComboBox.Location = new System.Drawing.Point(71, 4);
            this.playlistComboBox.Name = "playlistComboBox";
            this.playlistComboBox.Size = new System.Drawing.Size(137, 26);
            this.playlistComboBox.TabIndex = 90;
            // 
            // addToPlaylistButton
            // 
            this.addToPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.addToPlaylistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addToPlaylistButton.FlatAppearance.BorderSize = 0;
            this.addToPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToPlaylistButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToPlaylistButton.ForeColor = System.Drawing.Color.White;
            this.addToPlaylistButton.Location = new System.Drawing.Point(34, -2);
            this.addToPlaylistButton.Name = "addToPlaylistButton";
            this.addToPlaylistButton.Size = new System.Drawing.Size(30, 34);
            this.addToPlaylistButton.TabIndex = 89;
            this.addToPlaylistButton.Text = "+";
            this.addToPlaylistButton.UseVisualStyleBackColor = false;
            this.addToPlaylistButton.Click += new System.EventHandler(this.addToPlaylistButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.BackColor = System.Drawing.Color.Transparent;
            this.likeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likeButton.FlatAppearance.BorderSize = 0;
            this.likeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeButton.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeButton.ForeColor = System.Drawing.Color.White;
            this.likeButton.Location = new System.Drawing.Point(4, -3);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(30, 34);
            this.likeButton.TabIndex = 86;
            this.likeButton.Text = "👍🏻";
            this.likeButton.UseVisualStyleBackColor = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.BackgroundImage = global::Database.Properties.Resources.backButton;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(-1, 33);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 34);
            this.backButton.TabIndex = 109;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.artistTab);
            this.tabControl2.Controls.Add(this.songTab);
            this.tabControl2.Controls.Add(this.albumTab);
            this.tabControl2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(263, 602);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(720, 460);
            this.tabControl2.TabIndex = 108;
            // 
            // artistTab
            // 
            this.artistTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.artistTab.Controls.Add(this.panel4);
            this.artistTab.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistTab.Location = new System.Drawing.Point(4, 38);
            this.artistTab.Name = "artistTab";
            this.artistTab.Padding = new System.Windows.Forms.Padding(3);
            this.artistTab.Size = new System.Drawing.Size(712, 418);
            this.artistTab.TabIndex = 1;
            this.artistTab.Text = "Artist Info";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.bioTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 412);
            this.panel4.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 34);
            this.label1.TabIndex = 46;
            // 
            // bioTextBox
            // 
            this.bioTextBox.BackColor = System.Drawing.Color.White;
            this.bioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bioTextBox.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioTextBox.ForeColor = System.Drawing.Color.Black;
            this.bioTextBox.Location = new System.Drawing.Point(3, 3);
            this.bioTextBox.Multiline = true;
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.ReadOnly = true;
            this.bioTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bioTextBox.Size = new System.Drawing.Size(700, 406);
            this.bioTextBox.TabIndex = 60;
            // 
            // songTab
            // 
            this.songTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.songTab.Controls.Add(this.artistSongDataGridView);
            this.songTab.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTab.Location = new System.Drawing.Point(4, 38);
            this.songTab.Name = "songTab";
            this.songTab.Padding = new System.Windows.Forms.Padding(3);
            this.songTab.Size = new System.Drawing.Size(712, 418);
            this.songTab.TabIndex = 0;
            this.songTab.Text = "Songs";
            // 
            // artistSongDataGridView
            // 
            this.artistSongDataGridView.AllowUserToAddRows = false;
            this.artistSongDataGridView.AllowUserToDeleteRows = false;
            this.artistSongDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.artistSongDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.artistSongDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.artistSongDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistSongDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.artistSongDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.artistSongDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistSongDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtistSongPic,
            this.ArtistSongName,
            this.Album,
            this.Duration,
            this.TotalStreams});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.artistSongDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.artistSongDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.artistSongDataGridView.Location = new System.Drawing.Point(6, 6);
            this.artistSongDataGridView.MultiSelect = false;
            this.artistSongDataGridView.Name = "artistSongDataGridView";
            this.artistSongDataGridView.ReadOnly = true;
            this.artistSongDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.artistSongDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.artistSongDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.artistSongDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.artistSongDataGridView.Size = new System.Drawing.Size(700, 406);
            this.artistSongDataGridView.TabIndex = 94;
            // 
            // ArtistSongPic
            // 
            this.ArtistSongPic.HeaderText = "";
            this.ArtistSongPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ArtistSongPic.Name = "ArtistSongPic";
            this.ArtistSongPic.ReadOnly = true;
            // 
            // ArtistSongName
            // 
            this.ArtistSongName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArtistSongName.HeaderText = "Title";
            this.ArtistSongName.Name = "ArtistSongName";
            this.ArtistSongName.ReadOnly = true;
            this.ArtistSongName.Width = 87;
            // 
            // Album
            // 
            this.Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Width = 109;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 134;
            // 
            // TotalStreams
            // 
            this.TotalStreams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalStreams.HeaderText = "Streams";
            this.TotalStreams.Name = "TotalStreams";
            this.TotalStreams.ReadOnly = true;
            this.TotalStreams.Width = 124;
            // 
            // albumTab
            // 
            this.albumTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.albumTab.Controls.Add(this.albumDataGridView);
            this.albumTab.Location = new System.Drawing.Point(4, 38);
            this.albumTab.Name = "albumTab";
            this.albumTab.Size = new System.Drawing.Size(712, 418);
            this.albumTab.TabIndex = 2;
            this.albumTab.Text = "Albums";
            // 
            // albumDataGridView
            // 
            this.albumDataGridView.AllowUserToAddRows = false;
            this.albumDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.albumDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.albumDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.albumDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.albumDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.albumDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.albumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumPic,
            this.AlbumName,
            this.ReleaseYear,
            this.NumOfSongs,
            this.AlbumDuration});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.albumDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.albumDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.albumDataGridView.Location = new System.Drawing.Point(6, 6);
            this.albumDataGridView.MultiSelect = false;
            this.albumDataGridView.Name = "albumDataGridView";
            this.albumDataGridView.ReadOnly = true;
            this.albumDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.albumDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.albumDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.albumDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.albumDataGridView.Size = new System.Drawing.Size(700, 406);
            this.albumDataGridView.TabIndex = 95;
            // 
            // AlbumPic
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AlbumPic.DefaultCellStyle = dataGridViewCellStyle6;
            this.AlbumPic.HeaderText = "";
            this.AlbumPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AlbumPic.Name = "AlbumPic";
            this.AlbumPic.ReadOnly = true;
            this.AlbumPic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AlbumPic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AlbumName.DefaultCellStyle = dataGridViewCellStyle7;
            this.AlbumName.HeaderText = "Album";
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.ReadOnly = true;
            this.AlbumName.Width = 109;
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReleaseYear.DefaultCellStyle = dataGridViewCellStyle8;
            this.ReleaseYear.HeaderText = "Release";
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.ReadOnly = true;
            this.ReleaseYear.Width = 120;
            // 
            // NumOfSongs
            // 
            this.NumOfSongs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NumOfSongs.DefaultCellStyle = dataGridViewCellStyle9;
            this.NumOfSongs.HeaderText = "Songs";
            this.NumOfSongs.Name = "NumOfSongs";
            this.NumOfSongs.ReadOnly = true;
            // 
            // AlbumDuration
            // 
            this.AlbumDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AlbumDuration.DefaultCellStyle = dataGridViewCellStyle10;
            this.AlbumDuration.HeaderText = "Duration";
            this.AlbumDuration.Name = "AlbumDuration";
            this.AlbumDuration.ReadOnly = true;
            this.AlbumDuration.Width = 134;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.artistLabel);
            this.panel3.Location = new System.Drawing.Point(0, 544);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 36);
            this.panel3.TabIndex = 107;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.White;
            this.artistLabel.Location = new System.Drawing.Point(50, 0);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(101, 34);
            this.artistLabel.TabIndex = 50;
            this.artistLabel.Text = "Artists";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Georgia", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.searchLabel.Location = new System.Drawing.Point(129, 18);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(0, 61);
            this.searchLabel.TabIndex = 106;
            // 
            // artistDataGridView
            // 
            this.artistDataGridView.AllowUserToAddRows = false;
            this.artistDataGridView.AllowUserToDeleteRows = false;
            this.artistDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.artistDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.artistDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.artistDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArtistPic,
            this.ArtistName});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.artistDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.artistDataGridView.GridColor = System.Drawing.Color.White;
            this.artistDataGridView.Location = new System.Drawing.Point(17, 642);
            this.artistDataGridView.Name = "artistDataGridView";
            this.artistDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.artistDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.artistDataGridView.Size = new System.Drawing.Size(227, 420);
            this.artistDataGridView.TabIndex = 105;
            this.artistDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.artistDataGridViewCellClick);
            // 
            // ArtistPic
            // 
            this.ArtistPic.HeaderText = "Artist Pic";
            this.ArtistPic.Name = "ArtistPic";
            this.ArtistPic.ReadOnly = true;
            this.ArtistPic.Width = 54;
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArtistName.HeaderText = "Artist Name";
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.ReadOnly = true;
            this.ArtistName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ArtistName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ArtistName.Width = 67;
            // 
            // songDataGridView
            // 
            this.songDataGridView.AllowUserToAddRows = false;
            this.songDataGridView.AllowUserToDeleteRows = false;
            this.songDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.songDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.songDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.songDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongPic,
            this.SongTitle});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.songDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.songDataGridView.GridColor = System.Drawing.Color.White;
            this.songDataGridView.Location = new System.Drawing.Point(769, 189);
            this.songDataGridView.Name = "songDataGridView";
            this.songDataGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.songDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.songDataGridView.Size = new System.Drawing.Size(212, 331);
            this.songDataGridView.TabIndex = 104;
            this.songDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.songDataGridViewCellClick);
            // 
            // SongPic
            // 
            this.SongPic.HeaderText = "Song Pic";
            this.SongPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SongPic.Name = "SongPic";
            this.SongPic.ReadOnly = true;
            this.SongPic.Width = 56;
            // 
            // SongTitle
            // 
            this.SongTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SongTitle.DefaultCellStyle = dataGridViewCellStyle16;
            this.SongTitle.HeaderText = "SongTitle";
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.ReadOnly = true;
            this.SongTitle.Width = 77;
            // 
            // songPicBox
            // 
            this.songPicBox.BackgroundImage = global::Database.Properties.Resources.Background;
            this.songPicBox.Location = new System.Drawing.Point(17, 152);
            this.songPicBox.Name = "songPicBox";
            this.songPicBox.Size = new System.Drawing.Size(496, 327);
            this.songPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPicBox.TabIndex = 103;
            this.songPicBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.songInfoTab);
            this.tabControl1.Controls.Add(this.Lyrics);
            this.tabControl1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(530, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 373);
            this.tabControl1.TabIndex = 102;
            // 
            // songInfoTab
            // 
            this.songInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.songInfoTab.Controls.Add(this.panel5);
            this.songInfoTab.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfoTab.Location = new System.Drawing.Point(4, 38);
            this.songInfoTab.Name = "songInfoTab";
            this.songInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.songInfoTab.Size = new System.Drawing.Size(214, 331);
            this.songInfoTab.TabIndex = 1;
            this.songInfoTab.Text = "Song Info";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel5.Controls.Add(this.songInfoTxtBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 325);
            this.panel5.TabIndex = 72;
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
            this.songInfoTxtBox.Size = new System.Drawing.Size(208, 325);
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
            this.Lyrics.Size = new System.Drawing.Size(214, 331);
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
            this.lyricsTxtBox.Size = new System.Drawing.Size(208, 325);
            this.lyricsTxtBox.TabIndex = 54;
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(17, 152);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(496, 372);
            this.musicPlayer.TabIndex = 101;
            this.musicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPlayer_PlayStateChange);
            this.musicPlayer.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.musicPlayer_CurrentItemChange);
            // 
            // tk_search_picture
            // 
            this.tk_search_picture.BackColor = System.Drawing.Color.White;
            this.tk_search_picture.BackgroundImage = global::Database.Properties.Resources.Picture31;
            this.tk_search_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tk_search_picture.Location = new System.Drawing.Point(44, 25);
            this.tk_search_picture.Name = "tk_search_picture";
            this.tk_search_picture.Size = new System.Drawing.Size(68, 47);
            this.tk_search_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tk_search_picture.TabIndex = 100;
            this.tk_search_picture.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(102)))));
            this.panel6.Controls.Add(this.songLabel);
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1011, 36);
            this.panel6.TabIndex = 99;
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel.ForeColor = System.Drawing.Color.White;
            this.songLabel.Location = new System.Drawing.Point(50, -1);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(92, 34);
            this.songLabel.TabIndex = 50;
            this.songLabel.Text = "Songs";
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 766);
            this.Controls.Add(this.panel1);
            this.Name = "SearchResults";
            this.Text = "Genre";
            this.Load += new System.EventHandler(this.Genre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.artistTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.songTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistSongDataGridView)).EndInit();
            this.albumTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPicBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.songInfoTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Lyrics.ResumeLayout(false);
            this.Lyrics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_search_picture)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox artistNameComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox artistIdTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox artistPicTxtBox1;
        private System.Windows.Forms.Button browseButton1;
        private System.Windows.Forms.TextBox bioTxtBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox listenersTxtBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox followersTxtBox;
        private System.Windows.Forms.TextBox monthTxtBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private Panel panel1;
        private Panel panel2;
        private ComboBox playlistComboBox;
        private Button addToPlaylistButton;
        private Button likeButton;
        private Button backButton;
        private TabControl tabControl2;
        private TabPage artistTab;
        private Panel panel4;
        private Label label1;
        private TextBox bioTextBox;
        private TabPage songTab;
        private DataGridView artistSongDataGridView;
        private DataGridViewImageColumn ArtistSongPic;
        private DataGridViewTextBoxColumn ArtistSongName;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn TotalStreams;
        private TabPage albumTab;
        private DataGridView albumDataGridView;
        private DataGridViewImageColumn AlbumPic;
        private DataGridViewTextBoxColumn AlbumName;
        private DataGridViewTextBoxColumn ReleaseYear;
        private DataGridViewTextBoxColumn NumOfSongs;
        private DataGridViewTextBoxColumn AlbumDuration;
        private Panel panel3;
        private Label artistLabel;
        private Label searchLabel;
        private DataGridView artistDataGridView;
        private DataGridViewImageColumn ArtistPic;
        private DataGridViewTextBoxColumn ArtistName;
        private DataGridView songDataGridView;
        private PictureBox songPicBox;
        private TabControl tabControl1;
        private TabPage songInfoTab;
        private Panel panel5;
        private TextBox songInfoTxtBox;
        private Label label6;
        private TabPage Lyrics;
        private TextBox lyricsTxtBox;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private PictureBox tk_search_picture;
        private Panel panel6;
        private Label songLabel;
        private Panel panel7;
        private DataGridViewImageColumn SongPic;
        private DataGridViewTextBoxColumn SongTitle;
    }
}