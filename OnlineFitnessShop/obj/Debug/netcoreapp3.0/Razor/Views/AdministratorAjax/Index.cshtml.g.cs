#pragma checksum "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a3a1c0f7ec56147ce1a7c254f0dc28515646fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorAjax_Index), @"mvc.1.0.view", @"/Views/AdministratorAjax/Index.cshtml")]
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
#line 1 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a3a1c0f7ec56147ce1a7c254f0dc28515646fb", @"/Views/AdministratorAjax/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorAjax_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineFitnessShop.ViewModels.AdministratorVMs.NarudzbaStavkePrikazVM>
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
#line 3 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a3a1c0f7ec56147ce1a7c254f0dc28515646fb3962", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a3a1c0f7ec56147ce1a7c254f0dc28515646fb5042", async() => {
                WriteLiteral(@"
    <div class=""tabela"">
        <h3>Stavke narudžbe</h3>
        <table class=""table table-hover table-bordered "">
            <thead class=""thead-dark"">
                <tr>
                    <th>Slika proizvoda</th>
                    <th>Naziv proizvoda</th>
                    <th>Veličina</th>
                    <th>Količina</th>
                


                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 30 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
                 foreach (var x in Model.stavkeList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 941, "\"", 966, 2);
                WriteAttributeValue("", 947, "/images/", 947, 8, true);
#nullable restore
#line 34 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
WriteAttributeValue("", 955, x.imageUrl, 955, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50px\" height=\"50px\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
                   Write(x.NazivProizvoda);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
                   Write(x.Velicina);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
                   Write(x.Kolicina);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 47 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorAjax\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineFitnessShop.ViewModels.AdministratorVMs.NarudzbaStavkePrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
