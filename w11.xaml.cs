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
    /// Логика взаимодействия для w11.xaml
    /// </summary>
    public partial class w11 : Window
    {
        public w11()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            w10 win = new w10();
            win.Top = this.Top;
            win.Left = this.Left;
            win.Show();
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            ClassDB.DB.Сыры.Add(new Сыры { id = Convert.ToInt32(idnumber.Text), Дата = datanumber.Text, Пармезан = parmezannumber.Text, Российский = russiannumber.Text, Гауда = gaudanumber.Text });
            ClassDB.DB.SaveChanges();
            MessageBox.Show("База успешно обновлена");
            this.Close();
            w10 win = new w10();
            win.ShowDialog();
        }
    }
}
