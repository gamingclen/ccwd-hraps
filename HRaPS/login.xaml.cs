using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace HRaPS
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : MetroWindow
    {



        public login()
        {
            InitializeComponent();
        }



        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var controller = await this.ShowProgressAsync("HRaPS", "Checking account, please wait... ");
            await Task.Delay(1000);

            Menu w = new Menu();
            w.Show();
            this.Close();

            await controller.CloseAsync();


            //int q = db.login(txtUsername.Text, txtPassword.Password).Count();


            //if (q == 1)
            //{
            //    Menu f = new Menu();
            //    f.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Password or username is incorrect");
            //}



        }


    }
}
