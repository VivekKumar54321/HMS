#pragma checksum "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0561a0e8aa23a900b40c0680c5f03168763a11ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Details), @"mvc.1.0.view", @"/Views/Reservation/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservation/Details.cshtml", typeof(AspNetCore.Views_Reservation_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0561a0e8aa23a900b40c0680c5f03168763a11ad", @"/Views/Reservation/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe428b16058664feda5fd987bc7d9fd08b7c9b31", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HMS.Models.Reservation>
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(123, 114, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Reservation</h4>\r\n    <hr />\r\n\t<dl class=\"row\">\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(238, 43, false);
#line 15 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Visitor));

#line default
#line hidden
            EndContext();
            BeginContext(281, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(322, 51, false);
#line 18 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Visitor.VisitorName));

#line default
#line hidden
            EndContext();
            BeginContext(373, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(413, 47, false);
#line 21 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Room.RoomNo));

#line default
#line hidden
            EndContext();
            BeginContext(460, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(501, 43, false);
#line 24 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.RoomNo));

#line default
#line hidden
            EndContext();
            BeginContext(544, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(584, 47, false);
#line 27 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckInDate));

#line default
#line hidden
            EndContext();
            BeginContext(631, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(672, 43, false);
#line 30 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.CheckInDate));

#line default
#line hidden
            EndContext();
            BeginContext(715, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(755, 48, false);
#line 33 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckOutDate));

#line default
#line hidden
            EndContext();
            BeginContext(803, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(844, 44, false);
#line 36 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.CheckOutDate));

#line default
#line hidden
            EndContext();
            BeginContext(888, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(928, 46, false);
#line 39 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomBooked));

#line default
#line hidden
            EndContext();
            BeginContext(974, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1015, 42, false);
#line 42 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.RoomBooked));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1097, 46, false);
#line 45 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1184, 42, false);
#line 48 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.GrandTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1266, 55, false);
#line 51 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Billing.BillingType));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1362, 51, false);
#line 54 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Billing.BillingType));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1453, 55, false);
#line 57 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Billing.BillingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1549, 51, false);
#line 60 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Billing.BillingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 39, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class=\"col-sm-2\">\r\n\t\t\t");
            EndContext();
            BeginContext(1640, 57, false);
#line 63 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Billing.BillingAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 40, true);
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class=\"col-sm-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(1738, 53, false);
#line 66 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Billing.BillingAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 38, true);
            WriteLiteral("\r\n\t\t</dd>\r\n\t</dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1829, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0561a0e8aa23a900b40c0680c5f03168763a11ad11458", async() => {
                BeginContext(1875, 4, true);
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
#line 71 "C:\Users\vivek\source\repos\HMS\HMS\Views\Reservation\Details.cshtml"
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
            BeginContext(1883, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1891, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0561a0e8aa23a900b40c0680c5f03168763a11ad13769", async() => {
                BeginContext(1913, 12, true);
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
            BeginContext(1929, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HMS.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
