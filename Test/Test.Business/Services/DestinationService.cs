using GeoCoordinatePortable;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Business.Interfaces;
using Test.Data;
using Test.Data.Entities;

namespace Test.Business.Services
{
    public class DestinationService : IDestinationService
    {
        private readonly DataContext context;

        public DestinationService(DataContext context)
        {
            this.context = context;
        }

        public async Task<dynamic> GetDistanceAsync(double lang1, double long1, double lang2, double long2)
        {
            var destination1 = await GetDistanceAsync(lang1, long1);
            var destination2 = await GetDistanceAsync(lang2, long2);

            var coord1 = new GeoCoordinate(lang1, long1);
            var coord2 = new GeoCoordinate(lang2, long2);

            var distance = coord1.GetDistanceTo(coord2);

            return new
            {
                destination1 = destination1.Place,
                destination2 = destination2.Place,
                distance
            };
        }

        private async Task<Destination> GetDistanceAsync(double lang, double longtitude)
        {
            return await context.Destination
                .FirstOrDefaultAsync(x => x.Latitude == lang && x.Longitude == longtitude);
        }

        public async Task<List<Destination>> GetUserDestinationsAsync(int userId)
        {
            return await (from u in context.Users
                          where u.Id == userId
                          from d in u.Destinations
                          select d).ToListAsync();
        }
    }
}
