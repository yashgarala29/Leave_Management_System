#pragma checksum "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75fd5ad6f463f23ce7bd8218d0731c14923935a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveHistories_Details), @"mvc.1.0.view", @"/Views/LeaveHistories/Details.cshtml")]
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
#line 1 "D:\Project Copy\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Copy\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project Copy\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75fd5ad6f463f23ce7bd8218d0731c14923935a6", @"/Views/LeaveHistories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveHistories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Leave_Management_System.Models.Class.LeaveHistory>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Begin Page Content -->
<div class=""container-fluid px-lg-4"">
    <div class=""row"">
        <div class=""col-md-12 mt-lg-4 mt-4"">
            <!-- Page Heading -->
            <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
                <h2 class=""h3 mb-0 text-black-50 "">
                    LeaveHistory Details
                </h2>
            </div>
        </div>




        <!-- column -->
        <div class=""col-sm-8"">
            <div class=""card"">
                <div class=""card-body"">
                    <!-- title -->
                    <div class="" align-items-center"">
                        <div>
                            <h4>User Details </h4>

                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    ");
#nullable restore
#line 36 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 39 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 42 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.HODApproveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 45 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.HODApproveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 48 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.DeanApproveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 51 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.DeanApproveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 54 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.RegistrarApproveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 57 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.RegistrarApproveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 60 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 63 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 66 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 69 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 72 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.StartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 75 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.StartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 78 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.EndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 81 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.EndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                                <dt class=\"col-sm-2\">\n                                    ");
#nullable restore
#line 84 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.AllUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dt>\n                                <dd class=\"col-sm-10\">\n                                    ");
#nullable restore
#line 87 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                               Write(Html.DisplayFor(model => model.AllUser.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </dd>\n                            </dl>\n                        </div>\n                        <div>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75fd5ad6f463f23ce7bd8218d0731c14923935a612468", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 92 "D:\Project Copy\Leave_Management_System\Views\LeaveHistories\Details.cshtml"
                                                   WriteLiteral(Model.leave_id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75fd5ad6f463f23ce7bd8218d0731c14923935a614659", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n                        </div>\n                    </div>\n\n                </div>\n                <!-- title -->\n            </div>\n\n        </div>\n    </div>\n</div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Leave_Management_System.Models.Class.LeaveHistory> Html { get; private set; }
    }
}
#pragma warning restore 1591
