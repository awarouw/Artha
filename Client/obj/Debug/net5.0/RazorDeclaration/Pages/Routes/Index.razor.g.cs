// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Artha.Client.Pages.Routes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Application\Artha\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Application\Artha\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Application\Artha\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Application\Artha\Client\_Imports.razor"
using Artha.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\Application\Artha\Client\_Imports.razor"
using Artha.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\Application\Artha\Client\_Imports.razor"
using Artha.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\Application\Artha\Client\_Imports.razor"
using Artha.Client.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\Application\Artha\Client\_Imports.razor"
using Artha.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "G:\Application\Artha\Client\_Imports.razor"
using Artha.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "G:\Application\Artha\Client\_Imports.razor"
using Artha.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "G:\Application\Artha\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/route")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
        List<TransferRoute> Route;
    PaginationViewModel paginationViewModel = new PaginationViewModel() { RecordsPerPage = 10 };
    private int totalAmountPages;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await LoadRoute();
        }
        catch (Exception ex)
        {

        }
    }

    private async Task LoadRoute()
    {
        var paginatedResponse = await RouteService.GetRoute(paginationViewModel);
        Route = paginatedResponse.Response;
        totalAmountPages = paginatedResponse.TotalAmountPages;
    }

    private async Task SelectedPage(int page)
    {
        paginationViewModel.Page = page;
        await LoadRoute();
    }

    private async Task DeleteRoute(int id)
    {
        await RouteService.DeleteRoute(id);
        await LoadRoute();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRouteService RouteService { get; set; }
    }
}
#pragma warning restore 1591