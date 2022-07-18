namespace DesignPatternProject;

public class Price
{
    private float _value;
    private string _currency;

    public Price(float value, string currency)
    {
        this._value = value;
        this._currency = currency;
    }

    public float Value
    {
        get => _value;
        set => _value = value;
    }

    public string Currency
    {
        get => _currency;
        set => _currency = value;
    }
}