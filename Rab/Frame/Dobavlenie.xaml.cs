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

namespace YouMed72.Rab.Frame
{
    /// <summary>
    /// Логика взаимодействия для Dobavlenie.xaml
    /// </summary>
    public partial class Dobavlenie : Window
    {
        public Dobavlenie()
        {
            InitializeComponent();
            Id_cat.ItemsSource = Medical_cardEntities.GetContext().Patient.ToList();
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            var c = Id_cat.Text;
            Patient Ccuputer = new Patient()
            {

                NAME = NAME.Text,
                PASS = (int)Convert.ToDouble(PASS.Text),
                NCARD = (int)Convert.ToDouble(NCARD.Text),
                F = F.Text,
                O = O.Text,
                ID = (int)(Medical_cardEntities.GetContext().Patient.First(x => x.NAME == c).ID)
            };
            Medical_cardEntities.GetContext().Patient.Add(Ccuputer);
            Medical_cardEntities.GetContext().SaveChanges();
            YouMed72.MainWindow sdel = new YouMed72.MainWindow();
            sdel.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            YouMed72.MainWindow sda = new YouMed72.MainWindow();
            sda.Show();
            this.Close();
        }
    }
}


