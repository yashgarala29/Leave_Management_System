#pragma checksum "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "241c392a741d6774297c5068e4f6e1d904314bf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HOD_MyLeave), @"mvc.1.0.view", @"/Views/HOD/MyLeave.cshtml")]
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
#line 1 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241c392a741d6774297c5068e4f6e1d904314bf5", @"/Views/HOD/MyLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_HOD_MyLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leave_Management_System.Models.ViewModel.MyLeave>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateLeave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteLeave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
  
    ViewData["Title"] = "MyLeave";
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
                    My Leave HOD
                </h2>

            </div>
        </div>




        <!-- column -->
        <div class=""col-md-12 mt-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <!-- title -->
                    <div class=""d-md-flex align-items-center"">
                        <div>

                            <h5 class=""card-subtitle"">List Of All Leave Requests</h5>
                        </div>
                        <!--
                        <div class=""ml-auto"">
                            <div class=""dl"">
                                <select class=""custom-select"">
                                    <option value=""0"" selected=""""");
            WriteLiteral(@">Monthly</option>
                                    <option value=""1"">Daily</option>
                                    <option value=""2"">Weekly</option>
                                    <option value=""3"">Yearly</option>
                                </select>
                            </div>
                        </div>
                            -->
                    </div>
                    <!-- title -->
                </div>
                <div class=""table-responsive"">
                    <table class=""table v-middle"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 54 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </th>\n                                <th>\n                                    ");
#nullable restore
#line 57 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </th>\n                                <th>\n                                    ");
#nullable restore
#line 60 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </th>\n                                <th>\n                                    ");
#nullable restore
#line 63 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.StartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </th>\n                                <th>\n                                    ");
#nullable restore
#line 66 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.EndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </th>\n                                <th>\n                                    ");
#nullable restore
#line 69 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayNameFor(model => model.Attachment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </th>\n                                <th>Operations</th>\n                            </tr>\n                        </thead>\n                        <tbody>\n");
#nullable restore
#line 75 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>\n                                    ");
#nullable restore
#line 79 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 82 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 85 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 88 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayFor(modelItem => item.StartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n                                    ");
#nullable restore
#line 91 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </td>\n                                <td>\n");
#nullable restore
#line 94 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                                     if (item.Attachment == null)
                                    {

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "241c392a741d6774297c5068e4f6e1d904314bf513529", async() => {
                WriteLiteral("User Document");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4110, "~/file/", 4110, 7, true);
#nullable restore
#line 100 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
AddHtmlAttributeValue("", 4117, item.Attachment, 4117, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 101 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n");
#nullable restore
#line 103 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                                 if (item.changeable == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "241c392a741d6774297c5068e4f6e1d904314bf515928", async() => {
                WriteLiteral("Update leave");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-leave_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                                                                    WriteLiteral(item.leave_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-leave_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "241c392a741d6774297c5068e4f6e1d904314bf518339", async() => {
                WriteLiteral("Delete Leave");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-leave_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                                                                    WriteLiteral(item.leave_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-leave_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                            </td>");
#nullable restore
#line 110 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\n");
#nullable restore
#line 112 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (2)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\HOD\MyLeave.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Leave_Management_System.Models.ViewModel.MyLeave>> Html { get; private set; }
    }
}
#pragma warning restore 1591
