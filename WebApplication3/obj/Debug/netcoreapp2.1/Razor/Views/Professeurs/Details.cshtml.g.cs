#pragma checksum "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc3583c56b1b41210593901fc77ed51d40a7006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professeurs_Details), @"mvc.1.0.view", @"/Views/Professeurs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Professeurs/Details.cshtml", typeof(AspNetCore.Views_Professeurs_Details))]
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
#line 1 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using miniPrpject_Asp;

#line default
#line hidden
#line 2 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using miniPrpject_Asp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc3583c56b1b41210593901fc77ed51d40a7006", @"/Views/Professeurs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7526617cd1245d2f900c0656a732b5055e04ccc", @"/Views/_ViewImports.cshtml")]
    public class Views_Professeurs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<miniPrpject_Asp.Models.Professeur>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 143, true);
            WriteLiteral("Id,Nom,Prenom,UserName\r\n\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Local</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(231, 39, false);
#line 15 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(270, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(314, 35, false);
#line 18 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(393, 42, false);
#line 21 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(435, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(479, 38, false);
#line 24 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(517, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(561, 44, false);
#line 27 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 40, false);
#line 30 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(689, 56, true);
            WriteLiteral("\r\n        </dd>\r\n       \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(745, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7e3969f5c7e41b0948994fa0c363499", async() => {
                BeginContext(791, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\dell\Desktop\WebApplication3\WebApplication3\Views\Professeurs\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(799, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(807, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a6602fe00546bb8d1ba02309508f0f", async() => {
                BeginContext(829, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(845, 3000, true);
            WriteLiteral(@"
</div>


<div class=""card"">
    <div class=""card-header"">
        <div class=""card-title"">Striped Rows</div>
    </div>
    <div class=""card-body"">
        <div class=""card-sub"">
            Add <code class=""highlighter-rouge"">.table-striped</code> to rows the striped table
        </div>
        <table class=""table table-striped mt-3"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">First</th>
                    <th scope=""col"">Last</th>
                    <th scope=""col"">Handle</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Mark</td>
                    <td>Otto</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Jacob</td>
                    <td>Thornton</td>
                </tr>
                <tr>
                    <td>3</td>
                    <");
            WriteLiteral(@"td colspan=""2"">Larry the Bird</td>
                </tr>
            </tbody>
        </table>
        <div class=""card-sub"">
            Add <code class=""#highlighter-rouge"">.table-striped-bg-*states</code> to change background from striped rows
        </div>
        <table class=""table table-striped table-striped-bg-default mt-3"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">First</th>
                    <th scope=""col"">Last</th>
                    <th scope=""col"">Handle</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Mark</td>
                    <td>Otto</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Jacob</td>
                    <td>Thornton</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td colspa");
            WriteLiteral(@"n=""2"">Larry the Bird</td>
                </tr>
            </tbody>
        </table>
        <table class=""table table-striped table-striped-bg-danger mt-4"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">First</th>
                    <th scope=""col"">Last</th>
                    <th scope=""col"">Handle</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Mark</td>
                    <td>Otto</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Jacob</td>
                    <td>Thornton</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td colspan=""2"">Larry the Bird</td>
                </tr>
            </tbody>
        </table>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<miniPrpject_Asp.Models.Professeur> Html { get; private set; }
    }
}
#pragma warning restore 1591
