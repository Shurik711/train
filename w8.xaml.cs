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
    /// Логика взаимодействия для w8.xaml
    /// </summary>
    public partial class w8 : Window
    {
        public w8()
        {
            InitializeComponent();
            MyDataGridFermented.ItemsSource = ClassDB.DB.Кисломолочные_продукты.ToList();
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
            MyDataGridFermented.ItemsSource = ClassDB.DB.Кисломолочные_продукты.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w9 win = new w9();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
