#pragma checksum "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f9d109fe4792541f57d91feb63fcd16037dd75"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
using NewBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class ShoppingBasket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
       
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public Basket Basket { get; set; }
    [Parameter]
    public Func<int, Pizza> GetPizzaFromId { get; set; }
    [Parameter]
    public Action<int> Selected { get; set; }
    public IEnumerable<(Pizza pizza, int pos)> Pizzas { get; set; }
    public double TotalPrice { get; set; }
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        Pizzas = Basket.Orders.Select((id, pos) => (pizza:GetPizzaFromId(id), pos:pos));
        TotalPrice = Pizzas.Select(tuple => tuple.pizza.Price).Sum();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
