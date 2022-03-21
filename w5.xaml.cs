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
    /// Логика взаимодействия для w5.xaml
    /// </summary>
    public partial class w5 : Window
    {
        public w5()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            ClassDB.DB.Молоко_и_сливки.Add(new Молоко_и_сливки { id = Convert.ToInt32(idnumber.Text), Дата = datanumber.Text, Молоко_обезжиренное = milk0number.Text, Молоко_2_5 = milk25number.Text, Молоко_3_2 = milk32number.Text, Сливки_10 = sliv10number.Text, Сливки_20 = sliv20number.Text });
            ClassDB.DB.SaveChanges();
            MessageBox.Show("База успешно обновлена");
            this.Close();
            w4 win = new w4();
            win.ShowDialog();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w4 win = new w4();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

    }
}
