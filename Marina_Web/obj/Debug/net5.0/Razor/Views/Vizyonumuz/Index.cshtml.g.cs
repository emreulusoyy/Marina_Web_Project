#pragma checksum "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca07751848ceb4f9070636eb85fa0d82e946325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vizyonumuz_Index), @"mvc.1.0.view", @"/Views/Vizyonumuz/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca07751848ceb4f9070636eb85fa0d82e946325", @"/Views/Vizyonumuz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a31feccddf55c0357f42be24921d37fa4897a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Vizyonumuz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vizyonumuz>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Areas/Admin/Views/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"page-wrapper\">\r\n\t<div class=\"main-page\">\r\n\t\t<div class=\"tables\">\r\n\t\t\t<div class=\"panel-body widget-shadow\">\r\n");
#nullable restore
#line 12 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
                 foreach (var x in Model)
				{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"					<h4>Misyonumuz Sayfası</h4>
					<table class=""table"">
						<thead>
							<tr>
								<th>#</th>
								<th>Hakkımızda</th>
								<th>Açıklama</th>
								<th>Güncelle</th>
							</tr>
						</thead>
						<tbody>
							<tr>
								<th scope=""row"">");
#nullable restore
#line 28 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
                                           Write(x.VizyonumuzID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 29 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
                               Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
                               Write(x.Description.Substring(0,75));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</td>\r\n\t\t\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 698, "\"", 746, 2);
            WriteAttributeValue("", 705, "/Vizyonumuz/VizyonDuzenle/", 705, 26, true);
#nullable restore
#line 31 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
WriteAttributeValue("", 731, x.VizyonumuzID, 731, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a> </td>\r\n\t\t\t\t\t\t\t</tr>\r\n\r\n\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n");
#nullable restore
#line 36 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Vizyonumuz\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vizyonumuz>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
