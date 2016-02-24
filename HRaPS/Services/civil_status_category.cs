using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRaPS.Services
{
    class civil_status_category : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void Notify(string propName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }



        int categoryCode;

        public int CategoryCode
        {
            get { return categoryCode; }
            set
            {
                if (categoryCode == value) { return; }
                categoryCode = value;
                Notify("CategoryCode");
            }
        }



        int civil_status;

        public int Civil_Status
        {
            get { return civil_status; }
            set
            {
                civil_status = value;
                Notify("Code");
            }
        }

        string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                Notify("Category");
            }
        }

        public civil_status_category(int civil_status, string description)
        {
            Civil_Status = civil_status;
            Description = description;
        }

    }
}
