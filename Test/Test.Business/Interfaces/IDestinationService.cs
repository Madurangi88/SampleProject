using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Business.Models;
using Test.Data.Entities;

namespace Test.Business.Interfaces
{
    public interface IDestinationService
    {
        Task<List<Destination>> GetUserDestinationsAsync(int userId);

        Task<dynamic> GetDistanceAsync(double lang1, double long1, double lang2, double long2);
    }
}
