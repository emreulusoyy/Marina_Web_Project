#pragma checksum "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\Components\_HizmetlerList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9009250046ca32aa1957a71bea26784a91c40670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__HizmetlerList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_HizmetlerList/Default.cshtml")]
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
#line 1 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\_ViewImports.cshtml"
using Marina_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\_ViewImports.cshtml"
using Marina_Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9009250046ca32aa1957a71bea26784a91c40670", @"/Views/Shared/Components/_HizmetlerList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a31feccddf55c0357f42be24921d37fa4897a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__HizmetlerList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Hizmetler>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\Components\_HizmetlerList\Default.cshtml"
  foreach(var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12 col-md-12 col-lg-4\">\r\n    <div class=\"card text-white text-center bg-dark pd-2\" style=\"height: 340px;\">\r\n        <div class=\"card-body\">\r\n            <i class=\"bi bi-gear-fill\"></i>\r\n            <h3 key=\"14\">");
#nullable restore
#line 8 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\Components\_HizmetlerList\Default.cshtml"
                    Write(x.HizmetlerBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p key=\"18\">\r\n                ");
#nullable restore
#line 10 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\Components\_HizmetlerList\Default.cshtml"
           Write(x.HizmetlerAcıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <button key=\"13\" class=\"btn btn-primary mb-3\">Görüntüle</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 16 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\Components\_HizmetlerList\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Hizmetler>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591