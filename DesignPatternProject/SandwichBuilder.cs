namespace DesignPatternProject;

public class SandwichBuilder
{
    private string? _name;
    private Price? _price;
    private List<string>? _ingredients;

    public SandwichBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public SandwichBuilder WithPrice(Price price)
    {
        _price = price;
        return this;
    }

    public SandwichBuilder WithIngredient(List<string> ingredients)
    {
        _ingredients = ingredients;
        return this;
    }

    public Sandwich Build()
    {
        if (_name != null && _price != null && _ingredients != null)
        {
            return new Sandwich(_name, _price, _ingredients);   
        }

        throw new ArgumentException();
    }
}