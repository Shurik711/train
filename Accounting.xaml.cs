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

namespace BFE
{
    /// <summary>
    /// Логика взаимодействия для Accounting.xaml
    /// </summary>
    public partial class Accounting : Window
    {
        public Accounting()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow win = new MainWindow();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void milk_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w4 win = new w4();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void butter_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w6 win = new w6();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void fermented_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w8 win = new w8();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void cheese_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w10 win = new w10();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void canned_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w12 win = new w12();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void powdered_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w14 win = new w14();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }


    }
}
