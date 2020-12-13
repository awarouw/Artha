using Artha.Shared.ViewModels;
using System.Linq;

namespace Artha.Server.Helpers
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable , PaginationViewModel paginationViewModel)
        {
            return queryable
                .Skip((paginationViewModel.Page - 1) * paginationViewModel.RecordsPerPage)
                .Take(paginationViewModel.RecordsPerPage);
        }
    }
}
