using Artha.Shared.Entities;
using Artha.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Artha.Client.Services.Interface
{
    public interface ICountryService
    {
        Task CreateCountry(Country Country);
        Task DeleteCountry(int Id);
        Task<PaginatedResponse<List<Country>>> GetCountry(PaginationViewModel paginationViewModel);
        Task<List<Country>> GetCountryByName(string name);
        Task<Country> GetCountryById(int id);
        Task UpdateCountry(Country Country);
    }
}
