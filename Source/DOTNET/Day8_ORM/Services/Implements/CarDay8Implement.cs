using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Entity;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Services.Interface;

namespace TryToLearnNetCore.LearnOn30Days.Day8_ORM.Services.Implements
{
    public class CarDay8Implement : CarInterfaceDay8
    {
        private readonly AppDBContextDay8 _context;

        public CarDay8Implement(AppDBContextDay8 context)
        {
            _context = context;
        }

        async Task<List<CarDay8>> CarInterfaceDay8.GetAllCar()
        {
            return await _context.carinfo.ToListAsync();
        }

        //bool CarInterfaceDay8.CheckExistsCarDay8(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //void CarInterfaceDay8.CreateCarDay8(CarDay8 newCar)
        //{
        //    throw new NotImplementedException();
        //}

        //bool CarInterfaceDay8.DeleteCarDay8(int id)
        //{
        //    throw new NotImplementedException();
        //}



        //CarDay8? CarInterfaceDay8.GetCarDay8ByID(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
