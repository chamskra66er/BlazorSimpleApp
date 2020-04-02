#pragma checksum "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c59788ed77145bd745e609a6c6e494c890d554c"
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
#line 1 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
using NewBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class ShoppingBasket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
 if (Basket.Orders.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 6 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
     foreach (var (pizza, pos) in Pizzas)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.OpenComponent<NewBlazor.Client.Pages.PizzaItem>(5);
            __builder.AddAttribute(6, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NewBlazor.Shared.Pizza>(
#nullable restore
#line 8 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
                           pizza

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ButtonClass", "btn btn-danger");
            __builder.AddAttribute(8, "ButtonTitle", "Remove");
            __builder.AddAttribute(9, "Selected", new System.Action<NewBlazor.Shared.Pizza>(
#nullable restore
#line 10 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
                               p => Selected(pos)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 11 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<div class=\"col\"> Total: </div>\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.AddContent(18, " ");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
                           TotalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<div class=\"col\"> </div>\r\n        ");
            __builder.AddMarkupContent(23, "<div class=\"col\"> </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 18 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\ShoppingBasket.razor"
       
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
        Pizzas = Basket.Orders.Select((id, pos) => (pizza: GetPizzaFromId(id), pos: pos));
        TotalPrice = Pizzas.Select(tuple => tuple.pizza.Price).Sum();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591