namespace DesignPatternProject;

public class SandwichCommand
{
    private List<Sandwich> _commandList;

    public List<Sandwich> CommandList
    {
        get => _commandList;
        set => _commandList = value;
    }
   
    public SandwichCommand()
    {
        _commandList = new List<Sandwich>();
    }

    public bool ContainsSandwich(Sandwich other)
    {
        foreach(Sandwich sandwich in this._commandList)
        {
            if (sandwich.Equals(other))
            {
                Console.WriteLine("Same sandwich choosed");
                sandwich.IncreaseQuantityBy(1);
                return true;
            }
        }
        return false;
    }


    public void AddSandwich(Sandwich sandwich)
    {
        if (this.ContainsSandwich(sandwich)) {
            sandwich.IncreaseQuantityBy(1);

           
        }else
        {
            sandwich.IncreaseQuantityBy(1);
            this._commandList.Add(sandwich);
        }        
    }

    public void RemoveTheLastAddedSandwich()
    {
        this._commandList.RemoveAt(-1);
    }

    public bool IsCommandValid()
    {
        return _commandList.Count > 0;
    }

    public override string? ToString()
    {
        string commandListToString = "";
        foreach(Sandwich sandwich in _commandList)
        {            
            commandListToString += sandwich.ToString() + "\n";
        }
        return commandListToString;
    }
}