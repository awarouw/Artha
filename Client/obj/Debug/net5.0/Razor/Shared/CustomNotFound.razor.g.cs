#pragma checksum "G:\Application\Artha\Client\Shared\CustomNotFound.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6dcdc9326ba2081387a78cfba8aebc3496dbff8"
// <auto-generated/>
#pragma warning disable 1591
namespace Artha.Client.Shared
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
    public partial class CustomNotFound : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p style=\"color: blue;\">Sorry, there\'s nothing at this address.</p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "G:\Application\Artha\Client\Shared\CustomNotFound.razor"
       
    protected override void OnInitialized()
    {
        Console.WriteLine("404 NOT FOUND");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
