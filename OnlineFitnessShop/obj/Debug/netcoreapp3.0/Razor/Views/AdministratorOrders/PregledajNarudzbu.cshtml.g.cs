#pragma checksum "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f3102e2608ea6fd429884f1c391a16e14dc3319"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorOrders_PregledajNarudzbu), @"mvc.1.0.view", @"/Views/AdministratorOrders/PregledajNarudzbu.cshtml")]
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
#line 1 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f3102e2608ea6fd429884f1c391a16e14dc3319", @"/Views/AdministratorOrders/PregledajNarudzbu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorOrders_PregledajNarudzbu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineFitnessShop.ViewModels.AdministratorVMs.NarudzbaSoloPrikazVM>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
  
    ViewData["Title"] = "PregledajNarudzbu";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f3102e2608ea6fd429884f1c391a16e14dc33194139", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Prikaz narudzbi na cekanju</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f3102e2608ea6fd429884f1c391a16e14dc33195219", async() => {
                WriteLiteral(@"
    <div class=""tabela"">
        <h3>Narudžba na čekanju</h3>
        <table class=""table table-hover table-bordered "">
            <thead class=""thead-dark"">
                <tr>
                    <th>Ime i prezime kupca</th>
                    <th>Datum narudžbe</th>
                    <th>Grad i adresa</th>
                    <th>Status</th>
                    <th>Iznos</th>
                    <th>Akcija</th>


                </tr>
            </thead>
            <tbody>

                <tr>
                    <td>
                        ");
#nullable restore
#line 36 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
                   Write(Model.ImePrezimeKupca);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
                   Write(Model.DatumNarucivanja.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
                   Write(Model.Grad_Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
                   Write(Model.StatusNarudzbe);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
                   Write(Model.IznosNarudzbe);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1491, "\"", 1565, 2);
                WriteAttributeValue("", 1498, "/AdministratorOrders/PregledajNarudzbu?NarudzbaID=", 1498, 50, true);
#nullable restore
#line 50 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
WriteAttributeValue("", 1548, Model.NarudzbaID, 1548, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-search\"></span>Pregledaj narudžbu</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1694, "\"", 1767, 2);
                WriteAttributeValue("", 1701, "/AdministratorOrders/PrihvatiNarudzbu?NarudzbaID=", 1701, 49, true);
#nullable restore
#line 51 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
WriteAttributeValue("", 1750, Model.NarudzbaID, 1750, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success btn-sm \"><span class=\"glyphicon glyphicon-ok\"></span>Prihvati</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1885, "\"", 1955, 2);
                WriteAttributeValue("", 1892, "/AdministratorOrders/OdbijNarudzbu?NarudzbaID=", 1892, 46, true);
#nullable restore
#line 52 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
WriteAttributeValue("", 1938, Model.NarudzbaID, 1938, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-danger btn-sm ""><span class=""glyphicon glyphicon-minus""></span>Odbij</a>

                    </td>
                </tr>

            </tbody>
        </table>

        <a href=""/AdministratorOrders/PrikazNarudzbiNaCekanju"" class=""btn btn-info btn-sm ""><span class=""glyphicon glyphicon-arrow-left""></span>Vrati na prikaz narudžbi</a>

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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n<script>\r\n    $(document).ready(function(parameters) {\r\n        $.get(\"/AdministratorAjax/Index?NarudzbaID=");
#nullable restore
#line 71 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorOrders\PregledajNarudzbu.cshtml"
                                              Write(Model.NarudzbaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            function(rezultat, status) {\r\n                $(\"#nekiID\").html(rezultat);\r\n\r\n            });\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineFitnessShop.ViewModels.AdministratorVMs.NarudzbaSoloPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
