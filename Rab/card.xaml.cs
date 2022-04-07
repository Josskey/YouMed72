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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YouMed72.Rab
{
    /// <summary>
    /// Логика взаимодействия для card.xaml
    /// </summary>
    public partial class card : Page
    {
        public card()
        {
            InitializeComponent();
            Table.ItemsSource = Medical_cardEntities.GetContext().Patient.ToList();
        }
        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int i = (Table.SelectedItem as Patient).ID;

            var delt = Medical_cardEntities.GetContext().Patient.Where(m => m.ID == i).Single();
            Medical_cardEntities.GetContext().Patient.Remove(delt);
            Medical_cardEntities.GetContext().SaveChanges();
            Medical_cardEntities forum = new Medical_cardEntities();
            Table.ItemsSource = forum.Patient.ToList();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            YouMed72.Rab.Frame.Dobavlenie asade = new YouMed72.Rab.Frame.Dobavlenie();
            asade.Show();

        }
        private void redact_Click(object sender, RoutedEventArgs e)
        {
            YouMed72.Rab.Frame.Redact pdsfa = new YouMed72.Rab.Frame.Redact((Table.SelectedItem as Patient).ID);
            pdsfa.Show();


        }
    }
}
