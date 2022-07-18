namespace DesignPatternProject;

public class BillGenerator
{
    private SandwichCommand _sandwichCommand;
    private float _totalPrice;
    public float TotalPrice => _totalPrice;

    public BillGenerator(SandwichCommand sandwichCommand)
    {
        _sandwichCommand = sandwichCommand;
        _totalPrice = 0;
    }

    public void CalculateTotalPrice()
    {
        if (_sandwichCommand.IsCommandValid())
        {
            foreach (Sandwich sn in _sandwichCommand.CommandList)
            {
                this._totalPrice += sn.Price.Value;
            }
        }
        else
        {
            throw new Exception("Command is not valid ");
        }
    }

    public override string? ToString()
    {
        string currency = _sandwichCommand.CommandList[0].Price.Currency;
        return _sandwichCommand.ToString() + "Prix total = " + _totalPrice + currency;
    }
}