using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Database.Properties;

namespace Database
{
    public partial class DemoUser : Form
    {
        private SearchResults frm;
        static bool loaded = false;
        public DemoUser()
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection("Data Source=LAPTOP-E031DC8S\\SQLEXPRESS;Initial Catalog=DigitalMusicLibraryTK;Integrated Security=True");
            sqlConnection1.Open();
        }

        private void countryButton_Click(object sender, EventArgs e)
        {
            countryComboBox.Enabled = true;
            countryButton.Visible = false;
            countryButtonSave.Visible = true;
        }

        private void sexButton_Click(object sender, EventArgs e)
        {
            sexComboBox.Enabled = true;
            sexButton.Visible = false;
            sexButtonSave.Visible = true;
        }

        private void dobButton_Click(object sender, EventArgs e)
        {
            dobDateTimePicker.Enabled = true;
            dobButton.Visible = false;
            dobButtonSave.Visible = true;
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = true;
            passwordButton.Visible = false;
            passwordButtonSave.Visible = true;
        }

        private void phoneNumButton_Click(object sender, EventArgs e)
        {
            phoneNumTxtBox.Enabled = true;
            phoneNumButton.Visible = false;
            phoneNumButtonSave.Visible = true;
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            emailTxtBox.Enabled = true;
            emailButton.Visible = false;
            emailButtonSave.Visible = true;
        }

        private void emailButtonSave_Click(object sender, EventArgs e)
        {
            emailTxtBox.Enabled = false;
            emailButton.Visible = true;
            emailButtonSave.Visible = false;
        }

        private void phoneNumButtonSave_Click(object sender, EventArgs e)
        {
            phoneNumTxtBox.Enabled = false;
            phoneNumButton.Visible = true;
            phoneNumButtonSave.Visible = false;
        }

        private void passwordButtonSave_Click(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = false;
            passwordButton.Visible = true;
            passwordButtonSave.Visible = false;
        }

        private void dobButtonSave_Click(object sender, EventArgs e)
        {
            dobDateTimePicker.Enabled = false;
            dobButton.Visible = true;
            dobButtonSave.Visible = false;
        }

        private void sexButtonSave_Click(object sender, EventArgs e)
        {
            sexComboBox.Enabled = false;
            sexButton.Visible = true;
            sexButtonSave.Visible = false;
        }

        private void countryButtonSave_Click(object sender, EventArgs e)
        {
            countryComboBox.Enabled = false;
            countryButton.Visible = true;
            countryButtonSave.Visible = false;
        }

