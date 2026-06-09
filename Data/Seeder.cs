using WebsiteProject.Models;

namespace WebsiteProject.Data
{
    public static class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            if (context.EnergyDrinks == null) return;

            var drinks = new List<EnergyDrink>
            {
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
                },
                new EnergyDrink
                {
                    Brand = "Red Bull",
                    Name = "Sugarfree",
                    Flavor = "Original",
                    Description = "The classic Red Bull taste without sugar, providing the same energy boost and caffeine content.",
                    CaffeineContent = 80,
                    Ingredients = "Carbonated water, citric acid, taurine, caffeine, sweeteners, B vitamins.",
                    ServingSize = "250 ml",
                    ImageUrl = "https://example.com/redbull-sugarfree.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Monster",
                    Name = "Pipeline Punch",
                    Flavor = "Passion Fruit",
                    Description = "A tropical blend of passion fruit, orange, and guava flavors with Monster's signature energy formula.",
                    CaffeineContent = 160,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, ginseng extract, B vitamins.",
                    ServingSize = "500 ml",
                    ImageUrl = "https://example.com/monster-pipeline-punch.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Monster",
                    Name = "Mango Loco",
                    Flavor = "Mango",
                    Description = "A mango-flavored energy drink inspired by the vibrant traditions of Día de los Muertos.",
                    CaffeineContent = 160,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, natural flavors, B vitamins.",
                    ServingSize = "500 ml",
                    ImageUrl = "https://example.com/monster-mango-loco.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Rockstar",
                    Name = "Original",
                    Flavor = "Original",
                    Description = "The original Rockstar formula packed with caffeine, taurine, and B vitamins.",
                    CaffeineContent = 160,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, guarana extract, B vitamins.",
                    ServingSize = "500 ml",
                    ImageUrl = "https://example.com/rockstar-original.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Rockstar",
                    Name = "Recovery Lemonade",
                    Flavor = "Lemonade",
                    Description = "A non-carbonated energy drink with a refreshing lemonade taste.",
                    CaffeineContent = 160,
                    Ingredients = "Filtered water, sugar, taurine, caffeine, electrolytes, B vitamins.",
                    ServingSize = "500 ml",
                    ImageUrl = "https://example.com/rockstar-recovery.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Burn",
                    Name = "Original",
                    Flavor = "Original",
                    Description = "Burn Original delivers an intense energy boost with a distinctive sweet flavor.",
                    CaffeineContent = 80,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, guarana, B vitamins.",
                    ServingSize = "250 ml",
                    ImageUrl = "https://example.com/burn-original.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Burn",
                    Name = "Apple Kiwi",
                    Flavor = "Apple Kiwi",
                    Description = "A fruity combination of crisp apple and kiwi flavors with Burn's energy formula.",
                    CaffeineContent = 80,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, natural flavors.",
                    ServingSize = "250 ml",
                    ImageUrl = "https://example.com/burn-apple-kiwi.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Hell",
                    Name = "Classic",
                    Flavor = "Original",
                    Description = "One of Europe's most popular energy drinks with a balanced taste and caffeine kick.",
                    CaffeineContent = 80,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, vitamins.",
                    ServingSize = "250 ml",
                    ImageUrl = "https://example.com/hell-classic.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Hell",
                    Name = "Watermelon",
                    Flavor = "Watermelon",
                    Description = "Refreshing watermelon flavor combined with the classic Hell Energy formula.",
                    CaffeineContent = 80,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, vitamins, flavorings.",
                    ServingSize = "250 ml",
                    ImageUrl = "https://example.com/hell-watermelon.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Prime",
                    Name = "Energy Blue Raspberry",
                    Flavor = "Blue Raspberry",
                    Description = "A modern energy drink featuring a bold blue raspberry flavor and high caffeine content.",
                    CaffeineContent = 200,
                    Ingredients = "Carbonated water, caffeine, electrolytes, natural flavors, vitamins.",
                    ServingSize = "355 ml",
                    ImageUrl = "https://example.com/prime-blue-raspberry.jpg"
                },
                new EnergyDrink
                {
                    Brand = "Celsius",
                    Name = "Sparkling Orange",
                    Flavor = "Orange",
                    Description = "Fitness-focused energy drink with orange flavor and no added sugar.",
                    CaffeineContent = 200,
                    Ingredients = "Carbonated water, green tea extract, caffeine, ginger extract, vitamins.",
                    ServingSize = "355 ml",
                    ImageUrl = "https://example.com/celsius-orange.jpg"
                },
                new EnergyDrink
                {
                    Brand = "NOS",
                    Name = "Original",
                    Flavor = "Citrus",
                    Description = "A citrus-flavored energy drink inspired by motorsports and performance.",
                    CaffeineContent = 160,
                    Ingredients = "Carbonated water, sugar, taurine, caffeine, guarana extract.",
                    ServingSize = "473 ml",
                    ImageUrl = "https://example.com/nos-original.jpg"
                },
                new EnergyDrink
{
    Brand = "Red Bull",
    Name = "Tropical Edition",
    Flavor = "Tropical Fruits",
    Description = "A vibrant tropical mix with exotic fruit notes and classic Red Bull energy.",
    CaffeineContent = 80,
    Ingredients = "Carbonated water, sucrose, glucose, taurine, caffeine, vitamins.",
    ServingSize = "250 ml",
    ImageUrl = "https://example.com/redbull-tropical.jpg"
},
new EnergyDrink
{
    Brand = "Monster",
    Name = "Ultra White",
    Flavor = "Citrus",
    Description = "A light, zero-sugar citrus energy drink with a clean and refreshing taste.",
    CaffeineContent = 150,
    Ingredients = "Carbonated water, citric acid, taurine, caffeine, B vitamins.",
    ServingSize = "500 ml",
    ImageUrl = "https://example.com/monster-ultra-white.jpg"
},
new EnergyDrink
{
    Brand = "Monster",
    Name = "Aussie Lemonade",
    Flavor = "Lemon",
    Description = "Sweet and tangy lemonade-style energy drink inspired by Australian summers.",
    CaffeineContent = 150,
    Ingredients = "Carbonated water, sugar, citric acid, taurine, caffeine, natural flavors.",
    ServingSize = "500 ml",
    ImageUrl = "https://example.com/monster-aussie-lemonade.jpg"
},
new EnergyDrink
{
    Brand = "Rockstar",
    Name = "Tropical Guava",
    Flavor = "Guava",
    Description = "A bold tropical guava flavor with a strong energy kick.",
    CaffeineContent = 160,
    Ingredients = "Carbonated water, sugar, taurine, caffeine, guarana, vitamins.",
    ServingSize = "500 ml",
    ImageUrl = "https://example.com/rockstar-guava.jpg"
},
new EnergyDrink
{
    Brand = "Burn",
    Name = "Black Energy",
    Flavor = "Cola",
    Description = "A cola-inspired energy drink with a darker, richer taste profile.",
    CaffeineContent = 80,
    Ingredients = "Carbonated water, sugar, caffeine, taurine, flavorings.",
    ServingSize = "250 ml",
    ImageUrl = "https://example.com/burn-black.jpg"
},
new EnergyDrink
{
    Brand = "Hell",
    Name = "Strong Apple",
    Flavor = "Apple",
    Description = "Sweet apple flavor with an intensified energy formula for longer focus.",
    CaffeineContent = 100,
    Ingredients = "Carbonated water, sugar, taurine, caffeine, vitamins.",
    ServingSize = "250 ml",
    ImageUrl = "https://example.com/hell-apple.jpg"
},
new EnergyDrink
{
    Brand = "Prime",
    Name = "Tropical Punch",
    Flavor = "Tropical",
    Description = "A fruity punch-style energy drink with a modern formula and strong caffeine hit.",
    CaffeineContent = 200,
    Ingredients = "Carbonated water, caffeine, electrolytes, natural flavors.",
    ServingSize = "355 ml",
    ImageUrl = "https://example.com/prime-tropical.jpg"
},
new EnergyDrink
{
    Brand = "Celsius",
    Name = "Berry",
    Flavor = "Mixed Berries",
    Description = "A fitness-focused berry energy drink designed for clean energy without sugar.",
    CaffeineContent = 200,
    Ingredients = "Carbonated water, green tea extract, caffeine, ginger, vitamins.",
    ServingSize = "355 ml",
    ImageUrl = "https://example.com/celsius-berry.jpg"
},
new EnergyDrink
{
    Brand = "NOS",
    Name = "Grape",
    Flavor = "Grape",
    Description = "A sweet grape-flavored energy drink inspired by racing performance energy.",
    CaffeineContent = 160,
    Ingredients = "Carbonated water, sugar, taurine, caffeine, guarana.",
    ServingSize = "473 ml",
    ImageUrl = "https://example.com/nos-grape.jpg"
}
                
            };

            foreach (var drink in drinks)
            {
                var exists = context.EnergyDrinks.Any(e =>
                    e.Brand == drink.Brand &&
                    e.Name == drink.Name);

                if (!exists)
                {
                    context.EnergyDrinks.Add(drink);
                }
            }

            context.SaveChanges();
        }
    }
}

