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
    /// Логика взаимодействия для Redact.xaml
    /// </summary>
    public partial class Redact : Window
    {
        int id;
        public Redact(int Mid)
        {
            id = Mid;
            InitializeComponent();
            Id_cat.ItemsSource = Medical_cardEntities.GetContext().Patient.ToList();
            Patient ldsa = (from m in Medical_cardEntities.GetContext().Patient
                            where m.ID == Mid
                             select m).Single();
            NAME.Text = ldsa.NAME;
            PASS.Text = ldsa.PASS.ToString();
            NCARD.Text = ldsa.NCARD.ToString();
            F.Text = ldsa.F.ToString();
            O.Text = ldsa.O.ToString();
            Id_cat.SelectedItem = ldsa.ID;
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            var c = Id_cat.Text;
            Patient ldsa = (from m in Medical_cardEntities.GetContext().Patient
                             where m.ID == id
                             select m).Single();
            ldsa.NAME = NAME.Text;
            ldsa.PASS = (int)Convert.ToDouble(PASS.Text);
            ldsa.NCARD = (int)Convert.ToDouble(NCARD.Text);
            ldsa.F = (F.Text);
            ldsa.O = (O.Text);
            ldsa.ID = (int)(Medical_cardEntities.GetContext().Patient.First(x => x.NAME == c).ID);
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
