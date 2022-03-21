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
    /// Логика взаимодействия для W3.xaml
    /// </summary>
    public partial class W3 : Window
    {
        public W3()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow win = new MainWindow();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "Админ" && Pass.Password == "12345")
            {
                this.Hide();
                Accounting win = new Accounting();
                win.Top = this.Top;
                win.Left = this.Left;
                win.Show();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
