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
    /// Logique d'interaction pour AdministratorView.xaml
    /// </summary>
    public partial class AdministratorView : Page
    {
        public AdministratorView()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e) {

            AddTitle.IsEnabled = true;
            GameNameTitle.IsEnabled = true;
            txtGameName.IsEnabled = true;
            CreditTitle.IsEnabled = true;
            txtCreditCost.IsEnabled = true;
            ConsoleTitle.IsEnabled = true;
            txtConsole.IsEnabled = true;
            BtnAddTitle.IsEnabled = true;

            AddTitle.Visibility = Visibility.Visible;
            GameNameTitle.Visibility = Visibility.Visible;
            txtGameName.Visibility = Visibility.Visible;
            CreditTitle.Visibility = Visibility.Visible;
            txtCreditCost.Visibility = Visibility.Visible;
            ConsoleTitle.Visibility = Visibility.Visible;
            txtConsole.Visibility = Visibility.Visible;
            BtnAddTitle.Visibility = Visibility.Visible;

            DeleteTitle.IsEnabled = false;
            NameDeleteTitle.IsEnabled = false;
            txtGameNameDelete.IsEnabled = false;
            ConsoleDeleteTitle.IsEnabled = false;
            txtConsoleDelete.IsEnabled = false;
            BtnDeleteTitle.IsEnabled = false;

            DeleteTitle.Visibility = Visibility.Collapsed;
            NameDeleteTitle.Visibility = Visibility.Collapsed;
            txtGameNameDelete.Visibility = Visibility.Collapsed;
            ConsoleDeleteTitle.Visibility = Visibility.Collapsed;
            txtConsoleDelete.Visibility = Visibility.Collapsed;
            BtnDeleteTitle.Visibility = Visibility.Collapsed;

            ModifyTitle.IsEnabled = false;
            NameModifyTitle.IsEnabled = false;
            txtGameNameModify.IsEnabled = false;
            ConsoleModifyTitle.IsEnabled = false;
            txtConsoleModify.IsEnabled = false;
            NewGameNameTitle.IsEnabled = false;
            NewtxtGameName.IsEnabled = false;
            NewCreditTitle.IsEnabled = false;
            NewtxtCreditCost.IsEnabled = false;
            NewConsoleTitle.IsEnabled = false;
            NewtxtConsole.IsEnabled = false;
            BtnModifyTitle.IsEnabled = false;

            ModifyTitle.Visibility = Visibility.Collapsed;
            NameModifyTitle.Visibility = Visibility.Collapsed;
            txtGameNameModify.Visibility = Visibility.Collapsed;
            ConsoleModifyTitle.Visibility = Visibility.Collapsed;
            txtConsoleModify.Visibility = Visibility.Collapsed;
            BtnModifyTitle.Visibility = Visibility.Collapsed;
            NewGameNameTitle.Visibility = Visibility.Collapsed;
            NewtxtGameName.Visibility = Visibility.Collapsed;
            NewCreditTitle.Visibility = Visibility.Collapsed;
            NewtxtCreditCost.Visibility = Visibility.Collapsed;
            NewConsoleTitle.Visibility = Visibility.Collapsed;
            NewtxtConsole.Visibility = Visibility.Collapsed;
            BtnModifyTitle.Visibility = Visibility.Collapsed;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteTitle.IsEnabled = true;
            NameDeleteTitle.IsEnabled = true;
            txtGameNameDelete.IsEnabled = true;
            ConsoleDeleteTitle.IsEnabled = true;
            txtConsoleDelete.IsEnabled = true;
            BtnDeleteTitle.IsEnabled = true;

            DeleteTitle.Visibility = Visibility.Visible;
            NameDeleteTitle.Visibility = Visibility.Visible;
            txtGameNameDelete.Visibility = Visibility.Visible;
            ConsoleDeleteTitle.Visibility = Visibility.Visible;
            txtConsoleDelete.Visibility = Visibility.Visible;
            BtnDeleteTitle.Visibility = Visibility.Visible;

            AddTitle.IsEnabled = false;
            GameNameTitle.IsEnabled = false;
            txtGameName.IsEnabled = false;
            CreditTitle.IsEnabled = false;
            txtCreditCost.IsEnabled = false;
            ConsoleTitle.IsEnabled = false;
            txtConsole.IsEnabled = false;
            BtnAddTitle.IsEnabled = false;

            AddTitle.Visibility = Visibility.Collapsed;
            GameNameTitle.Visibility = Visibility.Collapsed;
            txtGameName.Visibility = Visibility.Collapsed;
            CreditTitle.Visibility = Visibility.Collapsed;
            txtCreditCost.Visibility = Visibility.Collapsed;
            ConsoleTitle.Visibility = Visibility.Collapsed;
            txtConsole.Visibility = Visibility.Collapsed;
            BtnAddTitle.Visibility = Visibility.Collapsed;

            ModifyTitle.IsEnabled = false;
            NameModifyTitle.IsEnabled = false;
            txtGameNameModify.IsEnabled = false;
            ConsoleModifyTitle.IsEnabled = false;
            txtConsoleModify.IsEnabled = false;
            NewGameNameTitle.IsEnabled = false;
            NewtxtGameName.IsEnabled = false;
            NewCreditTitle.IsEnabled = false;
            NewtxtCreditCost.IsEnabled = false;
            NewConsoleTitle.IsEnabled = false;
            NewtxtConsole.IsEnabled = false;
            BtnModifyTitle.IsEnabled = false;

            ModifyTitle.Visibility = Visibility.Collapsed;
            NameModifyTitle.Visibility = Visibility.Collapsed;
            txtGameNameModify.Visibility = Visibility.Collapsed;
            ConsoleModifyTitle.Visibility = Visibility.Collapsed;
            txtConsoleModify.Visibility = Visibility.Collapsed;
            BtnModifyTitle.Visibility = Visibility.Collapsed;
            NewGameNameTitle.Visibility = Visibility.Collapsed;
            NewtxtGameName.Visibility = Visibility.Collapsed;
            NewCreditTitle.Visibility = Visibility.Collapsed;
            NewtxtCreditCost.Visibility = Visibility.Collapsed;
            NewConsoleTitle.Visibility = Visibility.Collapsed;
            NewtxtConsole.Visibility = Visibility.Collapsed;
            BtnModifyTitle.Visibility = Visibility.Collapsed;
        }

        private void BtnModify_Click(object sender, RoutedEventArgs e)
        {
            ModifyTitle.IsEnabled = true;
            NameModifyTitle.IsEnabled = true;
            txtGameNameModify.IsEnabled = true;
            ConsoleModifyTitle.IsEnabled = true;
            txtConsoleModify.IsEnabled = true;
            NewGameNameTitle.IsEnabled = true;
            NewtxtGameName.IsEnabled = true;
            NewCreditTitle.IsEnabled = true;
            NewtxtCreditCost.IsEnabled = true;
            NewConsoleTitle.IsEnabled = true;
            NewtxtConsole.IsEnabled = true;
            BtnModifyTitle.IsEnabled = true;

            ModifyTitle.Visibility = Visibility.Visible;
            NameModifyTitle.Visibility = Visibility.Visible;
            txtGameNameModify.Visibility = Visibility.Visible;
            ConsoleModifyTitle.Visibility = Visibility.Visible;
            txtConsoleModify.Visibility = Visibility.Visible;
            BtnModifyTitle.Visibility = Visibility.Visible;
            NewGameNameTitle.Visibility = Visibility.Visible;
            NewtxtGameName.Visibility = Visibility.Visible;
            NewCreditTitle.Visibility = Visibility.Visible;
            NewtxtCreditCost.Visibility = Visibility.Visible;
            NewConsoleTitle.Visibility = Visibility.Visible;
            NewtxtConsole.Visibility = Visibility.Visible;
            BtnModifyTitle.Visibility = Visibility.Visible;

            AddTitle.IsEnabled = false;
            GameNameTitle.IsEnabled = false;
            txtGameName.IsEnabled = false;
            CreditTitle.IsEnabled = false;
            txtCreditCost.IsEnabled = false;
            ConsoleTitle.IsEnabled = false;
            txtConsole.IsEnabled = false;
            BtnAddTitle.IsEnabled = false;

            AddTitle.Visibility = Visibility.Collapsed;
            GameNameTitle.Visibility = Visibility.Collapsed;
            txtGameName.Visibility = Visibility.Collapsed;
            CreditTitle.Visibility = Visibility.Collapsed;
            txtCreditCost.Visibility = Visibility.Collapsed;
            ConsoleTitle.Visibility = Visibility.Collapsed;
            txtConsole.Visibility = Visibility.Collapsed;
            BtnAddTitle.Visibility = Visibility.Collapsed;

            DeleteTitle.IsEnabled = false;
            NameDeleteTitle.IsEnabled = false;
            txtGameNameDelete.IsEnabled = false;
            ConsoleDeleteTitle.IsEnabled = false;
            txtConsoleDelete.IsEnabled = false;
            BtnDeleteTitle.IsEnabled = false;

            DeleteTitle.Visibility = Visibility.Collapsed;
            NameDeleteTitle.Visibility = Visibility.Collapsed;
            txtGameNameDelete.Visibility = Visibility.Collapsed;
            ConsoleDeleteTitle.Visibility = Visibility.Collapsed;
            txtConsoleDelete.Visibility = Visibility.Collapsed;
            BtnDeleteTitle.Visibility = Visibility.Collapsed;
        }

        private void AddVideoGameButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VideoGame newVideoGame = new VideoGame
                {
                    names = txtGameName.Text,
                    creditCost = Convert.ToInt32(txtCreditCost.Text),
                    console = txtConsole.Text
                };

                DAO dao = new DAO();
                dao.InsertNewVideoGame(newVideoGame);

                MessageBox.Show("Video Game added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DeleteVideoGameButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string gameNameToDelete = txtGameNameDelete.Text;
                string consoleToDelete = txtConsoleDelete.Text;

                DAO dao = new DAO();
                dao.DeleteVideoGame(gameNameToDelete, consoleToDelete);

                MessageBox.Show("Video Game deleted successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ModifyVideoGameButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string oldGameName = txtGameNameModify.Text;
                string oldConsole = txtConsoleModify.Text;
                string newGameName = NewtxtGameName.Text;
                int newCreditCost = Convert.ToInt32(NewtxtCreditCost.Text);
                string newConsole = NewtxtConsole.Text;

                DAO dao = new DAO();
                dao.ModifyVideoGame(oldGameName, oldConsole, newGameName, newConsole, newCreditCost);

                MessageBox.Show("Video Game modified successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void BtnAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DAO dao = new DAO();
                List<VideoGame> videoGames = dao.GetAllVideoGames();

                StringBuilder sb = new StringBuilder();
                foreach (VideoGame videoGame in videoGames)
                {
                    sb.AppendLine($"Name: {videoGame.names}, Credit Cost: {videoGame.creditCost}, Console: {videoGame.console}");
                }

                MessageBox.Show(sb.ToString(), "List of Video Games");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
