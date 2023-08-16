using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Video_Game_App.Backend;
using Video_Game_App.Management;

namespace Video_Game_App.View
{
    /// <summary>
    /// Logique d'interaction pour PlayerView.xaml
    /// </summary>
    public partial class PlayerView : Page
    {
        public PlayerView()
        {
            InitializeComponent();
        }

        private void BtnPropose_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DAO dao = new DAO();

                List<VideoGame> videoGames = dao.GetAllVideoGames();

                lstGames.ItemsSource = videoGames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnSelectAndAddCopy_Click(object sender, RoutedEventArgs e)
        {
            if (lstGames.SelectedItem is VideoGame selectedGame)
            {
                DAO dao = new DAO();

                string username = dao.loggedInUsername;

                Copy newCopy = new Copy
                {
                    usernames = username,
                    names = selectedGame.names
                };
                dao.InsertNewCopy(newCopy);

                MessageBox.Show($"Copy of {selectedGame.names} added for {username}");
            }
            else
            {
                MessageBox.Show("Please select a game.");
            }
        }
    }
}
