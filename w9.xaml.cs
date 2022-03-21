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
    /// Логика взаимодействия для w9.xaml
    /// </summary>
    public partial class w9 : Window
    {
        public w9()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w8 win = new w8();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            ClassDB.DB.Кисломолочные_продукты.Add(new Кисломолочные_продукты { id = Convert.ToInt32(idnumber.Text), Дата = datanumber.Text, Кефир_обезжиренный = kefir0number.Text, Кефир_2_5 = kefir25number.Text, Кефир_3_2 = kefir32number.Text, Йогурт_клубничный_2_5 = yoghurtclubnumber.Text, Йогурт_персиковый_2_5 = yoghurtpersnumber.Text });
            ClassDB.DB.SaveChanges();
            MessageBox.Show("База успешно обновлена");
            this.Close();
            w8 win = new w8();
            win.ShowDialog();
        }
    }
}
