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

namespace BFE
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
           
            //        fr1.Navigate(new P1());
           this.Hide();
           W1 win = new W1();
           win.Top = this.Top;
           win.Left = this.Left;
           win.Show();
        }

        private void production_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            W3 win = new W3();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
