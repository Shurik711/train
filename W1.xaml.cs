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
    /// Логика взаимодействия для W1.xaml
    /// </summary>
    public partial class W1 : Window
    {
        public W1()
        {
            InitializeComponent();
        }

       

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow win = new MainWindow();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
