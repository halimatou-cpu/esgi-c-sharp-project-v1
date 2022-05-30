
using System.Text;

namespace DesignPatternProject;
using System;

class Program
{
    public static void Main()
    {
       // MakeCommandDashbord();
    }

    public static string MakeCommandDashbord()
    {
        string key;
        do
        {
            Console.WriteLine("############### Appuyer sur la touche correspondate pour faire votre commande. ###############");
            Console.WriteLine("(a) pour Jambon beurre");
            Console.WriteLine("(b) pour Poulet crudités");
            Console.WriteLine("(c) pour Dieppois");
            Console.WriteLine("___________________________________________________________________________________");
            key = (Console.ReadLine()?.ToString()!);
        } while (!key.Equals("a") && !key.Equals("b") && !key.Equals("c"));

        return key;
    }

    public static void CommandChoice(string choice, out SandwichCommand sandwichCommand)
    {
        switch (choice)
        {
            case "a":
                
        }
    }
}