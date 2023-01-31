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

namespace Video_Game_App.View
{
    /// <summary>
    /// Logique d'interaction pour StartView.xaml
    /// </summary>
    public partial class StartView : Window
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) // méthode permettant de bouger la fenêtre
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e) // méthode permettant de réduire la fenêtre
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) // méthode permettant de fermer la fenêtre
        {
            Application.Current.Shutdown();
        }
    }
}
