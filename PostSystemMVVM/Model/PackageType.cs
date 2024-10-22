using PostSystemMVVM.ViewModel;

namespace PostSystemMVVM.Model;

public class PackageType : BaseViewModel
{
    private double _maxWeight;
    private double _maxHeight;
    private double _maxWidth;
    private double _maxLength;
    private double _price;

    public PackageType()
    {
        this._maxWeight = 0;
        this._maxHeight = 0;
        this._maxWidth = 0;
        this._maxLength = 0;
        this._price = 0;
    }

    public PackageType(double maxWeight, double maxHeight, double maxWidth, double maxLength, double price)
    {
        this._maxWeight = maxWeight;
        this._maxHeight = maxHeight;
        this._maxWidth = maxWidth;
        this._maxLength = maxLength;
        this._price = price;
    }

    public double MaxWeight
    {
        get => _maxWeight;
        set { _maxWeight = value; OnPropertyChanged(nameof(MaxWeight)); }
    }

    public double MaxHeight
    {
        get => _maxHeight;
        set { _maxHeight = value; OnPropertyChanged(nameof(MaxHeight)); }
    }

    public double MaxWidth
    {
        get => _maxWidth;
        set { _maxWidth = value; OnPropertyChanged(nameof(MaxWidth)); }
    }

    public double MaxLength
    {
        get => _maxLength;
        set { _maxLength = value; OnPropertyChanged(nameof(MaxLength)); }
    }

    public double Price
    {
        get => _price;
        set { _price = value; OnPropertyChanged(nameof(Price)); }
    }
}