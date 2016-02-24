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
using HRaPS.Model;
using HRaPS.Services;

namespace HRaPS.HR.view.employee
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    /// 

    public partial class frmCreate : MetroWindow
    {
        public frmCreate()
        {
            InitializeComponent();
        }


        employee_validator emp_validator = new employee_validator();


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {

            var cc = await this.ShowMessageAsync("HRaPS", "Are you sure you want to save it?", MessageDialogStyle.AffirmativeAndNegative);

            if (cc == MessageDialogResult.Negative)
            {
                return;
            }

            var success = await this.ShowProgressAsync("HRaPS", "Success");
            await Task.Delay(2000);
            await success.CloseAsync();

            var controller = await this.ShowMessageAsync("HRaPS", "Do you want to update other information?", MessageDialogStyle.AffirmativeAndNegative);

            if (controller == MessageDialogResult.Negative)
            {
                return;
            }

            HR.view.employee.View f = new HR.view.employee.View();
            f.Show();
            this.Close();

            
        }

        private async void MetroWindow_Loaded_1(object sender, RoutedEventArgs e)
        {

            this.personal_info.DataContext = emp_validator;

            var display = await this.ShowProgressAsync("HRaPS", "Loading Division/Department");
            fill_combo.display_division(cbo_department);
            display.SetMessage("Loading Gender");
            fill_combo.display_gender(cbo_sex);
            display.SetMessage("Loading Civil Status");
            fill_combo.display_civil_status(cbo_civil_status);
            display.SetMessage("Loading Status");
            fill_combo.display_status(cbo_status);
            await display.CloseAsync();

        }
    }
}
