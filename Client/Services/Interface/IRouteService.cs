using Artha.Shared.Entities;
using Artha.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artha.Client.Services.Interface
{
    public interface IRouteService
    {
        Task CreateRoute(TransferRoute Route);
        Task DeleteRoute(int Id);
        Task<PaginatedResponse<List<TransferRoute>>> GetRoute(PaginationViewModel paginationViewModel);
        Task<List<TransferRoute>> GetRouteByName(string name);
        Task<TransferRoute> GetRouteById(int id);
        Task UpdateRoute(TransferRoute Route);
    }
}
