#pragma checksum "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66eed15409ecbbc407ce77fae2c971c3b41209e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvod_Izbrishi), @"mvc.1.0.view", @"/Views/Proizvod/Izbrishi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66eed15409ecbbc407ce77fae2c971c3b41209e6", @"/Views/Proizvod/Izbrishi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b212ccc7cc63bec6ab089f1624d8395f2cbd01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Proizvod_Izbrishi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganmakcore.Models.Proizvod>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Izbrishi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
  
    ViewData["Title"] = "Бришење на " + Model.ime;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Izbrishi</h1>\r\n\r\n<h3>Дали сте сигурни дека сакате да го избришете ");
#nullable restore
#line 9 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
                                            Write(Model.ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
       Write(Html.DisplayNameFor(model => model.ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            <b>");
#nullable restore
#line 17 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
          Write(Html.DisplayFor(model => model.ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
       Write(Html.DisplayNameFor(model => model.kratok_opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
       Write(Html.DisplayFor(model => model.kratok_opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
       Write(Html.DisplayNameFor(model => model.slika));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 808, "\"", 826, 1);
#nullable restore
#line 29 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
WriteAttributeValue("", 814, Model.slika, 814, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200px\" />\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66eed15409ecbbc407ce77fae2c971c3b41209e66079", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Избриши\" class=\"btn btn-danger\" /> <br /><br />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"btn-group\" role=\"group\">\r\n     <button type=\"button\" class=\"btn kopce-proizvod\">");
#nullable restore
#line 37 "C:\Diplomska\Maganmakcore\Views\Proizvod\Izbrishi.cshtml"
                                                 Write(Html.ActionLink("Назад кон листата", "Index1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maganmakcore.Models.Proizvod> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591