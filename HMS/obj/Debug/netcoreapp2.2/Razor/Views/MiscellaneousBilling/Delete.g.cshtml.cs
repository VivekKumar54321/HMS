#pragma checksum "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da059f5a4af348641441e89238818f55bdd5202"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MiscellaneousBilling_Delete), @"mvc.1.0.view", @"/Views/MiscellaneousBilling/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MiscellaneousBilling/Delete.cshtml", typeof(AspNetCore.Views_MiscellaneousBilling_Delete))]
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
#line 1 "C:\Users\vivek\source\repos\HMS\HMS\Views\_ViewImports.cshtml"
using HMS;

#line default
#line hidden
#line 2 "C:\Users\vivek\source\repos\HMS\HMS\Views\_ViewImports.cshtml"
using HMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da059f5a4af348641441e89238818f55bdd5202", @"/Views/MiscellaneousBilling/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe428b16058664feda5fd987bc7d9fd08b7c9b31", @"/Views/_ViewImports.cshtml")]
    public class Views_MiscellaneousBilling_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HMS.Models.MiscellaneousBilling>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
  
	ViewData["Title"] = "Delete";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 164, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n\t<h4>MiscellaneousBilling</h4>\r\n\t<hr />\r\n\t<dl class=\"row\">\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(290, 40, false);
#line 16 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Food));

#line default
#line hidden
            EndContext();
            BeginContext(330, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(371, 36, false);
#line 19 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Food));

#line default
#line hidden
            EndContext();
            BeginContext(407, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(447, 44, false);
#line 22 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodRate));

#line default
#line hidden
            EndContext();
            BeginContext(491, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(532, 40, false);
#line 25 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FoodRate));

#line default
#line hidden
            EndContext();
            BeginContext(572, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(612, 53, false);
#line 28 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomServiceCharge));

#line default
#line hidden
            EndContext();
            BeginContext(665, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(706, 49, false);
#line 31 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomServiceCharge));

#line default
#line hidden
            EndContext();
            BeginContext(755, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(795, 46, false);
#line 34 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ServiceTax));

#line default
#line hidden
            EndContext();
            BeginContext(841, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(882, 42, false);
#line 37 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ServiceTax));

#line default
#line hidden
            EndContext();
            BeginContext(924, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(964, 47, false);
#line 40 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1052, 43, false);
#line 43 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1135, 43, false);
#line 46 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Visitor));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1219, 51, false);
#line 49 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Visitor.VisitorName));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 22, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t</dl>\r\n\r\n\t");
            EndContext();
            BeginContext(1292, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da059f5a4af348641441e89238818f55bdd52029905", async() => {
                BeginContext(1318, 4, true);
                WriteLiteral("\r\n\t\t");
                EndContext();
                BeginContext(1322, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4da059f5a4af348641441e89238818f55bdd520210292", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "C:\Users\vivek\source\repos\HMS\HMS\Views\MiscellaneousBilling\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MiscellaneousBillingId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1378, 71, true);
                WriteLiteral("\r\n\t\t<input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n\t\t");
                EndContext();
                BeginContext(1449, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da059f5a4af348641441e89238818f55bdd520212207", async() => {
                    BeginContext(1471, 12, true);
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
                BeginContext(1487, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1497, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HMS.Models.MiscellaneousBilling> Html { get; private set; }
    }
}
#pragma warning restore 1591
