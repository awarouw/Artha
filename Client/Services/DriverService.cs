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
    public class DriverService : IDriverService
    {
        private readonly IHttpService httpService;
        private string url = "api/drivers";

        public DriverService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<Staff>>> GetDriver(PaginationViewModel paginationViewModel)
        {
            return await httpService.GetHelper<List<Staff>>(url, paginationViewModel);
        }

        public async Task<List<Staff>> GetDriverByName(string name)
        {
            var response = await httpService.Get<List<Staff>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Staff> GetDriverById(int id)
        {
            return await httpService.GetHelper<Staff>($"{url}/{id}");
        }

        public async Task CreateDriver(Staff Driver)
        {
            var response = await httpService.Post(url, Driver);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateDriver(Staff Driver)
        {
            var response = await httpService.Put(url, Driver);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteDriver(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