        private SearchResults openSearchResults(String genre)
        {
            try
            {
                frm = new SearchResults(genre);
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 55);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                AutoScroll = false;

                return frm;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }

        }

        private void kpopButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Kpop");
        }

        private void latinButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Latin");
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Pop");
        }

        private void rbButton_Click(object sender, EventArgs e)
        {
            openSearchResults("RB");
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Rock");
        }   

        private void countrButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Country");
        }

        private void hiphopButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Hip Hop");
        }

        private void animeButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Anime");
        }

        private void disneyButton_Click(object sender, EventArgs e)
        {
            openSearchResults("Disney");
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTabIndex = tabControl.SelectedIndex;

            if (selectedTabIndex != 2 && frm != null)
            {
                frm.Close();
                AutoScroll = true;
            }

            if (selectedTabIndex == 1)
            {
                DemoUser_Load(sender, null);
                durationTxtBox.Text = string.Empty;
                dateCreated.Text = string.Empty;
                playlistDataGridView.ClearSelection();
            }
        }

        private void DemoUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm != null && !frm.IsDisposed)
            {
                frm.Close();
            }
        }

        private void DemoUser_Load(object sender, EventArgs e)
        {
            playlistDataGridView.Rows.Clear();
            playlistDataGridView.Columns.Clear();

            playlistDataGridView.RowHeadersVisible = false;
            playlistDataGridView.ColumnHeadersVisible = false;

            invisiblePlaylistDataGridView.Rows.Clear();
            invisiblePlaylistDataGridView.RowHeadersVisible = false;
            invisiblePlaylistDataGridView.ColumnHeadersVisible = false;

            playlistSongDataGridView.RowHeadersVisible = false;
            playlistSongDataGridView.ColumnHeadersVisible = false;

            
            musicPlayer.Ctlenabled = false;

            playlistSongDataGridView.Rows.Clear();
            songInfoTxtBox.Text = string.Empty;
            lyricsTxtBox.Text = string.Empty;
            deleteFromPlaylistButton.Enabled = false;
            likeButton.Enabled = false;

            SqlCommand sqlCommand = new SqlCommand("SELECT PlaylistName, PlaylistPic FROM PLAYLIST;", sqlConnection1);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            int i = 0;

            while (reader.Read())
            {
                try
                {
                    string playlistPicPath = reader["PlaylistPic"].ToString();

                    if (!string.IsNullOrEmpty(playlistPicPath))
                    {
                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

                        imageColumn.Name = "Playlist" + i;

                        playlistDataGridView.Columns.Add(imageColumn);

                        if (playlistDataGridView.Rows.Count == 0)
                        {
                            playlistDataGridView.Rows.Add();
                            playlistDataGridView.Rows.Add();
                        }

                        System.Drawing.Image im = System.Drawing.Image.FromFile(playlistPicPath);
                        System.Drawing.Image playlistCover = new Bitmap(im, 120, 120);
                        playlistDataGridView.Rows[0].Cells[i].Value = playlistCover;

                        string playlistName = reader["PlaylistName"].ToString();
                        invisiblePlaylistDataGridView.Rows.Add();
                        invisiblePlaylistDataGridView.Rows[i].Cells["PlaylistName"].Value = playlistName;

                        Graphics graphics = CreateGraphics();

                        Font font = new Font("Times New Roman", 14, FontStyle.Regular, GraphicsUnit.Point);
                        SizeF textSize = graphics.MeasureString(playlistName, font);

                        int width = (int)Math.Ceiling(textSize.Width) + 10;
                        int height = 40;

                        Bitmap playlistTitle = new Bitmap(width, height);

                        Graphics imageGraphics = Graphics.FromImage(playlistTitle);
                        Brush brush = Brushes.Black;
                        imageGraphics.DrawString(playlistName, font, brush, new PointF(5, 5));

                        playlistDataGridView.Rows[1].Cells[i].Value = playlistTitle;
                    }

                    i++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex, "ERROR");
                }
            }

            reader.Close();

            loaded = true;
        }

        private void playlistDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            playlistSongDataGridView.Rows.Clear();
            musicPlayer.currentPlaylist.clear();
            songInfoTxtBox.Text = string.Empty;
            lyricsTxtBox.Text = string.Empty;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < playlistDataGridView.Columns.Count)
            {
                try
                {
                    SqlCommand cmdSongs = sqlConnection1.CreateCommand();
                    string playlistName = invisiblePlaylistDataGridView.Rows[e.ColumnIndex].Cells[0].Value.ToString();

                    cmdSongs.CommandText = @"SELECT SongPic, SongTitle, Music, PA.ArtistName AS PrimaryArtist, FA.ArtistName AS FeaturingArtist, DateCreated
                                             FROM SONG S
                                                            LEFT JOIN SUNGBY SP ON S.SongId = SP.SongId AND SP.ArtistRole = 'P'
                                                            LEFT JOIN SUNGBY SF ON S.SongId = SF.SongId AND SF.ArtistRole = 'F'
                                                            LEFT JOIN ARTIST PA ON SP.ArtistId = PA.ArtistId
                                                            LEFT JOIN ARTIST FA ON SF.ArtistId = FA.ArtistId
                                                            LEFT JOIN PLAYLISTSONG PS ON S.SongId = PS.SongId
                                                            LEFT JOIN PLAYLIST P ON PS.PlaylistId = P.PlaylistId
                                             WHERE PlaylistName = @PlaylistName;
                                             SELECT CONVERT(TIME, DATEADD(SECOND, SUM(DATEDIFF(SECOND, '00:00:00', S.Duration)), '00:00:00')) AS TotalDuration
                                             FROM SONG S LEFT JOIN PLAYLISTSONG PS ON S.SongId = PS.SongId LEFT JOIN PLAYLIST P ON PS.PlaylistId = P.PlaylistId
                                             WHERE PlaylistName = @PlaylistName;";

                    cmdSongs.Parameters.AddWithValue("@PlaylistName", playlistName);

                    SqlDataReader reader = cmdSongs.ExecuteReader();

                    int i = 0;

                    while (reader.Read())
                    {
                        playlistSongDataGridView.Rows.Add();

                        string songPicPath = reader["SongPic"].ToString();

                        if (!string.IsNullOrEmpty(songPicPath))
                        {
                            try
                            {
                                System.Drawing.Image im = System.Drawing.Image.FromFile(songPicPath);
                                System.Drawing.Image songCover = new Bitmap(im, 85, 85);
                                playlistSongDataGridView.Rows[i].Cells["SongPic"].Value = songCover;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error loading image" + Environment.NewLine + ex.Message, "Error");
                            }
                        }

                        string song = reader["SongTitle"].ToString();
                        string primaryArtist = reader["PrimaryArtist"].ToString();
                        string featuringArtist = reader["FeaturingArtist"].ToString();

                        if (string.IsNullOrEmpty(featuringArtist))
                        {
                            playlistSongDataGridView.Rows[i].Cells["SongInfo"].Value = song + Environment.NewLine + primaryArtist;
                        }
                        else
                        {
                            playlistSongDataGridView.Rows[i].Cells["SongInfo"].Value = song + Environment.NewLine + primaryArtist + " ft. " + featuringArtist;
                        }

                        try
                        {
                            musicPlayer.currentPlaylist.appendItem(musicPlayer.newMedia(reader["Music"].ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading media" + Environment.NewLine + ex.Message, "Error");
                        }

                        dateCreated.Text = reader["DateCreated"].ToString();

                        i++;
                    }

                    reader.NextResult();

                    if(reader.Read())
                    {
                        durationTxtBox.Text = reader["TotalDuration"].ToString();
                    }

                    reader.Close();

                    invisiblePlaylistDataGridView.ClearSelection();
                    invisiblePlaylistDataGridView.Rows[e.ColumnIndex].Cells[0].Selected = true;
                    musicPlayer.Ctlenabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem loading song information" + Environment.NewLine + ex.Message, "Error");
                }
            }
        }

        private void playlistSongDataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                if (rowIndex < musicPlayer.currentPlaylist.count)
                {
                    musicPlayer.Ctlcontrols.currentItem = musicPlayer.currentPlaylist.get_Item(rowIndex);
                    musicPlayer.Ctlenabled = true;
                }

                songInfoLoad();
                likeButton.Enabled = true;
                deleteFromPlaylistButton.Enabled = true;
            }
        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3 && musicPlayer.Ctlcontrols.currentPosition == 0)
            {
                try
                {

                    SqlCommand cmdSong = sqlConnection1.CreateCommand();
                    cmdSong.CommandText = @"UPDATE SONG SET TotalStreams = TotalStreams + 1 WHERE SongTitle = @SongTitle";

                    cmdSong.Parameters.AddWithValue("@SongTitle", musicPlayer.currentMedia.name);

                    cmdSong.ExecuteNonQuery();

                    songInfoLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem updating total streams" + Environment.NewLine + ex.Message, "Error");
                }
            }

            if (e.newState == 9 && musicPlayer.currentMedia != null)
            {
                string songName = musicPlayer.currentMedia.name;

                foreach (DataGridViewRow row in playlistSongDataGridView.Rows)
                {
                    string[] songInfo = row.Cells["SongInfo"].Value.ToString().Split('\n');

                    if (songInfo[0].Trim() == songName)
                    {
                        row.Selected = true;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }

                try
                {

                    SqlCommand cmdSong = sqlConnection1.CreateCommand();
                    cmdSong.CommandText = @"UPDATE SONG SET TotalStreams = TotalStreams + 1 WHERE SongTitle = @SongTitle";

                    cmdSong.Parameters.AddWithValue("@SongTitle", musicPlayer.currentMedia.name);

                    cmdSong.ExecuteNonQuery();

                    songInfoLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem updating total streams" + Environment.NewLine + ex.Message, "Error");
                }

                songInfoLoad();
            }
        }

        // Delete song from playlist

        private void deleteFromPlaylistButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = playlistDataGridView.CurrentCell.ColumnIndex;
                string playlistName = invisiblePlaylistDataGridView.Rows[index].Cells[0].Value.ToString();

                string[] songInfo = playlistSongDataGridView.CurrentCell.Value.ToString().Split('\n');

                SqlCommand cmdSong = sqlConnection1.CreateCommand();

                cmdSong.CommandText = @"DECLARE @SongId INT;
                                        SELECT @SongId = SongId FROM SONG WHERE SongTitle = @SongTitle;
                                        DECLARE @PlaylistId INT;
                                        SELECT @PlaylistId = PlaylistId FROM PLAYLIST WHERE PlaylistName = @PlaylistName;
                                        DELETE FROM PLAYLISTSONG WHERE SongId = @SongId AND PlaylistId = @PlaylistId;";

                cmdSong.Parameters.AddWithValue("@SongTitle", songInfo[0].Trim());
                cmdSong.Parameters.AddWithValue("@PlaylistName", playlistName);

                cmdSong.ExecuteNonQuery();

                MessageBox.Show(songInfo[0].Trim() + " was deleted from " + playlistName, "DELETION COMPLETE");

                deleteFromPlaylistButton.Enabled = false;
                likeButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem deleting the playlist" + Environment.NewLine + ex.Message, "Error");
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdSong = sqlConnection1.CreateCommand();

                cmdSong.CommandText = @"UPDATE SONG SET NumOfLikes = NumOfLikes + 1 WHERE SongTitle = @SongTitle";

                cmdSong.Parameters.AddWithValue("@SongTitle", musicPlayer.currentMedia.name);

                cmdSong.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem updating number of likes" + Environment.NewLine + ex.Message, "Error");
            }

            songInfoLoad();
        }

        private void songInfoLoad()
        {
            try
            {
                SqlCommand cmdSong = sqlConnection1.CreateCommand();
                string currentTrackName = musicPlayer.currentMedia.name;
                cmdSong = sqlConnection1.CreateCommand();
                cmdSong.CommandText = @"SELECT SongTitle AS Title, AlbumName AS Album, PA.ArtistName AS Artist, 
                                                FA.ArtistName AS FeaturingArtistName, 
                                                S.Duration AS Duration, S.NumOfLikes AS Likes, S.TotalStreams AS Streams, lyrics
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
                }

                songInfoTxtBox.Text = songInfo;

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem loading song information" + Environment.NewLine + ex.Message, "Error");
            }
        }

        private void searchBarTxtBox_GotFocus(object sender, EventArgs e)
        {
            searchBarTxtBox.Text = "";
            searchBarTxtBox.ForeColor = Color.Black;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            openSearchResults(searchBarTxtBox.Text);
        }
    }
}