using Artha.Shared.Entities;
using Artha.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artha.Client.Services.Interface
{
    public interface IFixedAssetService
    {
        Task CreateFixedAsset(FixedAsset FixedAsset);
        Task DeleteFixedAsset(int Id);
        Task<PaginatedResponse<List<FixedAsset>>> GetFixedAsset(PaginationViewModel paginationViewModel);
        Task<List<FixedAsset>> GetFixedAssetByName(string name);
        Task<FixedAsset> GetFixedAssetById(int id);
        Task UpdateFixedAsset(FixedAsset FixedAsset);
    }
}
