#pragma checksum "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd1cd5e1c6e189627b35c6dac4dffc7eeb0216f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Test), @"mvc.1.0.view", @"/Views/Administrator/Test.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
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
#line 1 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
using System.Composition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
using ClassLibrarySeminarski.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
using Microsoft.EntityFrameworkCore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
using OnlineFitnessShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1cd5e1c6e189627b35c6dac4dffc7eeb0216f3", @"/Views/Administrator/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79204dbb1655b4437774af9dbae6f65688b11d8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "D:\Seminarski_radRS1\webapp\OnlineFitnessShop\Views\Administrator\Test.cshtml"
  
    ViewData["Title"] = "Test";
    Layout = "~/Views/Shared/AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <div class=""divProizvodi"">

        <div class=""divSuplemetacija"">
            <a href=""/Administrator/PrikazSuplementacije"">
                <div style=""height: 80%; width: 100%; "" class=""slika"">
                    <img src=""/images/Suplementacije.jpg"" style=""width: 100%; height: 100%;"" />
                </div>


                <div class=""title"">

                    <h4>Administracija suplementacije</h4>

                </div>

            </a>
        </div>

        <div class=""divOdjeca"">
            <a href=""/Administrator/PrikazOdjece"">
                <div style=""height: 80%; width: 100%;"" class=""slika"">
                    <img src=""/images/Majica.jpg"" style=""width: 100%; height: 100%;"" />
                </div>


                <div class=""title"">

                    <h4>Administracija odjeće</h4>

                </div>
            </a>
        </div>

        <div class=""divObuca"">
            <a href=""/Administrator/PrikazObuce"">
               ");
            WriteLiteral(@" <div style=""height: 80%; width: 100%;"" class=""slika"">
                    <img src=""/images/Patike.jpg"" style=""width: 100%; height: 100%;"" />
                </div>


                <div class=""title"">

                    <h4>Administracija obuće</h4>

                </div>
            </a>
        </div>

        <div class=""divDodatci"">
            <a href=""/Administrator/PrikazDodataka"">
                <div style=""height: 80%; width: 100%;"" class=""slika"">
                    <img src=""/images/Pojas.jpg"" style=""width: 100%; height: 100%;"" />
                </div>


                <div class=""title"">

                    <h4>Administracija dodatcima za treniranje</h4>

                </div>
            </a>
        </div>
        <div class=""divKupci"">
            <a href=""/Administrator/PrikazKupaca"">
                <div style=""height: 80%; width: 100%;"" class=""slika"">
                    <img src=""/images/Kupac.jpg"" style=""width: 100%; height: 100%;"" />
             ");
            WriteLiteral(@"   </div>


                <div class=""title"">

                    <h4>Administracija kupcima</h4>

                </div>
            </a>
        </div>
        <div class=""divAdmini"">
            <a href=""/Administrator/PrikazAdmina"">
                <div style=""height: 80%; width: 100%;"" class=""slika"">
                    <img src=""/images/Administrator.jpg"" style=""width: 100%; height: 100%;"" />
                </div>


                <div class=""title"">

                    <h4>Upravljanje adminima</h4>

                </div>
            </a>
        </div>

    </div>");
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