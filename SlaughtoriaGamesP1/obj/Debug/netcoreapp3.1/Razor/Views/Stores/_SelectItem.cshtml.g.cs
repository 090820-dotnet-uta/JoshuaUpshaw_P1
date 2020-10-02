#pragma checksum "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af4d59be185ea61e6cb28bf8012d36d75082af53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores__SelectItem), @"mvc.1.0.view", @"/Views/Stores/_SelectItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4d59be185ea61e6cb28bf8012d36d75082af53", @"/Views/Stores/_SelectItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01979a0215d620ef76dbf7ee008c39f1cf45dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores__SelectItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SlaughtoriaGamesP1.Models.InventoryProductSelect>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_CheckCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>

    /* Dropdown Button */
    .btnDrop {
        background-color: #3498DB;
        color: white;
        padding: 16px;
        font-size: 16px;
        border: none;
        cursor: pointer;
    }

        /* Dropdown button on hover & focus */
        .btnDrop:hover, .btnDrop:focus {
            background-color: #2980B9;
        }

    /* The container <div> - needed to position the dropdown content */
    .dDown {
        position: relative;
        display: inline-block;
    }

    /* Dropdown Content (Hidden by Default) */
    .dDown-content {
        position: absolute;
        background-color: #f1f1f1;
        min-width: 160px;
        max-height: 200px;
        margin-bottom: 20px;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
        overflow-y: scroll;
    }

        /* Links inside the dropdown */
        .dDown-content a {
            color: black;
            padding: 12px 16px;
            text-decoration: none;
  ");
            WriteLiteral(@"          display: block;
        }

    .hidedrop {
        display: none;
    }

    .showdrop {
        display: block;
    }
</style>
<p>
    Displaying items being sold at your default store...
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ProductName
            </th>
            <th>
                Product Description
            </th>
            <th>
                Unit Price
            </th>
            <th>
                Product Current Quantity
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 76 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
         foreach (var item in Model.inventoryitem)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductDescrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductCurrentQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <a>");
#nullable restore
#line 93 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                  Write(Html.ActionLink("Add item to cart", "AddItemToCart", "Stores", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 106 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 109 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
 foreach (var item in Model.inventoryitem)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
     if (item.ProductDiscount != 0)
    {
        decimal discount = item.ProductDiscount;
        item.ProductDiscount = Math.Round((discount * 100), 0);

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> is on sale for </span>");
#nullable restore
#line 116 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                                                                               Write(Html.ValueFor(modelItem => item.ProductDiscount));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>% off!</span>\r\n");
#nullable restore
#line 117 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\NeonJ\source\repos\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af4d59be185ea61e6cb28bf8012d36d75082af539546", async() => {
                WriteLiteral("Check Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    var mydroplist = document.querySelector(""#dropCon"");
    console.log(mydroplist);


    document.querySelector("".btnDrop"").addEventListener(""click"", (e) => {
        console.log(e);
        if (mydroplist.classList.contains(""showdrop"")) {
            mydroplist.classList.remove(""showdrop"");
            mydroplist.classList.add(""hidedrop"");
        }
        else if (mydroplist.classList.contains(""hidedrop"")) {
            mydroplist.classList.remove(""hidedrop"");
            mydroplist.classList.add(""showdrop"");
        }


    })
    /* When the user clicks on the button,
    toggle between hiding and showing the dropdown content */
    function storeDropdown() {
        document.getElementById(""dropCon"").classList.toggle(""show"");
    }

    // Close the dropdown menu if the user clicks outside of it
    window.onclick = function (event) {
        if (!event.target.matches('.btnDrop')) {
            var dropdowns = document.getElementsByClassName(""dDown-content"");");
            WriteLiteral(@"
            var i;
            for (i = 0; i < dropdowns.length; i++) {
                var openDropdown = dropdowns[i];
                if (openDropdown.classList.contains('show')) {
                    openDropdown.classList.remove('show');
                }
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SlaughtoriaGamesP1.Models.InventoryProductSelect> Html { get; private set; }
    }
}
#pragma warning restore 1591
