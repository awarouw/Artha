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
    public class RouteService : IRouteService
    {
        private readonly IHttpService httpService;
        private string url = "api/Routes";

        public RouteService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<TransferRoute>>> GetRoute(PaginationViewModel paginationViewModel)
        {
            return await httpService.GetHelper<List<TransferRoute>>(url, paginationViewModel);
        }

        public async Task<List<TransferRoute>> GetRouteByName(string name)
        {
            var response = await httpService.Get<List<TransferRoute>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<TransferRoute> GetRouteById(int id)
        {
            return await httpService.GetHelper<TransferRoute>($"{url}/{id}");
        }

        public async Task CreateRoute(TransferRoute Route)
        {
            var response = await httpService.Post(url, Route);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateRoute(TransferRoute Route)
        {
            var response = await httpService.Put(url, Route);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteRoute(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
