using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSystemMVVM.ViewModel
{
    public class BranchViewModel : BaseViewModel
    {
        private int _id;
        private string _name;
        private string _location;

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
