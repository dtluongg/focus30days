using TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Entities;
using TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Services.Interface;

namespace TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Services.Implements
{
    public class ImplCars : ICars
    {
        private static readonly List<CarDay4> _cars = new() {
            new CarDay4 { carID  = "car01", carName = "Dodge Challenger", carTopSpeed = 287, carType = "Muscle" },
            new CarDay4 { carID  = "car02", carName = "Dodge Challenger", carTopSpeed = 287, carType = "Muscle" }
        };

        public bool CheckExists(string carID)
        {
            return _cars.Any(c => c.carID.Equals(carID, StringComparison.OrdinalIgnoreCase));
        }

        public void CreateCarDay4(CarDay4 newCar, decimal priceCar)
        {
            newCar.UpdatePrice(priceCar);
            _cars.Add(newCar);
        }

        public void CreateCarDay4(CarDay4 newCar)
        {
            _cars.Add(newCar);
        }

        public bool DeleteCarDay4(string carID)
        {
            CarDay4 findCar = GetCarDay4ByID(carID);
            return _cars.Remove(findCar);
        }

        public List<CarDay4> GetAllCar()
        {
            return _cars;
        }

        public CarDay4? GetCarDay4ByID(string carID)
        {
            return _cars.FirstOrDefault(c => c.carID.Equals(carID, StringComparison.OrdinalIgnoreCase));
        }
    }
}
