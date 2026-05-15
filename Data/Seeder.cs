using WebsiteProject.Models;
namespace WebsiteProject.Data;

public static class Seeder
{
    public static void Seed(AppDbContext context)
    {
        if (!context.EnergyDrinks.Any())
        {
            context.EnergyDrinks.AddRange(
                new EnergyDrink
                {
                    Brand = "Red Bull",
                    Name = "Spring Edition",
                    Flavor = "Berry",
                    Description = "Red Bull gives you wings! A popular energy drink known for its distinctive taste and energy-boosting properties.",
                    CaffeineContent = 80,
                    Ingredients = "Carbonated water, sucrose, glucose, taurine, caffeine, vitamins (B6, B12), and flavorings.",
                    ServingSize = "250 ml",
                    ImageUrl = "https://example.com/redbull.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Monster",
                    Name = "Energy Ultra Sunrise",
                    Flavor = "Citrus",
                    Description = "Monster Energy Ultra Sunrise is a sugar-free energy drink with a refreshing citrus flavor, designed to provide an energy boost without the crash.",
                    CaffeineContent = 150,
                    Ingredients = "Carbonated water, citric acid, taurine, caffeine, B vitamins (B2, B3, B6, B12), and natural flavors.",
                    ServingSize = "500 ml",
                    ImageUrl = "https://example.com/monster.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Rockstar",
                    Name = "Pomegranate Blueberry",
                    Flavor = "Pomegranate Blueberry",
                    Description = "Rockstar Energy Drink in Pomegranate Blueberry flavor offers a bold and fruity taste, packed with caffeine and B vitamins to keep you energized throughout the day.",
                    CaffeineContent = 160,
                    Ingredients = "Carbonated water, high fructose corn syrup, citric acid, taurine, caffeine, B vitamins (B3, B6, B12), and natural flavors.",
                    ServingSize = "500 ml",
                    ImageUrl = "https://example.com/rockstar.jpg"
                }
            );

            context.SaveChanges();
        }
    }
}