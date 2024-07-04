using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Collections;
using System.IO;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Odbc;
using System.Diagnostics.CodeAnalysis;
using AxWMPLib;

namespace Database
{
    public partial class SearchResults : Form
    {
        private String search;
        static bool loaded = false;
        static List<string> validGenres = new List<string> { "Kpop", "Latin", "Pop", "R & B", "Rock", "Country", "Hip Hop", "Anime", "Disney" };


        public SearchResults(String search)
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection("Data Source=LAPTOP-E031DC8S\\SQLEXPRESS;Initial Catalog=DigitalMusicLibraryTK;Integrated Security=True");
            sqlConnection1.Open();
            this.search = search;
            searchLabel.Text = search;

        }

        private void Genre_Load(object sender, EventArgs e)
        {
            loaded = false;

            if (validGenres.Contains(search))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("SELECT SongTitle, Music, SongPic FROM SONG WHERE Genre = @Genre", sqlConnection1);

                    sqlCmd.Parameters.AddWithValue("@Genre", search);

                    SqlDataReader songReader1 = sqlCmd.ExecuteReader();

                    int i = 0;

                    while (songReader1.Read())
                    {
                        try
                        {
                            songDataGridView.Rows.Add();
                            songDataGridView.Rows[i].Cells["SongTitle"].Value = songReader1["SongTitle"].ToString();

                            string songPath = songReader1["Music"].ToString();
                            string songPicPath = songReader1["SongPic"].ToString();

                            musicPlayer.currentPlaylist.appendItem(musicPlayer.newMedia(songPath));

                            if (!string.IsNullOrEmpty(songPicPath))
                            {
                                System.Drawing.Image im = System.Drawing.Image.FromFile(songPicPath);
                                System.Drawing.Image songCover = new Bitmap(im, 61, 61);
                                songDataGridView.Rows[i].Cells["SongPic"].Value = songCover;
                            }

                            i++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was a problem loading song information." + Environment.NewLine + ex.Message, "Error");
                        }
                    }

                    songReader1.Close();

                    SqlCommand cmdArtist = new SqlCommand("SELECT DISTINCT ArtistName, ArtistPic " +
                                                          "FROM ARTIST A LEFT JOIN SUNGBY SU ON A.ArtistId = SU.ArtistId " +
                                                          "LEFT JOIN SONG SO ON SU.SongId = SO.SongId " +
                                                          "WHERE Genre = @Genre AND ArtistRole = 'P'", sqlConnection1);

                    cmdArtist.Parameters.AddWithValue("@Genre", search);

                    SqlDataReader artistReader = cmdArtist.ExecuteReader();

                    i = 0;

                    while (artistReader.Read())
                    {
                        try
                        {
                            artistDataGridView.Rows.Add();
                            artistDataGridView.Rows[i].Cells["ArtistName"].Value = artistReader["ArtistName"].ToString();

                            string artistPicPath = artistReader["ArtistPic"].ToString();

                            if (!string.IsNullOrEmpty(artistPicPath))
                            {
                                System.Drawing.Image im = System.Drawing.Image.FromFile(artistPicPath);
                                System.Drawing.Image artistCover = new Bitmap(im, 85, 85);
                                artistDataGridView.Rows[i].Cells["ArtistPic"].Value = artistCover;
                            }

                            i++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was a problem loading artist information" + Environment.NewLine + ex.Message, "Error");
                        }
                    }

                    artistReader.Close();

                    if (songDataGridView.Rows.Count > 0)
                    {
                        musicPlayer_CurrentItemChange(sender, null);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Songs could not be loaded" + Environment.NewLine + ex.Message, "Error");  
                }
            }
            else
            {
                try
                {
                    SqlCommand sqlCmd = sqlConnection1.CreateCommand();

                    sqlCmd.CommandText = @"SELECT SongTitle, Music, SongPic FROM SONG WHERE SongTitle LIKE '%' + @SongTitle + '%';
                                           SELECT DISTINCT ArtistName, ArtistPic
                                           FROM ARTIST A LEFT JOIN SUNGBY SU ON A.ArtistId = SU.ArtistId
                                           LEFT JOIN SONG SO ON SU.SongId = SO.SongId
                                           WHERE ArtistName LIKE '%' + @ArtistName + '%';";

                    sqlCmd.Parameters.AddWithValue("@ArtistName", search);
                    sqlCmd.Parameters.AddWithValue("@SongTitle", search);

                    SqlDataReader songReader = sqlCmd.ExecuteReader();

                    int i = 0;

                    while(songReader.Read())
                    {
                        try
                        {
                            songDataGridView.Rows.Add();
                            songDataGridView.Rows[i].Cells["SongTitle"].Value = songReader["SongTitle"].ToString();

                            string songPath = songReader["Music"].ToString();
                            string songPicPath = songReader["SongPic"].ToString();

                            musicPlayer.currentPlaylist.appendItem(musicPlayer.newMedia(songPath));

                            if (!string.IsNullOrEmpty(songPicPath))
                            {
                                System.Drawing.Image im = System.Drawing.Image.FromFile(songPicPath);
                                System.Drawing.Image songCover = new Bitmap(im, 61, 61);
                                songDataGridView.Rows[i].Cells["SongPic"].Value = songCover;
                            }

                            i++;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("There was an error loading the songs" + Environment.NewLine + ex.Message, "Error");
                        }
                    }

                    songReader.NextResult();

                    i = 0;

                    while(songReader.Read())
                    {
                        try
                        {
                            artistDataGridView.Rows.Add();
                            artistDataGridView.Rows[i].Cells["ArtistName"].Value = songReader["ArtistName"].ToString();

                            string artistPicPath = songReader["ArtistPic"].ToString();

                            if (!string.IsNullOrEmpty(artistPicPath))
                            {
                                System.Drawing.Image im = System.Drawing.Image.FromFile(artistPicPath);
                                System.Drawing.Image artistCover = new Bitmap(im, 85, 85);
                                artistDataGridView.Rows[i].Cells["ArtistPic"].Value = artistCover;
                            }

                            i++;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was a problem loading artist information" + Environment.NewLine + ex.Message, "Error");
                        }
                    }

                    songReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Could not load search results" + Environment.NewLine + ex.Message, "Error");
                }
            }
            

