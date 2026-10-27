using TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Entities;

namespace TryToLearnNetCore.LearnOn30Days.Day3_OOP_DEEP.Services.Interface
{
    public interface ICars
    {
        List<CarDay3> GetAllCar();
        CarDay3? GetCarDay3ByID(string carID);
        bool CheckExists(string carID);
        void CreateCarDay3(CarDay3 newCar);
        bool DeleteCarDay3(string carID);
    }
}
