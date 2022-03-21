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
    /// Логика взаимодействия для w15.xaml
    /// </summary>
    public partial class w15 : Window
    {
        public w15()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w14 win = new w14();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            ClassDB.DB.Сухие_молочные_продукты.Add(new Сухие_молочные_продукты { id = Convert.ToInt32(idnumber.Text), Дата = datanumber.Text, Молоко_сухое_20 = suhmilknumber.Text, Сливки_сухие_42 = suhslivnumber.Text });
            ClassDB.DB.SaveChanges();
            MessageBox.Show("База успешно обновлена");
            this.Close();
            w14 win = new w14();
            win.ShowDialog();
        }
    }
}
