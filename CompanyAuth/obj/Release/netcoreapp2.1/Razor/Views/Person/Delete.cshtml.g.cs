#pragma checksum "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/Person/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864ed310174eef080e9ccf2342f49607e4ffd178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Delete), @"mvc.1.0.view", @"/Views/Person/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Delete.cshtml", typeof(AspNetCore.Views_Person_Delete))]
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
#line 1 "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/_ViewImports.cshtml"
using CompanyAuth;

#line default
#line hidden
#line 2 "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/_ViewImports.cshtml"
using CompanyAuth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"864ed310174eef080e9ccf2342f49607e4ffd178", @"/Views/Person/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28233836552e66bb03a5f12abd18f1bab5c94ee0", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyAuth.Models.Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/Person/Delete.cshtml"
  
    ViewData["Title"] = "Lista de Areas";

#line default
#line hidden
            BeginContext(80, 71, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Bem Vindo !!</h1>\n");
            EndContext();
#line 8 "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/Person/Delete.cshtml"
  using (Html.BeginForm())
{ 
   

#line default
#line hidden
            BeginContext(185, 117, false);
#line 10 "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/Person/Delete.cshtml"
Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control", @disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(306, 120, false);
#line 11 "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/Person/Delete.cshtml"
Write(Html.EditorFor(model => model.Surname, new { htmlAttributes = new { @class = "form-control", @disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(427, 163, true);
            WriteLiteral("    <div class=\"form-group\">\n            <div >\n                <input type=\"submit\" value=\"Deletar\" class=\"btn btn-warning\" />\n                |\n\n                ");
            EndContext();
            BeginContext(590, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4ff0b7ad6414dfd9a30b15741b16c25", async() => {
                BeginContext(638, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(648, 32, true);
            WriteLiteral(" \n            </div>\n    </div>\n");
            EndContext();
#line 20 "/home/jbazzoli/Documentos/VisualStudio/CompanyAuth/Company/CompanyAuth/Views/Person/Delete.cshtml"
    
 }

#line default
#line hidden
            BeginContext(688, 11, true);
            WriteLiteral("   \n </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyAuth.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
