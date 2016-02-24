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
    /// Interaction logic for Employee.xaml
    /// </summary>
    /// 


    class Animal
    {
        public string sFullName { get; set; }        
        public string division { get; set; }
    }


    public partial class Employee : MetroWindow
    {
        public Employee()
        {
            InitializeComponent();
            lvEmployee.Items.Add(new Animal() { sFullName = "Clen", division="MIS" });
            lvEmployee.Items.Add(new Animal() { sFullName = "Clen", division = "MIS" });
            lvEmployee.Items.Add(new Animal() { sFullName = "Clen", division = "MIS" });
            lvEmployee.Items.Add(new Animal() { sFullName = "Clen", division = "MIS" });
        }
    }
}
