#pragma checksum "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00869299dfdd15454e022c21051eda55fbd840bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores__CustomerOrderHistory), @"mvc.1.0.view", @"/Views/Stores/_CustomerOrderHistory.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\_ViewImports.cshtml"
using SlaughtoriaGamesP1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\_ViewImports.cshtml"
using SlaughtoriaGamesP1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00869299dfdd15454e022c21051eda55fbd840bd", @"/Views/Stores/_CustomerOrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01979a0215d620ef76dbf7ee008c39f1cf45dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores__CustomerOrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SlaughtoriaGamesP1.Models.OrderInformation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    body {
        background-image: url(../skavenbkg.gif);
        background-repeat: no-repeat;
        background-position: top;
        background-size: cover;
        padding: 0;
        margin: 0;
    }

    .contain {
        display: inline-flex;
        flex-wrap: wrap;
        overflow: scroll;
       
        justify-content: center;
        max-height: 500px;
        overflow-x: hidden;
    }

    .card {
        line-height: 1.5rem;
        margin: 15px;
        padding: 15px;
        text-align: center;
        font-size: large;
        font-weight: 500;
        width: 40%;
        border: 3px outset #4C7E12;
        border-top-left-radius: 20px;
        border-top-right-radius: 20px;
        background-color: #4C7E12;
        color: black;
        text-decoration: none;
        text-shadow: 5px 5px 5px black;
    }

    .back {
        border: 3px outset #4C7E12;
        border-top-left-radius: 20px;
        border-top-right-radius: 20px;
     ");
            WriteLiteral(@"   background-color: #4C7E12;
        text-decoration: none;
        text-shadow: 5px 5px 5px black;
        padding: 5px;
    }
    .back:hover {
        border: 3px inset #4C7E12;
    }

    .back:focus {
        border: 3px inset #6F9741;
        background-color: #6F9741;
    }

    container{
        max-height: 600px;
    }
</style>

<div class=""contain"">
");
#nullable restore
#line 64 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div>\r\n                Order ID: #\r\n                ");
#nullable restore
#line 69 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                Order Date: \r\n                ");
#nullable restore
#line 73 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                SKU #\r\n                ");
#nullable restore
#line 77 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderedProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 80 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                Quantity: \r\n                ");
#nullable restore
#line 84 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderedProductAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                Store: \r\n                ");
#nullable restore
#line 88 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.StoreOrderedFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                Total: $\r\n                ");
#nullable restore
#line 92 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 95 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_CustomerOrderHistory.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<button class=\"back\" onclick=\"history.back()\">Return to previous page...</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SlaughtoriaGamesP1.Models.OrderInformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
