#pragma checksum "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0931cf5bd2cd5fa9c0e64d1ecfc7102ee9d104"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorProizvod_PrikazOdjece), @"mvc.1.0.view", @"/Views/AdministratorProizvod/PrikazOdjece.cshtml")]
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
#line 1 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\_ViewImports.cshtml"
using OnlineFitnessShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\_ViewImports.cshtml"
using OnlineFitnessShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0931cf5bd2cd5fa9c0e64d1ecfc7102ee9d104", @"/Views/AdministratorProizvod/PrikazOdjece.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorProizvod_PrikazOdjece : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineFitnessShop.ViewModels.AdministratorVMs.OdjecaPrikazVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Administrator/ProizvodiFilteri.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
  

   int brojac = 0;
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d0931cf5bd2cd5fa9c0e64d1ecfc7102ee9d1044615", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Prikaz odjece</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d0931cf5bd2cd5fa9c0e64d1ecfc7102ee9d1044978", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d0931cf5bd2cd5fa9c0e64d1ecfc7102ee9d1046781", async() => {
                WriteLiteral(@"
    <div class=""container"" id=""cont1"">
        <p class=""pClass"">
            Filter za spol:
        </p>
        <label class=""radio-inline"">
            <input lass=""option-input radio"" id=""rd1"" type=""radio"" name=""optradio"" onclick=""filterMuški()"" >Muškarci
        </label>
        <label class=""radio-inline"">
            <input lass=""option-input radio"" id=""rd2"" type=""radio"" name=""optradio"" onclick=""filterŽenski()"">Žene
        </label>
        <label class=""radio-inline"">
            <input lass=""option-input radio"" id=""rd1"" type=""radio"" name=""optradio"" onclick=""filterSvi()"" checked>Svi proizvodi
        </label>

    </div>


    <div class=""proizvodi"">
        <div class=""tabela"">
            <table class=""table table-hover table-bordered"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Slika</th>
                        <th>Naziv</th>
                        <th>Cijena</th>
                        <th>Spol</th>
              ");
                WriteLiteral("          <th>Brend</th>\r\n                        <th>Akcija</th>\r\n\r\n\r\n\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"b-id\">\r\n                    <div id=\"pcL\" class=\"p-container\">\r\n");
#nullable restore
#line 53 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
                         foreach (var x in @Model.podaciOdjece)
                        {
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr");
                BeginWriteAttribute("id", "  id=\"", 1827, "\"", 1844, 2);
                WriteAttributeValue("", 1833, "red-", 1833, 4, true);
#nullable restore
#line 56 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
WriteAttributeValue("", 1837, brojac, 1837, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                <td>\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1928, "\"", 1953, 2);
                WriteAttributeValue("", 1934, "/images/", 1934, 8, true);
#nullable restore
#line 59 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
WriteAttributeValue("", 1942, x.ImageUrl, 1942, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50px\" height=\"50px\" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
                               Write(x.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 65 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
                               Write(x.Cijena);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <td class=\"spol\">\r\n                                    ");
#nullable restore
#line 67 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
                               Write(x.Spol);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
                               Write(x.Brend);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n\r\n");
                WriteLiteral("                                <td>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2739, "\"", 2801, 2);
                WriteAttributeValue("", 2746, "/AdministratorProizvod/UrediOdjecu?OdjecaID=", 2746, 44, true);
#nullable restore
#line 75 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
WriteAttributeValue("", 2790, x.OdjecaID, 2790, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-pencil\"></span>Uredi</a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2929, "\"", 2992, 2);
                WriteAttributeValue("", 2936, "/AdministratorProizvod/ObrisiOdjecu?OdjecaID=", 2936, 45, true);
#nullable restore
#line 76 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
WriteAttributeValue("", 2981, x.OdjecaID, 2981, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger btn-sm \"><span class=\"glyphicon glyphicon-remove-circle\"></span>Obrisi</a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3130, "\"", 3195, 2);
                WriteAttributeValue("", 3137, "/AdministratorProizvod/PrikazVelicine?OdjecaID=", 3137, 47, true);
#nullable restore
#line 77 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
WriteAttributeValue("", 3184, x.OdjecaID, 3184, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-list-alt\"></span>Upravljanje veličinama</a>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3342, "\"", 3414, 2);
                WriteAttributeValue("", 3349, "/AdministratorProizvod/PrikazKomentaraZaProizvod?id=", 3349, 52, true);
#nullable restore
#line 78 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
WriteAttributeValue("", 3401, x.ProizvodID, 3401, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-search\"></span>Prikaži komentare</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 81 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazOdjece.cshtml"
                            brojac = brojac + 1;

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </tbody>\r\n            </table>\r\n\r\n            <a href=\"/AdministratorProizvod/DodajOdjecu\" class=\"btn btn-success\">Dodaj novu odjeću</a>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineFitnessShop.ViewModels.AdministratorVMs.OdjecaPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
