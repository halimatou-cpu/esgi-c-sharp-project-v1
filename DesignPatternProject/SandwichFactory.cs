namespace DesignPatternProject;

public abstract class SandwichFactory
{
    public static Sandwich Of(string commande)
    {
        string choice = commande.ToUpper().Substring(0, 1);
        if (choice.Equals("A"))
        {
            return new Sandwich("Jambon beurre", new Price(3.50f, "€"), new List<string>()
                    { "1 pain", "1 tranche de jambon", "10g de beurre" });
        }
        if (choice.Equals("B"))
        {
            return new Sandwich("Poulet crudités", new Price(5f, "€"), new List<string>()
                    { "1 pain", "1 oeuf ", "0.5 tomate", "10g de mayonnaise", "10g de salade" });

        }
        if (choice.Equals("C"))
        {
            return new Sandwich("Dieppois", new Price(4.50f, "€"), new List<string>()
                    { "1 pain", "5g de thon", "0.5 tomate",  "10g de mayonnaise", "10g de salade" });
            
        }
        Console.WriteLine(
                "######### Merci de faire une saisie valide #######");
        throw new ArgumentException();
    }
}