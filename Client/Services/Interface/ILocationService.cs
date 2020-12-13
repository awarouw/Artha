using Artha.Shared.Entities;
using Artha.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artha.Client.Services.Interface
{
    public interface ILocationService
    {
        Task CreateLocation(Location Location);
        Task DeleteLocation(int Id);
        Task<PaginatedResponse<List<Location>>> GetLocation(PaginationViewModel paginationViewModel);
        Task<List<Location>> GetLocationByName(string name);
        Task<Location> GetLocationById(int id);
        Task UpdateLocation(Location Location);
    }
}
