using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model
{
    public class Branch : BaseViewModel
    {
        private int _id;
        private string _name;
        private string _location;

        public Branch()
        {
            this._id = 0;
            this._name = "";
            this._location = "";
        }

        public Branch(int id, string name, string location)
        {
            this._id = id;
            this._name = name;
            this._location = location;
        }

        public int Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(nameof(Id)); }
        }

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Location
        {
            get => _location;
            set { _location = value; OnPropertyChanged(nameof(Location)); }
        }
    }
}
