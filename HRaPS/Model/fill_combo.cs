using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using HRaPS.Services;

namespace HRaPS.Model
{
    class fill_combo
    {


        private static HRaPSEntities db = new HRaPSEntities();


        public static void getBinding(ComboBox cbo, Binding comboBinding, string memberPath, string valuePath)
        {
            BindingOperations.SetBinding(cbo, ComboBox.ItemsSourceProperty, comboBinding);
            cbo.DisplayMemberPath = memberPath;
            cbo.SelectedValuePath = valuePath;
            cbo.SelectedIndex = 0;
        }

        public static void display_civil_status(ComboBox cbo)
        {

            ObservableCollection<civil_status_category> cat_list = new ObservableCollection<civil_status_category>();
            var q = db.hr_view_employee_view_civil_status();           
            foreach (var c in q)           
                cat_list.Add(new civil_status_category(c.civil_status, c.description));

            Binding comboBinding = new Binding();
            comboBinding.Source = cat_list;

            getBinding(cbo, comboBinding, "Description", "Civil_Status");

        }


        public static void display_division(ComboBox cbo)
        {

            ObservableCollection<division_category> cat_list = new ObservableCollection<division_category>();
            var q = db.hr_view_employee_view_division();
            foreach (var c in q)
                cat_list.Add(new division_category(c.id, c.description));

            Binding comboBinding = new Binding();
            comboBinding.Source = cat_list;

            getBinding(cbo, comboBinding, "Description", "ID");

        }


        public static void display_gender(ComboBox cbo)
        {

            ObservableCollection<gender_category> cat_list = new ObservableCollection<gender_category>();
            var q = db.hr_view_employee_view_gender();
            foreach (var c in q)
                cat_list.Add(new gender_category(c.sex, c.description));

            Binding comboBinding = new Binding();
            comboBinding.Source = cat_list;

            getBinding(cbo, comboBinding, "Description", "Sex");

        }


        public static void display_status(ComboBox cbo)
        {

            ObservableCollection<status_category> cat_list = new ObservableCollection<status_category>();
            var q = db.hr_view_employee_view_status();
            foreach (var c in q)
                cat_list.Add(new status_category(c.status_id, c.description));

            Binding comboBinding = new Binding();
            comboBinding.Source = cat_list;

            getBinding(cbo, comboBinding, "Description", "Status_ID");

        }

    }
}
