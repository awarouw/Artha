using System;
using System.Collections.Generic;
using System.Text;

namespace Artha.Shared.ViewModels
{
    public class PaginationViewModel
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage { get; set; } = 10;
    }
}
