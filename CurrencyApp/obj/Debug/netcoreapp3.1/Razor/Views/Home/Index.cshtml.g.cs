#pragma checksum "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99706a84043dd4c0071f82ea8b95f4ef2ac27dff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\_ViewImports.cshtml"
using CurrencyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\_ViewImports.cshtml"
using CurrencyApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99706a84043dd4c0071f82ea8b95f4ef2ac27dff", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbdda72238709024483c1810d8afb778a6b8fe2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CurrencyConverter>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\Home\Index.cshtml"
  
    decimal priceUAH = 1000;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Гланая страница</h1>\r\n<div>\r\n    ");
#nullable restore
#line 7 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\Home\Index.cshtml"
Write($"Курс американского доллара: {Model.USD}. Цена в американских долларах: {Decimal.Round(Model.convertToUSD(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 11 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\Home\Index.cshtml"
Write($"Курс евро: {Model.EUR}. Цена в евро: {Decimal.Round(Model.convertToEUR(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 15 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\Home\Index.cshtml"
Write($"Курс австралийского доллара: {Model.AUD}. Цена в австралийских долларах: {Decimal.Round(Model.convertToAUD(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 19 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\Home\Index.cshtml"
Write($"Курс китайского юаня: {Model.CNY}. Цена в китайских юанях: {Decimal.Round(Model.convertToCNY(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 23 "C:\Users\dimko\Desktop\CurrencyApp\CurrencyApp\Views\Home\Index.cshtml"
Write($"Курс шведской кроны: {Model.SEK}. Цена в шведских кронах: {Decimal.Round(Model.convertToSEK(priceUAH),2)}");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CurrencyConverter> Html { get; private set; }
    }
}
#pragma warning restore 1591
