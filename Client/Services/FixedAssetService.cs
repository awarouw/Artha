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
    public class FixedAssetService : IFixedAssetService
    {
        private readonly IHttpService httpService;
        private string url = "api/FixedAssets";

        public FixedAssetService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<FixedAsset>>> GetFixedAsset(PaginationViewModel paginationViewModel)
        {
            return await httpService.GetHelper<List<FixedAsset>>(url, paginationViewModel);
        }

        public async Task<List<FixedAsset>> GetFixedAssetByName(string name)
        {
            var response = await httpService.Get<List<FixedAsset>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<FixedAsset> GetFixedAssetById(int id)
        {
            return await httpService.GetHelper<FixedAsset>($"{url}/{id}");
        }

        public async Task CreateFixedAsset(FixedAsset FixedAsset)
        {
            var response = await httpService.Post(url, FixedAsset);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateFixedAsset(FixedAsset FixedAsset)
        {
            var response = await httpService.Put(url, FixedAsset);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteFixedAsset(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
