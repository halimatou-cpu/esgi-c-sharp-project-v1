using System.Text;

namespace DesignPatternProject;

public class Sandwich
{
    private int _quantity = 0;
    public int Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }
    public void IncreaseQuantityBy(int quantitySup = 1)
    {
        Console.WriteLine("Before increase " +this._quantity);
        this._quantity += quantitySup;
        Console.WriteLine(this._quantity);
    }

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

    //private List<string> _ingredients;

    //public List<string> Ingredients
    //{
    //    get => _ingredients;
    //    set => _ingredients = value;
    //}

    public Sandwich(string name, Price price)
    {
        this._name = name;
        this._price = price;
        //this._ingredients = ingredients;
    }
    public Sandwich(string name, Price price, List<string> ingredients)
    {
        this._name = name;
        this._price = price;
        //this._ingredients = ingredients;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        Sandwich other = (Sandwich) obj;
        return this._name.Equals(other._name) && this._price.Equals(other._price);
        // && this._ingredients.Equals(other._ingredients)
    }

    public override string ToString()
    {
        StringBuilder sn = new StringBuilder("");
        //foreach (string ing in this._ingredients)
        //{
        //    sn.Append(ing + "\n \t");
        //}

        return this._quantity + " x " + this._name + "\n \t" + sn;

    }

}