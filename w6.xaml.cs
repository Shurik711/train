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
    /// Логика взаимодействия для w6.xaml
    /// </summary>
    public partial class w6 : Window
    {
        public w6()
        {
            InitializeComponent();
            MyDataGridButter.ItemsSource = ClassDB.DB.Масло.ToList();
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
            MyDataGridButter.ItemsSource = ClassDB.DB.Масло.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w7 win = new w7();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
