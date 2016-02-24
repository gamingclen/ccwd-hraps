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
using MahApps.Metro.Controls.Dialogs;

namespace HRaPS.HR.view.employee
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class frmUpdate : MetroWindow
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.ShowMessageAsync("title", "ahaha", MessageDialogStyle.Affirmative);
        }
    }
}
