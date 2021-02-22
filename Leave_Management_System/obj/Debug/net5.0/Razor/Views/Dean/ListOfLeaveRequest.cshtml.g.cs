#pragma checksum "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a13259d0098ee2cbef49d1ecac6de06bed8c06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dean_ListOfLeaveRequest), @"mvc.1.0.view", @"/Views/Dean/ListOfLeaveRequest.cshtml")]
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
#line 1 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a13259d0098ee2cbef49d1ecac6de06bed8c06", @"/Views/Dean/ListOfLeaveRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Dean_ListOfLeaveRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Leave_Management_System.Models.ViewModel.ListOfLeaveRequestHOD>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
  

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
                    Leave Requests
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
                                    <option value=""0"" selecte");
            WriteLiteral(@"d="""">Monthly</option>
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

                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Username</th>
                                <th>Start Frome</th>
                                <th>End Till</th>
                                <th>No Of Day</th>
                                <th>Leave Reason</th>
                                <th>Operation</th>
 ");
            WriteLiteral("                           </tr>\n                        </thead>\n                        <tbody>\n");
#nullable restore
#line 67 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                             for (int i = 0; i < Model.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td> ");
#nullable restore
#line 70 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                    Write(Model[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 71 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                   Write(Model[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td> ");
#nullable restore
#line 72 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                    Write(Model[i].username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 73 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                   Write(Model[i].LeaveStartFrome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 74 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                   Write(Model[i].LeaveEndTill);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td> ");
#nullable restore
#line 75 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                    Write(Model[i].NoOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n                                    <td> ");
#nullable restore
#line 78 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                    Write(Model[i].LeaveReason);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <!--<td> <button class=\"btn btn-primary\" value=\"");
#nullable restore
#line 79 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                                                                               Write(Model[i].id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"savechange\"> Save Change </button></td>-->\n\n                                    <td>\n                                        <button class=\"btn btn-success\"");
            BeginWriteAttribute("value", " value=\"", 3137, "\"", 3157, 1);
#nullable restore
#line 82 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 3145, Model[i].id, 3145, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Accept\">Accept</button>\n                                        <button class=\"btn btn-danger\"");
            BeginWriteAttribute("value", " value=\"", 3259, "\"", 3279, 1);
#nullable restore
#line 83 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
WriteAttributeValue("", 3267, Model[i].id, 3267, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Reject\">Reject</button>\n                                    </td>\n                                    <td></td>\n                                </tr>\n");
#nullable restore
#line 87 "E:\SEM 6\SDP\project\Leave_Management_System\Leave_Management_System\Views\Dean\ListOfLeaveRequest.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        /*$(""[name=savechange]"").on(""click"", function () {
            var savechangevalue = $(this).val();
            var save_change = $(this).closest('td').prev().prev().find('.status').val();
            $.ajax({
                type: ""POST"",
                url: ""/Dean/AjaxMethod"",
                data: { ""name"": save_change, ""leave_id"": savechangevalue },
                success: function (response) {
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
            var savechangevalue = $(this).val();
            var save_change = ""Accept"";
            $.ajax({
                type: ""POST"",
                url: ""/HOD/AjaxMethod"",
                data: { ""name"": save");
                WriteLiteral(@"_change, ""leave_id"": savechangevalue },
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

        })
        $(""[name=Reject]"").on(""click"", function () {
            var savechangevalue = $(this).val();
            var save_change = ""Reject"";
            $.ajax({
                type: ""POST"",
                url: ""/HOD/AjaxMethod"",
                data: { ""name"": save_change, ""leave_id"": savechangevalue },
                success: function (response) {
                    alert(""Status Updated Successfully!"");
                    location.reload();

                },
                failure: function (response) {
                    alert(""failur");
                WriteLiteral("e\");\n                },\n                error: function (response) {\n                    alert(\"error\");\n                }\n            });\n            //alert(save_change);\n\n        })\n    </script>\n\n\n");
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
