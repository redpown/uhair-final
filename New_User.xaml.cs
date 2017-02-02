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
    /// Interaction logic for New_User.xaml
    /// </summary>
    public partial class New_User : Window
    {
        public DAONewUser newUser;
        public bool btn = true;
        public Cad_menu menu_principal;
        public New_User()
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

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            menu_principal = new Cad_menu();
            this.Close();
            menu_principal.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
           newUser = new DAONewUser();
            newUser.Inserir( user.Text , pass.Text , key.Text );
        }
    }
}
