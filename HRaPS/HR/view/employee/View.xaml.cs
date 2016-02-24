using MahApps.Metro.Controls;
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

namespace HRaPS.HR.view.employee
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : MetroWindow
    {


        static int tabIndex;

        public View()
        {
            InitializeComponent();
            tabIndex = 0;
            btnNew.Visibility = Visibility.Hidden;
            txtNew.Text = "";
        }


        #region getTabIndex

            private void tabInformation_GotFocus(object sender, RoutedEventArgs e)
            {
                tabIndex = Convert.ToInt32(tabEmployee.SelectedIndex);
                btnNew.Visibility = Visibility.Hidden;
                txtNew.Text = "";
            }

            private void tabFamily_GotFocus(object sender, RoutedEventArgs e)
            {
                tabIndex = Convert.ToInt32(tabEmployee.SelectedIndex);
                btnNew.Visibility = Visibility.Visible;
                txtNew.Text = "New Child";
            }

            private void tabEducation_GotFocus(object sender, RoutedEventArgs e)
            {
                tabIndex = Convert.ToInt32(tabEmployee.SelectedIndex);
                btnNew.Visibility = Visibility.Visible;
                txtNew.Text = "New Education";
            }

            private void tabEligibility_GotFocus(object sender, RoutedEventArgs e)
            {
                tabIndex = Convert.ToInt32(tabEmployee.SelectedIndex);
                btnNew.Visibility = Visibility.Visible;
                txtNew.Text = "New Eligibility";
            }

            private void tabWork_GotFocus(object sender, RoutedEventArgs e)
            {
                tabIndex = Convert.ToInt32(tabEmployee.SelectedIndex);
                btnNew.Visibility = Visibility.Visible;
                txtNew.Text = "New Work Experience";
            }

            private void tabVoluntary_GotFocus(object sender, RoutedEventArgs e)
            {
                tabIndex = Convert.ToInt32(tabEmployee.SelectedIndex);
                btnNew.Visibility = Visibility.Visible;
                txtNew.Text = "New Voluntary";
            }

            private void tabTraining_GotFocus(object sender, RoutedEventArgs e)
            {
                tabIndex = Convert.ToInt32(tabEmployee.SelectedIndex);
                btnNew.Visibility = Visibility.Visible;
                txtNew.Text = "New Training";
            }

        #endregion

            private void btnNew_Click(object sender, RoutedEventArgs e)
            {
                if (tabIndex == 1)
                {
                    //new child code here
                    MessageBox.Show("hr_view_employee_new_child");
                }
                else if (tabIndex == 2)
                {
                    //new education code here
                    MessageBox.Show("hr_view_employee_new_education");
                }
                else if (tabIndex == 3)
                {
                    //new Eligibility code here
                    MessageBox.Show("hr_view_employee_new_eligibility");
                }
                else if (tabIndex == 4)
                {
                    //new Work Experience code here
                    MessageBox.Show("hr_view_employee_new_work_experience");
                }
                else if (tabIndex == 5)
                {
                    //new Voluntary work code here
                    MessageBox.Show("hr_view_employee_new_voluntary_work");
                } else if(tabIndex == 6)
                {
                    //new training code here
                    MessageBox.Show("hr_view_employee_new_training");                    
                }
            }

    }
}
