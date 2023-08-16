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
    /// Logique d'interaction pour LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                string usernames = txtUser.Text;
                string passwords = txtPassword.Password;

                User user = new User
                {
                    usernames = usernames,
                    passwords = passwords
                };

                DAO dao = new DAO();
                bool userExists = dao.CheckUserExists(usernames, passwords);

                if (userExists)
                {
                    MessageBox.Show("Login successful!");

                    dao = new DAO();
                    bool playerExists = dao.CheckPlayerExists(usernames);

                    if (playerExists)
                    {
                        NavigationService.Navigate(new Uri("View/PlayerView.xaml", UriKind.Relative));
                    }
                    else
                    {
                        dao = new DAO();
                        bool administratorExists = dao.CheckAdministratorExists(usernames);

                        if (administratorExists)
                        {
                            NavigationService.Navigate(new Uri("View/AdministratorView.xaml", UriKind.Relative));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Login failed. Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

}
