namespace DesignPatternProject;

public abstract class SandwichFactory
{
    public static Sandwich Of(string commande)
    {
        string choice = commande.ToUpper().Substring(0, 1);
        if (choice.Equals("A"))
        {
            return new SandwichBuilder()
                .WithName("Jambon beurre")
                .WithPrice(new Price(3.50f, "€"))
                .WithIngredient(new List<string>()
                    { "1 pain", "1 tranche de jambon", "10g de beurre" })
                .Build();
        }
        if (choice.Equals("B"))
        {
            return new SandwichBuilder()
                .WithName("Poulet crudités")
                .WithPrice(new Price(5f, "€"))
                .WithIngredient(new List<string>()
                    { "1 pain", "1 oeuf ", "0.5 tomate", "10g de mayonnaise", "10g de salade" })
                .Build();
        }
        if (choice.Equals("C"))
        {
            return new SandwichBuilder()
                .WithName("Dieppois")
                .WithPrice(new Price(4.50f, "€"))
                .WithIngredient(new List<string>()
                    { "1 pain", "5g de thon", "0.5 tomate",  "10g de mayonnaise", "10g de salade" })
                .Build();
        }
        Console.WriteLine(
                "######### Merci de faire une saisie valide #######");
        throw new ArgumentException();
    }
}