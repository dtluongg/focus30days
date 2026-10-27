using System.ComponentModel.DataAnnotations;

namespace TryToLearnNetCore.LearnOn30Days.Day1_BasicOfNetCore
{
    public class Cars2
    {
        [Required(ErrorMessage = "ID car cannot null")]
        public string carID { get; set; }


        public string carName { get; set; }
        public string carType { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to 0")]
        public double carPrice { get; set; }
        
        [Range(60, double.MaxValue, ErrorMessage = "Top Speed cannot bellow 60km/h")]
        public double carTopSpeed { get; set; }
    }
}
