#pragma checksum "C:\Users\sesra\Documents\GitHub\bsm-web-livanurpulat\DenizKabugu\DenizKabugu\Views\Product\Oyuncak.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9dd6de000c3752500df22ffb49f8982c2ee1f7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Oyuncak), @"mvc.1.0.view", @"/Views/Product/Oyuncak.cshtml")]
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
#line 1 "C:\Users\sesra\Documents\GitHub\bsm-web-livanurpulat\DenizKabugu\DenizKabugu\Views\_ViewImports.cshtml"
using DenizKabugu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sesra\Documents\GitHub\bsm-web-livanurpulat\DenizKabugu\DenizKabugu\Views\_ViewImports.cshtml"
using DenizKabugu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9dd6de000c3752500df22ffb49f8982c2ee1f7c", @"/Views/Product/Oyuncak.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd3b52bd7cedc0c2d8890c8bfae40e0633033f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Oyuncak : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DenizKabugu.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sesra\Documents\GitHub\bsm-web-livanurpulat\DenizKabugu\DenizKabugu\Views\Product\Oyuncak.cshtml"
  
    ViewData["Title"] = "Oyuncak Kategorisi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1> Oyuncak Kategorisi</h1>
<br />
<h6>3 adet oyuncak kategorisi bulunmaktadır. </h6>
<br />

<div class=""navbar-nav flex-grow-1"">
    <div class=""col-md-4"">
        <div class=""form-group"">
            <ul class=""navbar-nav flex-grow-1"">
                <li class=""nav-item"">
                    <a class=""nav-link text-dark"">Puzzle</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link text-dark"">Oyuncak Ayı</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link text-dark"">Oyun Seti</a>
                </li>
            </ul>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DenizKabugu.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
