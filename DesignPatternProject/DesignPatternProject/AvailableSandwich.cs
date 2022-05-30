namespace DesignPatternProject;

public class AvailableSandwich
{
    private List<Sandwich> list;

    private void init()
    {
        List<string> ingredientForJambon = new List<string>(3);
        ingredientForJambon.Add("1 pain");
        ingredientForJambon.Add("1 tranche de jambon");
        ingredientForJambon.Add("10g de beurre");
        Sandwich sn1 = new Sandwich("Jambon beurre", 3.50f, ingredientForJambon);
        list.Add(sn1);
        
        List<string> ingredientForPoulet = new List<string>(3);
        ingredientForPoulet.Add("1 pain");
        ingredientForPoulet.Add("1 oeuf");
        ingredientForPoulet.Add("0.5 tomate");
        ingredientForPoulet.Add("1 tranche de poulet");
        ingredientForPoulet.Add("10g de mayonnaise");
        ingredientForPoulet.Add("10g de salade");
        Sandwich sn2 = new Sandwich("Jambon beurre", 10.0f, ingredientForPoulet);
        list.Add(sn2);

    }
    
}