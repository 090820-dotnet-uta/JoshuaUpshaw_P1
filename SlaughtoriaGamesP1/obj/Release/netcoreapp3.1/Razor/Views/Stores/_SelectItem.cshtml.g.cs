#pragma checksum "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fee7502db6f060177a5a5ce3bc2b514c6e21434"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fee7502db6f060177a5a5ce3bc2b514c6e21434", @"/Views/Stores/_SelectItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01979a0215d620ef76dbf7ee008c39f1cf45dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores__SelectItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SlaughtoriaGamesP1.Models.InventoryProductInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_CheckCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Stores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_StoreMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    body {
        background-image: url(https://media.playstation.com/is/image/SCEA/playstation-wallpapers_ghost-of-tsushima-keyart-4K-01-ps4-26jun20-en-us?$native_nt$);
        background-repeat: no-repeat;
        background-position: top;
        background-size: cover;
        height: 100vh;
        padding: 0;
        margin: 0;
    }

    table{
        border: 3px inset #941812;
        background-color: #DADBD9;
    }

    th, thead {
        border: 3px inset #941812;
        text-align: center;
        font-size: medium;
        padding: 5px;

    }

    td {
        border: 3px inset #941812;
        text-align: center;
        font-size: medium;
        padding: 5px;
    }

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
    .btnDrop:hover, .btnDrop:focu");
            WriteLiteral(@"s {
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
            display: block;
        }

    .hidedrop {
        display: none;
    }

    .showdrop {
        display: block;
    }

    a{
        text-decoration: none;
        color: black;
    }

    a:hover{
        text-decoration: none;
        color: black;
    }

    .button{
        bor");
            WriteLiteral(@"der: 3px outset #941812;
        border-radius: 20px;
        text-decoration: none;
        color: black;
        padding: 7px;
        background-color:#DADBD9;
        text-align: center;
    }

    .button:hover{
        border: 3px inset #941812;
    }

    .salebox{
        border: 3px inset #941812;
        border-radius: 20px;
        width: 100%;
        align-self: center;
        background-color: #DADBD9;
    }

    .sale {
        background-color: #DADBD9;
        color: black;
        text-shadow: 3px 3px 3px #941812;
        border: 3px inset #941812;
        border-radius: 20px;
        font-size: x-large;
        font-weight: 600;
        padding: 5px;
        margin: 5px;
        text-align: center;
    }

    .contain {
        display: inline-flex;
        flex-wrap: wrap;
        overflow: scroll;
        overflow-x: hidden;
        justify-content: center;
        max-height: 500px;
    }

    .contained {
        display: flex;
        align");
            WriteLiteral(@"-content: center;
        flex-wrap: wrap;
        justify-content: center;
        width: 100%;
    }

</style>
<p>
    Displaying items being sold at your default store...
</p>
<div class=""contain"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Product Name
                </th>
                <th>
                    Product Description
                </th>
                <th>
                    Unit Price
                </th>
                <th>
                    Current Quantity
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 169 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 173 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 176 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductDescrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        $");
#nullable restore
#line 179 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                    Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 182 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductCurrentQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a>");
#nullable restore
#line 186 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                      Write(Html.ActionLink("Add item to cart", "AddItemToCart", "Stores", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 189 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <div class=\"salebox\">\r\n");
#nullable restore
#line 193 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
             if (item.ProductDiscount != 0)
            {
                decimal discount = item.ProductDiscount;
                item.ProductDiscount = Math.Round((discount * 100), 0);


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"sale\">\r\n                    ");
#nullable restore
#line 201 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> is on sale for </span>");
#nullable restore
#line 201 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
                                                                                           Write(Html.ValueFor(modelItem => item.ProductDiscount));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>% off!</span>\r\n                </div>\r\n");
#nullable restore
#line 203 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"


            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_SelectItem.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"contained\">\r\n    <div>\r\n        <button class=\"button\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fee7502db6f060177a5a5ce3bc2b514c6e2143413230", async() => {
                WriteLiteral("\r\n                Check Cart\r\n            ");
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
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n    <div >\r\n        <button class=\"button\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fee7502db6f060177a5a5ce3bc2b514c6e2143414930", async() => {
                WriteLiteral("\r\n                Checkout\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n    <div>\r\n        <button class=\"button\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fee7502db6f060177a5a5ce3bc2b514c6e2143416627", async() => {
                WriteLiteral("\r\n                Return to store menu\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </button>
    </div>
</div>




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
            var dropdowns = docu");
            WriteLiteral(@"ment.getElementsByClassName(""dDown-content"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SlaughtoriaGamesP1.Models.InventoryProductInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
