#pragma checksum "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0b89ffe02a099ae39633f196355452ee67672c7"
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
    public partial class RouteForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                 Route

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                       OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "<label for=\"name\">TransferfromCode</label>\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                                          Route.TransferfromCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Route.TransferfromCode = __value, Route.TransferfromCode))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Route.TransferfromCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n            ");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 9 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                      () => Route.TransferfromCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"name\">TransfertoCode</label>\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                                          Route.TransfertoCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Route.TransfertoCode = __value, Route.TransfertoCode))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Route.TransfertoCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n            ");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 17 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                      () => Route.TransfertoCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n\n\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label for=\"name\">JarakTempuh</label>\n        ");
                __builder2.OpenElement(35, "div");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateInputNumber_2(__builder2, 36, 37, "form-control", 38, 
#nullable restore
#line 25 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                                            Route.JarakTempuh

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Route.JarakTempuh = __value, Route.JarakTempuh)), 40, () => Route.JarakTempuh);
                __builder2.AddMarkupContent(41, "\n            ");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateValidationMessage_3(__builder2, 42, 43, 
#nullable restore
#line 26 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                      () => Route.JarakTempuh

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n\n\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label for=\"name\">BiayaToll</label>\n        ");
                __builder2.OpenElement(48, "div");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateInputNumber_4(__builder2, 49, 50, "form-control", 51, 
#nullable restore
#line 34 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                                            Route.BiayaToll

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Route.BiayaToll = __value, Route.BiayaToll)), 53, () => Route.BiayaToll);
                __builder2.AddMarkupContent(54, "\n            ");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateValidationMessage_5(__builder2, 55, 56, 
#nullable restore
#line 35 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                      () => Route.BiayaToll

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\n\n\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label for=\"name\">BiayaBBM</label>\n        ");
                __builder2.OpenElement(61, "div");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateInputNumber_6(__builder2, 62, 63, "form-control", 64, 
#nullable restore
#line 43 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                                            Route.BiayaBBM

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Route.BiayaBBM = __value, Route.BiayaBBM)), 66, () => Route.BiayaBBM);
                __builder2.AddMarkupContent(67, "\n            ");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateValidationMessage_7(__builder2, 68, 69, 
#nullable restore
#line 44 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                      () => Route.BiayaBBM

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n\n\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group");
                __builder2.AddMarkupContent(73, "<label for=\"name\">Retribusi</label>\n        ");
                __builder2.OpenElement(74, "div");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateInputNumber_8(__builder2, 75, 76, "form-control", 77, 
#nullable restore
#line 52 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                                            Route.Retribusi

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Route.Retribusi = __value, Route.Retribusi)), 79, () => Route.Retribusi);
                __builder2.AddMarkupContent(80, "\n            ");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateValidationMessage_9(__builder2, 81, 82, 
#nullable restore
#line 53 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                      () => Route.Retribusi

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\n\n\n    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group");
                __builder2.AddMarkupContent(86, "<label for=\"name\">BiayaLainLain</label>\n        ");
                __builder2.OpenElement(87, "div");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateInputNumber_10(__builder2, 88, 89, "form-control", 90, 
#nullable restore
#line 61 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                                            Route.BiayaLainLain

#line default
#line hidden
#nullable disable
                , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Route.BiayaLainLain = __value, Route.BiayaLainLain)), 92, () => Route.BiayaLainLain);
                __builder2.AddMarkupContent(93, "\n            ");
                __Blazor.Artha.Client.Pages.Routes.RouteForm.TypeInference.CreateValidationMessage_11(__builder2, 94, 95, 
#nullable restore
#line 62 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
                                      () => Route.BiayaLainLain

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\n\n    ");
                __builder2.AddMarkupContent(97, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "G:\Application\Artha\Client\Pages\Routes\RouteForm.razor"
        [Parameter] public TransferRoute Route { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    protected override void OnInitialized()
    {
    } 

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Artha.Client.Pages.Routes.RouteForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591