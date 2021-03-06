﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRaPS.Services
{
    class division_category  : INotifyPropertyChanged
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



        int id;

        public int ID
        {
            get { return id; }
            set
            {
                id = value;
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

        public division_category(int id, string description)
        {
            ID = id;
            Description = description;
        }

    }
}
