using patron_conception_composite;

//Construction de l'arborescence
var boutique = new Menu("Boutique");
boutique.Ajouter(new Option("Nouveautés"));
boutique.Ajouter(new Option("Promotions"));

var categories = new Menu("Catégories");    
categories.Ajouter(new Option("Hommes"));
categories.Ajouter(new Option("Femmes"));

boutique.Ajouter(categories);               

//debut du test
var navigation = new Navigation(boutique);

Console.WriteLine("=== AVANT désactivation ===");
navigation.Afficher();

navigation.ToutDesactiver();

Console.WriteLine();
Console.WriteLine("=== APRÈS désactivation ===");
navigation.Afficher();