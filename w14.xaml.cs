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
    /// Логика взаимодействия для w14.xaml
    /// </summary>
    public partial class w14 : Window
    {
        public w14()
        {
            InitializeComponent();
            MyDataGridPowdered.ItemsSource = ClassDB.DB.Сухие_молочные_продукты.ToList();
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
            MyDataGridPowdered.ItemsSource = ClassDB.DB.Сухие_молочные_продукты.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w15 win = new w15();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }
    }
}
