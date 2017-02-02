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
    /// Interaction logic for popup_ERRO.xaml
    /// </summary>
    public partial class popup_ERRO : Window
    {
        public int err = 1;
        public popup_ERRO()
        {
           
            InitializeComponent();
        }

        private void errror_close_Click(object sender, RoutedEventArgs e)
        {
            err = 0;
            this.Close();
           
        }

        private void acpt_Click(object sender, RoutedEventArgs e)
        {
            err = 0;
            this.Close();
            
        }
    }
}
