using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Entity;

namespace TryToLearnNetCore.LearnOn30Days.Day8_ORM.Services.Interface
{
    public interface CarInterfaceDay8
    {
        Task<List<CarDay8>> GetAllCar();
        //CarDay8? GetCarDay8ByID(int id);
        //bool CheckExistsCarDay8(int id);
        //void CreateCarDay8(CarDay8 newCar);
        //bool DeleteCarDay8(int id);
    }
}
