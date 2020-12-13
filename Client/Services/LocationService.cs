using Artha.Client.Helpers;
using Artha.Client.Services.Interface;
using Artha.Shared.Entities;
using Artha.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artha.Client.Services
{
    public class LocationService : ILocationService
    {
        private readonly IHttpService httpService;
        private string url = "api/Locations";

        public LocationService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<Location>>> GetLocation(PaginationViewModel paginationViewModel)
        {
            return await httpService.GetHelper<List<Location>>(url, paginationViewModel);
        }

        public async Task<List<Location>> GetLocationByName(string name)
        {
            var response = await httpService.Get<List<Location>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Location> GetLocationById(int id)
        {
            return await httpService.GetHelper<Location>($"{url}/{id}");
        }

        public async Task CreateLocation(Location Location)
        {
            var response = await httpService.Post(url, Location);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateLocation(Location Location)
        {
            var response = await httpService.Put(url, Location);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteLocation(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
