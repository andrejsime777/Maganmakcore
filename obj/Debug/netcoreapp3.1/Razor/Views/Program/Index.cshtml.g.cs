#pragma checksum "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c4d39488db78798280f7a7ea23ce6e87d99b896"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_Index), @"mvc.1.0.view", @"/Views/Program/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4d39488db78798280f7a7ea23ce6e87d99b896", @"/Views/Program/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b212ccc7cc63bec6ab089f1624d8395f2cbd01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Program_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganmakcore.ViewModel.ProgramViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
  
    ViewBag.Title = Model.momentalna_kategorija;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"text-center\">Во прилог ви претставуваме ");
#nullable restore
#line 7 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
                                              Write(Model.Programi.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" програми кои ги нудиме (кликнете на програма за повеќе информации):</h4>\r\n<br />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
     foreach(var program in Model.Programi)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-6 col-md-4 col-xs-12\">\r\n            <div class=\"thumbnail prog\">\r\n                <div class=\"slika_prog\">\r\n                    <a class=\"hover-img caption\"");
            BeginWriteAttribute("href", " href=\"", 520, "\"", 544, 1);
#nullable restore
#line 15 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
WriteAttributeValue("", 527, program.pdf_link, 527, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"> <img class=\"slika\" alt=\"image\" src=\"/sodrzhina/images/programs.png\">\r\n                    </a>\r\n                </div>\r\n                <div class=\"caption\">\r\n                    <h3 id=\"txt\"><a");
            BeginWriteAttribute("href", " href=\"", 757, "\"", 781, 1);
#nullable restore
#line 19 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
WriteAttributeValue("", 764, program.pdf_link, 764, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 19 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
                                                                        Write(program.kategorija_programi.KategorijaIme);

#line default
#line hidden
#nullable disable
            WriteLiteral(" на ");
#nullable restore
#line 19 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
                                                                                                                      Write(program.Ime.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Diplomska\Maganmakcore\Views\Program\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Maganmakcore.ViewModel.ProgramViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
