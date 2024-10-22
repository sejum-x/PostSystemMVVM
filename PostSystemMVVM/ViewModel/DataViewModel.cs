using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSystemMVVM.Model;

namespace PostSystemMVVM.ViewModel
{
    public class DataViewModel : BaseViewModel
    {
        private ObservableCollection<BranchViewModel> _branches { get; set; }

        private ObservableCollection<ClientViewModel> _clients { get; set; }

        private ObservableCollection<WorkerViewModel> _workers { get; set; }

        private ObservableCollection<OrderViewModel> _orders { get; set; }

        public ObservableCollection<BranchViewModel> Branches
        {
            get => _branches;
            set
            {
                _branches = value;
                OnPropertyChanged(nameof(Branches));
            }
        }

        public ObservableCollection<ClientViewModel> Clients
        {
            get => _clients;
            set
            {
                _clients = value;
                OnPropertyChanged(nameof(Clients));
            }
        }

        public ObservableCollection<WorkerViewModel> Workers
        {
            get => _workers;
            set
            {
                _workers = value;
                OnPropertyChanged(nameof(Workers));
            }
        }

        public ObservableCollection<OrderViewModel> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
                OnPropertyChanged(nameof(Orders));
            }
        }
    }
}
