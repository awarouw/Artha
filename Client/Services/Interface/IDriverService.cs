using Artha.Shared.Entities;
using Artha.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artha.Client.Services.Interface
{
    public interface IDriverService
    {
        Task CreateDriver(Staff Driver);
        Task DeleteDriver(int Id);
        Task<PaginatedResponse<List<Staff>>> GetDriver(PaginationViewModel paginationViewModel);
        Task<List<Staff>> GetDriverByName(string name);
        Task<Staff> GetDriverById(int id);
        Task UpdateDriver(Staff Driver);
    }
}
