#pragma checksum "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce9d05034ea65754707791f05ee9e68aa46b6115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iletisim_Index), @"mvc.1.0.view", @"/Views/Iletisim/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce9d05034ea65754707791f05ee9e68aa46b6115", @"/Views/Iletisim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a31feccddf55c0357f42be24921d37fa4897a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Iletisim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Iletisim>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"page-wrapper\">\r\n\t<div class=\"main-page\">\r\n\t\t<div class=\"tables\">\r\n\t\t\t<div class=\"panel-body widget-shadow\">\r\n");
#nullable restore
#line 12 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                 foreach (var x in Model)
				{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"						<h4>??leti??im Sayfas??</h4>
					<table class=""table"">
						<thead>
							<tr>
								<th>#</th>
								<th>??l</th>
								<th>A????k Adres</th>
								<th>Ofis Tel</th>
								<th>Cep Tel</th>
								<th>Mail Adresi</th>
								<th>??nstagram Adresi</th>
								<th>Facebook Adresi</th>
								<th>G??ncelle</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<th scope=""row"">");
#nullable restore
#line 33 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                                           Write(x.IletisimID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 34 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                               Write(x.IlAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 35 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                               Write(x.Ac??kAdres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 36 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                               Write(x.OfisNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 37 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                               Write(x.GsmNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 38 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                               Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 39 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                               Write(x.Instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 40 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
                               Write(x.Facebook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 964, "\"", 1010, 2);
            WriteAttributeValue("", 971, "/Iletisim/IletisimDuzenle/", 971, 26, true);
#nullable restore
#line 41 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
WriteAttributeValue("", 997, x.IletisimID, 997, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">G??ncelle</a> </td>\r\n\t\t\t\t\t\t\t</tr>\r\n\r\n\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n");
#nullable restore
#line 46 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Iletisim\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Iletisim>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
