#pragma checksum "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\Home\GetCarByModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad431d064086e64aa92a60ac024f40a8387b33ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCarByModel), @"mvc.1.0.view", @"/Views/Home/GetCarByModel.cshtml")]
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
#line 1 "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\_ViewImports.cshtml"
using CarManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\_ViewImports.cshtml"
using CarManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad431d064086e64aa92a60ac024f40a8387b33ab", @"/Views/Home/GetCarByModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ee8f9524e88559ec699464f51f0e67fa0e6490", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCarByModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarManager.Models.CarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n\r\n    <h2>Model: ");
#nullable restore
#line 5 "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\Home\GetCarByModel.cshtml"
          Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h4>Marka: ");
#nullable restore
#line 7 "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\Home\GetCarByModel.cshtml"
          Write(Model.Manufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <h4>Cena: ");
#nullable restore
#line 9 "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\Home\GetCarByModel.cshtml"
         Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 172, "\"", 203, 1);
#nullable restore
#line 11 "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\Home\GetCarByModel.cshtml"
WriteAttributeValue("", 178, Url.Content(Model.Photo), 178, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 204, "\"", 222, 1);
#nullable restore
#line 11 "E:\Jakub\Documents\Programowanie\CodeTeam\Szkolenie DotNet Core\Lab 3 - Wstęp do MVC\CarManager\Views\Home\GetCarByModel.cshtml"
WriteAttributeValue("", 210, Model.Model, 210, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarManager.Models.CarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
