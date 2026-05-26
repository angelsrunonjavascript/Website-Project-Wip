namespace WebsiteProject.Models
{
    public class Favorite
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int EnergyDrinkId { get; set; }
        public EnergyDrink EnergyDrink { get; set; } = null!;
    }
}