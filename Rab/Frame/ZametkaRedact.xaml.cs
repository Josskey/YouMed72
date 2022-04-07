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
    /// Логика взаимодействия для ZametkaRedact.xaml
    /// </summary>
    public partial class ZametkaRedact : Window
    {
        int id;
        public ZametkaRedact(int Mid)
        {
            id = Mid;
            InitializeComponent();
            Id_cat.ItemsSource = Medical_cardEntities.GetContext().Zametka.ToList();
            Zametka ldsa = (from m in Medical_cardEntities.GetContext().Zametka
                            where m.ID == Mid
                            select m).Single();
            NAME.Text = ldsa.NAME;
            DATA.Text = ldsa.DATA.ToString();
            Id_cat.SelectedItem = ldsa.ID;
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
            var c = Id_cat.Text;
            Zametka ldsa = (from m in Medical_cardEntities.GetContext().Zametka
                            where m.ID == id
                            select m).Single();
            ldsa.NAME = NAME.Text;
            ldsa.DATA = (DATA.Text);
            ldsa.ID = (int)(Medical_cardEntities.GetContext().Zametka.First(x => x.NAME == c).ID);
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