            musicPlayer.Ctlenabled = false;
            songInfoTxtBox.Visible = false;
            lyricsTxtBox.Visible = false;
            likeButton.Visible = false;
            songDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            musicPlayer.settings.autoStart = false;
            addToPlaylistButton.Visible = false;

            artistSongDataGridView.RowHeadersVisible = false;
            artistSongDataGridView.MultiSelect = false;
            albumDataGridView.RowHeadersVisible = false;

            songDataGridView.ColumnHeadersVisible = false;
            songDataGridView.RowHeadersVisible = false;
            songDataGridView.MultiSelect = false;

            artistDataGridView.ColumnHeadersVisible = false;
            artistDataGridView.RowHeadersVisible = false;
            artistDataGridView.MultiSelect = false;
            playlistComboBox.Items.Clear();

            SqlCommand cmdPlaylist = sqlConnection1.CreateCommand();

            cmdPlaylist.CommandText = @"SELECT PlaylistName FROM PLAYLIST";

            SqlDataReader reader = cmdPlaylist.ExecuteReader();

            while (reader.Read())
            {
                playlistComboBox.Items.Add(reader["PlaylistName"].ToString());
            }

            reader.Close();

            playlistComboBox.Visible = false;

            loaded = true;

        }

        private void musicPlayer_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            if (!loaded)
                return;

            try
            {
                if (musicPlayer.currentMedia != null)
                {
                    string currentTrackName = musicPlayer.currentMedia.name;
                    SqlCommand cmdSong = sqlConnection1.CreateCommand();
                    cmdSong.CommandText = @"SELECT SongTitle AS Title, AlbumName AS Album, PA.ArtistName AS Artist, 
                                                FA.ArtistName AS FeaturingArtistName, 
                                                S.Duration AS Duration, S.NumOfLikes AS Likes, S.TotalStreams AS Streams, Lyrics, SongPic
                                                FROM SONG S
                                                     LEFT JOIN SUNGBY SP ON S.SongId = SP.SongId AND SP.ArtistRole = 'P'
                                                     LEFT JOIN SUNGBY SF ON S.SongId = SF.SongId AND SF.ArtistRole = 'F'
                                                     LEFT JOIN ARTIST PA ON SP.ArtistId = PA.ArtistId
                                                     LEFT JOIN ARTIST FA ON SF.ArtistId = FA.ArtistId
                                                     LEFT JOIN SONGALBUM SA ON S.SongId = SA.SongId
                                                     LEFT JOIN ALBUM A ON SA.AlbumId = A.AlbumId
                                                WHERE Music = @Music";

                    cmdSong.Parameters.AddWithValue("@Music", musicPlayer.currentMedia.sourceURL);

                    SqlDataReader reader = cmdSong.ExecuteReader();

                    string songInfo = "";
                    songInfoTxtBox.Text = string.Empty;

                    if (reader.Read())
                    {
                        songInfo += reader[0].ToString() + Environment.NewLine;

                        if (!string.IsNullOrEmpty(reader[1].ToString()))
                        {
                            songInfo += "<" + reader[1].ToString() + ">" + Environment.NewLine;
                        }

                        songInfo += "by " + reader[2].ToString() + Environment.NewLine;

                        if (!string.IsNullOrEmpty(reader[3].ToString()))
                        {
                            songInfo += "ft. " + reader[3].ToString() + Environment.NewLine;
                        }

                        songInfo += "⏱️ " + reader[4].ToString() + Environment.NewLine +
                        "👍🏻 " + reader[5].ToString() + Environment.NewLine + "🎧 " + reader[6].ToString();

                        lyricsTxtBox.Text = reader[7].ToString();

                        songPicBox.Image = System.Drawing.Image.FromFile(reader[8].ToString());
                    }

                    songInfoTxtBox.Text = songInfo;

                    reader.Close();

                    string searchText = musicPlayer.currentMedia.name;

                    foreach (DataGridViewRow row in songDataGridView.Rows)
                    {
                        DataGridViewCell songTitleCell = row.Cells["SongTitle"];

                        if (songTitleCell.Value.ToString() == searchText)
                        {
                            songTitleCell.Selected = true;
                        }
                        else
                        {
                            songTitleCell.Selected = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem loading current media information" + Environment.NewLine + ex.Message, "Error");
            }
        }

        private void artistDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < artistDataGridView.Rows.Count)
            {
                DataGridViewRow selectedRow = artistDataGridView.Rows[e.RowIndex];

                if (selectedRow.Cells["ArtistName"].Value != null)
                {
                    string artistName = selectedRow.Cells["ArtistName"].Value.ToString();

                    SqlCommand cmdArtist = sqlConnection1.CreateCommand();
                    cmdArtist.CommandText = @"SELECT Bio FROM ARTIST WHERE ArtistName = @ArtistName;
                                              SELECT SongPic, SongTitle, Duration, TotalStreams, AlbumName
                                              FROM ARTIST A LEFT JOIN SUNGBY SU ON A.ArtistId = SU.ArtistId
                                                            LEFT JOIN SONG SO ON SU.SongId = SO.SongId
                                                            LEFT JOIN SONGALBUM SA ON SO.SongId = SA.SongId
                                                            LEFT JOIN ALBUM AL ON SA.AlbumId = AL.AlbumId
                                              WHERE ArtistName = @ArtistName;
                                              SELECT AlbumCover, AlbumName, ReleaseYear, COUNT(DISTINCT SO.SongId) AS NumOfSongs, CONVERT(TIME, DATEADD(SECOND, SUM(DATEDIFF(SECOND, '00:00:00', SO.Duration)), '00:00:00')) AS TotalDuration
                                              FROM ARTIST A LEFT JOIN SUNGBY SU ON A.ArtistId = SU.ArtistId
                                                            LEFT JOIN SONG SO ON SU.SongId = SO.SongId
                                                            LEFT JOIN SONGALBUM SA ON SO.SongId = SA.SongId
                                                            LEFT JOIN ALBUM AL ON SA.AlbumId = AL.AlbumId
                                              WHERE ArtistName = @ArtistName AND ArtistRole = 'P' AND AlbumName IS NOT NULL
                                              GROUP BY AlbumCover, AlbumName, ReleaseYear;";


                    cmdArtist.Parameters.AddWithValue("@ArtistName", artistName);

                    SqlDataReader reader = cmdArtist.ExecuteReader();

                    if (reader.Read())
                    {
                        bioTextBox.Text = reader["Bio"].ToString();
                    }

                    reader.NextResult();

                    int i = 0;

                    artistSongDataGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        artistSongDataGridView.Rows.Add();

                        string songPicPath = reader["SongPic"].ToString();

                        if (!string.IsNullOrEmpty(songPicPath))
                        {
                            System.Drawing.Image im = System.Drawing.Image.FromFile(songPicPath);
                            System.Drawing.Image songCover = new Bitmap(im, 85, 85);
                            artistSongDataGridView.Rows[i].Cells["ArtistSongPic"].Value = songCover;
                        }

                        artistSongDataGridView.Rows[i].Cells["ArtistSongName"].Value = reader["SongTitle"].ToString();
                        artistSongDataGridView.Rows[i].Cells["Duration"].Value = reader["Duration"].ToString();
                        artistSongDataGridView.Rows[i].Cells["TotalStreams"].Value = reader["TotalStreams"].ToString();
                        artistSongDataGridView.Rows[i].Cells["Album"].Value = reader["AlbumName"].ToString();

                        i++;
                    }

                    reader.NextResult();

                    i = 0;

                    albumDataGridView.Rows.Clear();

                    while (reader.Read())
                    {
                        albumDataGridView.Rows.Add();

                        string albumPicPath = reader["AlbumCover"].ToString();

                        if (!string.IsNullOrEmpty(albumPicPath))
                        {
                            try
                            {
                                System.Drawing.Image im = System.Drawing.Image.FromFile(albumPicPath);
                                System.Drawing.Image albumCover = new Bitmap(im, 85, 85);
                                albumDataGridView.Rows[i].Cells["AlbumPic"].Value = albumCover;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Image could not be loaded" + Environment.NewLine + ex.Message, "Error");
                            }
                        }

                        albumDataGridView.Rows[i].Cells["AlbumName"].Value = reader["AlbumName"].ToString();
                        albumDataGridView.Rows[i].Cells["ReleaseYear"].Value = reader["ReleaseYear"].ToString();
                        albumDataGridView.Rows[i].Cells["NumOfSongs"].Value = reader["NumOfSongs"].ToString();
                        albumDataGridView.Rows[i].Cells["AlbumDuration"].Value = reader["TotalDuration"].ToString();

                        i++;
                    }

                    reader.Close();
                }
            }
            else
            {
                bioTextBox.Text = string.Empty;
            }
        }


        private void songDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                string songName = songDataGridView.Rows[rowIndex].Cells[1].Value.ToString();

                if (rowIndex < musicPlayer.currentPlaylist.count)
                {
                    musicPlayer.Ctlcontrols.currentItem = musicPlayer.currentPlaylist.get_Item(rowIndex);
                    musicPlayer.Ctlenabled = true;
                    songInfoTxtBox.Visible = true;
                    lyricsTxtBox.Visible = true;
                    likeButton.Visible = true;
                    addToPlaylistButton.Visible = true;
                    playlistComboBox.Visible = true;
                }

                SqlCommand cmdSong = sqlConnection1.CreateCommand();

                cmdSong.CommandText = @"SELECT SongPic FROM SONG WHERE SongTitle = @SongTitle";

                cmdSong.Parameters.AddWithValue("@SongTitle", songName);

                SqlDataReader reader = cmdSong.ExecuteReader();

                if (reader.Read())
                {
                    songPicBox.Visible = true;
                    songPicBox.Image = System.Drawing.Image.FromFile(reader[0].ToString());
                }

                reader.Close();

                cmdSong.ExecuteNonQuery();
            }
        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3 && musicPlayer.Ctlcontrols.currentPosition == 0)
            {
                SqlCommand cmdSong = sqlConnection1.CreateCommand();

                cmdSong.CommandText = @"UPDATE SONG SET TotalStreams = TotalStreams + 1 WHERE SongTitle = @SongTitle";

                cmdSong.Parameters.AddWithValue("@SongTitle", musicPlayer.currentMedia.name);

                cmdSong.ExecuteNonQuery();

                musicPlayer_CurrentItemChange(sender, null);
            }
            if (e.newState == 9)
            {
                int index = songDataGridView.CurrentRow.Index;

                if (index < songDataGridView.Rows.Count - 1)
                {
                    songDataGridView.Rows[index].Selected = false;
                    songDataGridView.Rows[index + 1].Selected = true;
                }

                SqlCommand cmdSong = sqlConnection1.CreateCommand();

                cmdSong.CommandText = @"UPDATE SONG SET TotalStreams = TotalStreams + 1 WHERE SongTitle = @SongTitle";

                cmdSong.Parameters.AddWithValue("@SongTitle", musicPlayer.currentMedia.name);

                cmdSong.ExecuteNonQuery();

                musicPlayer_CurrentItemChange(sender, null);
            }

            songPicBox.Visible = false;
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSong = sqlConnection1.CreateCommand();

            cmdSong.CommandText = @"UPDATE SONG SET NumOfLikes = NumOfLikes + 1 WHERE SongTitle = @SongTitle";

            cmdSong.Parameters.AddWithValue("@SongTitle", musicPlayer.currentMedia.name);

            cmdSong.ExecuteNonQuery();

            musicPlayer_CurrentItemChange(sender, null);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addToPlaylistButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdPlaylist = sqlConnection1.CreateCommand();

                if (playlistComboBox.Items.Contains(playlistComboBox.Text.ToString()))
                {
                    cmdPlaylist.CommandText = @"DECLARE @PlaylistId INT;
                                                SELECT @PlaylistId = PlaylistId FROM PLAYLIST WHERE PlaylistName = @PlaylistName;
                                                DECLARE @SongId INT;
                                                SELECT @SongId = SongId FROM SONG WHERE SongTitle = @SongTitle;
                                                INSERT INTO PLAYLISTSONG(PlaylistId, SongId)
                                                VALUES(@PlaylistId, @SongId);";

                    cmdPlaylist.Parameters.AddWithValue("@PlaylistName", playlistComboBox.Text.ToString());
                    cmdPlaylist.Parameters.AddWithValue("@SongTitle", songDataGridView.SelectedCells[1].Value);

                    cmdPlaylist.ExecuteNonQuery();
                }
                else
                {
                    cmdPlaylist.CommandText = @"DECLARE @PlaylistPic NVARCHAR(100);
                                                SELECT @PlaylistPic = SongPic FROM SONG WHERE SongTitle = @SongTitle;
                                                INSERT INTO PLAYLIST(PlaylistName, PlaylistPic)
                                                VALUES(@PlaylistName, @PlaylistPic);";

                    int index = songDataGridView.CurrentCell.RowIndex;
                    System.Drawing.Image playlistPicPath = (System.Drawing.Image)songDataGridView.Rows[index].Cells[0].Value;

                    cmdPlaylist.Parameters.AddWithValue("@PlaylistName", playlistComboBox.Text.ToString());
                    cmdPlaylist.Parameters.AddWithValue("@SongTitle", songDataGridView.SelectedCells[1].Value.ToString());

                    cmdPlaylist.ExecuteNonQuery();

                    cmdPlaylist.CommandText = @" DECLARE @PlaylistId INT;
                                                 SELECT @PlaylistId = MAX(PlaylistId) FROM PLAYLIST;
                                                 DECLARE @SongId INT;
                                                 SELECT @SongId = SongId FROM SONG WHERE SongTitle = @SongTitle;
                                                 INSERT INTO PLAYLISTSONG(PlaylistId, SongId)
                                                 VALUES(@PlaylistId, @SongId);";

                    cmdPlaylist.ExecuteNonQuery();

                    playlistComboBox.Items.Add(playlistComboBox.Text.ToString());

                }

                MessageBox.Show(songDataGridView.SelectedCells[1].Value + " was added to " + playlistComboBox.Text, "INSERTION COMPLETE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add song to Playlist" + ex.Message, "Error");
            }
        }
    }
}

