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
    /// Логика взаимодействия для w10.xaml
    /// </summary>
    public partial class w10 : Window
    {
        public w10()
        {
            InitializeComponent();
            MyDataGridCheese.ItemsSource = ClassDB.DB.Сыры.ToList();
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
            MyDataGridCheese.ItemsSource = ClassDB.DB.Сыры.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w11 win = new w11();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
