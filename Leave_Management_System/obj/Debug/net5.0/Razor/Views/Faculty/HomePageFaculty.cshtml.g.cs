#pragma checksum "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Faculty\HomePageFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b4858e6ccd7543e4f93dbca641811f0dfcb02b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculty_HomePageFaculty), @"mvc.1.0.view", @"/Views/Faculty/HomePageFaculty.cshtml")]
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
#line 1 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Leave_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b4858e6ccd7543e4f93dbca641811f0dfcb02b7", @"/Views/Faculty/HomePageFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Faculty_HomePageFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Faculty\HomePageFaculty.cshtml"
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
                                        Welcome, ");
#nullable restore
#line 22 "E:\SEM 6\SDP\project\Leave_Management_System-BrijeshChudasama\Leave_Management_System\Views\Faculty\HomePageFaculty.cshtml"
                                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </h2>
                                       
                                </div>
                            </div>
                            



                            <!-- column -->
                           
                        </div>
                    </div>
");
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
