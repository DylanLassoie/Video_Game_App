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
using System.Windows.Shapes;
using Video_Game_App.Backend;
using Video_Game_App.Management;

namespace Video_Game_App.View
{
    /// <summary>
    /// Logique d'interaction pour RegisterView.xaml
    /// </summary>
    public partial class RegisterView : Page
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string usernames = txtUser.Text;
                string passwords = txtPassword.Password;

                DAO dao = new DAO();
                dao.InsertNewUser(usernames, passwords);
                try
                {
                    int crédit = 10;
                    string pseudo = txtPseudo.Text;
                    DateTime registrationDate = DateTime.Now;
                    DateTime dateOfBirth = dateBirth.SelectedDate ?? DateTime.MinValue;

                    Player newPlayer = new Player
                    {
                        usernames = usernames,
                        crédit = crédit,
                        pseudo = pseudo,
                        registrationDate = registrationDate,
                        dateOfBirth = dateOfBirth
                    };

                    dao = new DAO();
                    dao.InsertNewPlayer(newPlayer);

                    MessageBox.Show("Registration successful!");
                    NavigationService.Navigate(new Uri("View/PlayerView.xaml", UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
