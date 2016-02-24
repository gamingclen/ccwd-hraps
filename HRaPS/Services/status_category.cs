using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRaPS.Services
{
    class status_category  : INotifyPropertyChanged
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



        int status_id;

        public int Status_ID
        {
            get { return status_id; }
            set
            {
                status_id = value;
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

        public status_category(int status_id, string description)
        {
            Status_ID = status_id;
            Description = description;
        }

    }
}
