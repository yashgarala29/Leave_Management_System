#pragma checksum "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Dean\HomePageDean.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6686459c64b1d5493f73e5309439b008a6d9e4d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dean_HomePageDean), @"mvc.1.0.view", @"/Views/Dean/HomePageDean.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6686459c64b1d5493f73e5309439b008a6d9e4d1", @"/Views/Dean/HomePageDean.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e3b228aa076ab7ec13dfc207bfe07c7a3d1cb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Dean_HomePageDean : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Leave_Management_System.Models.ViewModel.HomePageDatapass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Dean\HomePageDean.cshtml"
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
                    Home Page Dean.
                    <div id=""piechart""></div>
                </h2>

            </div>
        </div>




        <!-- column -->

    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        // Load google charts
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        // Draw the chart and set the chart values
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Task', 'Leave Chart'],
                ['Accepted Leave', ");
#nullable restore
#line 50 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Dean\HomePageDean.cshtml"
                              Write(Model.approveleave);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\n                [\'Rejected Leave\', ");
#nullable restore
#line 51 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Dean\HomePageDean.cshtml"
                              Write(Model.Rejectedleave);

#line default
#line hidden
#nullable disable
                WriteLiteral("],\n                [\'Pending  Leave\',");
#nullable restore
#line 52 "C:\Users\Lenovo\Documents\Leave_Management_System\Leave_Management_System\Views\Dean\HomePageDean.cshtml"
                             Write(Model.Peandingeave);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"],

            ]);

            // Optional; add a title and set the width and height of the chart
            var options = { 'title': 'Under Employee', 'width': 550, 'height': 400 };

            // Display the chart inside the <div> element with id=""piechart""
            var chart = new google.visualization.PieChart(document.getElementById('piechart'));
            chart.draw(data, options);
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Leave_Management_System.Models.ViewModel.HomePageDatapass> Html { get; private set; }
    }
}
#pragma warning restore 1591
