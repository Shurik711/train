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
    /// Логика взаимодействия для w4.xaml
    /// </summary>
    public partial class w4 : Window
    {
        public w4()
        {
            InitializeComponent();
            MyDataGridMilk.ItemsSource = ClassDB.DB.Молоко_и_сливки.ToList();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Accounting win = new Accounting();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            ClassDB.DB.SaveChanges();
            MyDataGridMilk.ItemsSource = ClassDB.DB.Молоко_и_сливки.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w5 win = new w5();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

    }
}
