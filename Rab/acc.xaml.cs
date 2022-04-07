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
    /// Логика взаимодействия для acc.xaml
    /// </summary>
    public partial class acc : Page
    {
        public acc()
        {
            InitializeComponent();
            Table.ItemsSource = Medical_cardEntities.GetContext().Zametka.ToList();
        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int i = (Table.SelectedItem as Zametka).ID;

            var delt = Medical_cardEntities.GetContext().Zametka.Where(m => m.ID == i).Single();
            Medical_cardEntities.GetContext().Zametka.Remove(delt);
            Medical_cardEntities.GetContext().SaveChanges();
            Medical_cardEntities forum = new Medical_cardEntities();
            Table.ItemsSource = forum.Zametka.ToList();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            YouMed72.Rab.Frame.ZametkaDobavlenie asade = new YouMed72.Rab.Frame.ZametkaDobavlenie();
            asade.Show();

        }
        private void redact_Click(object sender, RoutedEventArgs e)
        {
            YouMed72.Rab.Frame.ZametkaRedact pdsfa = new YouMed72.Rab.Frame.ZametkaRedact((Table.SelectedItem as Zametka).ID);
            pdsfa.Show();


        }
    }
}
