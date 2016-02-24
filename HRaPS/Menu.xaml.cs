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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnHR_Click(object sender, RoutedEventArgs e)
        {
            //await this.ShowMessageAsync("HR Window", "ahaha", MessageDialogStyle.AffirmativeAndNegative);

            HR.view.main f = new HR.view.main();
            f.Show();
            this.Close();
        }
    }
}
