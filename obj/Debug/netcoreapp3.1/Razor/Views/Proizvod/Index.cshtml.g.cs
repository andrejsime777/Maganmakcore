#pragma checksum "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e3122ddfb3d0a386447aa8bd5f2d9e4a39f1eb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvod_Index), @"mvc.1.0.view", @"/Views/Proizvod/Index.cshtml")]
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
#line 1 "C:\Diplomska\Maganmakcore\Views\_ViewImports.cshtml"
using Maganmakcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Diplomska\Maganmakcore\Views\_ViewImports.cshtml"
using Maganmakcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e3122ddfb3d0a386447aa8bd5f2d9e4a39f1eb0", @"/Views/Proizvod/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b212ccc7cc63bec6ab089f1624d8395f2cbd01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Proizvod_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganmakcore.ViewModel.ProizvodViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
  
    ViewBag.Title = "Производи";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"lista-proizvodi\">\r\n\r\n");
            WriteLiteral("    <div class=\"proizvodi-container\">\r\n\r\n");
#nullable restore
#line 13 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
         foreach (var item in Model.Proizvodi)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"slika-proizvod\"><a");
            BeginWriteAttribute("href", " href=\"", 414, "\"", 462, 1);
#nullable restore
#line 17 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 421, Url.Action("Detali", new { id=item.Id }), 421, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 468, "\"", 515, 1);
#nullable restore
#line 17 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 474, Html.DisplayFor(modelItem => item.slika), 474, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 516, "\"", 561, 1);
#nullable restore
#line 17 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 522, Html.DisplayFor(modelItem => item.ime), 522, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a></div>\r\n                <div class=\"naslov-proizvod\"><a");
            BeginWriteAttribute("href", " href=\"", 622, "\"", 670, 1);
#nullable restore
#line 18 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 629, Url.Action("Detali", new { id=item.Id }), 629, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                <div class=\"kratok-opis-proizvod\">");
#nullable restore
#line 19 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.kratok_opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"cena\">");
#nullable restore
#line 20 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.Cena));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ден.</div>\r\n                <div class=\"d-inline-block\">\r\n                    <button class=\"kopce-proizvod \">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e3122ddfb3d0a386447aa8bd5f2d9e4a39f1eb06871", async() => {
                WriteLiteral("во кошничка");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-proizvodId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["proizvodId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-proizvodId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["proizvodId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n                    <button class=\"kopce-proizvod\"><a");
            BeginWriteAttribute("href", " href=\"", 1188, "\"", 1236, 1);
#nullable restore
#line 23 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"
WriteAttributeValue("", 1195, Url.Action("Detali", new { id=item.Id }), 1195, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">повеќе</a></button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Diplomska\Maganmakcore\Views\Proizvod\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maganmakcore.ViewModel.ProizvodViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
