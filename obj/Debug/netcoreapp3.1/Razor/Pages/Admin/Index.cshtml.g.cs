#pragma checksum "D:\Shopping Cart\ShoppingCart\Pages\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf52f7adb03ff94683a69116f5383fe82cbe803e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShoppingCart.Pages.Admin.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
namespace ShoppingCart.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\Shopping Cart\ShoppingCart\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Shopping Cart\ShoppingCart\Pages\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Shopping Cart\ShoppingCart\Pages\_ViewImports.cshtml"
using ShoppingCart.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin")]
#nullable restore
#line 6 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Index.cshtml"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf52f7adb03ff94683a69116f5383fe82cbe803e", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b825eee424b949e374dbe335c50cd5555b4c384e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf52f7adb03ff94683a69116f5383fe82cbe803e4486", async() => {
                WriteLiteral(@"
        <meta name=""viewport"" content=""width=device-width"" />
        <title>SportsStore - Admin</title>
        <link rel=""shortcut icon"" href=""/lib/assets/images/favicon.ico"">
        <link rel=""stylesheet"" href=""/lib/assets/styles/vendor/bootstrap.min.css"">
        <link rel=""stylesheet"" href=""/lib/assets/fonts/et-lineicons/css/style.css"">
        <link rel=""stylesheet"" href=""/lib/assets/fonts/linea-font/css/linea-font.css"">
        <link rel=""stylesheet"" href=""/lib/assets/fonts/fontawesome/css/font-awesome.min.css"">
        <link rel=""stylesheet"" href=""/lib/assets/styles/vendor/slick.css"">
        <link rel=""stylesheet"" href=""/lib/assets/styles/vendor/magnific-popup.css"">
        <link rel=""stylesheet"" href=""/lib/assets/styles/vendor/animate.css"">
        <link rel=""stylesheet"" href=""/lib/assets/styles/main.css"">
        <link rel=""stylesheet"" href=""/lib/assets/styles/responsive.css"">
        <script src=""/lib/assets/js/vendor/modernizr-2.8.3.min.js""></script>
        <base href=""/"" />
   ");
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf52f7adb03ff94683a69116f5383fe82cbe803e6561", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf52f7adb03ff94683a69116f5383fe82cbe803e6827", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ComponentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper);
#nullable restore
#line 26 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType = typeof(Routed);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("type", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.ComponentType, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "D:\Shopping Cart\ShoppingCart\Pages\Admin\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode = global::Microsoft.AspNetCore.Mvc.Rendering.RenderMode.Server;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("render-mode", __Microsoft_AspNetCore_Mvc_TagHelpers_ComponentTagHelper.RenderMode, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <script src=""/_framework/blazor.server.js""></script>
        <script src=""/lib/assets/js/vendor/jquery-2.1.4.min.js""></script>
        <script src=""/lib/assets/js/vendor/google-fonts.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.easing.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.waypoints.min.js""></script>
        <script src=""/lib/assets/js/vendor/bootstrap.min.js""></script>
        <script src=""/lib/assets/js/vendor/bootstrap-hover-dropdown.min.js""></script>
        <script src=""/lib/assets/js/vendor/smoothscroll.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.localScroll.min.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.scrollTo.min.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.stellar.min.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.parallax.js""></script>
        <script src=""/lib/assets/js/vendor/slick.min.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.easyp");
                WriteLiteral(@"iechart.min.js""></script>
        <script src=""/lib/assets/js/vendor/countup.min.js""></script>
        <script src=""/lib/assets/js/vendor/isotope.min.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.magnific-popup.min.js""></script>
        <script src=""/lib/assets/js/vendor/wow.min.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.mb.YTPlayer.min.js""></script>
        <script src=""/lib/assets/js/vendor/jquery.ajaxchimp.js""></script>        
        <script src=""/lib/assets/js/main.js""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Admin_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Admin_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Admin_Index>)PageContext?.ViewData;
        public Pages_Admin_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591