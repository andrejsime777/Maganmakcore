#pragma checksum "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "758879d570fd3579cd391b992ce11c3e3313c897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvod_Detali1), @"mvc.1.0.view", @"/Views/Proizvod/Detali1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"758879d570fd3579cd391b992ce11c3e3313c897", @"/Views/Proizvod/Detali1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b212ccc7cc63bec6ab089f1624d8395f2cbd01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Proizvod_Detali1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Maganmakcore.Models.Proizvod>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
  
    ViewData["Title"] = "Детали за " + @Model.ime;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 11 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 14 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayFor(model => model.ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.kategorija_proizvodi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayFor(model => model.kategorija_proizvodi.KategorijaIme));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.Cena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayFor(model => model.Cena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.kratok_opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayFor(model => model.kratok_opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.dolg_opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayFor(model => model.dolg_opis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.slika));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            <!-- Image Zoom HTML -->   \r\n            <img id=\"myImg\"");
            BeginWriteAttribute("src", " src=\"", 1430, "\"", 1448, 1);
#nullable restore
#line 45 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
WriteAttributeValue("", 1436, Model.slika, 1436, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1449, "\"", 1465, 1);
#nullable restore
#line 45 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
WriteAttributeValue("", 1455, Model.ime, 1455, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200px\">\r\n\r\n            <!-- The Modal -->\r\n            <div id=\"myModal\" class=\"modal\">\r\n                <img class=\"modal-content\" id=\"img01\">\r\n            </div>\r\n            <!-- End Image Zoom HTML -->\r\n        </dd>               \r\n");
#nullable restore
#line 53 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
         if(Model.upatstvo_link != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.prospekt_link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1937, "\"", 1964, 1);
#nullable restore
#line 59 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
WriteAttributeValue("", 1944, Model.prospekt_link, 1944, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Отвори во нов таб ></a>\r\n            </dd>\r\n");
#nullable restore
#line 61 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
         if(Model.upatstvo_link != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
       Write(Html.DisplayNameFor(model => model.upatstvo_link));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2262, "\"", 2289, 1);
#nullable restore
#line 68 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
WriteAttributeValue("", 2269, Model.upatstvo_link, 2269, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Отвори во нов таб ></a>\r\n            </dd>\r\n");
#nullable restore
#line 70 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </dl>\r\n</div>\r\n<div class=\"btn-group\" role=\"group\">\r\n    <button type=\"button\" class=\"btn btn-secondary\">");
#nullable restore
#line 75 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
                                               Write(Html.ActionLink("Измени", "Izmeni", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button type=\"button\" class=\"btn btn-secondary\">");
#nullable restore
#line 76 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
                                               Write(Html.ActionLink("Избриши", "Izbrishi", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button type=\"button\" class=\"btn btn-secondary\">");
#nullable restore
#line 77 "C:\Diplomska\Maganmakcore\Views\Proizvod\Detali1.cshtml"
                                               Write(Html.ActionLink("Назад кон листата", "Index1"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
</div>


<script>
// Get the modal
var modal = document.getElementById('myModal');

// Get the image and insert it inside the modal - use its ""alt"" text as a caption
var img = document.getElementById('myImg');
var modalImg = document.getElementById(""img01"");
var captionText = document.getElementById(""caption"");
img.onclick = function(){
    modal.style.display = ""block"";
    modalImg.src = this.src;
    modalImg.alt = this.alt;
    captionText.innerHTML = this.alt;
}


// When the user clicks on <span> (x), close the modal
modal.onclick = function() {
    img01.className += "" out"";
    setTimeout(function() {
       modal.style.display = ""none"";
       img01.className = ""modal-content"";
     }, 400);
    
 }    
    
</script>");
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
