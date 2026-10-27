using TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Entities;
using TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Services.Interface;

namespace TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Services.Implements
{
    public class ImplCars : ICars
    {
        private static readonly List<CarDay3> _cars = new() {
            new CarDay3 { carID  = "car01", carName = "Dodge Challenger", carTopSpeed = 287, carType = "Muscle" },
            new CarDay3 { carID  = "car02", carName = "Dodge Challenger", carTopSpeed = 287, carType = "Muscle" }
        };

        public bool CheckExists(string carID)
        {
            return _cars.Any(c => c.carID.Equals(carID, StringComparison.OrdinalIgnoreCase));
        }

        public void CreateCarDay3(CarDay3 newCar, decimal priceCar)
        {
            newCar.UpdatePrice(priceCar);
            _cars.Add(newCar);
        }

        public void CreateCarDay3(CarDay3 newCar)
        {
            _cars.Add(newCar);
        }

        public bool DeleteCarDay3(string carID)
        {
            CarDay3 findCar = GetCarDay3ByID(carID);
            return _cars.Remove(findCar);
        }

        public List<CarDay3> GetAllCar()
        {
            return _cars;
        }

        public CarDay3? GetCarDay3ByID(string carID)
        {
            return _cars.FirstOrDefault(c => c.carID.Equals(carID, StringComparison.OrdinalIgnoreCase));
        }
    }
}
