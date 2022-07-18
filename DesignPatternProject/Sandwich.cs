using System.Text;

namespace DesignPatternProject;

public class Sandwich
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    private Price _price;

    public Price Price
    {
        get => _price;
        set => _price = value;
    }

    private List<string> _ingredients;

    public List<string> Ingredients
    {
        get => _ingredients;
        set => _ingredients = value;
    }

    public Sandwich(string name, Price price, List<string> ingredients)
    {
        this._name = name;
        this._price = price;
        this._ingredients = ingredients;
    }

    public override string ToString()
    {
        StringBuilder sn = new StringBuilder("");
        foreach (string ing in this._ingredients)
        {
            sn.Append(ing + "\n \t");
        }

        return this._name + "\n" + sn;

    }
}