#pragma checksum "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\temp\Notification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1b33a136f0012b2ee83acc6ae862ee74df1be9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_temp_Notification), @"mvc.1.0.view", @"/Views/temp/Notification.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b33a136f0012b2ee83acc6ae862ee74df1be9b", @"/Views/temp/Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee516de2d55a90bd3e2f8df69648b9fe6a4b048", @"/Views/_ViewImports.cshtml")]
    public class Views_temp_Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\temp\Notification.cshtml"
   string s = ""; List<Leave_Management_System.Models.Class.Notification> return_response=null;
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"submit\" value=\"Request\" class=\"btn btn-primary\" name=\"GetNotification\" />\r\n<table id=\"listonotification\" border=\"2\">\r\n</table>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>

        $(""[name=GetNotification]"").on(""click"", function () {

            $.ajax({
                type: ""POST"",
                url: ""/temp/GetNotification"",
                success: function (response) {
                    //location.reload();
                    console.log(response.length);
                    var n = response.length;
                    $(""#listonotification"").empty();
                    for (var i = 0; i < n; i++)
                    {
                        var s = ""<tr><td>"" + response[i].heading + ""</td><td>"" + response[i].body + ""</td><td>""
                            + response[i].isreaded + ""</td><td>"" + response[i].notificationDate+""</td></tr>"";
                        $(""#listonotification"").append(s);
                        console.log(response[i]);
            }       
                    },
                failure: function (response) {
                    alert(""failure"");
                },
                error: function (respo");
                WriteLiteral("nse) {\r\n                    console.log(response);\r\n                    alert(\"error\");\r\n                }\r\n            });\r\n            //alert(save_change);\r\n\r\n        })\r\n    </script>\r\n\r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
