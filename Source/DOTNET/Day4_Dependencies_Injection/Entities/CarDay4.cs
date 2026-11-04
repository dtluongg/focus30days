using System.ComponentModel.DataAnnotations;

namespace TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Entities
{
    public class CarDay4
    {
        [Required(ErrorMessage = "ID car cannot null")]
        public string carID { get; init; } = string.Empty;


        public string carName { get; set; } = string.Empty;
        public string carType { get; set; } = string.Empty;

        [Range(0, 1000000, ErrorMessage = "Price must be greater than or equal to 0")]
        public decimal carPrice { get; private set; }

        [Range(60, 330, ErrorMessage = "Top Speed cannot bellow 60km/h")]
        public double carTopSpeed { get; set; }

        public void UpdatePrice(decimal newPrice)
        {
            if(newPrice < 0 )
            {
                throw new ArgumentException("Price need more than 0");
            }
            carPrice = newPrice;
        }
    }
}
