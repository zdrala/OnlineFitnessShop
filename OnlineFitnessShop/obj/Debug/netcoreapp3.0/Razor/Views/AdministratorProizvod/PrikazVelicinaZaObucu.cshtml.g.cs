#pragma checksum "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34600cf637470d383f93d1a50d331041794085d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorProizvod_PrikazVelicinaZaObucu), @"mvc.1.0.view", @"/Views/AdministratorProizvod/PrikazVelicinaZaObucu.cshtml")]
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
#line 1 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
using Microsoft.EntityFrameworkCore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34600cf637470d383f93d1a50d331041794085d0", @"/Views/AdministratorProizvod/PrikazVelicinaZaObucu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorProizvod_PrikazVelicinaZaObucu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineFitnessShop.ViewModels.AdministratorVMs.ObucaVelicinePrikazVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SnimiIzmijenuKolicineObuce", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("validacijaUnosa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
  

     ViewData["Title"] = "PrikazVelicinaZaObucu";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34600cf637470d383f93d1a50d331041794085d05383", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Prikaz veličina za artikal</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34600cf637470d383f93d1a50d331041794085d06463", async() => {
                WriteLiteral(@"
<div class=""tabela"">
    <table class=""table table-hover table-bordered"">
        <thead class=""thead-dark"">
        <tr>
            <th>Slika</th>
            <th>Velicina</th>
            <th>Kolicina</th>
            <th>Izmijena količine</th>
         
        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
         foreach (var x in @Model.velicine)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 914, "\"", 943, 2);
                WriteAttributeValue("", 920, "/images/", 920, 8, true);
#nullable restore
#line 35 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
WriteAttributeValue("", 928, Model.imageUrl, 928, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50px\" height=\"50px\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
               Write(x.Velicina);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
               Write(x.kolicina);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34600cf637470d383f93d1a50d331041794085d08658", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <input name=\"velicinaID\"");
                    BeginWriteAttribute("value", " value=\"", 1405, "\"", 1426, 1);
#nullable restore
#line 47 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
WriteAttributeValue("", 1413, x.VelicinaID, 1413, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" hidden />\r\n                            <input name=\"novaKolicina\" ");
                    WriteLiteral(" />\r\n                        </div>\r\n                            <button type=\"submit\" class=\"btn btn-warning\">Spremi izmijenu količine</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n\r\n              \r\n            </tr>\r\n");
#nullable restore
#line 56 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <a href=\"/AdministratorProizvod/PrikazObuce\" class=\"btn btn-secondary\">Nazad</a> <a");
                BeginWriteAttribute("href", " href=\"", 1884, "\"", 1955, 2);
                WriteAttributeValue("", 1891, "/AdministratorProizvod/DodajVelicinuObuce?ObucaID=", 1891, 50, true);
#nullable restore
#line 60 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorProizvod\PrikazVelicinaZaObucu.cshtml"
WriteAttributeValue("", 1941, Model.ObucaID, 1941, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-success\">Dodaj novu veličinu</a>\r\n</div>\r\n");
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
            WriteLiteral(@"
</html>
<script>
    $.validator.addMethod(
        ""regex"",
        function (value, element, regexp) {
            var check = false;
            return this.optional(element) || regexp.test(value);
        },
        ""Please check your input.""
    );

    $(""#validacijaUnosa"").validate({
        rules: {
            novaKolicina: {
                number: true,
                max: 50

            },

        },
        messages: {
            novaKolicina: {
                number: ""Moguće samo brojeve unositi"",

                max: ""Maksimalna količina za unijeti je 50!""
            },

        }


    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineFitnessShop.ViewModels.AdministratorVMs.ObucaVelicinePrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
