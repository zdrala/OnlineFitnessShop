#pragma checksum "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da669c0c58ab42119f9683361d89d717a6c923b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorNabavka_PrikazDobavljacaOdjece), @"mvc.1.0.view", @"/Views/AdministratorNabavka/PrikazDobavljacaOdjece.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da669c0c58ab42119f9683361d89d717a6c923b", @"/Views/AdministratorNabavka/PrikazDobavljacaOdjece.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorNabavka_PrikazDobavljacaOdjece : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineFitnessShop.ViewModels.AdministratorVMs.OdjecaSoloPrikazVM>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
  
    ViewData["Title"] = "PrikazDobavljacaOdjece";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da669c0c58ab42119f9683361d89d717a6c923b4347", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Prikaz odjece</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da669c0c58ab42119f9683361d89d717a6c923b4710", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da669c0c58ab42119f9683361d89d717a6c923b6513", async() => {
                WriteLiteral(@"

    <div class=""tabela"">
        <h3>Lista dobavljača za odjeću</h3>
        <table class=""table table-hover table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Slika</th>
                    <th>Naziv</th>
                    <th>Cijena</th>
                    <th>Veličine van stanja</th>
                    <th>Akcija</th>



                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        <img");
                BeginWriteAttribute("src", " src=\"", 936, "\"", 965, 2);
                WriteAttributeValue("", 942, "/images/", 942, 8, true);
#nullable restore
#line 36 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
WriteAttributeValue("", 950, Model.ImageUrl, 950, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50px\" height=\"50px\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
                   Write(Model.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
                   Write(Model.Cijena);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 46 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
                         foreach (var s in @Model.velicine)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span>");
#nullable restore
#line 48 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
                         Write(s);

#line default
#line hidden
#nullable disable
                WriteLiteral(",</span>\r\n");
#nullable restore
#line 49 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
                       }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1473, "\"", 1549, 2);
                WriteAttributeValue("", 1480, "/AdministratorNabavka/PrikazDobavljacaOdjece?OdjecaID=", 1480, 54, true);
#nullable restore
#line 53 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
WriteAttributeValue("", 1534, Model.OdjecaID, 1534, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-search\"></span>prikaži dobavljače odjeće</a>\r\n\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1687, "\"", 1756, 2);
                WriteAttributeValue("", 1694, "/AdministratorProizvod/PrikazVelicine?OdjecaID=", 1694, 47, true);
#nullable restore
#line 55 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\PrikazDobavljacaOdjece.cshtml"
WriteAttributeValue("", 1741, Model.OdjecaID, 1741, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-success btn-sm ""><span class=""glyphicon glyphicon-list-alt""></span>Dodavanje količine na stanje</a>
                    </td>

                </tr>

            </tbody>
        </table>
        <a href=""/AdministratorNabavka/ShowClothesOutOfStock"" class=""btn btn-danger btn-sm ""><span class=""glyphicon glyphicon-search""></span>Vrati na prikaz odjeće van stanja</a>
        <div id=""nekiID""></div>

    </div>
");
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
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    $(document).ready(function (parameters) {\r\n        $.get(\"/AdministratorAjax/GetDobavljaceOdjece\",\r\n            function (rezultat, status) {\r\n                $(\"#nekiID\").html(rezultat);\r\n\r\n            });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineFitnessShop.ViewModels.AdministratorVMs.OdjecaSoloPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591