#pragma checksum "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3595aa13e1d76a8820f0d249d5e60994df38a00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_MyLeave), @"mvc.1.0.view", @"/Views/Common/MyLeave.cshtml")]
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
#line 1 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3595aa13e1d76a8820f0d249d5e60994df38a00", @"/Views/Common/MyLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_MyLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leave_Management_System.Models.ViewModel.MyLeave>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateLeave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning zmdi zmdi-edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteLeave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger zmdi zmdi-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
  
    ViewData["Title"] = "MyLeave";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row m-t-30\">\n    <div class=\"col-md-12\">\n        <div class=\"table-data__tool-left\">\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3595aa13e1d76a8820f0d249d5e60994df38a008651", async() => {
                WriteLiteral("\n                <input class=\"au-input au-input--xl\" input type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 416, "\"", 450, 1);
#nullable restore
#line 13 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
WriteAttributeValue("", 424, ViewData["CurrentFilter"], 424, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required / placeholder=\"Search With Keayword\" />\n                &nbsp;&nbsp;\n                <input type=\"submit\" value=\"Search\" class=\"au-btn-filter\" />\n                &nbsp;&nbsp;\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3595aa13e1d76a8820f0d249d5e60994df38a009686", async() => {
                    WriteLiteral("Back to Full List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div><br />
        </hr>
        <!-- DATA TABLE-->

        <div class=""table-responsive m-b-40"">
            <table class=""table table-borderless table-data3"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 28 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                       Write(Html.DisplayNameFor(model => model.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 31 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                       Write(Html.DisplayNameFor(model => model.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 34 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                       Write(Html.DisplayNameFor(model => model.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 37 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                       Write(Html.DisplayNameFor(model => model.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 40 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                       Write(Html.DisplayNameFor(model => model.StartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 43 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                       Write(Html.DisplayNameFor(model => model.EndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
#nullable restore
#line 46 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                       Write(Html.DisplayNameFor(model => model.Attachment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </th>\n                        <th>Operations</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 52 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 56 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LeaveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 59 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 62 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LeaveReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 65 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NoOfDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 68 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                           Write(Html.DisplayFor(modelItem => item.StartFrome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 71 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EndTill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n");
#nullable restore
#line 74 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                                 if (item.Attachment == null)
                                {


                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3595aa13e1d76a8820f0d249d5e60994df38a0019603", async() => {
                WriteLiteral("User Document");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3272, "~/file/", 3272, 7, true);
#nullable restore
#line 81 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
AddHtmlAttributeValue("", 3279, item.Attachment, 3279, 16, false);

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
#nullable restore
#line 81 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                                                                                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n");
#nullable restore
#line 84 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                             if (item.changeable == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\n\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3595aa13e1d76a8820f0d249d5e60994df38a0022024", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-leave_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                                                                        WriteLiteral(item.leave_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-leave_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3595aa13e1d76a8820f0d249d5e60994df38a0024645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-leave_id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                                                                        WriteLiteral(item.leave_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-leave_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["leave_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                </td>\n");
#nullable restore
#line 92 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\n");
#nullable restore
#line 94 "C:\Users\ankit\Downloads\Leave_Management_System-BrijeshChudasama (3)\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Common\MyLeave.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n\n\n        <!-- END DATA TABLE-->\n    </div>\n</div>");
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
