using TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Entities;

namespace TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Services.Interface
{
    public interface ICars
    {
        List<CarDay4> GetAllCar();
        CarDay4? GetCarDay4ByID(string carID);
        bool CheckExists(string carID);
        void CreateCarDay4(CarDay4 newCar);
        bool DeleteCarDay4(string carID);
    }
}
