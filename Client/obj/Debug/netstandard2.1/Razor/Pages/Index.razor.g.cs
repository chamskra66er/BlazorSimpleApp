#pragma checksum "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15364d4f928cf840dd064b72a82bd854889debce"
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
#line 2 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
using NewBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
using Microsoft.AspNetCore.Blazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
  
    CultureInfo culture = new CultureInfo("en-US");

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<NewBlazor.Client.Pages.PizzaList>(0);
            __builder.AddAttribute(1, "Title", "Our selected list of pizzas");
            __builder.AddAttribute(2, "Menu", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NewBlazor.Shared.Menu>(
#nullable restore
#line 12 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                  State.Menu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Selected", new System.Action<NewBlazor.Shared.Pizza>(
#nullable restore
#line 13 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                       (pizza) => AddToBasket(pizza)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<h1>Pizza List</h1>\r\n");
#nullable restore
#line 16 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
 foreach (var pizza in State.Menu.Pizzas)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddContent(13, 
#nullable restore
#line 20 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
             pizza.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddContent(19, 
#nullable restore
#line 23 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
             pizza.Price.ToString("C2", culture)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col");
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "src", 
#nullable restore
#line 26 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                       SpicinessImage(pizza.Spiciness)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "alt", 
#nullable restore
#line 26 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                                                              pizza.Spiciness

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                                                               () => AddToBasket(pizza)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                Add\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 34 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
 if (State.Basket.Orders.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.AddMarkupContent(41, "<h1>Your current order</h1>\r\n");
#nullable restore
#line 38 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
     foreach (var (pizza, pos) in State.Basket.Orders.Select((id, pos) =>
            (State.Menu.GetPizza(id), pos)))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.AddContent(49, 
#nullable restore
#line 43 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                 pizza.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddContent(55, 
#nullable restore
#line 46 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                 pizza.Price.ToString("C2", culture)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                                                                  ()=>RemoveFromBascket(pos)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                    Remove\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 54 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row");
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.AddMarkupContent(72, "<div class=\"col\"> Total:</div>\r\n        ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col");
            __builder.AddContent(75, " ");
            __builder.AddContent(76, 
#nullable restore
#line 57 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                           State.TotalPrice.ToString("C2", culture)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.AddMarkupContent(79, "<div class=\"col\"> </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 60 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "<h1>Please enter your details below</h1>\r\n");
            __builder.OpenElement(82, "fieldset");
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.OpenElement(84, "p");
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.AddMarkupContent(86, "<label for=\"name\">Name:</label>\r\n        ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "id", "name");
            __builder.AddAttribute(89, "bind", 
#nullable restore
#line 66 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                                State.Basket.Customer.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 67 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
         if (State.Basket.Customer.GetErrors(nameof(Customer.Name)).Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "            ");
            __builder.OpenElement(92, "ul");
            __builder.AddAttribute(93, "class", "validation-error");
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 70 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                 foreach (string error in State.Basket.Customer.GetErrors(nameof(Customer.Name)))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                    ");
            __builder.OpenElement(96, "li");
            __builder.AddContent(97, 
#nullable restore
#line 72 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                         error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 73 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 75 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.OpenElement(103, "p");
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.AddMarkupContent(105, "<label for=\"street\">Street:</label>\r\n        ");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "id", "street");
            __builder.AddAttribute(108, "bind", 
#nullable restore
#line 79 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                                  State.Basket.Customer.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 80 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
         if (State.Basket.Customer.GetErrors(nameof(Customer.Street)).Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "            ");
            __builder.OpenElement(111, "ul");
            __builder.AddAttribute(112, "class", "validation-error");
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 83 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                 foreach (string error in State.Basket.Customer.GetErrors(nameof(Customer.Street)))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                    ");
            __builder.OpenElement(115, "li");
            __builder.AddContent(116, 
#nullable restore
#line 85 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                         error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 86 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
#nullable restore
#line 88 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(120, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.OpenElement(122, "p");
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.AddMarkupContent(124, "<label for=\"city\">City:</label>\r\n        ");
            __builder.OpenElement(125, "input");
            __builder.AddAttribute(126, "id", "city");
            __builder.AddAttribute(127, "bind", 
#nullable restore
#line 92 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                                State.Basket.Customer.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 93 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
         if (State.Basket.Customer.GetErrors(nameof(Customer.City)).Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "            ");
            __builder.OpenElement(130, "ul");
            __builder.AddAttribute(131, "class", "validation-error");
            __builder.AddMarkupContent(132, "\r\n");
#nullable restore
#line 96 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                 foreach (string error in State.Basket.Customer.GetErrors(nameof(Customer.City)))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, "                    ");
            __builder.OpenElement(134, "li");
            __builder.AddContent(135, 
#nullable restore
#line 98 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                         error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 99 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(137, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 101 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n    ");
            __builder.OpenElement(141, "button");
            __builder.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                       PlaceOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "disabled", 
#nullable restore
#line 103 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
                                              State.Basket.Customer.HasErrors

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(144, "Checkout");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 105 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
 if (State.Basket.Orders.Count() > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "    ");
            __builder.OpenElement(148, "p");
            __builder.AddContent(149, 
#nullable restore
#line 107 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
        State.ToJson()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
#nullable restore
#line 108 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
 
    private void PlaceOrder()
    {
        Console.WriteLine("Placing Order");
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
 
    private void RemoveFromBascket(int pos)
    {
        Console.WriteLine($"Removing pizza at pos {pos}");
        State.Basket.RemoveAt(pos);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
 
    private string SpicinessImage(Spiciness spiciness)
    {
        return $"images/{spiciness.ToString().ToLower()}.png";
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\VS\ASP_Net_Core\Blazor\Test\NewBlazor\Client\Pages\Index.razor"
 
    private void AddToBasket(Pizza pizza)
    {
        Console.WriteLine($"Added pizza {pizza.Name}");
        State.Basket.Add(pizza.Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State State { get; set; }
    }
}
#pragma warning restore 1591
