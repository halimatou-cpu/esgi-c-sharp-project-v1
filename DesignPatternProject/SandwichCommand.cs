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

    public int ContainsSandwich(Sandwich other)
    {
        for (int i = 0; i < this._commandList.Count; i++)
        {
            Sandwich sandwich = this._commandList[i];
            //if (sandwich.Equals(other))
            if (sandwich.Name.Equals(other.Name))
            {
                return i;
            }
        }
        return -1;
    }

    public void AddSandwich(Sandwich sandwich)
    {
        int sandwichOccurenceIndex = this.ContainsSandwich(sandwich);
        if (sandwichOccurenceIndex >= 0)
        {
            this._commandList[sandwichOccurenceIndex].IncreaseQuantityBy(1);
        }
        else
        {
            this._commandList.Add(sandwich);
            this._commandList.Last().IncreaseQuantityBy(1);
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
        foreach (Sandwich sandwich in _commandList)
        {
            commandListToString += sandwich.ToString() + "\n";
        }
        return commandListToString;
    }
}