#pragma checksum "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "938ed19f282a9a44df3472959e91bf77c63de60c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Caminhao), @"mvc.1.0.view", @"/Views/Home/Caminhao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Caminhao.cshtml", typeof(AspNetCore.Views_Home_Caminhao))]
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
#line 1 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\_ViewImports.cshtml"
using TesteDotNet.Web;

#line default
#line hidden
#line 2 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\_ViewImports.cshtml"
using TesteDotNet.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"938ed19f282a9a44df3472959e91bf77c63de60c", @"/Views/Home/Caminhao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8022add9ce3fa27a8cfae3a477d50543537515b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Caminhao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CaminhaoItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(37, 17, false);
#line 3 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(54, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
 if(ViewBag.ErroProcesso != null)
{

#line default
#line hidden
            BeginContext(101, 98, true);
            WriteLiteral("<div id=\"cookieConsent\" class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n    ");
            EndContext();
            BeginContext(200, 20, false);
#line 8 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
Write(ViewBag.ErroProcesso);

#line default
#line hidden
            EndContext();
            BeginContext(220, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 10 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
}

#line default
#line hidden
            BeginContext(233, 13, true);
            WriteLiteral("\r\n<p>\r\n\r\n    ");
            EndContext();
            BeginContext(246, 1114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "938ed19f282a9a44df3472959e91bf77c63de60c4943", async() => {
                BeginContext(266, 193, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label for=\"descricao\">Descrição</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"descricao\" name=\"Descricao\" placeholder=\"Teste\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 459, "\"", 483, 1);
#line 17 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
WriteAttributeValue("", 467, Model.Descricao, 467, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(484, 201, true);
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"modelo\">Modelo</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"modelo\" name=\"Modelo\" placeholder=\"FH ou FM\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 685, "\"", 706, 1);
#line 21 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
WriteAttributeValue("", 693, Model.Modelo, 693, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(707, 212, true);
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"AnoFabricacao\">Ano de fabricação</label>\r\n            <input type=\"number\" class=\"form-control\" id=\"AnoFabricacao\" name=\"AnoFabricacao\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 919, "\"", 947, 1);
#line 25 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
WriteAttributeValue("", 927, Model.AnoFabricacao, 927, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 948, "\"", 987, 1);
#line 25 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
WriteAttributeValue("", 962, System.DateTime.Now.Year, 962, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(988, 196, true);
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"AnoModelo\">Ano do modelo</label>\r\n            <input type=\"number\" class=\"form-control\" id=\"AnoModelo\" name=\"AnoModelo\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1184, "\"", 1208, 1);
#line 29 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
WriteAttributeValue("", 1192, Model.AnoModelo, 1192, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1209, "\"", 1253, 1);
#line 29 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
WriteAttributeValue("", 1223, System.DateTime.Now.Year +1, 1223, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1254, 99, true);
                WriteLiteral(">\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary mb-2\">Salvar</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1360, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
     if(ViewData["Method"] == "PUT"){

#line default
#line hidden
            BeginContext(1401, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1405, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "938ed19f282a9a44df3472959e91bf77c63de60c10185", async() => {
                BeginContext(1458, 30, true);
                WriteLiteral("\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1488, "\"", 1505, 1);
#line 35 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
WriteAttributeValue("", 1496, Model.Id, 1496, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1506, 85, true);
                WriteLiteral(" />\r\n        <button type=\"submit\" class=\"btn btn-danger mb-2\">Excluir</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1433, "/Home/excluir/", 1433, 14, true);
#line 34 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
AddHtmlAttributeValue("", 1447, Model.Id, 1447, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1598, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Diego Cordeiro\Desktop\VOlvo\TesteDotNet.Web\Views\Home\Caminhao.cshtml"
    }

#line default
#line hidden
            BeginContext(1607, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CaminhaoItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
