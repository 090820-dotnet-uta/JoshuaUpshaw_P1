#pragma checksum "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "050021655a8ea2c12165818233c9d312c90262d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ListSearchResults), @"mvc.1.0.view", @"/Views/Shared/_ListSearchResults.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"050021655a8ea2c12165818233c9d312c90262d0", @"/Views/Shared/_ListSearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01979a0215d620ef76dbf7ee008c39f1cf45dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ListSearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SlaughtoriaGamesP1.Models.Customers>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n\r\n\r\n</style>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Shared\_ListSearchResults.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<button onclick=\"history.back()\">Return to previous page...</button>\r\n\r\n<script>\r\n\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SlaughtoriaGamesP1.Models.Customers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
