#pragma checksum "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98fc6528b810e2446faa52351592a4bf8d17f294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_PrikazOdjece), @"mvc.1.0.view", @"/Views/Administrator/PrikazOdjece.cshtml")]
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
#line 1 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\_ViewImports.cshtml"
using OnlineFitnessShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\_ViewImports.cshtml"
using OnlineFitnessShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98fc6528b810e2446faa52351592a4bf8d17f294", @"/Views/Administrator/PrikazOdjece.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_PrikazOdjece : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineFitnessShop.ViewModels.AdministratorVMs.OdjecaPrikazVM>
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
#line 3 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
  

   
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fc6528b810e2446faa52351592a4bf8d17f2943996", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Prikaz odjece</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98fc6528b810e2446faa52351592a4bf8d17f2945063", async() => {
                WriteLiteral(@"
    <div class=""tabela"">
        <table class=""table table-hover table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Slika</th>
                    <th>Naziv</th>
                    <th>Cijena</th>
                    <th>Spol</th>
                    <th>Brend</th>
                    <th>Akcija</th>



                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 33 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
                 foreach (var x in @Model.podaciOdjece)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 957, "\"", 982, 2);
                WriteAttributeValue("", 963, "/images/", 963, 8, true);
#nullable restore
#line 38 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
WriteAttributeValue("", 971, x.ImageUrl, 971, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50px\" height=\"50px\" />\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
                       Write(x.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
                       Write(x.Cijena);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
                       Write(x.Spol);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
                       Write(x.Brend);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                   \r\n");
                WriteLiteral("                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1646, "\"", 1700, 2);
                WriteAttributeValue("", 1653, "/Administrator/UrediOdjecu?OdjecaID=", 1653, 36, true);
#nullable restore
#line 54 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
WriteAttributeValue("", 1689, x.OdjecaID, 1689, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-pencil\"></span>Uredi</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1816, "\"", 1871, 2);
                WriteAttributeValue("", 1823, "/Administrator/ObrisiOdjecu?OdjecaID=", 1823, 37, true);
#nullable restore
#line 55 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
WriteAttributeValue("", 1860, x.OdjecaID, 1860, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger btn-sm \"><span class=\"glyphicon glyphicon-remove-circle\"></span>Obrisi</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1997, "\"", 2054, 2);
                WriteAttributeValue("", 2004, "/Administrator/PrikazVelicine?OdjecaID=", 2004, 39, true);
#nullable restore
#line 56 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
WriteAttributeValue("", 2043, x.OdjecaID, 2043, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-list-alt\"></span>Upravljanje veličinama</a>\r\n                    </td>\r\n                    </tr>\r\n");
#nullable restore
#line 59 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\PrikazOdjece.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <a href=\"/Administrator/DodajOdjecu\" class=\"btn btn-success\">Dodaj novu odjeću</a>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
