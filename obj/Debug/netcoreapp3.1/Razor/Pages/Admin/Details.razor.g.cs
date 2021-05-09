#pragma checksum "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "284f06fb224ced755fb399c3aa05908e262543c9"
// <auto-generated/>
#pragma warning disable 1591
namespace ShoppingCart.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\Shopping Cart\ShoppingCart\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Shopping Cart\ShoppingCart\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Shopping Cart\ShoppingCart\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Shopping Cart\ShoppingCart\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Shopping Cart\ShoppingCart\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Shopping Cart\ShoppingCart\Pages\Admin\_Imports.razor"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/details/{Id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Details</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-hover table-bordered");
            __builder.OpenElement(3, "tbody");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "<th>Id</th>\r\n            ");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 8 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
                 Product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "<th>Name</th>\r\n            ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 12 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
                 Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "<th>Description</th>\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 16 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
                 Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "<th>Category</th>\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 20 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
                 Product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "<th>Price</th>\r\n            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 24 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
                 Product.Price.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "<th>Stock Available</th>\r\n            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 28 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
                 Product.StockQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "btn btn-round");
            __builder.AddAttribute(36, "href", 
#nullable restore
#line 33 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
                                      EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(38, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "btn btn-round");
            __builder.AddAttribute(42, "href", "/admin/products");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(44, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Details.razor"
 
    [Inject]
    public IProductRepository Repository { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Product Product { get; set; }

    protected override void OnParametersSet()
    {
        Product = Repository.Products.FirstOrDefault(p => p.ProductId == Id);
    }

    public string EditUrl => $"/admin/products/edit/{Product.ProductId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
