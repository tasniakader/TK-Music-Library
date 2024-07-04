using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Net;
using WMPLib;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using AxWMPLib;
using System.Runtime.CompilerServices;

namespace Database
{
    public partial class Admin : Form
    {
        static bool loaded = false;
        public Admin()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection("Data Source=LAPTOP-E031DC8S\\SQLEXPRESS;Initial Catalog=DigitalMusicLibraryTK;Integrated Security=True");
            sqlConnection1.Open();
        }

        private void databaseTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Admin_Load(sender, e);
            addingNewArtist = false;
            addingNewSong = false;
            addingNewAlbum = false;

            updateArtistButton.Enabled = true;
            deleteArtistButton.Enabled = true;

            updateSongButton.Enabled = true;
            deleteSongButton.Enabled = true;

            updateAlbumButton.Enabled = true;
            deleteAlbumButton.Enabled = true;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            adminArtistBindingNavigator_Load();
            adminSongBindingNavigator_Load();
            adminAlbumBindingNavigator_Load();

            loaded = true;
        }

        // Clear Album Tab

        private void clearAlbumTab()
        {
            albumTitleTxtBox.Text = string.Empty;
            albumArtistTxtBox.Text = string.Empty;
            releaseYearTxtBox.Text = string.Empty;
            albumPicTxtBox.Text = string.Empty;
            albumPicBox.Image = Database.Properties.Resources.Background;
            albumDurationTxtBox.Text = string.Empty;
            albumSongsTxtBox.Text = string.Empty;
        }

        // Album Binding Navigator

        private void adminAlbumBindingNavigator_Load()
        {
            clearAlbumTab();

            SqlDataAdapter albumAdapter = new SqlDataAdapter();

            BindingSource bindingSource3 = new BindingSource();

            DataTable albumTable = new DataTable();
            albumAdapter.SelectCommand = new SqlCommand("SELECT AlbumName, AlbumId FROM ALBUM ORDER BY AlbumId", sqlConnection1);
            albumAdapter.Fill(albumTable);

            bindingSource3.DataSource = albumTable;
            adminAlbumBindingNavigator.BindingSource = bindingSource3;
            albumNameToolStripComboBox.ComboBox.DataSource = bindingSource3;
            albumNameToolStripComboBox.ComboBox.DisplayMember = "albumName";
            albumIdToolStripComboBox.ComboBox.DataSource = bindingSource3;
            albumIdToolStripComboBox.ComboBox.DisplayMember = "albumId";

            albumIdToolStripComboBox_SelectedIndexChanged(null, EventArgs.Empty);
        }

        // Retrieve album from database

        private void albumIdToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded)
                return;

            clearAlbumTab();

            try
            {
                albumTitleTxtBox.Text = albumNameToolStripComboBox.Text;

                SqlCommand cmdAlbumInfo = sqlConnection1.CreateCommand();
                cmdAlbumInfo.CommandText = @"SELECT COUNT(DISTINCT S.SongId) AS NumOfSongs, ReleaseYear, CONVERT(TIME, DATEADD(SECOND, SUM(DATEDIFF(SECOND, '00:00:00', S.Duration)), '00:00:00')) AS TotalDuration, PA.ArtistName, AlbumCover
                                             FROM ALBUM A
                                                     LEFT JOIN SONGALBUM SA ON A.AlbumId = SA.AlbumId
                                                     LEFT JOIN SONG S ON SA.SongId = S.SongId
                                                     LEFT JOIN SUNGBY SP ON S.SongId = SP.SongId AND SP.ArtistRole = 'P'
                                                     LEFT JOIN SUNGBY SF ON S.SongId = SF.SongId AND SF.ArtistRole = 'F'
                                                     LEFT JOIN ARTIST PA ON SP.ArtistId = PA.ArtistId
                                                     LEFT JOIN ARTIST FA ON SF.ArtistId = FA.ArtistId
                                                     WHERE A.AlbumId = @AlbumId
                                                     GROUP BY ReleaseYear, PA.ArtistName, AlbumCover";

                cmdAlbumInfo.Parameters.AddWithValue("@AlbumId", albumIdToolStripComboBox.Text);

                SqlDataReader reader = cmdAlbumInfo.ExecuteReader();

                if (reader.Read())
                {
                    albumSongsTxtBox.Text = reader[0].ToString();
                    releaseYearTxtBox.Text = reader[1].ToString();
                    albumDurationTxtBox.Text = reader[2].ToString();
                    albumArtistTxtBox.Text = reader[3].ToString();

                    if (reader[4] != DBNull.Value)
                    {
                        albumPicTxtBox.Text = reader[4].ToString();

                        try
                        {
                            albumPicBox.Image = Image.FromFile(albumPicTxtBox.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Image file could not be opened" + Environment.NewLine + ex, "Error");
                        }
                    }
                    else
                    {
                        albumPicTxtBox.Text = string.Empty;
                        albumPicBox.Image = Database.Properties.Resources.Background;
                    }
                }

                reader.Close();

                if(string.IsNullOrEmpty(albumDurationTxtBox.Text) && !string.IsNullOrEmpty(albumTitleTxtBox.Text)) 
                {
                    albumDurationTxtBox.Text = "00:00:00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while loading the albums" + Environment.NewLine + ex.Message, "Error");
            }
        }

        private bool addingNewAlbum = false;

        // Add new album

        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            int endingPosition = albumIdToolStripComboBox.Items.Count;

            if (!addingNewAlbum)
            {
                clearAlbumTab();
                albumIdToolStripComboBox.Text = string.Empty;
                albumNameToolStripComboBox.Text = string.Empty;
                albumBindingNavigatorPosition.Text = (endingPosition + 1).ToString();
                albumBindingNavigatorCountItem.Text = (endingPosition + 1).ToString();
                addingNewAlbum = true;
                updateAlbumButton.Enabled = false;
                deleteAlbumButton.Enabled = false;
            }
            else
            {
                try
                {
                    SqlCommand cmdAlbumInfo = sqlConnection1.CreateCommand();

                    cmdAlbumInfo.CommandText = @"INSERT INTO ALBUM(AlbumName, ReleaseYear, AlbumCover)
                                                  VALUES(@AlbumName, @ReleaseYear, @AlbumCover)";


                    cmdAlbumInfo.Parameters.AddWithValue("@AlbumName", albumTitleTxtBox.Text);
                    cmdAlbumInfo.Parameters.AddWithValue("@ReleaseYear", releaseYearTxtBox.Text);

                    if (albumPicTxtBox.Text != string.Empty)
                    {
                        cmdAlbumInfo.Parameters.AddWithValue("@AlbumCover", albumPicTxtBox.Text);
                        albumPicBox.Image = Image.FromFile(albumPicTxtBox.Text);
                    }
                    else
                    {
                        cmdAlbumInfo.Parameters.AddWithValue("@AlbumCover", DBNull.Value);
                    }

                    cmdAlbumInfo.ExecuteNonQuery();

                    adminAlbumBindingNavigator_Load();
                    albumNameToolStripComboBox.SelectedIndex = endingPosition;
                    MessageBox.Show("Album has been added to the database", "Insertion Complete");
                    updateAlbumButton.Enabled = true;
                    deleteAlbumButton.Enabled = true;
                    addingNewAlbum = false;
                }
                catch (Exception ex)
                {
                    addingNewAlbum = true;
                    MessageBox.Show("Album could not be added to the database. Please ensure data has been entered correctly." + Environment.NewLine + ex.Message, "Error");
                }
            }

        }

        // Update album info
        private void updateAlbumButton_Click(object sender, EventArgs e)
        {
            if (albumNameToolStripComboBox.Items.Count == 0) { return; }

            int position = albumNameToolStripComboBox.SelectedIndex;

            SqlCommand cmdUpdateAlbumInfo = sqlConnection1.CreateCommand();

            try
            {
                cmdUpdateAlbumInfo.CommandText = @"UPDATE ALBUM
                                                  SET AlbumName = @AlbumName, ReleaseYear = @ReleaseYear, AlbumCover = @AlbumCover
                                                  WHERE AlbumId = @AlbumId";

                cmdUpdateAlbumInfo.Parameters.AddWithValue("@AlbumId", albumIdToolStripComboBox.Text);
                cmdUpdateAlbumInfo.Parameters.AddWithValue("@AlbumName", albumTitleTxtBox.Text);
                cmdUpdateAlbumInfo.Parameters.AddWithValue("@ReleaseYear", releaseYearTxtBox.Text);

                if (albumPicTxtBox.Text != string.Empty)
                {
                    cmdUpdateAlbumInfo.Parameters.AddWithValue("@AlbumCover", albumPicTxtBox.Text);
                    albumPicBox.Image = Image.FromFile(albumPicTxtBox.Text);
                }
                else
                {
                    cmdUpdateAlbumInfo.Parameters.AddWithValue("@AlbumCover", DBNull.Value);
                }


                cmdUpdateAlbumInfo.ExecuteNonQuery();

                adminAlbumBindingNavigator_Load();
                albumNameToolStripComboBox.SelectedIndex = position;
                MessageBox.Show("Song was succefully updated", "Update Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Album information could not be updated. Please ensure data has been entered correctly." + Environment.NewLine + ex.Message, "Error");
            }
        }

        // Delete album

        private void deleteAlbumButton_Click(object sender, EventArgs e)
        {
            if (albumBindingNavigatorCountItem.Text == "of 0")
                return;

            int position = int.Parse(albumBindingNavigatorPosition.Text);

            SqlCommand cmdDeleteAlbum = sqlConnection1.CreateCommand();

            try
            {
                cmdDeleteAlbum.CommandText = @"DELETE FROM SONG
                                               WHERE SongId IN (SELECT S.SongId 
                                                                FROM SONG S 
                                                                     LEFT JOIN SONGALBUM SA ON S.SongId = SA.SongId 
                                                                WHERE AlbumId = @AlbumId);
                                               DELETE FROM ALBUM
                                               WHERE AlbumId = @AlbumId;";

                cmdDeleteAlbum.Parameters.AddWithValue("@AlbumId", albumIdToolStripComboBox.Text);

                cmdDeleteAlbum.ExecuteNonQuery();
                Admin_Load(sender, null);

                if (albumBindingNavigatorCountItem.Text == "of 0")
                {
                    clearAlbumTab();
                    albumIdToolStripComboBox.Text = string.Empty;
                    albumNameToolStripComboBox.Text = string.Empty;
                }

                MessageBox.Show("Album was deleted from the database", "Deletion Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Album could not be deleted." + Environment.NewLine + ex.Message, "Error");
            }
        }

        // Clear Song Tab

        private void clearSongTab()
        {
            songTitleTxtBox.Text = string.Empty;
            artistComboBox.Text = string.Empty;
            featuringComboBox.Text = string.Empty;
            albumComboBox.Text = string.Empty;
            genreComboBox.Text = string.Empty;
            browseMusicTxtBox.Text = string.Empty;
            lyricsTxtBox.Text = string.Empty;
            durationTxtBox.Text = string.Empty;
            numOfLikesTxtBox.Text = string.Empty;
            numOfListenersTxtBox.Text = string.Empty;

            if (musicPlayer.currentPlaylist != null)
            {
                musicPlayer.currentPlaylist.clear();
            }

            songPicBox.Image = Database.Properties.Resources.Background;
            songPicTxtBox.Text = string.Empty;
        }

        // Song Binding Navigator

        private void adminSongBindingNavigator_Load()
        {
            clearSongTab();
            songIdComboBox.Text = string.Empty;
            songToolStripComboBox.Text = string.Empty;

            musicPlayer.Ctlcontrols.stop();

            SqlDataAdapter songAdapter = new SqlDataAdapter();
            SqlDataAdapter artistAdapter = new SqlDataAdapter();
            SqlDataAdapter albumAdapter = new SqlDataAdapter();

            BindingSource bindingSource2 = new BindingSource();

            DataTable songTable = new DataTable();
            songAdapter.SelectCommand = new SqlCommand("SELECT SongTitle, SongId FROM SONG ORDER BY SongId", sqlConnection1);
            songAdapter.Fill(songTable);

            bindingSource2.DataSource = songTable;
            adminSongBindingNavigator.BindingSource = bindingSource2;
            songToolStripComboBox.ComboBox.DataSource = bindingSource2;
            songToolStripComboBox.ComboBox.DisplayMember = "SongTitle";
            songIdComboBox.ComboBox.DataSource = bindingSource2;
            songIdComboBox.ComboBox.DisplayMember = "SongId";

            DataTable artistTable = new DataTable();
            DataTable featuringTable = new DataTable();
            artistAdapter.SelectCommand = new SqlCommand("SELECT ArtistName FROM ARTIST ORDER BY ArtistId", sqlConnection1);

            artistAdapter.Fill(artistTable);
            artistAdapter.Fill(featuringTable);

            artistComboBox.DataSource = artistTable;
            artistComboBox.DisplayMember = "ArtistName";

            DataRow blankRow = featuringTable.NewRow();
            blankRow["ArtistName"] = "";
            featuringTable.Rows.InsertAt(blankRow, 0);

            featuringComboBox.DataSource = featuringTable;
            featuringComboBox.DisplayMember = "ArtistName";

            DataTable albumTable = new DataTable();
            albumAdapter.SelectCommand = new SqlCommand("SELECT AlbumName FROM ALBUM ORDER BY AlbumId", sqlConnection1);
            albumAdapter.Fill(albumTable);

            blankRow = albumTable.NewRow();
            blankRow["AlbumName"] = "";
            albumTable.Rows.InsertAt(blankRow, 0);

            albumComboBox.DataSource = albumTable;
            albumComboBox.DisplayMember = "AlbumName";


            musicPlayer.settings.autoStart = false;
            songIdComboBox_SelectedIndexChanged(null, EventArgs.Empty);
        }

        // Retrieve Song info from database

        private void songIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loaded)
                return;

            clearSongTab();

            try
            {
                songTitleTxtBox.Text = songToolStripComboBox.Text;

                SqlCommand cmdSongInfo = sqlConnection1.CreateCommand();
                cmdSongInfo.CommandText = @"SELECT Music, PA.ArtistName AS PrimaryArtistName, 
                                            FA.ArtistName AS FeaturingArtistName, AlbumName, Genre, Lyrics, 
                                            S.Duration, S.NumOfLikes, S.TotalStreams, SongPic
                                            FROM SONG S
                                                 LEFT JOIN SUNGBY SP ON S.SongId = SP.SongId AND SP.ArtistRole = 'P'
                                                 LEFT JOIN SUNGBY SF ON S.SongId = SF.SongId AND SF.ArtistRole = 'F'
                                                 LEFT JOIN ARTIST PA ON SP.ArtistId = PA.ArtistId
                                                 LEFT JOIN ARTIST FA ON SF.ArtistId = FA.ArtistId
                                                 LEFT JOIN SONGALBUM SA ON S.SongId = SA.SongId
                                                 LEFT JOIN ALBUM A ON SA.AlbumId = A.AlbumId
                                                 WHERE S.SongId = @SongId";

                cmdSongInfo.Parameters.AddWithValue("@SongId", songIdComboBox.Text);

                SqlDataReader reader = cmdSongInfo.ExecuteReader();

                if (reader.Read())
                {

                    browseMusicTxtBox.Text = reader[0].ToString();

                    if (!string.IsNullOrEmpty(browseMusicTxtBox.Text))
                    {
                        musicPlayer.URL = browseMusicTxtBox.Text;
                    }

                    artistComboBox.Text = reader[1].ToString();
                    featuringComboBox.Text = reader[2].ToString();
                    albumComboBox.Text = reader[3].ToString();
                    genreComboBox.Text = reader[4].ToString();
                    lyricsTxtBox.Text = reader[5].ToString();
                    durationTxtBox.Text = reader[6].ToString();
                    numOfLikesTxtBox.Text = reader[7].ToString();
                    numOfListenersTxtBox.Text = reader[8].ToString();

                    if (reader[9] != DBNull.Value)
                    {
                        songPicTxtBox.Text = reader[9].ToString();

                        try
                        {
                            songPicBox.Image = Image.FromFile(songPicTxtBox.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Image file could not be opened" + Environment.NewLine + ex.Message, "ERROR");
                        }
                    }
                    else
                    {
                        songPicTxtBox.Text = string.Empty;
                        songPicBox.Image = Database.Properties.Resources.Background;
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while loading the songs." + Environment.NewLine + ex.Message, "Error");
            }

        }

        // Add New Song

        private bool addingNewSong = false;

        private void addSongButton_Click(object sender, EventArgs e)
        {
            int endingPosition = songToolStripComboBox.Items.Count;

            if (!addingNewSong)
            {
                clearSongTab();
                songIdComboBox.Text = string.Empty;
                songToolStripComboBox.Text = string.Empty;
                songBindingNavigatorPosition.Text = (endingPosition + 1).ToString();
                songBindingNavigatorCountItem.Text = (endingPosition + 1).ToString();
                addingNewSong = true;
                updateSongButton.Enabled = false;
                deleteSongButton.Enabled = false;
                musicPlayer.currentPlaylist.clear();
            }
            else
            {
                try
                {
                    SqlTransaction transaction = sqlConnection1.BeginTransaction();

                    try
                    {
                        SqlCommand cmdSongInfo = sqlConnection1.CreateCommand();
                        cmdSongInfo.Transaction = transaction;

                        cmdSongInfo.CommandText = @"INSERT INTO SONG(SongTitle, Lyrics, Duration, Genre, Music, SongPic)
                                                VALUES(@SongTitle, @Lyrics, @Duration, @Genre, @Music, @SongPic)";

                        cmdSongInfo.Parameters.AddWithValue("@Lyrics", lyricsTxtBox.Text);
                        cmdSongInfo.Parameters.AddWithValue("@Music", browseMusicTxtBox.Text);
                        musicPlayer.URL = browseMusicTxtBox.Text;
                        cmdSongInfo.Parameters.AddWithValue("@Duration", getDuration());
                        cmdSongInfo.Parameters.AddWithValue("@Genre", genreComboBox.Text);
                        cmdSongInfo.Parameters.AddWithValue("@SongTitle", Path.GetFileNameWithoutExtension(browseMusicTxtBox.Text));

                        if (songPicTxtBox.Text != string.Empty)
                        {
                            cmdSongInfo.Parameters.AddWithValue("@SongPic", songPicTxtBox.Text);
                            songPicBox.Image = Image.FromFile(songPicTxtBox.Text);
                        }
                        else
                        {
                            cmdSongInfo.Parameters.AddWithValue("@SongPic", DBNull.Value);
                        }

                        cmdSongInfo.ExecuteNonQuery();

                        cmdSongInfo.CommandText = @"DECLARE @MaxSongId INT;
                                                SELECT @MaxSongId = MAX(SongId) FROM SONG;
                                                DECLARE @PArtistId INT;
                                                SELECT @PArtistId = ArtistId FROM ARTIST WHERE ArtistName = @PArtistName;
                                                INSERT INTO SUNGBY(SongId, ArtistId, ArtistRole)
                                                VALUES(@MaxSongId, @PArtistId, 'P');";

                        cmdSongInfo.Parameters.AddWithValue("@PArtistName", artistComboBox.Text);

                        cmdSongInfo.ExecuteNonQuery();

                        if (featuringComboBox.Text != "")
                        {
                            cmdSongInfo.CommandText = @"DECLARE @MaxSongId INT;
                                                    SELECT @MaxSongId = MAX(SongId) FROM SONG;
                                                    DECLARE @FArtistId INT;
                                                    SELECT @FArtistId = ArtistId FROM ARTIST WHERE ArtistName = @FArtistName;
                                                    INSERT INTO SUNGBY(SongId, ArtistId, ArtistRole)
                                                    VALUES(@MaxSongId, @FArtistId, 'F');";

                            cmdSongInfo.Parameters.AddWithValue("@FArtistName", featuringComboBox.Text);
                            cmdSongInfo.ExecuteNonQuery();
                        }

                        if (albumComboBox.Text != "")
                        {
                            cmdSongInfo.CommandText = @"DECLARE @MaxSongId INT;
                                                    SELECT @MaxSongId = MAX(SongId) FROM SONG;
                                                    DECLARE @AlbumId INT;
                                                    SELECT @AlbumId = AlbumId From ALBUM WHERE AlbumName = @AlbumName;
                                                    INSERT INTO SONGALBUM(SongId, AlbumId)
                                                    VALUES(@MaxSongId, @AlbumId)";

                            cmdSongInfo.Parameters.AddWithValue("@AlbumName", albumComboBox.Text);

                            cmdSongInfo.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        adminSongBindingNavigator_Load();
                        songToolStripComboBox.SelectedIndex = endingPosition;
                        MessageBox.Show("Song has been added to the database", "Insertion Complete");
                        updateSongButton.Enabled = true;
                        deleteSongButton.Enabled = true;
                        addingNewSong = false;
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Song could not be added to the database. Please ensure data has been entered correctly." + Environment.NewLine + ex.Message, "Error");

                    }
                }
                catch (Exception ex)
                {
                    addingNewSong = true;
                    MessageBox.Show("An error occurred while attempting to add a song." + Environment.NewLine + ex.Message, "Error");
                }
            }

        }

        // Update Song Info

        private void UpdateSongButton_Click(object sender, EventArgs e)
        {
            if (songToolStripComboBox.Items.Count == 0) { return; }

            int position = songToolStripComboBox.SelectedIndex;

            SqlCommand cmdUpdateSongInfo = sqlConnection1.CreateCommand();

            try
            {
                cmdUpdateSongInfo.CommandText = @"UPDATE SONG
                                                  SET SongTitle = @SongTitle, Lyrics = @Lyrics, Genre = @Genre, Music = @Music, SongPic = @SongPic
                                                  WHERE SongId = @SongId
                                                  DECLARE @PArtistId INT;
                                                  SELECT @PArtistId = ArtistId FROM ARTIST WHERE ArtistName = @PArtistName;
                                                  Update SUNGBY SET ArtistId = @PArtistId WHERE SongId = @SongId AND ArtistRole = 'P';";

                cmdUpdateSongInfo.Parameters.AddWithValue("@SongTitle", Path.GetFileNameWithoutExtension(browseMusicTxtBox.Text));
                cmdUpdateSongInfo.Parameters.AddWithValue("@Lyrics", lyricsTxtBox.Text);
                cmdUpdateSongInfo.Parameters.AddWithValue("@Genre", genreComboBox.Text);
                cmdUpdateSongInfo.Parameters.AddWithValue("@Music", browseMusicTxtBox.Text);
                cmdUpdateSongInfo.Parameters.AddWithValue("@SongId", songIdComboBox.Text);
                cmdUpdateSongInfo.Parameters.AddWithValue("@PArtistName", artistComboBox.Text);

                if (songPicTxtBox.Text != string.Empty)
                {
                    cmdUpdateSongInfo.Parameters.AddWithValue("@SongPic", songPicTxtBox.Text);
                    songPicBox.Image = Image.FromFile(songPicTxtBox.Text);
                }
                else
                {
                    cmdUpdateSongInfo.Parameters.AddWithValue("@SongPic", DBNull.Value);
                }


                cmdUpdateSongInfo.ExecuteNonQuery();

                try
                {
                    musicPlayer.URL = browseMusicTxtBox.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The media file could not be opened." + Environment.NewLine + ex.Message, "Error");
                }

                cmdUpdateSongInfo.CommandText = @"UPDATE SONG SET Duration = @Duration WHERE SongId = @SongId";
                cmdUpdateSongInfo.Parameters.AddWithValue("@Duration", getDuration());
                cmdUpdateSongInfo.ExecuteNonQuery();

                if (featuringComboBox.Text != "")
                {
                    cmdUpdateSongInfo.CommandText = @"DECLARE @FArtistId INT;
                                                      SELECT @FArtistId = ArtistId FROM ARTIST WHERE ArtistName = @FArtistName;
                                                      IF EXISTS (SELECT SongId FROM SUNGBY WHERE SongId = @SongId AND ArtistRole = 'F')
                                                      BEGIN
                                                        Update SUNGBY SET ArtistId = @FArtistId WHERE SongId = SongId AND ArtistRole = 'F';;
                                                      END
                                                      ELSE
                                                      BEGIN
                                                          INSERT INTO SUNGBY (SongId, ArtistId, ArtistRole) VALUES (@SongId, @FArtistId, 'F');
                                                      END;";

                    cmdUpdateSongInfo.Parameters.AddWithValue("@FArtistName", featuringComboBox.Text);

                    cmdUpdateSongInfo.ExecuteNonQuery();
                }
                else
                {
                    cmdUpdateSongInfo.CommandText = @"IF EXISTS (SELECT SongId FROM SUNGBY WHERE SongId = @SongId AND ArtistRole = 'F')
                                                      BEGIN
                                                         DELETE SUNGBY WHERE SongId = @SongId AND ArtistRole = 'F';
                                                      END";

                    cmdUpdateSongInfo.ExecuteNonQuery();
                }

                if (albumComboBox.Text != "")
                {
                    cmdUpdateSongInfo.CommandText = @"DECLARE @AlbumId INT;
                                                      SELECT @AlbumId = AlbumId FROM ALBUM WHERE AlbumName = @AlbumName
                                                      IF EXISTS (SELECT SongId FROM SONGALBUM WHERE SongId = @SongId)
                                                      BEGIN
                                                         UPDATE SONGALBUM SET AlbumId = @AlbumId WHERE SongId = @SongId;
                                                      END
                                                      ELSE
                                                      BEGIN
                                                          INSERT INTO SONGALBUM (SongId, AlbumId) VALUES (@SongId, @AlbumId);
                                                      END;";

                    cmdUpdateSongInfo.Parameters.AddWithValue("@AlbumName", albumComboBox.Text);

                    cmdUpdateSongInfo.ExecuteNonQuery();
                }
                else
                {
                    cmdUpdateSongInfo.CommandText = @"IF EXISTS (SELECT SongId FROM SONGALBUM WHERE SongId = @SongId)
                                                      BEGIN
                                                         DELETE SONGALBUM WHERE SongId = @SongId;
                                                      END";

                    cmdUpdateSongInfo.ExecuteNonQuery();
                }

                adminSongBindingNavigator_Load();
                songToolStripComboBox.SelectedIndex = position;
                MessageBox.Show("Song was succefully updated", "Update Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Song information could not be updated. Please ensure data has been entered correctly." + Environment.NewLine + ex.Message, "Error");
            }
        }

        private void deleteSongButton_Click(object sender, EventArgs e)
        {
            if (songBindingNavigatorCountItem.Text == "of 0") return;

            int position = int.Parse(songBindingNavigatorPosition.Text);

            SqlCommand cmdDeleteSong = sqlConnection1.CreateCommand();

            try
            {
                cmdDeleteSong.CommandText = @"DELETE SONG
                                              WHERE SongId = @id;
                                              DELETE SONGALBUM
                                              WHERE SongId = @id";

                cmdDeleteSong.Parameters.AddWithValue("@id", songIdComboBox.Text);

                cmdDeleteSong.ExecuteNonQuery();
                Admin_Load(sender, null);
                if (songBindingNavigatorCountItem.Text == "of 0") clearSongTab();
                MessageBox.Show("Song was deleted from the database", "Deletion Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Song could not be deleted." + Environment.NewLine + ex.Message, "Error");
            }
        }

        // Upload music

        private void musicBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                openFileDialog.Title = "Upload Music";
                openFileDialog.FileName = string.Empty;
                openFileDialog.Filter = "Audio Files(*.WAV; *.MP3; *.OGG; *.FLAC; *.MP4)|*.WAV; *.MP3; *.PGG; *.FLAC; *.MP4";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    browseMusicTxtBox.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Media could not be uploaded." + Environment.NewLine + ex.Message, "ERROR");
            }

        }

        // Clear Artist Tab

        private void clearArtistTab()
        {
            artistNameTxtBox.Text = string.Empty;
            bioTxtBox.Text = string.Empty;
            listenersTxtBox.Text = string.Empty;
            numOfSongsTxtBox.Text = string.Empty;
            numOfAlbumsTxtBox.Text = string.Empty;
            artistPicBox.Image = Database.Properties.Resources.Background;
            artistToolStripComboBox.Text = string.Empty;
            artistIdToolStripComboBox.Text = string.Empty;
            artistPicTxtBox.Text = string.Empty;
        }

        // Artist Binding Navigator

        private void adminArtistBindingNavigator_Load()
        {
            clearArtistTab();

            DataTable artistTable = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT ArtistName, ArtistId FROM ARTIST ORDER BY ArtistId", sqlConnection1);

            adapter1.Fill(artistTable);

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = artistTable;

            adminArtistBindingNavigator.BindingSource = bindingSource1;
            artistToolStripComboBox.ComboBox.DataSource = bindingSource1;
            artistToolStripComboBox.ComboBox.DisplayMember = "ArtistName";
            artistIdToolStripComboBox.ComboBox.DataSource = bindingSource1;
            artistIdToolStripComboBox.ComboBox.DisplayMember = "ArtistId";

            artistIdToolStripComboBox_SelectedIndexChanged(null, EventArgs.Empty);
        }

        // Retrieve Artist info from database

        private void artistIdToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                artistNameTxtBox.Text = artistToolStripComboBox.Text;

                SqlCommand cmdArtistInfo = sqlConnection1.CreateCommand();
                cmdArtistInfo.CommandText = @"SELECT Bio, Count(SU.SongId) AS NumOfSongs, Count(AL.AlbumId) AS NumOfAlbums, ArtistPic
                                              FROM ARTIST AR
                                                      LEFT JOIN SUNGBY SU ON AR.ArtistId = SU.ArtistId
                                                      LEFT JOIN SONG SO ON SU.SongId = SO.SongId
                                                      LEFT JOIN SONGALBUM SA ON SO.SongId = SA.SongId
                                                      LEFT JOIN ALBUM AL ON SA.AlbumId = AL.AlbumId
                                              WHERE ArtistName = @ArtistName
                                              GROUP BY ArtistPic, Bio;
                                              SELECT SUM(TotalStreams)
                                              FROM ARTIST AR
                                              LEFT JOIN SUNGBY SU ON AR.ArtistId = SU.ArtistId
                                              LEFT JOIN SONG SO ON SU.SongId = SO.SongId
                                              WHERE ArtistName = @ArtistName;";

                cmdArtistInfo.Parameters.AddWithValue("@ArtistName", artistNameTxtBox.Text);

                SqlDataReader reader = cmdArtistInfo.ExecuteReader();

                if (reader.Read())
                {
                    bioTxtBox.Text = reader[0].ToString();
                    numOfSongsTxtBox.Text = reader[1].ToString();
                    numOfAlbumsTxtBox.Text = reader[2].ToString();

                    if (reader[3] != DBNull.Value)
                    {
                        artistPicTxtBox.Text = reader[3].ToString();

                        try
                        {
                            artistPicBox.Image = Image.FromFile(artistPicTxtBox.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Image file could not be opened" + Environment.NewLine + ex.Message, "Error");
                        }
                    }
                    else
                    {
                        artistPicTxtBox.Text = string.Empty;
                        artistPicBox.Image = Database.Properties.Resources.Background;
                    }
                }

                reader.NextResult();

                if (reader.Read())
                {
                    listenersTxtBox.Text = reader[0].ToString();
                }

                if(string.IsNullOrEmpty(listenersTxtBox.Text) && !string.IsNullOrEmpty(artistNameTxtBox.Text))
                {
                    listenersTxtBox.Text = "0";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while loading the artists" + Environment.NewLine + ex.Message, "Error");
            }
        }

        // Add New Artist

        private bool addingNewArtist = false;

        private void addArtistButton_Click(object sender, EventArgs e)
        {
            int endingPosition = artistToolStripComboBox.Items.Count;

            if (!addingNewArtist)
            {
                clearArtistTab();
                artistBindingNavigatorPosition.Text = (endingPosition + 1).ToString();
                artistBindingNavigatorCountItem.Text = (endingPosition + 1).ToString();
                addingNewArtist = true;
                updateArtistButton.Enabled = false;
                deleteArtistButton.Enabled = false;
            }
            else
            {
                try
                {
                    SqlCommand cmdArtistInfo = sqlConnection1.CreateCommand();

                    cmdArtistInfo.CommandText = @"INSERT INTO ARTIST(ArtistName, Bio, ArtistPic)
                                                  VALUES(@ArtistName, @ArtistBio, @ArtistPic)";

                    cmdArtistInfo.Parameters.AddWithValue("@ArtistName", artistNameTxtBox.Text);
                    cmdArtistInfo.Parameters.AddWithValue("@ArtistBio", bioTxtBox.Text);

                    if (artistPicTxtBox.Text != string.Empty)
                    {
                        cmdArtistInfo.Parameters.AddWithValue("@ArtistPic", artistPicTxtBox.Text);
                        artistPicBox.Image = Image.FromFile(artistPicTxtBox.Text);
                    }
                    else
                    {
                        cmdArtistInfo.Parameters.AddWithValue("@ArtistPic", DBNull.Value);
                    }

                    cmdArtistInfo.ExecuteNonQuery();

                    adminArtistBindingNavigator_Load();
                    artistToolStripComboBox.SelectedIndex = endingPosition;
                    MessageBox.Show("Artist has been added to the database", "Insertion Complete");
                    updateArtistButton.Enabled = true;
                    deleteArtistButton.Enabled = true;
                    addingNewArtist = false;
                }
                catch (Exception ex)
                {
                    addingNewArtist = true;
                    MessageBox.Show("Artist could not be added to the database. Please ensure data has been entered correctly." + Environment.NewLine + ex.Message, "Error");
                }
            }
        }

        // Update Artist Information

        private void updateArtistButton_Click(object sender, EventArgs e)
        {
            if (artistToolStripComboBox.Items.Count == 0) { return; }

            int position = artistToolStripComboBox.SelectedIndex;

            SqlCommand cmdUpdateArtistInfo = sqlConnection1.CreateCommand();

            try
            {
                cmdUpdateArtistInfo.CommandText = @"UPDATE ARTIST
                                                    SET ArtistName = @name, Bio = @bio, ArtistPic = @pic
                                                    WHERE ArtistId = @id";

                cmdUpdateArtistInfo.Parameters.AddWithValue("@name", artistNameTxtBox.Text);
                cmdUpdateArtistInfo.Parameters.AddWithValue("@bio", bioTxtBox.Text);
                cmdUpdateArtistInfo.Parameters.AddWithValue("@id", artistIdToolStripComboBox.Text);


                if (artistPicTxtBox.Text != string.Empty)
                {
                    cmdUpdateArtistInfo.Parameters.AddWithValue("@pic", artistPicTxtBox.Text);
                    artistPicBox.Image = Image.FromFile(artistPicTxtBox.Text);
                }
                else
                {
                    cmdUpdateArtistInfo.Parameters.AddWithValue("@pic", DBNull.Value);
                }

                cmdUpdateArtistInfo.ExecuteNonQuery();
                adminArtistBindingNavigator_Load();
                artistToolStripComboBox.SelectedIndex = position;
                MessageBox.Show("Artist information was succefully updated", "Update Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Artist information could not be updated. Please ensure data has been entered correctly." + Environment.NewLine + ex.Message, "Error");
            }
        }

        // Delete an Artist

        private void deleteArtistButton_Click(object sender, EventArgs e)
        {
            if (artistBindingNavigatorCountItem.Text == "of 0") return;

            int position = int.Parse(artistBindingNavigatorPosition.Text);

            SqlCommand cmdDeleteArtist = sqlConnection1.CreateCommand();

            try
            {
                cmdDeleteArtist.CommandText = @"DELETE FROM ALBUM
                                                WHERE AlbumId IN (SELECT SA.AlbumId
                                                                  FROM SONGALBUM SA
                                                                  WHERE SA.SongId IN (SELECT S.SongId
                                                                                      FROM SONG S JOIN SUNGBY SU ON S.SongId = SU.SongId
                                                                                      WHERE ArtistId = @ArtistId));

                                                DELETE FROM SONG
                                                WHERE SongId IN (SELECT S.SongId
                                                                 FROM SONG S JOIN SUNGBY SU ON S.SongId = SU.SongId
                                                                 WHERE ArtistId = @ArtistId);

                                                DELETE FROM ARTIST
                                                WHERE ArtistId = @ArtistId";

                cmdDeleteArtist.Parameters.AddWithValue("@ArtistId", artistIdToolStripComboBox.Text);

                cmdDeleteArtist.ExecuteNonQuery();
                Admin_Load(sender, null);

                if (artistBindingNavigatorCountItem.Text == "of 0")
                    clearArtistTab();

                MessageBox.Show("Artist was deleted from the database", "Deletion Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Artist could not be deleted" + Environment.NewLine + ex.Message, "Error");
            }
        }

        // Uploads

        private void browse(TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                openFileDialog.Title = "Upload Image";
                openFileDialog.FileName = string.Empty;
                openFileDialog.Filter = "Image Files(*.BMP; *.GIF; *.JPEG; *.PNG; *.TIFF; *.JFIF; *.JPG)|*.BMP; *.GIF; *.JPEG; *.PNG; *.TIFF; *.JFIF; *.JPG";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    textBox.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image could not be uploaded" + Environment.NewLine + ex.Message, "Error");
            }
        }

        private void artistPicBrowseButton_Click(object sender, EventArgs e)
        {
            browse(artistPicTxtBox);
        }

        private void songPicBrowseButton_Click(object sender, EventArgs e)
        {
            browse(songPicTxtBox);
        }

        private void albumPicBrowseButton_Click(object sender, EventArgs e)
        {
            browse(albumPicTxtBox);
        }

        private void deleteFromPlaylistButton_Click(object sender, EventArgs e)
        {
            try
            {
                DemoUser frm = new DemoUser();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem loading the demo user form" + Environment.NewLine + ex.Message, "Error");
            }
        }

        // Duration of current media

        private TimeSpan getDuration()
        {
            if (musicPlayer.currentMedia != null)
            {
                WindowsMediaPlayerClass wmp = new WindowsMediaPlayerClass();
                IWMPMedia mediaInfo = wmp.newMedia(musicPlayer.currentMedia.sourceURL);
                TimeSpan duration = TimeSpan.FromSeconds(mediaInfo.duration);


                return duration;
            }
            else
            {
                return TimeSpan.Zero;
            }
        }
    }
}

