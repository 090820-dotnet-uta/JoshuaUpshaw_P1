#pragma checksum "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee917a961e55e1f7ab19f35189d5ec0d4f9e35b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores__ListStoreInventory), @"mvc.1.0.view", @"/Views/Stores/_ListStoreInventory.cshtml")]
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
#line 1 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\_ViewImports.cshtml"
using SlaughtoriaGamesP1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\_ViewImports.cshtml"
using SlaughtoriaGamesP1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee917a961e55e1f7ab19f35189d5ec0d4f9e35b3", @"/Views/Stores/_ListStoreInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01979a0215d620ef76dbf7ee008c39f1cf45dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores__ListStoreInventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SlaughtoriaGamesP1.Models.InventoryProductInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<style>\r\n    .card{\r\n        padding: 15px;\r\n        margin: 15px;\r\n    }\r\n</style>\r\n\r\n<h1>Shop Inventory</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div>\r\n            ");
#nullable restore
#line 17 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml"
       Write(Html.DisplayFor(modelItem => item.Skunum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 21 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml"
       Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 25 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml"
       Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 29 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml"
       Write(Html.DisplayFor(modelItem => item.ProductDescrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 33 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml"
       Write(Html.DisplayFor(modelItem => item.ProductCurrentQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_ListStoreInventory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<button onclick=\"history.back()\">Return to previous page</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SlaughtoriaGamesP1.Models.InventoryProductInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
