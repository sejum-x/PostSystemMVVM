using System.Collections.ObjectModel;
using PostSystemMVVM.Model;
using PostSystemMVVM.Command;

namespace PostSystemMVVM.ViewModel
{
    class ClientViewModel : BaseViewModel
    {
        public ObservableCollection<Client> Clients { get; set; }
        private Client selectedClient;

        private CustomCommand addClientCmd;
        private CustomCommand removeClientCmd;

        public CustomCommand AddClientCmd
        {
            get
            {
                return addClientCmd ?? (addClientCmd = new CustomCommand(
                    obj =>
                    {
                        Client client = new Client();
                        Clients.Add(client);
                        SelectedClient = client;
                    },
                    (obj) => true
                ));
            }
        }

        public CustomCommand RemoveClientCmd
        {
            get
            {
                return removeClientCmd ?? (removeClientCmd = new CustomCommand(
                    obj =>
                    {
                        Client client = obj as Client;
                        if (client != null)
                        {
                            Clients.Remove(client);
                        }
                    },
                    (obj) => Clients.Count > 0
                ));
            }
        }

        public Client SelectedClient
        {
            get { return selectedClient; }
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }

        public ClientViewModel()
        {
            Clients = new ObservableCollection<Client>
            {
                new Client(1, "Oleksandr", "Klymenko", "380661111111"),
                new Client(2,"Mychailo", "Mychailov", "380662222222"),
            };
        }
    }
}