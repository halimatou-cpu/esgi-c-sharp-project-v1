namespace DesignPatternProject;

public class Price
{
    private float _value;

    public Price(float value, string currency)
    {
        this._value = value;
        this.Currency = currency;
    }

    public float Value
    {
        get => _value;
        set => _value = value;
    }

    public string Currency { get; set; }

    //public override bool Equals(object? obj)
    //{
    //    if (obj == null)
    //    {
    //        return false;
    //    }

    //    Price other = (Price) obj;

    //    return other._value == this._value && other.Currency.Equals(this.Currency);
    //}
}