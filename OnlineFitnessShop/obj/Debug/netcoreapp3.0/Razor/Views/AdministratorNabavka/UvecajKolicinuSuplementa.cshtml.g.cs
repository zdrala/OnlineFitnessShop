#pragma checksum "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68818a334133bae6217c607e1e9b46aebda3c0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministratorNabavka_UvecajKolicinuSuplementa), @"mvc.1.0.view", @"/Views/AdministratorNabavka/UvecajKolicinuSuplementa.cshtml")]
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
#line 1 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
using OnlineFitnessShop.ViewModels.AdministratorVMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68818a334133bae6217c607e1e9b46aebda3c0d5", @"/Views/AdministratorNabavka/UvecajKolicinuSuplementa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministratorNabavka_UvecajKolicinuSuplementa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineFitnessShop.ViewModels.AdministratorVMs.SuplementSoloPrikazVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrihvatiUnosKolicineNaStanju", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
  

    ViewData["Title"] = "UvecajKolicinuSuplementa";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68818a334133bae6217c607e1e9b46aebda3c0d55406", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Prikaz dobavljaca suplemenata</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68818a334133bae6217c607e1e9b46aebda3c0d56489", async() => {
                WriteLiteral(@"
    <div class=""tabela"" id=""myTable"">

        <table class=""table table-hover table-bordered"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Slika</th>
                    <th>Naziv</th>
                    <th>Cijena</th>
                    <th>Kategorija</th>
                    <th>Tezina(kg)</th>
                    <th>Akcija</th>



                </tr>
            </thead>
            <tbody id=""b-id"">

                <tr>

                    <td>
                        <img");
                BeginWriteAttribute("src", " src=\"", 1033, "\"", 1062, 2);
                WriteAttributeValue("", 1039, "/images/", 1039, 8, true);
#nullable restore
#line 39 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
WriteAttributeValue("", 1047, Model.ImageUrl, 1047, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"50px\" height=\"50px\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
                   Write(Model.Naziv);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
                   Write(Model.Cijena);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td class=\"kategorija\">\r\n                        ");
#nullable restore
#line 48 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
                   Write(Model.kategorijaSuplementacije);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
                   Write(Model.Tezina);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                    <td>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1584, "\"", 1667, 2);
                WriteAttributeValue("", 1591, "/AdministratorNabavka/PrikazDobavljacaSuplemenata?id=", 1591, 53, true);
#nullable restore
#line 57 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
WriteAttributeValue("", 1644, Model.SuplementacijaID, 1644, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-info btn-sm \"><span class=\"glyphicon glyphicon-search\"></span>Prikaži dobavljače suplementacije</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1811, "\"", 1891, 2);
                WriteAttributeValue("", 1818, "/AdministratorNabavka/UvecajKolicinuSuplementa?id=", 1818, 50, true);
#nullable restore
#line 58 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
WriteAttributeValue("", 1868, Model.SuplementacijaID, 1868, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-success btn-sm ""><span class=""glyphicon glyphicon-pencil""></span>Uvećaj količinu na stanju</a>
                    </td>
                </tr>

            </tbody>
        </table>
        <div class=""formaUnosKolicine"">
            <h3>Unesi novu količinu suplementa na stanju</h3>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68818a334133bae6217c607e1e9b46aebda3c0d510888", async() => {
                    WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input name=\"suplementacijaID\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 2398, "\"", 2429, 1);
#nullable restore
#line 69 "D:\Rs1SeminarskiFinal\webapp\OnlineFitnessShop\Views\AdministratorNabavka\UvecajKolicinuSuplementa.cshtml"
WriteAttributeValue("", 2406, Model.SuplementacijaID, 2406, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" hidden />
                    <input name=""kolicina"" class=""form-control"" />
                </div>

                <button id=""prihvatiOdbijanjeDugme"" type=""submit"" class=""btn btn-success""><span class=""glyphicon glyphicon-check""></span>Prihvati unos količine na stanje</button>

            ");
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
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n\r\n        <a href=\"/AdministratorNabavka/ShowSuplementsOutOfStock\" class=\"btn btn-danger btn-sm \"><span class=\"glyphicon glyphicon-search\"></span>Vrati na prikaz suplementacije van stanja</a>\r\n    </div>\r\n\r\n\r\n");
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
        function(value, element, regexp) {
            var check = false;
            return this.optional(element) || regexp.test(value);
        },
        ""Please check your input.""
    );

    $(""#validacijaUnosa"").validate({
        rules: {
           kolicina: {
                number:true,
                max: 50,
           min:1

            },

        },
        messages: {
           kolicina: {
                number:""Moguće samo brojeve unositi"",

                max: ""Maksimalna količina za unijeti je 50!"",
                min:""Minimalna količina za unijeti je 1!""
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineFitnessShop.ViewModels.AdministratorVMs.SuplementSoloPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591