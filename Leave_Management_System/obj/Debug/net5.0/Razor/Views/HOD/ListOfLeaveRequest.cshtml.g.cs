#pragma checksum "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e9a1b48871ce4bfc281159cf8c13e998de6e36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HOD_ListOfLeaveRequest), @"mvc.1.0.view", @"/Views/HOD/ListOfLeaveRequest.cshtml")]
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
#line 1 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e9a1b48871ce4bfc281159cf8c13e998de6e36", @"/Views/HOD/ListOfLeaveRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_HOD_ListOfLeaveRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Leave_Management_System.Models.ViewModel.ListOfLeaveRequestHOD>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""row m-t-30"">
    <div class=""col-md-12"">
        <div class=""table-data__tool-left"">

            <div class=""table-data__tool-left"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""overview-wrap"">
                        <h2 class=""title-1"">List of Leave Request of HOD</h2>

                    </div>
                </div>
            </div>

        </div><br />
        </hr>
        <!-- DATA TABLE-->

        <div class=""table-responsive m-b-40"">
            <table class=""table table-borderless table-data3"">
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Username</th>
                        <th>Start Frome</th>
                        <th>End Till</th>
                        <th>No Of Day</th>
                        <th>Leave Reason</th>
                        <th>Attachment</th>
            ");
            WriteLiteral("            <th colspan=\"2\">Operation</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 48 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                        Write(Model[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                       Write(Model[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                        Write(Model[i].username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                       Write(Model[i].LeaveStartFrome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                       Write(Model[i].LeaveEndTill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 53 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                        Write(Model[i].NoOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                        <td> ");
#nullable restore
#line 56 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                        Write(Model[i].LeaveReason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n");
#nullable restore
#line 59 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                             if (Model[i].Attachment == null)
                            {

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e9a1b48871ce4bfc281159cf8c13e998de6e367990", async() => {
                WriteLiteral("User Document");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2036, "~/file/", 2036, 7, true);
#nullable restore
#line 65 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
AddHtmlAttributeValue("", 2043, Model[i].Attachment, 2043, 20, false);

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
#line 65 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <!--<td> <button class=\"btn btn-primary\" value=\"");
#nullable restore
#line 68 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                                                                   Write(Model[i].id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"savechange\"> Save Change </button></td>-->\r\n\r\n                        <td>\r\n                            <button class=\"btn btn-success\"");
            BeginWriteAttribute("value", " value=\"", 2345, "\"", 2365, 1);
#nullable restore
#line 71 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 2353, Model[i].id, 2353, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  class=""btn btn-success zmdi zmdi-badge-check"" data-toggle=""tooltip"" data-placement=""top"" title=""Accept"" name=""Accept"">Accept</button>
                            </td>
                        <td>
                            <button class=""btn btn-danger""");
            BeginWriteAttribute("value", " value=\"", 2626, "\"", 2646, 1);
#nullable restore
#line 74 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 2634, Model[i].id, 2634, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger zmdi zmdi-check-circle\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Accept\"name=\"Reject\">Reject</button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\HOD\ListOfLeaveRequest.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
        <script>

            /* $(""[name=savechange]"").on(""click"", function () {
                 var savechangevalue = $(this).val();
                 var save_change = $(this).closest('td').prev().prev().find('.status').val();
                 $.ajax({
                     type: ""POST"",
                     url: ""/HOD/AjaxMethod"",
                     data: { ""name"": save_change, ""leave_id"": savechangevalue },
                     success: function (response) {
                         alert(""Status Updated Successfully!"");
                         location.reload();

                     },
                     failure: function (response) {
                         alert(""failure"");
                     },
                     error: function (response) {
                         alert(""error"");
                     }
                 });
                 //alert(save_change);

             })*/

            $(""[name=Accept]"").on(""click"", function () {
                var save");
                WriteLiteral(@"changevalue = $(this).val();
                var save_change = ""Accepted"";
                $.ajax({
                    type: ""POST"",
                    url: ""/HOD/AjaxMethod"",
                    data: { ""name"": save_change, ""leave_id"": savechangevalue },
                    success: function (response) {
                        location.reload();

                    },
                    failure: function (response) {
                        alocation.reload();
                    },
                    error: function (response) {
                        location.reload();
                    }
                });
                //alert(save_change);

            })
            $(""[name=Reject]"").on(""click"", function () {
                var savechangevalue = $(this).val();
                var save_change = ""Rejected"";
                $.ajax({
                    type: ""POST"",
                    url: ""/HOD/AjaxMethod"",
                    data: { ""name"": save_change, ""leave_i");
                WriteLiteral(@"d"": savechangevalue },
                    success: function (response) {
                        location.reload();

                    },
                    failure: function (response) {
                        location.reload();
                    },
                    error: function (response) {
                        location.reload();
                    }
                });
                //alert(save_change);

            })

        </script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Leave_Management_System.Models.ViewModel.ListOfLeaveRequestHOD>> Html { get; private set; }
    }
}
#pragma warning restore 1591
