using System.Collections.ObjectModel;
using PostSystemMVVM.Model;
using PostSystemMVVM.Command;
using PostSystemMVVM.Command;
using PostSystemMVVM.Model;
using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.ViewModel
{
    class PackageViewModel : BaseViewModel
    {
        public ObservableCollection<Package> Packages { get; set; }
        private Package selectedPackage;

        private CustomCommand addPackageCmd;
        private CustomCommand removePackageCmd;

        public CustomCommand AddPackageCmd
        {
            get
            {
                return addPackageCmd ?? (addPackageCmd = new CustomCommand(
                    obj =>
                    {
                        Package package = new Package();
                        Packages.Add(package);
                        SelectedPackage = package;
                    },
                    (obj) => true
                ));
            }
        }

        public CustomCommand RemovePackageCmd
        {
            get
            {
                return removePackageCmd ?? (removePackageCmd = new CustomCommand(
                    obj =>
                    {
                        Package package = obj as Package;
                        if (package != null)
                        {
                            Packages.Remove(package);
                        }
                    },
                    (obj) => Packages.Count > 0
                ));
            }
        }

        public Package SelectedPackage
        {
            get { return selectedPackage; }
            set
            {
                selectedPackage = value;
                OnPropertyChanged("SelectedPackage");
            }
        }

        public PackageViewModel()
        {
            Packages = new ObservableCollection<Package>
            {
                new Package( 1, "Toy", 5.0, 10, 20, 30, new PackageType(10, 15, 20, 30, 100)),
                new Package( 1, "Shoes", 5.0, 10, 20, 30, new PackageType(10, 15, 20, 30, 100)),
            };
        }
    }
}
