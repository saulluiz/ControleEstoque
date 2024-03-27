#pragma checksum "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\ControleEstoque\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed6c359522d1afdf102bbdf9eda43e31a187e478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ControleEstoque.Models.Shared.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace ControleEstoque.Models.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed6c359522d1afdf102bbdf9eda43e31a187e478", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf51782cd4828c73f0cc8b9d6c3d517219bfab85", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\ControleEstoque\Views\Shared\_Layout.cshtml"
  
    var pageOn = "text-indigo-500";
    var controllerAtual = (string)ViewContext.RouteData.Values["controller"];
    var classeMenuProdutos = controllerAtual == "Produto" ? pageOn : "hover:text-indigo-400";
    var classeMenuPrincipal = controllerAtual == "Home" ? pageOn : "hover:text-indigo-400";
    var classeMenuCategorias = controllerAtual == "Categoria" ? pageOn : "hover:text-indigo-400";
   
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed6c359522d1afdf102bbdf9eda43e31a187e4783592", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>EstoqueWeb:: ");
#nullable restore
#line 19 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\ControleEstoque\Views\Shared\_Layout.cshtml"
                   Write(ViewBag.Subtitulo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <script src=""https://cdn.tailwindcss.com""></script>
    <style>
        *{
            .tabela-categorias tr > :last-child,
            .tabela-categorias tr > td:last-child{
                
                    white-space: nowrap;
                    text-align: center;
            }
        }


    </style>
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed6c359522d1afdf102bbdf9eda43e31a187e4785301", async() => {
                WriteLiteral(@"
    <nav class=""bg-gray-200 shadow shadow-gray-300 w-100 px-8 md:px-auto"">
        <div class=""md:h-16 h-28 mx-auto md:px-4 container flex items-center justify-between flex-wrap md:flex-nowrap"">
            <!-- Logo -->
            <div class=""text-indigo-500 md:order-1"">
                
              
                <!-- Heroicon - Chip Outline -->
                <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-10 w-10"" fill=""none"" viewBox=""0 0 24 24""
                    stroke=""currentColor"">
                    <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2""
                        d=""M9 3v2m6-2v2M9 19v2m6-2v2M5 9H3m2 6H3m18-6h-2m2 6h-2M7 19h10a2 2 0 002-2V7a2 2 0 00-2-2H7a2 2 0 00-2 2v10a2 2 0 002 2zM9 9h6v6H9V9z"" />
                </svg>
            </div>
            <div class=""text-gray-500 order-3 w-full md:w-auto md:order-2"">
                <ul class=""flex font-semibold justify-between"">
                    <!-- Active Link = text-indigo-500
            ");
                WriteLiteral("    Inactive Link = hover:text-indigo-500 -->\r\n                    <li");
                BeginWriteAttribute("class", " class=\"", 2120, "\"", 2164, 3);
                WriteAttributeValue("", 2128, "md:px-4", 2128, 7, true);
                WriteAttributeValue(" ", 2135, "md:py-2", 2136, 8, true);
#nullable restore
#line 53 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\ControleEstoque\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 2143, classeMenuPrincipal, 2144, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"Home\">Home</a></li>\r\n                    <li");
                BeginWriteAttribute("class", " class=\"", 2219, "\"", 2264, 3);
                WriteAttributeValue("", 2227, "md:px-4", 2227, 7, true);
                WriteAttributeValue(" ", 2234, "md:py-2", 2235, 8, true);
#nullable restore
#line 54 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\ControleEstoque\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 2242, classeMenuCategorias, 2243, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"Categoria\">Categorias</a></li>\r\n                    <li");
                BeginWriteAttribute("class", " class=\"", 2330, "\"", 2373, 3);
                WriteAttributeValue("", 2338, "md:px-4", 2338, 7, true);
                WriteAttributeValue(" ", 2345, "md:py-2", 2346, 8, true);
#nullable restore
#line 55 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\ControleEstoque\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 2353, classeMenuProdutos, 2354, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"Produto\">Produtos</a></li>\r\n                  \r\n                </ul>\r\n            </div>\r\n            <div class=\"order-2 md:order-3\">\r\n             \r\n        </div>\r\n    </nav>\r\n        <div>\r\n            ");
#nullable restore
#line 64 "C:\Users\saulo\OneDrive\Área de Trabalho\DEV\Asp.net\ControleEstoque\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n      \r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
