#pragma checksum "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82aa629fac496f8d5aba9a36dc3364de99cd14ae"
// <auto-generated/>
#pragma warning disable 1591
namespace NewBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using NewBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using NewBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\_Imports.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
using NewBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class PizzaItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
  
    CultureInfo culture = new CultureInfo("en-US");

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 10 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
         Pizza.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
         Pizza.Price.ToString("C2", culture)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 16 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
                   SpicinessImage(Pizza.Spiciness)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "alt", 
#nullable restore
#line 17 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
                   Pizza.Spiciness

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", 
#nullable restore
#line 20 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
                        ButtonClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
                                                 () => Selected(Pizza)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n            Add\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\PizzaItem.razor"
       
    [Parameter]
    public Pizza Pizza { get; set; }
    [Parameter]
    public string ButtonTitle { get; set; }
    [Parameter]
    public string ButtonClass { get; set; }
    [Parameter]
    public Action<Pizza> Selected { get; set; }
    private string SpicinessImage(Spiciness spiciness)
    => $"images/{spiciness.ToString().ToLower()}.png";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
