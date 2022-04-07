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
using YouMed72.customcontrols;

namespace YouMed72
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PagesNavigation_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MediumCard_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MediumCard_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void MediumCard_Loaded_2(object sender, RoutedEventArgs e)
        {

        }

        private void MediumCard_Loaded_3(object sender, RoutedEventArgs e)
        {

        }

        private void MediumCard_Loaded_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((RadioButton)e.Source).Uid);



            switch (index)
            {
                case 1:
                    PagesNavigation.Navigate(new YouMed72.Rab.acc()); // открытие страницы
                    break;
                case 2:
                    PagesNavigation.Navigate(new YouMed72.Rab.card()); // открытие страницы
                    break;
                case 3:
                    PagesNavigation.Navigate(new YouMed72.Rab.chablon()); // открытие страницы
                    break;


            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // закрытие окна
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("C:\\Users\\dimon\\OneDrive\\Рабочий стол\\YouMed72\\spravka027.docx");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("C:\\Users\\dimon\\OneDrive\\Рабочий стол\\YouMed72\\NapraavlenieNaKal.doc");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("C:\\Users\\dimon\\OneDrive\\Рабочий стол\\YouMed72\\Vipiska.doc");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("C:\\Users\\dimon\\OneDrive\\Рабочий стол\\YouMed72\\Epicriz.doc");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("C:\\Users\\dimon\\OneDrive\\Рабочий стол\\YouMed72\\Beremenna.doc");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }

}
