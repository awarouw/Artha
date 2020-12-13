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
    public class CountryService : ICountryService
    {
        private readonly IHttpService httpService;
        private string url = "api/Countries";

        public CountryService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<Country>>> GetCountry(PaginationViewModel paginationViewModel)
        {
            return await httpService.GetHelper<List<Country>>(url, paginationViewModel);
        }

        public async Task<List<Country>> GetCountryByName(string name)
        {
            var response = await httpService.Get<List<Country>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Country> GetCountryById(int id)
        {
            return await httpService.GetHelper<Country>($"{url}/{id}");
        }

        public async Task CreateCountry(Country Country)
        {
            var response = await httpService.Post(url, Country);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateCountry(Country Country)
        {
            var response = await httpService.Put(url, Country);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteCountry(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
