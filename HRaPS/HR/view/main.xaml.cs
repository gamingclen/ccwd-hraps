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

namespace HRaPS.HR.view
{
    /// <summary>
    /// Interaction logic for main.xaml
    /// </summary>
    public partial class main : MetroWindow
    {
        public main()
        {
            InitializeComponent();
        }

        private void MetroWindow_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

            if (Mouse.RightButton == MouseButtonState.Pressed)
            {

                if (foSide.IsOpen == true)
                {
                    foSide.IsOpen = false;
                    return;
                }

                if (foSide.IsOpen == false)
                {
                    foSide.IsOpen = true;
                    return;
                }

            }



        }

        public static bool IsWindowOpen<T>(string name = "") where T : Window
        {
            return string.IsNullOrEmpty(name)
               ? Application.Current.Windows.OfType<T>().Any()
               : Application.Current.Windows.OfType<T>().Any(w => w.Name.Equals(name));
        }


        private async void btnCreate_Click(object sender, RoutedEventArgs e)
        {


            foreach (var wnd in Application.Current.Windows)
            {
                if (wnd is employee.frmCreate)
                {
                    await this.ShowMessageAsync("HR", "Create form Is already open", MessageDialogStyle.Affirmative);                       
                    return;
                }                
            }

            employee.frmCreate f = new employee.frmCreate();
            f.Show();

        }

        private async void btnView_Click(object sender, RoutedEventArgs e)
        {
                        
            foreach (var wnd in Application.Current.Windows)
            {
                if (wnd is employee.Employee)
                {
                    await this.ShowMessageAsync("HR", "View form Is already open", MessageDialogStyle.Affirmative);                       
                    return;
                }                
            }

            employee.Employee f = new employee.Employee();
            f.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            this.Close();
        }

       
    }
}
