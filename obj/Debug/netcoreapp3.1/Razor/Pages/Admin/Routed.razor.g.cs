#pragma checksum "D:\Shopping Cart\ShoppingCart\Pages\Admin\Routed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaf42ae6d6a4c0575060b2c2d9ad08791b33d67c"
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
    public partial class Routed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Routed.razor"
                     typeof(Startup).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(3);
                __builder2.AddAttribute(4, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Routed.razor"
                               context

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Routed.razor"
                                                       typeof(AdminLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(6, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "<h4 class=\"bg-danger text-white text-center p-2\">\r\n            No Matching Route Found\r\n        </h4>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
