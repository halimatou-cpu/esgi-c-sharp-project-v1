namespace DesignPatternProject;

public abstract class SandwichFactory
{
    public static Sandwich Of(string commande)
    {
        string choice = commande.ToUpper().Substring(0, 1);
        if (choice.Equals("A"))
        {
            return new Sandwich("Jambon beurre", new Price(3.50f, "€"));
        }
        if (choice.Equals("B"))
        {
            return new Sandwich("Poulet crudités", new Price(5f, "€"));

        }
        if (choice.Equals("C"))
        {
            return new Sandwich("Dieppois", new Price(4.50f, "€"));

        }
        Console.WriteLine(
                "######### Merci de faire une saisie valide #######");
        throw new ArgumentException();
    }
}