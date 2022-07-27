
using System.Text;

namespace DesignPatternProject;
using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine(
                "############### Appuyer sur la touche correspondante pour faire votre commande. ###############");
        CommandChoice(MakeCommandDashbord());

    }

    public static string MakeCommandDashbord()
    {
        string key;
        do
        {
            Console.WriteLine("(a) pour Jambon beurre");
            Console.WriteLine("(b) pour Poulet crudités");
            Console.WriteLine("(c) pour Dieppois");
            Console.WriteLine("(d) pour Finir");
            Console.WriteLine("___________________________________________________________________________________");
            key = (Console.ReadLine()?.ToString()!);
        } while (!key.Equals("a") && !key.Equals("b") && !key.Equals("c") && !key.Equals("d"));

        return key;
    }

    public static void CommandChoice(string choice)
    {
        
        SandwichCommand sandwichCommand = new SandwichCommand();

        while (choice != "d")
        {            
            sandwichCommand.AddSandwich(SandwichFactory.Of(choice));
            choice = MakeCommandDashbord();
        } 

        BillGenerator billGenerator = new BillGenerator(sandwichCommand);
        Console.WriteLine("******************Facture****************");
        billGenerator.CalculateTotalPrice();
        Console.WriteLine(billGenerator.ToString());
        Console.WriteLine(
                "############### Appuyer sur la touche correspondante pour faire une nouvelle commande. ###############");
        CommandChoice(MakeCommandDashbord());
    }
}