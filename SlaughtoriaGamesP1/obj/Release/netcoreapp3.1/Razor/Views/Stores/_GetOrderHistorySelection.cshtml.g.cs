#pragma checksum "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_GetOrderHistorySelection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee400c44e8659f76797c7c16813143ce0358384e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stores__GetOrderHistorySelection), @"mvc.1.0.view", @"/Views/Stores/_GetOrderHistorySelection.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee400c44e8659f76797c7c16813143ce0358384e", @"/Views/Stores/_GetOrderHistorySelection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01979a0215d620ef76dbf7ee008c39f1cf45dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Stores__GetOrderHistorySelection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SlaughtoriaGamesP1.Models.Stores>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Icon_corruption_skv.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Skaven"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .one {
        display: flex;
        flex-direction: row;
        align-items: center;
        align-content: center;
        justify-content: center;
        width: 100%;
        padding: 75px;
        margin-left: 5px;
        margin-right: 10px;
    }

    .two {
        display: flex;
        border: 3px ridge #4C7E12;
        background-color: #343A40;
        font-size: large;
        font-weight: 500;
        text-align: center;
        justify-content: center;
        margin: 10px;
        padding: 10px;
        color: #4C7E12;
        width: 40%;
        text-shadow: 5px 5px 5px black;
    }

    body {
        background-image: url(../skavenbkg.gif);
        background-repeat: no-repeat;
        background-position: top;
        background-size: cover;
        height: 100vh;
        padding: 0;
        margin: 0;
    }

    .h1 {
        text-align: center;
        align-content: center;
        align-items: center;
        width: 100%;
     ");
            WriteLiteral(@"   color: #4C7E12;
    }

    .h1span {
        padding: 7px;
        border: 5px ridge #4C7E12;
        background-color: #343A40;
        text-shadow: 5px 5px 5px black;
        border-top-left-radius: 20px;
        border-top-right-radius: 20px;
    }

    a {
        text-decoration: none;
        color: black;
    }

        a:hover {
            text-decoration: none;
            color: #343A40;
        }

    .button {
        border: 3px outset #4C7E12;
        border-radius: 20px;
        background-color: #4C7E12;
        text-decoration: none;
        text-shadow: 5px 5px 5px #343A40;
        padding: 5px;
        color: black;
    }

        .button:hover {
            border: 3px inset #4C7E12;
        }

        .button:focus {
            border: 3px inset #6F9741;
            background-color: #6F9741;
        }

    /* Dropdown Button */
    .btnDrop {
        border: 3px outset #4C7E12;
        border-radius: 20px;
        background-color: #6F974");
            WriteLiteral(@"1;
        text-decoration: none;
        text-shadow: 5px 5px 5px #343A40;
        padding: 7px;
        background-color: #4C7E12;
        color: black;
        font-weight: 500;
        font-size: large;
    }

        /* Dropdown button on hover & focus */
        .btnDrop:hover{
            border: 3px inset #4C7E12;
        }

         .btnDrop:focus{
            border: 3px inset #6F9741;
            background-color: #6F9741;
        }

    /* The container <div> - needed to position the dropdown content */
    .dDown {
        position: relative;
        display: inline-block;
    }

    /* Dropdown Content (Hidden by Default) */
    .dDown-content {
        position: absolute;
        background-color: #4C7E12;
        min-width: 160px;
        max-height: 200px;
        margin-bottom: 10px;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
        overflow-y: scroll;
        padding: 5px;
        border: 3px solid #4C7E12;
    }

     ");
            WriteLiteral(@"   /* Links inside the dropdown */
        .dDown-content a {
            color: black;
            padding: 6px 6px;
            text-decoration: none;
            display: block;
            font-size: large;
            text-shadow: 5px 5px 5px #343A40;
        }

    .hidedrop {
        display: none;
    }

    .showdrop {
        display: block;
    }

    .back {
        border: 3px outset #4C7E12;
        border-top-left-radius: 20px;
        border-top-right-radius: 20px;
        background-color: #4C7E12;
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
</style>


");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee400c44e8659f76797c7c16813143ce0358384e8152", async() => {
                WriteLiteral(@"
    <div>
        <div class=""h1"">
            <span class=""h1span"">Which would you like to see?</span>
        </div>
    </div>
    <div class=""one"">
        <div class=""two"" style=""border-top-left-radius: 20px; border-top-right-radius: 20px;"">
");
#nullable restore
#line 177 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_GetOrderHistorySelection.cshtml"
              
                int orderHistoryType = 1;
                SlaughtoriaGamesP1.Models.Stores store = new SlaughtoriaGamesP1.Models.Stores();
            

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee400c44e8659f76797c7c16813143ce0358384e9120", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <button class=\"button\" display=\"none\">");
#nullable restore
#line 184 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_GetOrderHistorySelection.cshtml"
                                             Write(Html.ActionLink("Your order history", "GetOrderHistorySelection", "Stores", new { orderHistoryType, store }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n            <div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee400c44e8659f76797c7c16813143ce0358384e10821", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"one\">\r\n        <div class=\"two\" style=\"border-bottom-left-radius: 20px; border-bottom-right-radius: 20px;\">\r\n            <div class=\"dDown\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee400c44e8659f76797c7c16813143ce0358384e12237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <button onclick=\"storeDropdown()\" class=\"btnDrop\">Dropdown</button>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee400c44e8659f76797c7c16813143ce0358384e13518", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div id=\"dropCon\" class=\"dDown-content hidedrop\">\r\n\r\n");
#nullable restore
#line 198 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_GetOrderHistorySelection.cshtml"
                     foreach (var item in Model)
                    {
                        string id = item.StoreId.ToString();
                        string city = item.City;
                        string linkText = id + ") " + city;


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a>");
#nullable restore
#line 204 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_GetOrderHistorySelection.cshtml"
                      Write(Html.ActionLink(linkText, "_StoreOrderHistory", item));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 205 "C:\Users\NeonJ\OneDrive\Documents\GitHub\JoshuaUpshaw_P1\SlaughtoriaGamesP1\Views\Stores\_GetOrderHistorySelection.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<button class=""back"" onclick=""window.history.back()"">Return to previous page</button>

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
        if (!event.target.matches('.btnDro");
            WriteLiteral(@"p')) {
            var dropdowns = document.getElementsByClassName(""dDown-content"");
            var i;
            for (i = 0; i < dropdowns.length; i++) {
                var openDropdown = dropdowns[i];
                if (openDropdown.classList.contains('show')) {
                    openDropdown.classList.remove('show');
                }
            }
        }
    }

</script>




");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SlaughtoriaGamesP1.Models.Stores>> Html { get; private set; }
    }
}
#pragma warning restore 1591