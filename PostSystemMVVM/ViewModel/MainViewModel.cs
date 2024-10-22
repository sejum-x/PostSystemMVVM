using System.Collections.ObjectModel;
using System.Windows.Input;
using PostSystemMVVM.Model;
using PostSystemMVVM.Command;

namespace PostSystemMVVM.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        // Branch properties
        public ObservableCollection<Branch> Branches { get; set; }
        private Branch selectedBranch;
        public Branch SelectedBranch
        {
            get => selectedBranch;
            set
            {
                selectedBranch = value;
                OnPropertyChanged(nameof(SelectedBranch));
            }
        }

        // Client properties
        public ObservableCollection<Client> Clients { get; set; }
        private Client selectedClient;
        public Client SelectedClient
        {
            get => selectedClient;
            set
            {
                selectedClient = value;
                OnPropertyChanged(nameof(SelectedClient));
            }
        }

        // Worker properties
        public ObservableCollection<Worker> Workers { get; set; }
        private Worker selectedWorker;
        public Worker SelectedWorker
        {
            get => selectedWorker;
            set
            {
                selectedWorker = value;
                OnPropertyChanged(nameof(SelectedWorker));
            }
        }

        // Commands
        public ICommand AddBranchCommand { get; set; }
        public ICommand RemoveBranchCommand { get; set; }
        public ICommand EditBranchCommand { get; set; }

        public ICommand AddClientCommand { get; set; }
        public ICommand RemoveClientCommand { get; set; }
        public ICommand EditClientCommand { get; set; }

        public ICommand AddWorkerCommand { get; set; }
        public ICommand RemoveWorkerCommand { get; set; }
        public ICommand EditWorkerCommand { get; set; }

        public MainViewModel()
        {
            // Initializing collections with hardcoded data
            Branches = new ObservableCollection<Branch>
            {
                new Branch(1, "Main Branch", "123 Main St, Kyiv"),
                new Branch(2, "West Branch", "456 West St, Lviv"),
                new Branch(3, "East Branch", "789 East St, Kharkiv")
            };

            Clients = new ObservableCollection<Client>
            {
                new Client(1, "John Doe", "john@example.com", "+380123456789"),
                new Client(2, "Jane Smith", "jane@example.com", "+380987654321"),
                new Client(3, "Alex Johnson", "alex@example.com", "+380567890123")
            };

            Workers = new ObservableCollection<Worker>
            {
                new Worker(1, "Mark Williams", "mark@example.com", "+380345678901", WorkerPosition.Operator),
                new Worker(2, "Anna Taylor", "anna@example.com", "+380456789012", WorkerPosition.Manager),
                new Worker(3, "Olga Ivanova", "olga@example.com", "+380567890123", WorkerPosition.Supervisor)
            };

            // Initialize commands
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            // Add commands
            AddBranchCommand = new CustomCommand((obj) =>
            {
                var branch = new Branch();
                Branches.Add(branch);
                SelectedBranch = branch;
            }, (obj) => true);

            RemoveBranchCommand = new CustomCommand((obj) =>
            {
                if (SelectedBranch != null)
                    Branches.Remove(SelectedBranch);
            }, (obj) => Branches.Count > 0);

            AddClientCommand = new CustomCommand((obj) =>
            {
                var client = new Client();
                Clients.Add(client);
                SelectedClient = client;
            }, (obj) => true);

            RemoveClientCommand = new CustomCommand((obj) =>
            {
                if (SelectedClient != null)
                    Clients.Remove(SelectedClient);
            }, (obj) => Clients.Count > 0);

            AddWorkerCommand = new CustomCommand((obj) =>
            {
                var worker = new Worker();
                Workers.Add(worker);
                SelectedWorker = worker;
            }, (obj) => true);

            RemoveWorkerCommand = new CustomCommand((obj) =>
            {
                if (SelectedWorker != null)
                    Workers.Remove(SelectedWorker);
            }, (obj) => Workers.Count > 0);

            // Edit commands
            EditBranchCommand = new CustomCommand((obj) =>
            {
                if (SelectedBranch != null)
                {
                    // Here, logic to edit the selected branch could be handled in the view,
                    // such as opening a dialog or enabling editing mode in the UI.
                    // The edited data is already updated through data binding.
                }
            }, (obj) => SelectedBranch != null);

            EditClientCommand = new CustomCommand((obj) =>
            {
                if (SelectedClient != null)
                {
                    // Logic to edit the selected client
                }
            }, (obj) => SelectedClient != null);

            EditWorkerCommand = new CustomCommand((obj) =>
            {
                if (SelectedWorker != null)
                {
                    // Logic to edit the selected worker
                }
            }, (obj) => SelectedWorker != null);
        }
    }
}
