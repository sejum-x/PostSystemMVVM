using PostSystemMVVM.Command;
using PostSystemMVVM.Model;
using System.Collections.ObjectModel;

namespace PostSystemMVVM.ViewModel
{
    class BranchViewModel : BaseViewModel
    {
        public ObservableCollection<Branch> Branches { get; set; }
        private Branch selectedBranch;

        private CustomCommand addBranchCmd;
        private CustomCommand removeBranchCmd;

        public CustomCommand AddBranchCmd
        {
            get
            {
                return addBranchCmd ?? (addBranchCmd = new CustomCommand(
                    obj =>
                    {
                        Branch branch = new Branch();
                        Branches.Add(branch);
                        SelectedBranch = branch;
                    },
                    (obj) => true
                ));
            }
        }

        public CustomCommand RemoveBranchCmd
        {
            get
            {
                return removeBranchCmd ?? (removeBranchCmd = new CustomCommand(
                    obj =>
                    {
                        Branch branch = obj as Branch;
                        if (branch != null)
                        {
                            Branches.Remove(branch);
                        }
                    },
                    (obj) => Branches.Count > 0
                ));
            }
        }

        public Branch SelectedBranch
        {
            get { return selectedBranch; }
            set
            {
                selectedBranch = value;
                OnPropertyChanged("SelectedBranch");
            }
        }

        public BranchViewModel()
        {
            Branches = new ObservableCollection<Branch>
            {
                // Initialize with sample data
                new Branch(1, "Main Branch", "Lviv 123 Street"),
                new Branch(2, "Secondary Branch", "Kyiv 456 Avenue"),
            };
        }
    }
}