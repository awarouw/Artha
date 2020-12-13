#pragma checksum "G:\Application\Artha\Client\Pages\Routes\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e2f45fd36ff85f01155c669a3e12d8582bcad79"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Index Route</h3>\n\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><a class=\"btn btn-info\" href=\"Route/create\">New Route</a></div>\n\n");
            __builder.OpenComponent<Artha.Client.Shared.Pagination>(2);
            __builder.AddAttribute(3, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                          paginationViewModel.Page

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "TotalAmountPages", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                                                                      totalAmountPages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 12 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n\n");
            __Blazor.Artha.Client.Pages.Routes.Index.TypeInference.CreateGenericList_0(__builder, 7, 8, 
#nullable restore
#line 14 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                   Route

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "table table-striped");
                __builder2.AddMarkupContent(12, @"<thead><tr><th></th>
                    <th>TransferfromCode</th>
                    <th>TransfertoCode</th>
                    <th>JarakTempuh</th>
                    <th>BiayaToll</th>
                    <th>BiayaBBM</th>
                    <th>Retribusi</th>
                    <th>BiayaLainLain</th></tr></thead>
            ");
                __builder2.OpenElement(13, "tbody");
#nullable restore
#line 30 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                 foreach (var item in Route)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(14, "tr");
                __builder2.OpenElement(15, "td");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "class", "btn btn-success");
                __builder2.AddAttribute(18, "href", "/Route/edit/" + (
#nullable restore
#line 34 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                                                                      item.TransferRouteID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n                        ");
                __builder2.OpenElement(21, "button");
                __builder2.AddAttribute(22, "class", "btn btn-danger");
                __builder2.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                                                                   () => DeleteRoute(item.TransferRouteID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(24, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n                    ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 37 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                         item.TransferfromCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n                    ");
                __builder2.OpenElement(29, "td");
                __builder2.AddContent(30, 
#nullable restore
#line 38 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                         item.TransfertoCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n                    ");
                __builder2.OpenElement(32, "td");
                __builder2.AddContent(33, 
#nullable restore
#line 39 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                         item.JarakTempuh

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n                    ");
                __builder2.OpenElement(35, "td");
                __builder2.AddContent(36, 
#nullable restore
#line 40 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                         item.BiayaToll

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\n                    ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, 
#nullable restore
#line 41 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                         item.BiayaBBM

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n                    ");
                __builder2.OpenElement(41, "td");
                __builder2.AddContent(42, 
#nullable restore
#line 42 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                         item.Retribusi

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n                    ");
                __builder2.OpenElement(44, "td");
                __builder2.AddContent(45, 
#nullable restore
#line 43 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                         item.BiayaLainLain

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 44 "G:\Application\Artha\Client\Pages\Routes\Index.razor"
                     }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
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
namespace __Blazor.Artha.Client.Pages.Routes.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Artha.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
