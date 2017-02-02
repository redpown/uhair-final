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

namespace WpfApplication9
{
    /// <summary>
    /// Interaction logic for Cad_menu.xaml
    /// </summary>
    public partial class Cad_menu : Window
    {
        public bool btn = true;
        New_User tela_user;
        New_Cli tela_cli;
        public Cad_menu()

        {
           
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void bnt_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bnt_res_Click(object sender, RoutedEventArgs e)
        {
            if (btn == true)
            {
                this.WindowState = WindowState.Normal;
                btn = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;

                btn = true;
            }
        }

        private void bnt_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void bnt_new_user_Click(object sender, RoutedEventArgs e)
        {
            tela_user = new New_User();
            this.Close();
            tela_user.Show();
        }

        private void bnt_new_cli_Click(object sender, RoutedEventArgs e)
        {
            tela_cli = new New_Cli();
            this.Close();
            tela_cli.Show();
        }
    }
}
