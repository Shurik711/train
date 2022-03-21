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
    /// Логика взаимодействия для w13.xaml
    /// </summary>
    public partial class w13 : Window
    {
        public w13()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w12 win = new w12();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            ClassDB.DB.Молочные_консервы.Add(new Молочные_консервы { id = Convert.ToInt32(idnumber.Text), Дата = datanumber.Text, Молоко_сгущенное = sgusnumber.Text, Молоко_концентрированное_2_5 = concnumber.Text });
            ClassDB.DB.SaveChanges();
            MessageBox.Show("База успешно обновлена");
            this.Close();
            w12 win = new w12();
            win.ShowDialog();
        }
    }
}
