#pragma checksum "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3003fb7509187b35e7d6ee317b500c94c3c21229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorProizvod_Obrisi), @"mvc.1.0.view", @"/Views/AdministratorProizvod/Obrisi.cshtml")]
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
#line 1 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3003fb7509187b35e7d6ee317b500c94c3c21229", @"/Views/AdministratorProizvod/Obrisi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorProizvod_Obrisi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
  

    var dobavljaci = (List<Dobavljac>)ViewData["Dobavljaci"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3003fb7509187b35e7d6ee317b500c94c3c212293976", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Prikaz dobavljača</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3003fb7509187b35e7d6ee317b500c94c3c212295047", async() => {
                WriteLiteral(@"
    <table border=""1"" class=""table-hover"">
        <thead>
            <tr>
                <td>Naziv</td>
                <td>Broj telefona</td>
                <td>e-mail adresa</td>
                <td>Grad</td>
                <td>Adresa</td>
                <td>Kategorija</td>
                <td>Obrisi</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
             foreach (var x in dobavljaci)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
               Write(x.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
               Write(x.BrojTelefona);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
               Write(x.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
               Write(x.Grad.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
               Write(x.Adresa);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
               Write(x.DobavljacKategorija.nazivKategorije);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td><a");
                BeginWriteAttribute("href", " href=\"", 1248, "\"", 1308, 2);
                WriteAttributeValue("", 1255, "/Administrator/ObrisiZapis?dobavljacid=", 1255, 39, true);
#nullable restore
#line 49 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
WriteAttributeValue("", 1294, x.DobavljacID, 1294, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><input type=\"button\" value=\"Obrisi\"/></a></td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\Obrisi.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    Povratak <a href=\"/Administrator\"><input type=\"button\" value=\"Nazad\" /></a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591