#pragma checksum "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2be49ea8ad755e9825ca098b4d6c4e515809f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kontakt_Detali), @"mvc.1.0.view", @"/Views/Kontakt/Detali.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2be49ea8ad755e9825ca098b4d6c4e515809f4", @"/Views/Kontakt/Detali.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b212ccc7cc63bec6ab089f1624d8395f2cbd01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kontakt_Detali : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganmakcore.Models.Kontakt>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
  
    ViewData["Title"] = "Детали за контакт форма";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 11 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayNameFor(model => model.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 14 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayFor(model => model.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayFor(model => model.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayNameFor(model => model.Poraka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
       Write(Html.DisplayFor(model => model.Poraka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"btn-group\" role=\"group\">\r\n    <button type=\"button\" class=\"btn kopce-proizvod\">");
#nullable restore
#line 37 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
                                                Write(Html.ActionLink("Избриши", "Izbrishi", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button type=\"button\" class=\"btn kopce-proizvod\">");
#nullable restore
#line 38 "C:\Diplomska\Maganmakcore\Views\Kontakt\Detali.cshtml"
                                                Write(Html.ActionLink("Назад кон листата", "List"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maganmakcore.Models.Kontakt> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
