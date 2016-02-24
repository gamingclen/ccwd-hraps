using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRaPS.Services
{
    class gender_category : INotifyPropertyChanged
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



        int sex;

        public int Sex
        {
            get { return sex; }
            set
            {
                sex = value;
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

        public gender_category(int sex, string description)
        {
            Sex = sex;
            Description = description;
        }

    }
}
