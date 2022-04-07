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
using System.Data.SqlClient;
using System.Configuration;

namespace YouMed72
{
    /// <summary>
    /// Логика взаимодействия для reg.xaml
    /// </summary>
   
        public partial class reg : Window
        {
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            SqlDataReader dr;
            public reg()
        {
            InitializeComponent();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            if (VerifyUser(txtUsername.Text, txtPassword.Password))
            {
                MessageBox.Show("Login Successfully", "Congrats", MessageBoxButton.OK, MessageBoxImage.Information);
                if (txtUsername.Text == "admin")
                {
                    // доделать this.Hide();
                    // доделать YouMed72.Zav.ZavOkno qwert = new YouMed72.Zav.ZavOkno();  
                    // доделать qwert.Show();
                }
                else
                {
                    this.Hide();
                    YouMed72.MainWindow qwert = new YouMed72.MainWindow();
                    qwert.Show();
                }
            }
            else
            {
                MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool VerifyUser(string username, string password)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select Status from Users where username='" + username + "' and password='" + password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToBoolean(dr["Status"]) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
