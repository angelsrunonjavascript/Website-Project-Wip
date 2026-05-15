namespace WebsiteProject.Models
{
    public class EnergyDrink
    {   
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Flavor { get; set; }
        public string Description { get; set; }
        public double CaffeineContent { get; set; }
        public string Ingredients { get; set; }
        public string ServingSize { get; set; }                           
        public string ImageUrl { get; set; }
    }
} 