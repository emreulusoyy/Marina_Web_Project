#pragma checksum "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\_UserLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d4e808cc1140638b84d3c6c59d26d859729ebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserLayout), @"mvc.1.0.view", @"/Views/Shared/_UserLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d4e808cc1140638b84d3c6c59d26d859729ebf", @"/Views/Shared/_UserLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a31feccddf55c0357f42be24921d37fa4897a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__UserLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Marina_Website/Marina_Website-main/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\_UserLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d4e808cc1140638b84d3c6c59d26d859729ebf4436", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>KWM</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9d4e808cc1140638b84d3c6c59d26d859729ebf4907", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.3/font/bootstrap-icons.css"">
    <script src=""https://kit.fontawesome.com/70920e8a48.js"" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""
            integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js""
            integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN""
            crossorigin=""anonymous""></script>
    <script src=""https:/");
                WriteLiteral("/stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js\"\r\n            integrity=\"sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV\"\r\n            crossorigin=\"anonymous\"></script>\r\n    <script src=\"app.js\"></script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d4e808cc1140638b84d3c6c59d26d859729ebf8140", async() => {
                WriteLiteral("\r\n    <header class=\"header\">\r\n        <nav class=\"navbar navbar-expand-lg bg-body-tertiary fixed-top\">\r\n            <div class=\"container\">\r\n                <a class=\"navbar-brand\" href=\"#\"><img src=\"logo.png\" class=\"w-75\"");
                BeginWriteAttribute("alt", " alt=\"", 1844, "\"", 1850, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                        data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav ms-auto mb-2 mb-lg-0"">
                        <li class=""nav-item"">
                            <a key=""0"" class=""nav-link active"" aria-current=""page"" href=""#home"">ANASAYFA</a>
                        </li>
                        <li class=""nav-item"">
                            <a key=""1"" class=""nav-link"" aria-current=""page"" href=""#about"">HAKKIMIZDA</a>
                        </li>
                        <li class=""nav-item"">
                            <a key=""2"" class=""nav-link"" aria-current=""page"" href=""#ser");
                WriteLiteral(@"vices"">HİZMETLERİMİZ</a>
                        </li>
                        <li class=""nav-item"">
                            <a key=""3"" class=""nav-link"" aria-current=""page"" href=""#contact"">İLETİŞİM</a>
                        </li>
                        <li class=""nav-item"">
                            <a key=""4"" class=""nav-link"" aria-current=""page"" href=""gallery.php"">GALERİ</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" id=""language"" role=""button"" data-bs-toggle=""dropdown""
                               aria-expanded=""false"">
                                TÜRKÇE
                            </a>
                            <ul class=""dropdown-menu"">
                                <li><a class=""dropdown-item"" id=""en"">ENGLISH</a></li>
                                <li><a class=""dropdown-item"" id=""tr"">TÜRKÇE</a></li>
                            </ul>
                        </li>");
                WriteLiteral("\n                        <li class=\"nav-item\">\r\n                            <a key=\"5\" class=\"nav-link ms-3\" aria-current=\"page\"");
                BeginWriteAttribute("href", " href=\"", 4027, "\"", 4034, 0);
                EndWriteAttribute();
                WriteLiteral(">GİRİŞ</a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n\r\n    ");
#nullable restore
#line 78 "C:\Users\eulus\Desktop\marina\Marina_Web\Marina_Web\Views\Shared\_UserLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer class=""bg-dark p-2 text-center"">
        <div class=""container"">
            <p key=""27"" class=""text-white"">Copyright © 2023 Tüm Hakları Saklıdır.</p>
        </div>
    </footer>
    
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js""
            integrity=""sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN""
            crossorigin=""anonymous""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
